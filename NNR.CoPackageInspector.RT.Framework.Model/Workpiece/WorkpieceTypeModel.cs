using NNR.Liblary.Utility.Misc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.Framework.Model.Workpiece
{
    public class WorkpieceTypeModel
    {
        private Guid _uid;
        private string _idName;
        IMaybe<WorkpieceSize> _workpieceSizeContainer = Maybe.Empty<WorkpieceSize>(); 

        public Guid Uid => _uid;

        public string IdName => _idName;

        public WorkpieceSize WorkpieceSize => _workpieceSizeContainer.Object;

        public event Action<float> WorkpieceSizeWidthChanged;
        public event Action<float> WorkpieceSizeHeightChanged;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceTypeModel(Guid uid)
        {
            _uid = uid;

            WorkpieceSizeWidthChanged += UpdateWorkpieceSizeWidth;
            WorkpieceSizeHeightChanged += UpdateWorkpieceSizeHeight;
        }


        public void UpdateIdName(string renewIdName)
        {
            _idName = renewIdName;
        }

        public void UpdateWorkpieceSizeWidth(float width)
        {
            WorkpieceSize renewWorkpieceSize;
            if (!_workpieceSizeContainer.HasObject)
            {
                renewWorkpieceSize = new WorkpieceSize(width, 0);
            }
            else
            {
                var workpieceSize = _workpieceSizeContainer.Object;
                renewWorkpieceSize = new WorkpieceSize(width, workpieceSize.Height);
            }

            _workpieceSizeContainer = Maybe.Create(renewWorkpieceSize);
        }

        public void UpdateWorkpieceSizeHeight(float height)
        {
            WorkpieceSize renewWorkpieceSize;
            if (!_workpieceSizeContainer.HasObject)
            {
                renewWorkpieceSize = new WorkpieceSize(0, height);
            }
            else
            {
                var workpieceSize = _workpieceSizeContainer.Object;
                renewWorkpieceSize = new WorkpieceSize(workpieceSize.Width, height);
            }

            _workpieceSizeContainer = Maybe.Create(renewWorkpieceSize);
        }

        public IDisposable CreateDisposable()
        {
            return Disposable.Create(() =>
            {
                WorkpieceSizeWidthChanged -= UpdateWorkpieceSizeWidth;
                WorkpieceSizeHeightChanged -= UpdateWorkpieceSizeHeight;
            });
        }
    }
}
