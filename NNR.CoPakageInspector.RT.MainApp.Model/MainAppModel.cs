using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPakageInspector.RT.MainApp.Model.Interface;
using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.Model
{
    internal class MainAppModel : IMainAppModel, IMainAppModelWriter
    {

        public IStationCollection Stations { get; set; }

        public IApplicationCondition AppCondition { get; }

        public List<UserControl> MainPanels { get; } = new List<UserControl>();

        public List<UserControl> MenuPanels { get; } = new List<UserControl>();

        public static IMainAppModelWriter Create()
        {
            return new MainAppModel();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal MainAppModel()
        {
            AppCondition = new ApplicationCondition();
        }
    }
}
