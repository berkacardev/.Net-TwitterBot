using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
    public class TwitterAccount : ITwitterAccount
    {
        public TwitterAccount()
        {
                
        }
        public TwitterAccount(string userName, string userPassword)
        {
            this.AccountUserName = userName;
            this.AccountPassword = userPassword;
            this.AccountDate = DateTime.Now;
        }
        public override string ToString()
        {
            return AccountUserName + "  |  " + AccountPassword;
        }
        [Key] public int AccountId { get; set; }
        public string AccountUserName { get; set; }
        public string AccountPassword { get; set; }
        public DateTime AccountDate { get; set; }
    }
}
