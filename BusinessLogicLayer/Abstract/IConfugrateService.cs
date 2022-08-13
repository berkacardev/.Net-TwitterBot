using Entity.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IConfugrateService
    {
        int GetMinValue();
        void SetMinValue(int minValue);
        int GetMaxValue();
        void SetMaxValue(int maxValue);
        Modems GetModem();
        void SetModem(Modems modem);
        bool GetRebootModeStatus();
        void SetRebootModeStatus(bool status);
        int GetFollowingAccountNumberValue();
        void SetFollowingAccountNumberValue(int value);
    }
}
