using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace BusinessLogicLayer.Concreate
{
    public static class Helper
    {
        public static bool IsNumber(string term)
        {
            foreach (char item in term)
            {
                if (!char.IsNumber(item))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        public static bool IsConnected()
        {
            if(NetworkInterface.GetIsNetworkAvailable() == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
