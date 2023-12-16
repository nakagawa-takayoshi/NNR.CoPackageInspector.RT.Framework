using NNR.CoPackageInspector.RT.Framework.Interface.Enums;
using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.EventArguments
{
    public class WorkpieceChangedEventArgs : EventArgs
    {

        #region 内部メモリ

        private WorkpieceChangedEventID _eventID;

        private IWorkpieceModel _workpieceModel;

        #endregion

        /// <summary>
        /// プロパティ
        /// </summary>

        public WorkpieceChangedEventID EventID => _eventID;

        public IWorkpieceModel WorkpieceModel => _workpieceModel;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceChangedEventArgs(WorkpieceChangedEventID eventID, IWorkpieceModel workpieceModel)
        {
            _eventID = eventID;
            _workpieceModel = workpieceModel;
        }
    }
}
