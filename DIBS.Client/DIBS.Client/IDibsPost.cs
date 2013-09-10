namespace DIBS.Client
{
    public interface IDibsPost
    {
        // TODO: implement products grid
        // ie:
        // name="oiTypes" value="QUANTITY;UNITCODE;DESCRIPTION;AMOUNT;ITEMID;VATAMOUNT"
        // name="oiNames" value="Items;UnitCode;Description;Amount;ItemId;VatAmount" 
        // name="oiRow1" value="1;pcs;ACME Rocket Roller skates; ultra fast;100;98;25"
        // name="oiRow2" value="1;pcs;ACME Band Aid;100;99;25"
        // name="oiRow3" value="1;pcs;Some description;100;45;25"

        string Amount { get; set; }
        string Currency { get; set; }
        string Merchant { get; set; }
        string BillingFirstName { get; set; }
        string BillingLastName { get; set; }
        string BillingAddress { get; set; }
        string BillingPostalCode { get; set; }
        string BillingPostalPlace { get; set; }
        string BillingEmail { get; set; }
        string BillingMobile { get; set; }
        string AcceptReturnUrl { get; set; }
        string CancelReturnUrl { get; set; }
        string CallbackUrl { get; set; }
        string Language { get; set; }
        string PayType { get; set; }

        [CamelCaseAttribute]
        string OrderId { get; set; }

        [IgnoreHashing]
        string MAC { get; set; }

        [IgnoreHashing("1")]
        string Test { get; set; }
    }
}