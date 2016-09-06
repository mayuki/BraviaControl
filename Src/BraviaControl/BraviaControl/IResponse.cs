using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BraviaControl
{
    public interface IResponse
    {
    }
    public interface ICompositeResponse : IResponse
    {
        void ReadFromJson(JArray values);
    }
}
