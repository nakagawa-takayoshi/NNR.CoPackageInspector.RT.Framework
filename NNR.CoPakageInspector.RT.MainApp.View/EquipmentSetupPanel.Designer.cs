namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class EquipmentSetupPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentSetupPanel));
            this._titleBar = new NNR.CoPakageInspector.RT.MainApp.View.TitleBar();
            this._buttonWorkSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _titleBar
            // 
            this._titleBar.Captions = "Equipment Setup";
            resources.ApplyResources(this._titleBar, "_titleBar");
            this._titleBar.FontSize = 24;
            this._titleBar.Name = "_titleBar";
            // 
            // _buttonWorkSetup
            // 
            resources.ApplyResources(this._buttonWorkSetup, "_buttonWorkSetup");
            this._buttonWorkSetup.Name = "_buttonWorkSetup";
            this._buttonWorkSetup.UseVisualStyleBackColor = true;
            // 
            // EquipmentSetupPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonWorkSetup);
            this.Controls.Add(this._titleBar);
            this.Name = "EquipmentSetupPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar _titleBar;
        private System.Windows.Forms.Button _buttonWorkSetup;
    }
}
