using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Utilities;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concreate
{
    public class TwitterAccountManager : ITwitterAccountService
    {
        ITwitterAccountDal _twitterAccountDal;
        public TwitterAccountManager()
        {
            _twitterAccountDal = NinjectInstanceFactory.GetInstance<ITwitterAccountDal>();
        }

        public bool Add(TwitterAccount twitterAccount)
        {
            bool result = _twitterAccountDal.Add(twitterAccount);
            return result;
        }

        public bool Delete(TwitterAccount twitterAccount)
        {
            bool result = _twitterAccountDal.Delete(twitterAccount);
            return result;
        }

        public List<TwitterAccount> List()
        {
            List<TwitterAccount> result = _twitterAccountDal.List();
            return result;
        }

        public bool Update(TwitterAccount twitterAccount)
        {
            bool result = _twitterAccountDal.Update(twitterAccount);
            return result;
        }
    }
}
