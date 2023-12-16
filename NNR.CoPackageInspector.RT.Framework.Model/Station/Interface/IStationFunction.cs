using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNR.CoPackageInspector.RT.Framework.Model.Station.Enums;

namespace NNR.CoPackageInspector.RT.Framework.Model.Station.Interface
{
    /// <summary>
    /// ステーション機能　インターフェースクラス
    /// </summary>
    public interface IStationFunction
    {
        FunctionStationDiscriptor Discriptor { get; }
    }
}
