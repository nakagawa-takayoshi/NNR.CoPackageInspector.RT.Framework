using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNR.CopackageInspector.RT.Framework.Model.Workpiece;
using NR.Inspector.RT.Framework.Model.EventArguments;

namespace NNR.CopackageInspector.RT.Framework.Model.Workpiece.Interface
{
    public interface IWorkpieceModel
    {
        /// <summary>
        /// ワークサイズのプロパティ
        /// </summary>
        WorkpieceSize Size { get; }

        /// <summary>
        /// サイズ変化処理
        /// </summary>
        /// <param name="e"></param>
        void OnSizeChanged(WorkSizeChanedEventArg e);
    }
}
