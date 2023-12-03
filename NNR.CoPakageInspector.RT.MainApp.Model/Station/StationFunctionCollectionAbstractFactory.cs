using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Station
{
    public class StationFunctionCollectionAbstractFactory
    {
        private List<FunctionStationDiscriptor> _stationFunctions = new List<FunctionStationDiscriptor>();

        public static StationFunctionCollectionAbstractFactory Create()
        {
            return new StationFunctionCollectionAbstractFactory();
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private StationFunctionCollectionAbstractFactory()
        {
        }


        /// <summary>
        /// 機能を追加
        /// </summary>
        public void Add(FunctionStationDiscriptor functionStationDiscriptor) 
        {
            _stationFunctions.Add(functionStationDiscriptor);
        }


        public StationFunctionCollectionFactory CreateFactory()
        {
            var stationFunctionCollectionFactory = new StationFunctionCollectionFactory(_stationFunctions.ToArray());

            return stationFunctionCollectionFactory;
        }
    }
}
