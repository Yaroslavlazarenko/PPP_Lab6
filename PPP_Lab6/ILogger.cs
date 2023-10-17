using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPP_Lab6
{
    public interface ILogger
    {
        void Log(string message);
        void LogInfo(string message);
        void LogError(string error);
    }


}
