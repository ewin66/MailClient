using System.Collections.Generic;

namespace DevExpress.MailClient.Win.Helpers.Accounts
{
    public interface IAccountReader
    {
        List<Account> GetAccounts();
    }
}