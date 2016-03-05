using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace IPOCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DevExpress.UserSkins.BonusSkins.Register();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                if (!DevExpress.Skins.SkinManager.AllowFormSkins)
                {
                    DevExpress.Skins.SkinManager.EnableFormSkins();
                }
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
