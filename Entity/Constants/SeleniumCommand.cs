using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Constants
{
    public static class SeleniumCommand
    {
        public const string TWITTER_JS_DOCUMENTISREADY_COMMAND = "return document.readyState";
        public const string TWITTER_JS_DOCUMENTISREADY_STATUS = "complete";
        public const string TWITTER_LOGIN_USERNAME_TEXT_ELEMENT_BYNAME = "text";
        public const string TWITTER_LOGIN_CONTINUE_BUTTON_ELEMENT_BYXPATH = "//div[contains(@class, 'css-901oao r-1awozwy r-6koalj r-18u37iz r-16y2uox r-37j5jr r-a023e6 r-b88u0q r-1777fci r-rjixqe r-bcqeeo r-q4m81j r-qvutc0')]";
        public const string TWITTER_LOGIN_USERPASSWORD_TEXT_ELEMENT_BYNAME = "password";
        public const string TWITTER_LOGIN_LOGIN_BUTTON_ELEMENT_BYXPATH = "//div[contains(@class, 'css-901oao r-1awozwy r-6koalj r-18u37iz r-16y2uox r-37j5jr r-a023e6 r-b88u0q r-1777fci r-rjixqe r-bcqeeo r-q4m81j r-qvutc0')]";
        public const string TWITTER_FOLLOW_FOLLOW_BUTTON_ELEMENT_BYXPATH = "//div[contains(@class,'css-1dbjc4n r-6gpygo')]";
        public const string TWITTER_ACCOUNT_STATUS_ELEMENT_BYXPATH = "//span[contains(@class, 'css-901oao css-16my406 r-poiln3 r-bcqeeo r-qvutc0')]";
        public const string TWITTER_YOUR_ACCOUNT_STATUS_ELEMENT_BYPATH = "//div[contains(@class,'PageHeader Edge')]";
        public const string TWITTER_YOUR_ACCOUNT_STATUS_BLOCKED_TR = "Bazı hesap özelliklerini geçici olarak sınırladık.";
        public const string TWITTER_ACCOUNT_STATUS_BLOCKED_TR = "Hesap askıya alındı";
        public const string TWITTER_ACCOUNT_STATUS_BLOCKED_EN = "Account suspended";
        public const string TWITTER_ACCOUNT_STATUS_NOEXIST_TR = "Böyle bir hesap yok";
        public const string TWITTER_ACCOUNT_STATUS_NOEXIST_EN = "This account doesn’t exist";



    }
}
