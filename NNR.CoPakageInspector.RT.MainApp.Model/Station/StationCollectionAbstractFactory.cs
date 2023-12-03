using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Station
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

