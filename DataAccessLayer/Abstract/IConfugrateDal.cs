using Entity.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IConfugrateDal
    {
        int GetMinValue();
        void SetMinValue(int minValue);
        int GetMaxValue();
        void SetMaxValue(int minValue);
        Modems GetModem();
        void SetModem(Modems modem);
        bool GetRebootModeStatus();
        void SetRebootModeStatus(bool status);
        int GetFollowingAccountNumberValue();
        void SetFollowingAccountNumberValue(int value);
    }
}
