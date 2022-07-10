using System.Collections.Generic;

namespace RestfulAPI.ViewModels
{
    /// <summary>
    /// View Model for Customer Reward Details. Initialization done to avoid null reference exception.
    /// </summary>
    public partial class CustomerRewardDetails
    {
        /// <summary>
        /// Gets or Sets Customer Code.
        /// </summary>
        public string CustomerCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets Customer Description.
        /// </summary>
        public string CustomerDesc { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets Invoice Month.
        /// </summary>
        public int InvoiceMonth { get; set; } = 0;

        /// <summary>
        /// Gets or Sets Invoice Year.
        /// </summary>
        public int InvoiceYear { get; set; } = 0;

        /// <summary>
        /// Gets or Sets Reward Point Total.
        /// </summary>
        public long RewardPointTotal { get; set; } = 0;

        /// <summary>
        /// Gets or Sets Collection for Reward Point Monthly Total.
        /// </summary>
        public List<MonthWiseTotalRewards> RewardPointMonthlyTotal { get; set; } = new List<MonthWiseTotalRewards>();

        /// <summary>
        /// Gets or Sets Collection for Invoice Reward Point Calculation View Model.
        /// </summary>
        public List<InvoiceRewardPointCal> InvoiceList { get; set; } = new List<InvoiceRewardPointCal>();
    }
}
