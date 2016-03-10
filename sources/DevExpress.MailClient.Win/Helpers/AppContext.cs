using System.Configuration;

namespace DevExpress.MailClient.Win.Helpers
{
    public class AppContext
    {
        private static AppContext _context;

        public static AppContext CurrentContext
        {
            get { return _context ?? (_context = new AppContext()); }
        }

        private readonly IAppSettingsReader _appSettingsReader;
        private AppContext()
        {
            _appSettingsReader = new AppSettingsReader();
        }

        private AppSettings _settings;

        public AppSettings Settings
        {
            get
            {
                return _settings ?? (_settings = _appSettingsReader.Read());
            }
        }
    }
}