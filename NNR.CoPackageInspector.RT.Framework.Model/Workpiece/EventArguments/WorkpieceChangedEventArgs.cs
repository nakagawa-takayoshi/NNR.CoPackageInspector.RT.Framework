using NNR.CopackageInspector.RT.Framework.Model.Workpiece.Interface;
using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Model.Workpiece.EventArguments
{
    public class WorkpieceChangedEventArgs : EventArgs
    {

        #region 内部メモリ

        private Enums.EventID _eventID;

        private IWorkpieceModel _workpieceModel;

        #endregion

        /// <summary>
        /// プロパティ
        /// </summary>

        public Enums.EventID EventID => _eventID;

        public IWorkpieceModel WorkpieceModel => _workpieceModel;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceChangedEventArgs(Enums.EventID eventID, IWorkpieceModel workpieceModel)
        {
            _eventID = eventID;
            _workpieceModel = workpieceModel;
        }
    }
}
