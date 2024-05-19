using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Enums;
using NNR.CoPackageInspector.RT.MainApp.Interface.Model.Event;
using NNR.CoPackageInspector.RT.MainApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPcakageInspector.RT.MainApp.Controller
{
    public class ApplicationConditionController
    {
        IApplicationCondition _applicationCondition;

        /// <summary>
        /// インスタンスを生成します。
        /// </summary>
        public static ApplicationConditionController Create(IApplicationCondition applicationCondition)
        {
            return new ApplicationConditionController(applicationCondition);
        }

        /// <summary>
        /// コンストララクタ
        /// </summary>
        /// <param name="applicationCondition"></param>
        private ApplicationConditionController(IApplicationCondition applicationCondition)
        {
            _applicationCondition = applicationCondition;
        }


        /// <summary>
        /// 状態を更新します。
        /// </summary>
        public void Update(ApplicationConditionState state)
        {
            _applicationCondition.UpdateChange(state);
        }
    }
}
