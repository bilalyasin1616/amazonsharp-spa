using AmazonSharp.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonSharp.Models
{
    public class ClientToken
    {
        public string AccessToken { get; set; }
        public LWAAuthorizationCredentials LWACredentials { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
