using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.Framework.Model.Workpiece;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Collections;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Model.Collections;
using System;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.RT.MainApp.Model
{
    internal class MainAppModel : IMainAppModel, IMainAppModelWriter
    {

        public IStationCollection Stations { get; set; }

        public IWorkpieceModel WorkpieceModel { get; set; } = new WorkpieceModel(new WorkpieceTypeModel(Guid.Empty));

        public IApplicationCondition AppCondition { get; } = new ApplicationCondition();

        public Control MainPanel { get; set; }

        public IPanelsCollection<NcopPanelType> MainPanels { get; } = new PanelsCollection<NcopPanelType>();

        public IPanelsCollection<NcopMenuType> MenuPanels { get; } = new PanelsCollection<NcopMenuType>();


        public static MainAppModel Create()
        {
            return new MainAppModel();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal MainAppModel()
        {
        }

        public IMainAppModelWriter GetWriter()
        {
            return this;
        }

    }
}
