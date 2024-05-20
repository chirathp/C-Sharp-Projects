using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBuilding
{
    public interface IWebService
    {
        public void LogStateChange(string logDetails);
        public void LogEngineerRequired(string logDetails);
        public void LogFireAlarm(string logDetails);
    }
}
