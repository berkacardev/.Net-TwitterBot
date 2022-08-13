using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate.EntityFramework.Context;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.EntityFramework
{
    public class EfTwitterAccountToFollow : ITwitterAccountToFollowDal
    {
        EfContext efContext;
        public EfTwitterAccountToFollow()
        {
            efContext = new EfContext();
        }
        public bool Add(List<TwitterAccountToFollow> twitterAccountToFollow)
        {
            try
            {
                foreach (var item in twitterAccountToFollow)
                {
                    bool accountIsExist = Convert.ToBoolean(efContext.TwitterAccountToFollow.Where(u => u.AccountToFollowUserName == item.AccountToFollowUserName).ToList().Count());
                    if(accountIsExist == false)
                    {
                        efContext.TwitterAccountToFollow.Add(item);
                        efContext.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(TwitterAccountToFollow twitterAccountToFollow)
        {
            try
            {
                efContext.TwitterAccountToFollow.Remove(twitterAccountToFollow);
                efContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TwitterAccountToFollow> List()
        {
            List<TwitterAccountToFollow> twitterAccountToFollow = efContext.TwitterAccountToFollow.ToList();
            return twitterAccountToFollow;
        }

        public bool Update(TwitterAccountToFollow twitterAccountToFollow)
        {
            try
            {
                int twitterAccountToFollowId = twitterAccountToFollow.AccountToFollowId;
                TwitterAccountToFollow _twitterAccountToFollow = efContext.TwitterAccountToFollow.Find(twitterAccountToFollowId);
                _twitterAccountToFollow.AccountToFollowUserName = twitterAccountToFollow.AccountToFollowUserName;
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
