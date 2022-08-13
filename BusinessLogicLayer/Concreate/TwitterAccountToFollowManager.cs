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
    public class TwitterAccountToFollowManager : ITwitterAccountToFollowService
    {
        ITwitterAccountToFollowDal _twitterAccountToFollowDal; 
        public TwitterAccountToFollowManager()
        {
            _twitterAccountToFollowDal = NinjectInstanceFactory.GetInstance<ITwitterAccountToFollowDal>();
        }
        public bool Add(List<TwitterAccountToFollow> twitterAccountToFollow)
        {
            bool result = _twitterAccountToFollowDal.Add(twitterAccountToFollow);
            return result;
        }

        public bool Delete(TwitterAccountToFollow twitterAccountToFollow)
        {
            bool result = _twitterAccountToFollowDal.Delete(twitterAccountToFollow);
            return result;
        }

        public List<TwitterAccountToFollow> List()
        {
            List<TwitterAccountToFollow> twitterAccountToFollow = _twitterAccountToFollowDal.List();
            return twitterAccountToFollow;
        }

        public bool Update(TwitterAccountToFollow twitterAccountToFollow)
        {
            bool result = _twitterAccountToFollowDal.Update(twitterAccountToFollow);
            return result;
        }
    }
}
