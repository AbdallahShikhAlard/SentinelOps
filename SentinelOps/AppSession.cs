using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinelOps
{
    // Holds data shared across all forms for this session
    public static class AppSession
    {
        public static string ServerUrl { get; set; } = "";
        public static string ClientId { get; set; } = "";
    }
}
