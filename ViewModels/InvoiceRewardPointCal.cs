using System;

namespace RestfulAPI.ViewModels
{
    /// <summary>
    /// The Class Invoice Reward Point Cal responsible for calculation. Initialization done to avoid null reference exception.
    /// </summary>
    public class InvoiceRewardPointCal
    {
        /// <summary>
        /// Gets or Sets the Invoice Date.
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Gets or Sets the Invoice Number.
        /// </summary>
        public string InvoiceNo { get; set; } = string.Empty;

        /// <summary>
        /// Gets or Sets the Invoice Total.
        /// </summary>
        public decimal InvoiceTotal { get; set; } = 0;

        /// <summary>
        /// Gets the Calculated Invoice Reward Points.
        /// </summary>
        public long InvoiceRewardTotal
        {
            get
            {
                if (Convert.ToInt64(InvoiceTotal) > 50 && Convert.ToInt64(InvoiceTotal) < 100)
                {
                    return (Convert.ToInt64(InvoiceTotal) - 50) * 1;
                }
                else if (Convert.ToInt64(InvoiceTotal) > 100)
                {
                    return (Convert.ToInt64(InvoiceTotal) - 50) * 1 + (Convert.ToInt64(InvoiceTotal) - 100) * 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets or Sets the Invoice Month.
        /// </summary>
        public int InvoiceMonth
        {
            get
            {
                return InvoiceDate.Month;
            }
        }
    }
}

