using NNR.CoPackageInspector.MainApp.Runner;
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPakageInspector.RT.MainApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspectorApp
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainAppContext =  new MainAppContext(new MainAppForm());
            var mainAppRunner = MainAppRunner.Create(mainAppContext);

            mainAppRunner.Run();
        }
    }
}
