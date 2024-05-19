using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Model
{
    public class ApplicationCondition : IApplicationCondition, IDisposable
    {

        #region 内部メモリ

        private ApplicationConditionState _applicationConditionState = ApplicationConditionState.Startup;


        #endregion

        #region プロパティ

        /// <summary>
        /// コンディション状態のプロパティ
        /// </summary>
        public ApplicationConditionState State => _applicationConditionState;

        #endregion

        #region イベントハンドラ

        private  Action<ApplicationConditionState> _updateChange;

        public Action<ApplicationConditionState> UpdateChange  => _updateChange;

        #endregion


        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ApplicationCondition()
        {
            _applicationConditionState = ApplicationConditionState.Startup;
            _updateChange += _onConditionChange;
        }


        #region イベントハンドラ

        /// <summary>
        /// コンディション切り替えハンドラ
        /// </summary>
        private void _onConditionChange(ApplicationConditionState state)
        {
            _applicationConditionState = state;
        }

        #endregion


        public IDisposable ConditionChangeAsObservable(Action<ApplicationConditionState> action)
        {
            return Observable.FromEvent<Action<ApplicationConditionState>, ApplicationConditionState>(
                               h => h,
                               h => _updateChange += h,
                               h => _updateChange -= h)
                                .Subscribe(action);
        }


        public void Dispose()
        {
            _updateChange -= _onConditionChange;
        }

    }
}
