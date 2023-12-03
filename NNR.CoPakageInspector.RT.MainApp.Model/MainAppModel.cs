using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPakageInspector.RT.MainApp.Model.Interface;
using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model
{
    public class MainAppModel : IMainAppModel, IMainAppModelWriter
    {

        public StationCollection Stations { get; set; }

        public static IMainAppModelWriter Create()
        {
            return new MainAppModel();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal MainAppModel()
        {
            
        }
    }
}
