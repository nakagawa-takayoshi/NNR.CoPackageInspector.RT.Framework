using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.MainApp.Runner
{
    public class MainAppRunner
    {

        public static  MainAppRunner Create(IMainAppContext mainAppContext)
        {
            return new MainAppRunner(mainAppContext);
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private MainAppRunner(IMainAppContext mainAppContext) 
        {
            var mainAppContextProvider = MainAppContextFactory.Create(mainAppContext);
        }

        public void Run() 
        {
            var mainAppContext = MainAppContextProvider.GetInstance();
            if (!(mainAppContext.MainAppForm is Form mainAppForm)) return;

            Application.Run(mainAppForm);
        }
    }
}
