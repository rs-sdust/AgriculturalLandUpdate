using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ESRI.ArcGIS;
using ESRI.ArcGIS.esriSystem;
using System.Diagnostics;

namespace AgriculturalLandUpdate
{
    static class Program
    {
        private static LicenseInitializer m_AOLicenseInitializer = new LicenseInitializer();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //Process process = Common.ProcessCheck.RuningInstance();
                //if (process != null)
                //{
                //    Common.ProcessCheck.HandleRunningInstance(process);
                //    //System.Threading.Thread.Sleep(1000);  
                //    System.Environment.Exit(1);
                //}
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();

                    bool licensed = m_AOLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeEngine, esriLicenseProductCode.esriLicenseProductCodeStandard, esriLicenseProductCode.esriLicenseProductCodeAdvanced },
                        new esriLicenseExtensionCode[] { esriLicenseExtensionCode.esriLicenseExtensionCodeSpatialAnalyst });
                    if (!licensed)
                    {
                        MessageBox.Show(m_AOLicenseInitializer.LicenseMessage(), "初始化许可失败", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    frmLogin login = new frmLogin();
                    if (DialogResult.OK == login.ShowDialog())
                    {
                        Application.Run(new frmMain());
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"启动失败！");
            }
            finally
            {
                m_AOLicenseInitializer.ShutdownApplication();
            }
        }
    }
}
