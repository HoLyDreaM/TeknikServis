using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Threading;

namespace TeknikServis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        internal static ApplicationContext ac = new ApplicationContext();

        [STAThread]
        static void Main()
        {
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Black");

            ac.MainForm = new frmGiris();
            Application.Run(ac);
        }
    }
}
