using NNR.CoPackageInspector.RT.Framework.Controller.Station;
using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Interface;
using NNR.CoPackageInspector.RT.MainApp.Model.Station;
using NNR.Liblary.Utility;
using NNR.Liblary.Utility.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.Station
{
    public abstract class AbstractSation : IStationModel, IStationItem
    {
        #region 内部メモリ

        protected readonly Guid _guid = new Guid();
        protected int _id;
        protected StationFunctionQueue _stationFunctionQueue;
        protected IMaybe<IWorkpieceModel> _workpiece;

        #endregion

        public event Action OnAttachWorkpiece = delegate { };
        public event Action OnDettachWorkpiece = delegate { };

        //public IFrontControllerModel HardwareModel => _hardwareModel;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        protected AbstractSation(StationFunctionCollection stationFunctions, IStationFunction stationFunction, int id)
        {
            _id = id;
            _stationFunctionQueue = new StationFunctionQueue(stationFunctions, stationFunction);
        }

        #region プロパティ

        /// <summary>
        /// GUID＜プロパティ＞
        /// </summary>
        public Guid Guid => _guid;

        /// <summary>
        /// ＩＤ
        /// </summary>
        public int ID => _id;

        public bool HasWorkpiece => _workpiece.HasObject;

        /// <summary>
        /// 機能識別子
        /// </summary>
        public FunctionStationDiscriptor Function => _stationFunctionQueue.CurrentFunction;

        public IWorkpieceModel Workpiece => _workpiece.Object;

        #endregion

        public void ResetToOrigin()
        {
            _stationFunctionQueue.ResetToOrigin();
        }

        /// <summary>
        /// 機能キューを回します
        /// </summary>
        public void RotateFunction()
        {
            _stationFunctionQueue.Rotate();
        }

        /// <summary>
        /// ワークを割り当てる
        /// </summary>
        /// <param name="workpieceModel"></param>
        public void AttachWorkpiece(IWorkpieceModel workpieceModel)
        {
            _workpiece = Maybe.Create<IWorkpieceModel>(workpieceModel);

            OnAttachWorkpiece();
        }

        /// <summary>
        /// ワークを解除する
        /// </summary>
        /// <param name="workpiece"></param>
        public void DettachWorkpiece(out IMaybe<IWorkpieceModel> workpiece)
        {
            workpiece = _workpiece;
            if (!_workpiece.HasObject) return;

            OnDettachWorkpiece();
        }
    }
}

