using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonSharp.Models
{
    public class MarketPlaceId
    {
        private MarketPlaceId(string value) { Value = value; }

        public string Value { get; set; }

        public static MarketPlaceId US { get { return new MarketPlaceId("ATVPDKIKX0DER"); } }
        public static MarketPlaceId Canada { get { return new MarketPlaceId("A2EUQ1WTGCTBG2"); } }
        public static MarketPlaceId Mexico { get { return new MarketPlaceId("A1AM78C64UM0Y8"); } }
        public static MarketPlaceId Brazil { get { return new MarketPlaceId("A2Q3Y263D00KWC"); } }
        public static MarketPlaceId TestCase200 { get { return new MarketPlaceId("TEST_CASE_200"); } }
    }

    public enum MarketPlaceParamEnum
    {
        MarketplaceId,
        MarketplaceIds
    }
}
