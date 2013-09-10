namespace DIBS.Client
{
    public class DibsPost : DibsBase, IDibsPost
    {
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string Merchant { get; set; }
        public string BillingFirstName { get; set; }
        public string BillingLastName { get; set; }
        public string BillingAddress { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingPostalPlace { get; set; }
        public string BillingEmail { get; set; }
        public string BillingMobile { get; set; }
        public string AcceptReturnUrl { get; set; }
        public string CancelReturnUrl { get; set; }
        public string CallbackUrl { get; set; }
        public string Language { get; set; }
        public string PayType { get; set; }

        [CamelCaseAttribute]
        public string OrderId { get; set; }

        [IgnoreHashing]
        public string MAC { get; set; }

        [IgnoreHashing("1")]
        public string Test { get; set; }
    }
}