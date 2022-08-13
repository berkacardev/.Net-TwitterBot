using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Utilities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.WindowsRegistery;
using Entity.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concreate
{
    public class ConfugrateManager : IConfugrateService
    {
        IConfugrateDal _confugrateDal;
        public ConfugrateManager()
        {
            _confugrateDal = NinjectInstanceFactory.GetInstance<IConfugrateDal>();
        }

        public int GetFollowingAccountNumberValue()
        {
            int result = _confugrateDal.GetFollowingAccountNumberValue();
            return result;
        }
        public void SetFollowingAccountNumberValue(int value)
        {
            _confugrateDal.SetFollowingAccountNumberValue(value);
        }

        public int GetMaxValue()
        {
            int result = _confugrateDal.GetMaxValue();
            return result;
        }

        public int GetMinValue()
        {
            int result = _confugrateDal.GetMinValue();
            return result;
        }

        public Modems GetModem()
        {
            Modems result = _confugrateDal.GetModem();
            return result;
        }

        public bool GetRebootModeStatus()
        {
            bool result = _confugrateDal.GetRebootModeStatus();
            return result;
        }

        public void SetMaxValue(int maxValue)
        {
            _confugrateDal.SetMaxValue(maxValue);
        }

        public void SetMinValue(int minValue)
        {
            _confugrateDal.SetMinValue(minValue);
        }

        public void SetModem(Modems modem)
        {
            _confugrateDal.SetModem(modem);
        }

        public void SetRebootModeStatus(bool status)
        {
            _confugrateDal.SetRebootModeStatus(status);
        }
    }
}
