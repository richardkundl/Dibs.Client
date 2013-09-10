using System.Collections.Specialized;
namespace DIBS.Client
{
    public class DibsCallback : DibsPost, IDibsCallback
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="parameters"> HttpContext Reuqest params</param>
        public DibsCallback(NameValueCollection parameters)
        {
            var props = GetPropertiesName();
            foreach (var prop in props)
            {
                var value = parameters[prop];
                if (value != null)
                {
                    this.GetType().GetProperty(prop).SetValue(this, value, null);
                }
            }

            // add MAC 
            this.MAC = parameters["MAC"];
        }

        public string Acquirer { get; set; }

        [CamelCase]
        public string ActionCode { get; set; }

        [CamelCase]
        public string CardNumberMasked { get; set; }

        [CamelCase]
        public string CardTypeName { get; set; }

        [CamelCase]
        public string ExpMonth { get; set; }

        [CamelCase]
        public string ExpYear { get; set; }

        public string Status { get; set; }
        public string Transaction { get; set; }
    }
}