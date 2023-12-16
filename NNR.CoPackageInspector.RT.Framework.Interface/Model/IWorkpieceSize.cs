using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Interface.Model
{
    public interface IWorkpieceSize
    {
        /// <summary>
        /// 幅
        /// </summary>
        float Width { get; }

        /// <summary>
        /// 高さ
        /// </summary>
        float Height { get; }
    }
}
