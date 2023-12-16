using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using NNR.CoPackageInspector.RT.Framework.Interface.Model.EventArguments;

namespace NNR.CopackageInspector.RT.Framework.Model.Workpiece
{
    /// <summary>
    /// ワークモデル
    /// </summary>
    public class WorkpieceModel : IWorkpieceModel, IDisposable
    {
        private WorkpieceSize _workSize;

        public delegate void SizeChangeEventHandler(WorkSizeChanedEventArg e);

        public event SizeChangeEventHandler _sizeChangedEventHandler;

        /// <summary>
        /// ワークサイズ　プロパティ
        /// </summary>
        public IWorkpieceSize Size => _workSize;
            

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="size"></param>
        public WorkpieceModel(WorkpieceSize size)
        {
            _workSize = size;
            _sizeChangedEventHandler += _onSizeChangeDefault;
        }

        /// <summary>
        /// サイズ変更イベント発行
        /// </summary>
        /// <param name="e"></param>
        public void OnSizeChanged(WorkSizeChanedEventArg e)
        {
            _sizeChangedEventHandler?.Invoke(e);
        }

        /// <summary>
        /// サイズ変更イベント（デフォルト）
        /// </summary>
        /// <param name="e"></param>
        private void _onSizeChangeDefault(WorkSizeChanedEventArg e)
        {
            _workSize = e.Size;
        }


        public void Dispose()
        {
            _sizeChangedEventHandler -= _onSizeChangeDefault;
        }
    }
}
