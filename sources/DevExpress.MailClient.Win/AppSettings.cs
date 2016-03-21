using System.Collections.Generic;
using DevExpress.MailClient.Win.Helpers.Accounts;

namespace DevExpress.MailClient.Win
{
    public class AppSettings
    {
        public bool ShowSplashScreen { get; set; } 
        public List<Account> Accounts { get; set; }
    }
}