using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NR.Inspector.RT.Framework.HardwareIO.Model;
using NR.Inspector.RT.Framework.Model.Interface;

namespace NR.Inspector.RT.Framework.Model
{
    public class StationCollectionItem : AbstractSation
    {

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StationCollectionItem(List<IStationFunction> stationFunctionList, IStationFunction originFunction, IFrontControllerModel frontControllerModel)
            : base(stationFunctionList, originFunction, frontControllerModel, 1)
        {
        }
    }
}
