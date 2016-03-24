using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Helpers;
using DevExpress.XtraSplashScreen;
using DevExpress.Skins;
using DevExpress.Data.Filtering;
using DevExpress.MailClient.Win.Forms;
using System.Drawing;
using System.Threading;
using DevExpress.MailClient.EF;
using DevExpress.XtraEditors;
using System.Net.Mail;
using System.Xml;
using DevExpress.MailClient.Win.Helpers.Accounts;

// Hello eveybody! Gabi was here :P
// And I'm still here...

namespace DevExpress.MailClient.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments) {

            // TODO uncomment to test EF code first sample
            // Prerequisites: SQL Server express
            //using (var mailContext = new MailContext())
            //{
            //    var savedUser = new User {Name = "Test", Password = "Test"};
            //    mailContext.Users.Add(savedUser);
            //    mailContext.SaveChanges();

            //    var retrievedUser = mailContext.Users.First();
            //    Console.WriteLine($"User: {retrievedUser.Name}");
            //}

            DataHelper.ApplicationArguments = arguments;
            DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            SkinManager.EnableFormSkins();
            EnumProcessingHelper.RegisterEnum<TaskStatus>();
            UnpackHelper.Unpack();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            bool accountCreated = CheckAccountExists();
            if (!accountCreated)
            {
                accountCreated = CreateAccount();
            }

            if (accountCreated)
            {
                ShowSplashScreen();
                Application.Run(new frmMain()); 
            }
        }

        private static void ShowSplashScreen()
        {
            if (AppContext.CurrentContext.Settings.ShowSplashScreen)
            {
                SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);    
            }
        }

        private static bool CheckAccountExists()
        {
            try
            {
                return AppContext.CurrentContext.Accounts.Any();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error - Cannot load accounts file" + ex.Message);
            }
            return false;
        }

        private static bool CreateAccount()
        {
            using (var accountForm = new EmailAccountForm())
            {
                return accountForm.ShowDialog() == DialogResult.OK;
            }
        }
    }
}
