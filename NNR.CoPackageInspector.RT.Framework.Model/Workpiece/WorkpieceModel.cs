using System;
using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.Framework.Interface.EventArguments;

namespace NNR.CoPackageInspector.RT.Framework.Model.Workpiece
{
    /// <summary>
    /// ワークモデル
    /// </summary>
    public class WorkpieceModel : IWorkpieceModel
    {
        private WorkpieceTypeModel _workpieceTypeModel;

        /// <summary>
        /// ワークサイズ　プロパティ
        /// </summary>
        public IWorkpieceSize Size => _workpieceTypeModel.WorkpieceSize;

        public string TypeIdName => _workpieceTypeModel.IdName;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="size"></param>
        public WorkpieceModel(WorkpieceTypeModel workpieceTypeModel)
        {
            _workpieceTypeModel = workpieceTypeModel;
        }
    }
}
