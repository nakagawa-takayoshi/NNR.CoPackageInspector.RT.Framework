using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using RoundRobin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Controller.Station
{

    /// <summary>
    /// ステーション機能のキュー
    /// </summary>
    public class StationFunctionQueue
    {
        IStationFunction _originStationFunction;
        RoundRobinList<IStationFunction> _stationFunctionRoundRobin;
        IStationFunction _currentStationFunction;

        public FunctionStationDiscriptor CurrentFunction => _currentStationFunction.Discriptor;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StationFunctionQueue(List<IStationFunction> stationFunctionList, IStationFunction oringStationFunction)
        {
            _originStationFunction = oringStationFunction;
            _stationFunctionRoundRobin = new RoundRobinList<IStationFunction>(stationFunctionList);
            _stationFunctionRoundRobin.ResetTo(_originStationFunction);
            _currentStationFunction = oringStationFunction;
        }

        /// <summary>
        /// 原点復帰を行います。
        /// </summary>
        public void ResetToOrigin()
        {
            _stationFunctionRoundRobin.ResetTo(_originStationFunction);
        }

        /// <summary>
        /// キューを回転する。
        /// </summary>
        public void Rotate()
        {
            _currentStationFunction = _stationFunctionRoundRobin.Next();
        }

        public IStationFunction GetCurrentFunction()
        {
            return _currentStationFunction;
        }
    }
}
