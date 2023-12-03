using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
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

        public IMainAppForm MainAppForm => _mainAppForm;

        public IMainAppModel MainAppModel { get; set; }

        public SynchronizationContext MainAppSyncchronizationContext => _mainAppSynchronizationContext;


        //public IHardwareModel hardwareModel => throw new NotImplementedException();


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
