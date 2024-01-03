using NNR.CoPackageInspector.RT.MainApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Controller
{
    internal class MainAppControllers : IMainAppControllers
    {

        public ExcluclutionController ExcluclutionController { get; } =new ExcluclutionController();

        /// <summary>
        /// インスタンスの生成
        /// </summary>
        public static IMainAppControllers Create()
        {
            return new MainAppControllers();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private MainAppControllers() 
        { 
        }
    }
}
