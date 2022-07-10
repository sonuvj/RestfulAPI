using System;

namespace RestfulAPI.Models
{
    /// <summary>
    /// Customer Purchase info. Initialization done to avoid null reference exception.
    /// </summary>
    public class CustomerPurchaseInfo
    {
        /// <summary>
        /// Gets or Sets the Customer Code.
        /// </summary>
        public string CustomerCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the Customer Description.
        /// </summary>
        public string CustomerDesc { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the Invoice Date.
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets the Invoice No.
        /// </summary>
        public string InvoiceNo { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the Product Name.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the Product Qty.
        /// </summary>
        public int ProductQty { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the Product Sale Price.
        /// </summary>
        public decimal ProductSalePrice { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the Product Sale Discount.
        /// </summary>
        public decimal ProductSaleDiscount { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the Product Total Amount.
        /// </summary>
        public decimal ProductTotalAmount { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the Invoice Total.
        /// </summary>
        public decimal InvoiceTotal { get; set; } = 0;
    }
}
