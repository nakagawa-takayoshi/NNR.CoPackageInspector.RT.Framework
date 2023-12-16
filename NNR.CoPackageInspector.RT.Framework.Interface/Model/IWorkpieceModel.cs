using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model
{
    public interface IWorkpieceModel
    {
        /// <summary>
        /// ワークサイズのプロパティ
        /// </summary>
        IWorkpieceSize Size { get; }
    }
}
