using NNR.CoPackageInspector.RT.Framework.Interface.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CopackageInspector.RT.Framework.Controller
{
    public class WorkpieceController
    {

        private Action<IWorkpieceModel> _action = delegate { };

        private IWorkpieceModel _workpieceModel;

        private EventHandler _updateWorkpieceModel;


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WorkpieceController(IWorkpieceModel workpieceModel)
        {
            _workpieceModel = workpieceModel;            
        }

        public IDisposable updateWorkpieceModelAsObservable(Action<IWorkpieceModel> action)
        {
            return Observable.FromEvent<Action<IWorkpieceModel>, IWorkpieceModel>(
                h => action += h,
                h => action -= h).Subscribe(_ =>
                {
                    _action(_workpieceModel);
                });
        }
    }
}
