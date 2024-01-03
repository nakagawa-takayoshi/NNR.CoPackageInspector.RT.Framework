using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    /// <summary>
    /// MainAppControllersのProviderクラス
    /// </summary>
    public static  class MainAppControlersProvider
    {
        /// <summary>
        /// インスタンスの取得
        /// </summary>
        public static IMainAppControllers GetInstance()
        {
            var mainAppContextProvider = MainAppContextProvider.GetInstance();
            return mainAppContextProvider.MainAppControlers;
        }
    }
}

