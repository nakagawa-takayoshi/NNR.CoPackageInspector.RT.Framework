using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Model.Workpiece
{
    public class WorkpieceSize :IWorkpieceSize
    {
        private readonly float _width;
        private readonly float _height;

        /// <summary>
        /// 幅
        /// </summary>
        public float Width => _width;

        /// <summary>
        /// 高さ
        /// </summary>
        public float Height => _height; 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public WorkpieceSize(float width, float height)
        {
            _width = width;
            _height = height;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="size"></param>
        public WorkpieceSize(WorkpieceSize size)
        {
            _width = size.Width;
            _height = size.Height;
        }
    }
}
