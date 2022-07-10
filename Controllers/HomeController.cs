using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RestfulAPI.Models;
using RestfulAPI.ViewModels;

namespace RestfulAPI.Controllers
{
    /// <summary>
    /// Home Controller. Name can be changes based on requirement.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        /// <summary>
        /// Get Customer Reward invoice wise and Customer wise. 
        /// Reward Point Calculation done based on Invoice Total.
        /// </summary>
        /// <param name="customerPurchaseList">Customer Purchase History.</param>
        /// <returns>Customer Rewards Invoice wise.</returns>
        [HttpPost]
        [Route("GetCustomerRewardPoints")]
        public IActionResult GetCustomerRewardPoints([FromBody] CustomerPurchaseList customerPurchaseList)
        {
            List<CustomerPurchaseInfo> CustomerPurchases = new List<CustomerPurchaseInfo>();
            List<CustomerRewardDetails> customerRewardDetailsList = new List<CustomerRewardDetails>();
            try
            {
                CustomerPurchases = customerPurchaseList.CustomerPurchases;
                var Customer = CustomerPurchases.Select(x => x.CustomerCode).Distinct();
                foreach (string customerCode in Customer)
                {
                    CustomerRewardDetails customerRewardDetails = new CustomerRewardDetails();
                    customerRewardDetails.CustomerCode = customerCode;
                    foreach (CustomerPurchaseInfo cpurchase in CustomerPurchases)
                    {
                        if (cpurchase.CustomerCode.Trim().ToLowerInvariant().Contains(customerCode.Trim().ToLowerInvariant()))
                        {
                            InvoiceRewardPointCal invoice = new InvoiceRewardPointCal();
                            invoice.InvoiceDate = cpurchase.InvoiceDate;
                            invoice.InvoiceTotal = cpurchase.InvoiceTotal;
                            customerRewardDetails.InvoiceList.Add(invoice);
                        }
                    }
                    var rewardMonthlyDetails = customerRewardDetails.InvoiceList
                                    .GroupBy(x => x.InvoiceMonth)
                                    .Select(g => new
                                    {
                                        InvoiceMonth = g.Key,
                                        Total = g.Sum(x => x.InvoiceRewardTotal)
                                    }).ToList();
                    foreach (var rmonth in rewardMonthlyDetails)
                    {
                        MonthWiseTotalRewards pairMonth = new MonthWiseTotalRewards();
                        pairMonth.InvoiceMonth = rmonth.InvoiceMonth;
                        pairMonth.TotalRewardPoints = rmonth.Total;
                        customerRewardDetails.RewardPointMonthlyTotal.Add(pairMonth);
                    }
                    var rewardTotalDetails = customerRewardDetails.InvoiceList
                                    .Select(x => x.InvoiceRewardTotal).Sum();
                    customerRewardDetails.RewardPointTotal = Convert.ToInt64(rewardTotalDetails);
                    customerRewardDetailsList.Add(customerRewardDetails);
                }
                return Ok(customerRewardDetailsList);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }
    }
}
