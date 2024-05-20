using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBuilding
{
    /// <summary>
    /// Interface for a Smart Building Controller
    /// </summary>
    internal interface IBuildingController
    {
        public string GetCurrentState();
        public bool SetCurrentState(string state);
        public string GetBuildingID();
        public void SetBuildingID(string id);
        public string GetStatusReport();
    }
}

