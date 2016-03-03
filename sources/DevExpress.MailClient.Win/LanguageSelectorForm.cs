using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace DevExpress.MailClient.Win {
    public partial class LanguageSelectorForm :XtraForm {
        public LanguageSelectorForm() {
            InitializeComponent();
        }

        frmMain mainForm;
        private void simpleButton1_Click(object sender, EventArgs e) {
            Hide();
            SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);
            mainForm = new frmMain();
            mainForm.ShowDialog();
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            Hide();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;   //TODO
            SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);
            mainForm = new frmMain();
            mainForm.ShowDialog();
            Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e) {
            Hide();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa");
            Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;   //TODO
            SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);
            mainForm = new frmMain();
            mainForm.ShowDialog();
            Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e) {
            Hide();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("he");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("he");
            Properties.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture;   //TODO
            SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1000);
            mainForm = new frmMain();
            mainForm.ShowDialog();
            Close();
        }
    }
}
