using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;

namespace DIBS.Client.Test
{
    [TestClass]
    public class DibsCallbackTests
    {
        [TestMethod]
        public void Generate_HMAC_For_Empty_DibsPost()
        {
            // Arrange
            var param = new NameValueCollection();
            param.Add("acceptreturnurl", "http://localhost:1047/default.aspx");
            param.Add("transaction", "766141940");
            var ret = new DibsCallback(param);
            Assert.AreNotEqual(null, ret);
        }
    }
}
