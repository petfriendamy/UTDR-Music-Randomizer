using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTDRMusicRandomizer
{
    public class RandoResult
    {
        public string Message { get; }
        public bool Success { get; }

        public RandoResult(string message, bool success)
        {
            Message = message;
            Success = success;
        }
    }
}
