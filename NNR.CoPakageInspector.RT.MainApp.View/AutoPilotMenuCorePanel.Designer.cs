﻿namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class AutoPilotMenuCorePanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoPilotMenuCorePanel));
            this._buttonResetToOrigin = new System.Windows.Forms.Button();
            this._buttonOperationStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonResetToOrigin
            // 
            resources.ApplyResources(this._buttonResetToOrigin, "_buttonResetToOrigin");
            this._buttonResetToOrigin.Name = "_buttonResetToOrigin";
            this._buttonResetToOrigin.UseVisualStyleBackColor = true;
            // 
            // _buttonOperationStart
            // 
            resources.ApplyResources(this._buttonOperationStart, "_buttonOperationStart");
            this._buttonOperationStart.Name = "_buttonOperationStart";
            this._buttonOperationStart.UseVisualStyleBackColor = true;
            // 
            // AutoPilotMenuCorePanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonOperationStart);
            this.Controls.Add(this._buttonResetToOrigin);
            this.Name = "AutoPilotMenuCorePanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonResetToOrigin;
        private System.Windows.Forms.Button _buttonOperationStart;
    }
}
