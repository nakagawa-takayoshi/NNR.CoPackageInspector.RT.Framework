using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;
using NNR.Liblary.Utility.Maybe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.Station.Interface
{
    /// <summary>
    /// ステーションのインターフェースクラス
    /// </summary>
    public interface IStationModel
    {

        //IFrontControllerModel HardwareModel { get; }

        /// <summary>
        /// GUID
        /// </summary>
        Guid Guid { get; }


        int ID { get; }

        /// <summary>
        /// ワークを持っているか？
        /// </summary>
        bool HasWorkpiece { get; }

        /// <summary>
        /// ステーションの機能
        /// </summary>
        FunctionStationDiscriptor Function { get; }

        event Action OnAttachWorkpiece;

        void AttachWorkpiece(IWorkpieceModel workMode);

        void DettachWorkpiece(out IMaybe<IWorkpieceModel> workpiece);
    }
}
