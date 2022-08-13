using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework.Context;
using Entity.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfTwitterAccount : ITwitterAccountDal
    {
        EfContext efContext;
        public EfTwitterAccount()
        {
            efContext = new EfContext();
        }

        public bool Add(TwitterAccount twitterAccount)
        {
            try
            {
                efContext.TwitterAccount.Add(twitterAccount);
                efContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(TwitterAccount twitterAccount)
        {
            try
            {
                efContext.TwitterAccount.Remove(twitterAccount);
                efContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<TwitterAccount> List()
        {
            List<TwitterAccount> twitterAccounts = efContext.TwitterAccount.ToList();
            return twitterAccounts;
        }

        public bool Update(TwitterAccount twitterAccount)
        {
            try
            {
                int twitterAccountId = twitterAccount.AccountId;
                TwitterAccount _twitterAccount = efContext.TwitterAccount.Find(twitterAccountId);
                _twitterAccount.AccountUserName = twitterAccount.AccountUserName;
                _twitterAccount.AccountPassword = twitterAccount.AccountPassword;
                efContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
