using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public static class MainAppModelProvider
    {

        /// <summary>
        /// MainAppModelのインスタンスを取得します。
        /// </summary>
        public static IMainAppModel GetInstance()
        {
            var mainAppContext = MainAppContextProvider.GetInstance();

            return mainAppContext.MainAppModel;
        }
    }
}
