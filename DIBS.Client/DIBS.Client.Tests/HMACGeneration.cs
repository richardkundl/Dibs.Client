using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DIBS.Client.Tests
{
    [TestClass]
    public class HMACGeneration
    {
        private const string KEY = "f2355e3bb049eaa89e4e07a055042e9793b947cd49d09537fbb72e6e1f9a80e2f2355e3bb049eaa89e4e07a055042e9793b947cd49d09537fbb72e6e1f9a80e2";

        [TestMethod]
        public void Generate_HMAC_For_Empty_DibsPost()
        {
            // Arrange
            var post = new DibsPost();
            post.Test = "";

            // Act
            string mac = post.GenerateHMAC(KEY);

            // Assert
            string expected = HMACGenerator.HashHMACHex(KEY,
                              "acceptreturnurl=&amount=&billingaddress=&billingemail=&billingfirstname=&billinglastname=&billingmobile=&billingpostalcode=&billingpostalplace=&callbackurl=&cancelreturnurl=&currency=&language=&merchant=&orderId=&paytype=");
            Assert.AreEqual(expected, mac);
        }

        [TestMethod]
        public void Genereate_HMAC_For_Test_DibsPost()
        {
            // Arrange
            var post = new DibsPost();
            post.Test = "1";
            // Act
            string mac = post.GenerateHMAC(KEY);

            // Assert
            string expected = HMACGenerator.HashHMACHex(KEY,
                              "acceptreturnurl=&amount=&billingaddress=&billingemail=&billingfirstname=&billinglastname=&billingmobile=&billingpostalcode=&billingpostalplace=&callbackurl=&cancelreturnurl=&currency=&language=&merchant=&orderId=&paytype=&test=1");
            Assert.AreEqual(expected, mac);
        }

        [TestMethod]
        public void Genereate_HMAC_For_Full_Test_DibsPost()
        {
             // Arrange
            var Dibs = new DibsPost();
            Dibs.Test = "1";
            Dibs.Merchant = "90181846";
            Dibs.Currency = "208";
            Dibs.OrderId = "213456";
            Dibs.Amount = "375";
            Dibs.Language = "en_US";
            Dibs.PayType = "ALL_CARDS";

            Dibs.BillingFirstName = "John";
            Dibs.BillingLastName = "Doe";
            Dibs.BillingAddress = "Imagination Road 66";
            Dibs.BillingPostalCode = "99999";
            Dibs.BillingPostalPlace = "Fantasia";
            Dibs.BillingEmail = "John@Doe.com";
            Dibs.BillingMobile = "+45 1234 5678";

            Dibs.AcceptReturnUrl = "http://localhost:1047/default.aspx";
            Dibs.CancelReturnUrl = "http://localhost:1047/default.aspx";
            Dibs.CallbackUrl = "http://localhost:1047/default.aspx";

            // Act
            string mac = Dibs.GenerateHMAC(KEY);

            Assert.AreEqual("f653772e0b97b6e6bf684a03a20be8e5c9e6431eeaf12f0f224dbbcbcd849312", mac);
        }
    }
}