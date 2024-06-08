using NNR.CoPackageInspector.RT.MainApp.Controller.Factory;
using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPackageInspector.RT.MainApp.Interface.View;
using NNR.CoPackageInspector.RT.MainApp.Model.Factory;
using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNR.CoPackageInspector.MainApp.Runner
{
    public class MainAppRunner
    {
        /// <summary>
        /// クラスをインスタンス化
        /// </summary>
        public static  MainAppRunner Create(IMainAppContext mainAppContext)
        {
            return new MainAppRunner(mainAppContext);       
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private MainAppRunner(IMainAppContext mainAppContext) 
        {
            var mainAppContextProvider = MainAppContextProviderFactory.Create(mainAppContext);
        }

        /// <summary>
        /// MainAppを実行します。
        /// </summary>
        public void Run() 
        {
            // MainAppModel生成
            CreateMainAppModel();

            // MainAppControllers生成
            CreateMainAppControllers();

            var mainAppContext = MainAppContextProvider.GetInstance();

            InstantiationApplication(mainAppContext.MainAppForm);

            if (!(mainAppContext.MainAppForm is Form mainAppForm)) return;

            Application.Run(mainAppForm);
        }


        /// <summary>
        /// MainAppModelの生成
        /// </summary>
        private void CreateMainAppModel()
        {
            var mainAppContext = MainAppContextProvider.GetInstance();
            var mainAppContextInitializer = MainAppContextInitializer.Create(mainAppContext);

            // MainAppModelの抽象化ファクトリークラスを生成
            var mainAppModelAbstractFactory = MainAppModelAbstractFactory.Create();
            // ステーションンコレクションを生成
            var stationCollection = StationCollectionFactory.Create();

            // ステーションモデルを追加
            mainAppModelAbstractFactory.Add(stationCollection);
            // ファクトリークラスを生成
            var mainAppModelFactory = mainAppModelAbstractFactory.CreteFactory();

            // MainAppModelを生成
            mainAppContextInitializer.MainAppModel = mainAppModelFactory.Create();
        }


        private void CreateMainAppControllers()
        {
            var mainAppContext = MainAppContextProvider.GetInstance();
            var mainAppContextInitializer = MainAppContextInitializer.Create(mainAppContext);

            mainAppContextInitializer.MainAppControllers = MainAppControllersFactory.Create();
        }

        public void InstantiationApplication(IMainAppForm mainAppForm)
        {
            mainAppForm.CreateMainPanels(mainAppForm.MainPanel);
        }
    }
}
