using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paperless.Data.Models;
using Newtonsoft.Json;
using System.Net;

namespace Paperless.CharityCommissionAPI
{
    public static class SearchCharityCommision
    {
        public static ApiCharity SearchByNumber(Int32 searchCharityNumber)
        {
            CommissionCharityObject JsonToObject = new CommissionCharityObject();

            using (WebClient wc = new WebClient())
            {
                var subscriptionKey = CharityCommisionAPI.Properties.Settings.Default.CharityCommisionApiKey;
                wc.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                var queryResult = wc.DownloadString($"https://api.charitycommission.gov.uk/register/api/allcharitydetails/{searchCharityNumber}/0");

                JsonToObject = JsonConvert.DeserializeObject<CommissionCharityObject>(queryResult);
            }

            ApiCharity charityObject = new ApiCharity();

            if (JsonToObject != null)
            {
                charityObject.Name = JsonToObject.charity_name?.Trim();
                charityObject.Address = $"{JsonToObject.address_line_one?.Trim()}, {JsonToObject.address_line_two?.Trim()}, {JsonToObject.address_line_three?.Trim()}, {JsonToObject.address_line_four?.Trim()}, {JsonToObject.address_line_five?.Trim()}";
                charityObject.CharityNumber = JsonToObject.reg_charity_number.ToString();
                charityObject.Postcode = JsonToObject.address_post_code?.Trim();
                charityObject.Locality = JsonToObject.address_line_four?.Trim();
            }

            return charityObject;
        }
    }

}
