using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace NR.CoPackageInspectorApp.MainApp.View
{
    public class ApplicationExitProcessor
    {
        private ApplicationExitAskForm _exitAskForm;
        private IWin32Window _owner;

        /// <summary>
        /// アプリケーション終了処理クラス
        /// </summary>
        /// <param name="owner"></param>
        public ApplicationExitProcessor(IWin32Window owner)
        {
            _owner = owner;
        }


        /// <summary>
        /// 終了処理
        /// </summary>
        /// <param name="e"></param>
        public void Exit(FormClosingEventArgs e)
        {
            _exitAskForm = new ApplicationExitAskForm();
            var dr = _exitAskForm.ShowDialog(_owner);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }


            var progressForm = new ApplicationExitProgressForm(ExitProcess);

            // 終了処理中フォームを表示
            progressForm.ShowDialog(_owner);
        }

        /// <summary>
        /// 終了処理
        /// </summary>
        private void ExitProcess()
        {
            Thread.Sleep(2000);
        }

    }
}
