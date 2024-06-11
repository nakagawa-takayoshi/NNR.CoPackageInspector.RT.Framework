using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Factory
{
    public class MainAppModelFactory
    {
        internal StationCollection StationCollection { private get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal MainAppModelFactory()
        {
        }

        public IMainAppModel Create()
        {
            var mainAppModel = MainAppModel.Create();

            mainAppModel.Stations.Add(StationCollection);

            return mainAppModel;
        }

    }
}
