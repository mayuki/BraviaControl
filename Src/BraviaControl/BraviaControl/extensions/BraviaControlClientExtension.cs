using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BraviaControl.Extensions
{
    public static class BraviaControlClientExtension
    {
        public static async Task<bool> IsStandbyAsync(this BraviaControlClient.ISystem system)
        {
            return ((await system.GetPowerStatusAsync().ConfigureAwait(false)).Status == "standby");
        }
        public static async Task<bool> IsActiveAsync(this BraviaControlClient.ISystem system)
        {
            return ((await system.GetPowerStatusAsync().ConfigureAwait(false)).Status == "active");
        }
    }
}
