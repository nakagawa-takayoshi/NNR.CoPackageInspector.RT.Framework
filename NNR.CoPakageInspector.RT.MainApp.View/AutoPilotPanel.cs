using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using NNR.CoPakageInspector.RT.MainApp.View.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPakageInspector.RT.MainApp.View
{
    public partial class AutoPilotPanel : UserControl, IAutoPilotPanel
    {
        private IStationCollection _stations;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AutoPilotPanel()
        {
            InitializeComponent();
        }


        public void OnResetOrigin(EventArgs e)
        {
            _stations = MainAppContextProvider.GetInstance().MainAppModel.Stations;
            _stations.ResetToOrigin();
        }

        
        protected void OnPostExecuteCompleted(EventArgs e) 
        {
            // 自動運転の処理終了後にステーションの機能を切り替える。
            _stations.RoateFunction();
        }
    }
}
