using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model.Station
{
    public class StationFunctionCollection
    {

        public List<IStationFunction> Items { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StationFunctionCollection(IEnumerable<IStationFunction> stationFunctions)
        {
            Items = stationFunctions.ToList();
        }

        public StationFunctionCollection Clone()
        {
            return (StationFunctionCollection)MemberwiseClone();
        }

    }
}
