using NNR.CoPackageInspector.RT.Framework.Model.Station;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPakageInspector.RT.MainApp.Model.Station
{
    public class StationCollectionItem : AbstractSation
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StationCollectionItem(StationFunctionCollection stationFunctionCollection, IStationFunction thisFunction)
            : base(stationFunctionCollection, thisFunction, 1)
        {
        }
    }
}
