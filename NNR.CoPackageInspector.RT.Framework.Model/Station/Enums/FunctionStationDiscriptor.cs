using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.Station.Enums
{
    /// <summary>
    /// ステーション識別子
    /// </summary>
    public enum FunctionStationDiscriptor
    {
        AlignmentStation = 1,           // アライメント
        NoFunctionStation,              // 機能無し
        TwoDimCodeReaderStation,        // ２次元バーコード
        InsterctStaion,                 // 検査ステーション
        LaserStampStation,              // レーザー刻印ステーション
        PortInStation,                  // 投入ステーション
        PortOutStation,                 // 排出ステーション
        END
    }
}
