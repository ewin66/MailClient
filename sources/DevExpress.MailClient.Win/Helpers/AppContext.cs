﻿using System.Collections.Generic;
using DevExpress.MailClient.Win.Helpers.Accounts;

namespace DevExpress.MailClient.Win.Helpers
{
    public class AppContext
    {
        private static AppContext _context;

        private AppSettings _settings;
        private List<Account> _accounts;

        private readonly IAppSettingsReader _appSettingsReader;
        private readonly IAccountReader _accountReader;

        private AppContext()
        {
            _appSettingsReader = new AppSettingsReader();
            _accountReader = new AccountReader();
        }

        public static AppContext CurrentContext => _context ?? (_context = new AppContext());
        public AppSettings Settings => _settings ?? (_settings = _appSettingsReader.Read());
        public List<Account> Accounts => _accounts ?? (_accounts = _accountReader.GetAccounts());
    }
}