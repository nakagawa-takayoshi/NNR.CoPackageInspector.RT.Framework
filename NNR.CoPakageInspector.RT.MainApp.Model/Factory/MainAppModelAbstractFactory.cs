using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Factory
{
    public class MainAppModelAbstractFactory
    {
        MainAppModelFactory _factory = new MainAppModelFactory();

        public static MainAppModelAbstractFactory Create()
        {
            return new MainAppModelAbstractFactory();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private MainAppModelAbstractFactory()
        {
        }

        /// <summary>
        /// ステーション群を追加します。
        /// </summary>
        public void Add(StationCollection stations)
        {
            _factory.StationCollection = stations;
        }

        /// <summary>
        /// MainAppModelのファクトリークラスを生成します。
        /// </summary>
        public MainAppModelFactory CreteFactory()
        {
            return _factory;
        }

    }
}
