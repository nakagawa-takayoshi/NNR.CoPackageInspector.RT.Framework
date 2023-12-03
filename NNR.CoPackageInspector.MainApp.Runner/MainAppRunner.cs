using NNR.CoPackageInspector.RT.MainApp.Interface;
using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using NNR.CoPakageInspector.RT.MainApp.Runner.Factory;
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

            var mainAppContext = MainAppContextProvider.GetInstance();

            if (!(mainAppContext.MainAppForm is Form mainAppForm)) return;

            Application.Run(mainAppForm);
        }


        /// <summary>
        /// MainAppModelの生成
        /// </summary>
        private void CreateMainAppModel()
        {
            // ステーションンコレクションを生成
            var stationCollection = StationCollectionFactory.Create();


            // MainAppModelの抽象化ファクトリークラスを生成
            var mainAppModelAbstractFactory = MainAppModelAbstractFactory.Create();

            // ステーションモデルを追加
            mainAppModelAbstractFactory.Add(stationCollection);

            // ファクトリークラスを生成
            var mainAppModelFactory = mainAppModelAbstractFactory.CreteFactory();

            var mainAppContext = MainAppContextProvider.GetInstance();
            var mainAppContextInitializer = MainAppContextInitializer.Create(mainAppContext);


            // MainAppModelを生成
            mainAppContextInitializer.MainAppModel = mainAppModelFactory.Create();
        }

    }
}
