using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface ITwitterAccountService
    {
        List<TwitterAccount> List();
        bool Add(TwitterAccount twitterAccount);
        bool Update(TwitterAccount twitterAccount);
        bool Delete(TwitterAccount twitterAccount);
    }
}
