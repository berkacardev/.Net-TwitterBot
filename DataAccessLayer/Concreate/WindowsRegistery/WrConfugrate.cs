using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Entity.Constants;

namespace DataAccessLayer.Concreate.WindowsRegistery
{
    public class WrConfugrate : IConfugrateDal
    {
        RegistryKey registryKey;
        public int GetMaxValue()
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN);
            int maxValue = Convert.ToInt32(registryKey.GetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MAXVALUE));
            return maxValue;
        }

        public int GetMinValue()
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN);
            int minValue = Convert.ToInt32(registryKey.GetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MINVALUE));
            return minValue;
            
        }

        public void SetMaxValue(int minValue)
        {
            if (ExistDirectery())
            {
                registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MAXVALUE, minValue);
            }
            else
            {
                if (CreateDirectory())
                {
                    registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MAXVALUE, minValue);
                }
            }
        }

        public void SetMinValue(int minValue)
        {
            if (ExistDirectery())
            {
                registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MINVALUE, minValue);
            }
            else
            {
                if (CreateDirectory())
                {
                    registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MINVALUE, minValue);
                }
            }
        }
        private bool ExistDirectery()
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN,true);
            if (registryKey != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CreateDirectory()
        {
            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN,true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Modems GetModem()
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN);
            Modems modem = (Modems)Convert.ToInt32(registryKey.GetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MODEM));
            return modem;
        }

        public void SetModem(Modems modem)
        {
            if (ExistDirectery())
            {
                registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MODEM, (int)modem);
            }
            else
            {
                if (CreateDirectory())
                {
                    registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_MODEM, (int)modem);
                }
            }
        }

        public bool GetRebootModeStatus()
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN);
            bool status = Convert.ToBoolean(registryKey.GetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_REBOOT_MODEM_STATUS));
            return status;
        }

        public void SetRebootModeStatus(bool status)
        {
            if (ExistDirectery())
            {
                registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_REBOOT_MODEM_STATUS, Convert.ToInt32(status));
            }
            else
            {
                if (CreateDirectory())
                {
                    registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_REBOOT_MODEM_STATUS, Convert.ToInt32(status));
                }
            }
        }

        public int GetFollowingAccountNumberValue()
        {
            registryKey = Registry.CurrentUser.OpenSubKey(Directories.WINDOWSREGESTIRY_DIRECTORY_MAIN);
            int followingNumber = Convert.ToInt32(registryKey.GetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_FOLLOWING_ACCOUNT_NUMBER));
            return followingNumber;
        }

        public void SetFollowingAccountNumberValue(int value)
        {
            if (ExistDirectery())
            {
                registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_FOLLOWING_ACCOUNT_NUMBER, Convert.ToInt32(value));
            }
            else
            {
                if (CreateDirectory())
                {
                    registryKey.SetValue(Directories.WINDOWSREGESTIRY_VARIABLE_NAME_FOLLOWING_ACCOUNT_NUMBER, Convert.ToInt32(value));
                }
            }
        }
    }
}
