using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBuilding
{
    public interface ILightManager : IManager
    {
        public void SetLight(bool isOn, int lightID);
        public void SetAllLights(bool isOn);
    }
}
