using System.Collections.Generic;

namespace RestfulAPI.Models
{
    /// <summary>
    /// Customer Purchase List.
    /// </summary>
    public class CustomerPurchaseList
    {
        /// <summary>
        /// Gets or Sets the Collection of Customer purchases. Initialization done to avoid null reference exception.
        /// </summary>
        public List<CustomerPurchaseInfo> CustomerPurchases { get; set; } = new List<CustomerPurchaseInfo>();
    }
}
