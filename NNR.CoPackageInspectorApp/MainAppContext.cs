using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using NNR.Liblary.Utility.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NNR.CoPackageInspectorApp
{
    public class MainAppContext : IMainAppContext, IMainAppContextWriter
    {
        private IMainAppForm _mainAppForm;
        private SynchronizationContext _mainAppSynchronizationContext;

        private IMaybe<IMainAppModel> _mainAppModelContainer = Maybe.Empty<IMainAppModel>();

        private IMaybe<IMainAppControllers> _mainAppControllersContainer = Maybe.Empty<IMainAppControllers>();

        private IMaybe<IMainAppForm> _mainAppFormContainer = Maybe.Empty<IMainAppForm>();

        public IMainAppForm MainAppForm => _mainAppForm;

        public IMaybe<IMainAppForm> MainAppFormContainer => _mainAppFormContainer;

        public IMainAppModel MainAppModel {
            get =>  _mainAppModelContainer.Object;
            set => _mainAppModelContainer = Maybe.Create(value);
        }

        public SynchronizationContext MainAppSyncchronizationContext => _mainAppSynchronizationContext;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public IMainAppControllers MainAppControllers
        {
            get => _mainAppControllersContainer.Object;
            set => _mainAppControllersContainer = Maybe.Create(value);
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mainAppForm"></param>
        internal MainAppContext(IMainAppForm mainAppForm)
        {
            _mainAppForm = mainAppForm;
            _mainAppSynchronizationContext = SynchronizationContext.Current;
        }
    }
}
