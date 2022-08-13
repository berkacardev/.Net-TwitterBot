using BusinessLogicLayer.Abstract;
using Entity.Concreate;
using Entity.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concreate.Selenium
{
    public class SeleniumTwitterManager : ITwitterService
    {
        IWebDriver _webDriver;
        public SeleniumTwitterManager()
        {
            ChromeDriverService chromeDriverService = HideSeleniumConsoleSet();
            _webDriver = new ChromeDriver(chromeDriverService);
        }
        private ChromeDriverService HideSeleniumConsoleSet()
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            return chromeDriverService;
        }
        private bool DocumentIsReady(IWebDriver webDriver, int timeoutSec = 15)
        {
            System.Threading.Thread.Sleep(3000);
            IJavaScriptExecutor javascriptExecutor = (IJavaScriptExecutor)webDriver;
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, timeoutSec));
            try
            {
                wait.Until(u => javascriptExecutor.ExecuteScript(SeleniumCommand.TWITTER_JS_DOCUMENTISREADY_COMMAND).ToString() == SeleniumCommand.TWITTER_JS_DOCUMENTISREADY_STATUS);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Login(TwitterAccount twitterAccount)
        {
            string accountUserName = twitterAccount.AccountUserName;
            string accountPassword = twitterAccount.AccountPassword;
            _webDriver.Navigate().GoToUrl(UrlAddresses.TWITTER_MAIN_LOGIN_URL);
            System.Threading.Thread.Sleep(2000);
            if (DocumentIsReady(_webDriver) == true)
            {
                _webDriver.FindElement(By.Name(SeleniumCommand.TWITTER_LOGIN_USERNAME_TEXT_ELEMENT_BYNAME)).SendKeys(accountUserName);
                _webDriver.FindElement(By.XPath(SeleniumCommand.TWITTER_LOGIN_CONTINUE_BUTTON_ELEMENT_BYXPATH)).Click();
            }
            if (DocumentIsReady(_webDriver) == true)
            {
                _webDriver.FindElement(By.Name(SeleniumCommand.TWITTER_LOGIN_USERPASSWORD_TEXT_ELEMENT_BYNAME)).SendKeys(accountPassword);
                _webDriver.FindElement(By.XPath(SeleniumCommand.TWITTER_LOGIN_LOGIN_BUTTON_ELEMENT_BYXPATH)).Click();
            }
        }
        public bool Follow(TwitterAccountToFollow twitterAccountToFollow, int minValue, int maxValue)
        {
            Random random = new Random();
            int extraTimeToFollowProcess = random.Next(minValue, maxValue);
            string accountToFollowUserName = twitterAccountToFollow.AccountToFollowUserName;
            _webDriver.Navigate().GoToUrl(UrlAddresses.TWITTER_MAIN_URL + accountToFollowUserName);
            if (DocumentIsReady(_webDriver) == true && Helper.IsConnected())
            {
                System.Threading.Thread.Sleep(2000 + extraTimeToFollowProcess);
                _webDriver.FindElement(By.XPath(SeleniumCommand.TWITTER_FOLLOW_FOLLOW_BUTTON_ELEMENT_BYXPATH)).Click();
                System.Threading.Thread.Sleep(2500);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsLogin()
        {
            System.Threading.Thread.Sleep(2000);
            string url = _webDriver.Url;
            if (url == UrlAddresses.TWITTER_MAIN_HOME_PAGE_URL)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FollowingAccountExistOrBlocked(TwitterAccountToFollow twitterAccountToFollow)
        {

            string accountToFollowUserName = twitterAccountToFollow.AccountToFollowUserName;
            _webDriver.Navigate().GoToUrl(UrlAddresses.TWITTER_MAIN_URL + accountToFollowUserName);
            if (DocumentIsReady(_webDriver) == true)
            {
                System.Threading.Thread.Sleep(2200);
                List<IWebElement> webElements = _webDriver.FindElements(By.XPath(SeleniumCommand.TWITTER_ACCOUNT_STATUS_ELEMENT_BYXPATH)).ToList();
                foreach (var item in webElements)
                {
                    if (item.Text == SeleniumCommand.TWITTER_ACCOUNT_STATUS_NOEXIST_TR || item.Text == SeleniumCommand.TWITTER_ACCOUNT_STATUS_NOEXIST_EN || item.Text == SeleniumCommand.TWITTER_ACCOUNT_STATUS_BLOCKED_TR || item.Text == SeleniumCommand.TWITTER_ACCOUNT_STATUS_BLOCKED_EN)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void LogOut()
        {
            _webDriver.Quit();
        }

        public bool TwitterAccountIsBlocked()
        {
            string status = _webDriver.FindElement(By.XPath(SeleniumCommand.TWITTER_YOUR_ACCOUNT_STATUS_ELEMENT_BYPATH)).Text;
            if(status == SeleniumCommand.TWITTER_YOUR_ACCOUNT_STATUS_BLOCKED_TR)
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
