using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraviaControl
{
    public class BraviaApiException : Exception
    {
        public int ErrorId { get; }
        public BraviaApiException(int errorId, string message)
            : base(message)
        {
            this.ErrorId = errorId;
        }
    }
}
