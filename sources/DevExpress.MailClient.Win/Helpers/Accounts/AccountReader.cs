using System.Collections.Generic;
using System.Xml;

namespace DevExpress.MailClient.Win.Helpers.Accounts
{
    public class AccountReader : IAccountReader
    {
        public List<Account> GetAccounts()
        {
            List<Account> accountList = new List<Account>();
            XmlDocument doc = new XmlDocument();
            doc.Load(Constants.ACCOUNTS_FILE);
            var accountNodeList = doc.DocumentElement?.SelectNodes("account");
            if (accountNodeList != null)
            {
                foreach (XmlNode accountNode in accountNodeList)
                {
                    Account account = new Account();
                    account.Type = accountNode.SelectSingleNode("account-type")?.InnerText;
                    account.Name = accountNode.SelectSingleNode("name")?.InnerText;
                    account.Email = accountNode.SelectSingleNode("email")?.InnerText;
                    account.Incoming = accountNode.SelectSingleNode("incoming")?.InnerText;
                    account.Outgoing = accountNode.SelectSingleNode("outgoing")?.InnerText;
                    account.Username = accountNode.SelectSingleNode("username")?.InnerText;
                    account.Password = accountNode.SelectSingleNode("password")?.InnerText;

                    accountList.Add(account);
                }
            }
            return accountList;
        }
    }
}
