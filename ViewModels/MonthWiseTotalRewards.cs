namespace RestfulAPI.ViewModels
{
    /// <summary>
    /// Month wise reward total. Initialization done to avoid null reference exception.
    /// </summary>
    public class MonthWiseTotalRewards
    {
        /// <summary>
        /// Gets or Sets the Invoice Month.
        /// </summary>
        public int InvoiceMonth { get; set; } = 0;

        /// <summary>
        /// Gets or Sets the Total Reward Point month wise.
        /// </summary>
        public long TotalRewardPoints { get; set; } = 0;
    }
}
