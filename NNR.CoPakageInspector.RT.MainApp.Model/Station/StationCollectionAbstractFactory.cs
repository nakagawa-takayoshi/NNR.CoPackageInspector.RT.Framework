using NNR.CoPakageInspector.RT.MainApp.Model.Station;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Station
{
    public class StationCollectionAbstractFactory
    {
        List<StationCollectionItem> stationCollectionItems = new List<StationCollectionItem>();

        public static StationCollectionAbstractFactory Create()
        {

            return new StationCollectionAbstractFactory();
        }

        private StationCollectionAbstractFactory() 
        {
        }

        public void Add(StationCollectionItem stationCollectionItem)
        {
            stationCollectionItems.Add(stationCollectionItem);
        }


        /// <summary>
        /// ファクトリークラスを生成します。
        /// </summary>
        public StationCollectionConcreteFactory CreateFactory()
        {
            return new StationCollectionConcreteFactory(stationCollectionItems);
        }
    }
}

