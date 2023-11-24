using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NNR.CoPakageInspector.RT.MainApp.Model
{
    public class MainAppContext : IMainAppContext
    {
        private static MainAppContext _me;

        private IMainAppForm _mainAppForm;
        private IMainAppSynchronizationContext _mainAppSynchronizationContext;
        private MainAppModel _mainAppModel;

        public IMainAppForm MainAppForm => _mainAppForm;

        public IMainAppModel MainAppModel => _mainAppModel;

        public SynchronizationContext MainAppSyncchronizationContext => _mainAppSynchronizationContext.MainAppSynchronizationContext;


        public IHardwareModel hardwareModel => throw new NotImplementedException();

        /// <summary>
        /// インスタンス取得
        /// </summary>
        /// <returns></returns>
        public static MainAppContext GetInstance()
        {
            return _me;
        }


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="mainAppForm"></param>
        internal MainAppContext(IMainAppFormContext mainAppForm)
        {
            _mainAppForm = mainAppForm;
            _mainAppSynchronizationContext = mainAppForm;

            var hardwareModelFactory = new HardwareModelFactory();
            var hardWareModel = hardwareModelFactory.Create();

            var mainAppModelFactory = new MainAppModelAbstractFactory();
            mainAppModelFactory.AddHardwareModel(hardwareModelFactory);

            _mainAppModel = mainAppModelFactory.Create();
        }
    }
}
