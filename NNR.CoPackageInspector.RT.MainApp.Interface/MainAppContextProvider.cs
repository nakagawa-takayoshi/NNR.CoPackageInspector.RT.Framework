using NNR.CoPackageInspector.RT.MainApp.Interface.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNR.CoPackageInspector.RT.MainApp.Interface
{
    public class MainAppContextProvider
    {
        /// <summary>
        /// シングルトンオブジェクト
        /// </summary>
        private static MainAppContextProvider _me = null;

        /////////////////////////////////////////////////////////
        // <summary>
        // 内部変数
        // </summary>

        /// <summary>
        /// MainAppContext
        /// </summary>
        private IMainAppContext _mainAppContext;


        #region internal
        /// <summary>
        /// インスタンスを生成する。
        /// </summary>
        internal static MainAppContextProvider CreteInstance(IMainAppContext mainAppContext)
        {
            if (!(_me is null)) return _me;

            _me = new MainAppContextProvider(mainAppContext);

            return _me;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal MainAppContextProvider(IMainAppContext mainAppContext)
        {
            _mainAppContext = mainAppContext;
        }

        #endregion
        

        /// <summary>
        /// アプリケーションコンテキストを取得します。
        /// </summary>
        public static IMainAppContext GetInstance()
        {
            return _me._mainAppContext;
        }

    }
}
