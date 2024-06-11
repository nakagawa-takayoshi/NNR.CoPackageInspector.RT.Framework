namespace NNR.CoPckageInspector.RT.EquipmentSetup.View
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
            this._titleBar = new NNR.CoPackageInspector.CustomControl.View.TitleBar();
            this.SuspendLayout();
            // 
            // _titleBar
            // 
            this._titleBar.Captions = "Equipment Setup";
            resources.ApplyResources(this._titleBar, "_titleBar");
            this._titleBar.FontSize = 24;
            this._titleBar.IsReturnButton = false;
            this._titleBar.Name = "_titleBar";
            // 
            // EquipmentSetupPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._titleBar);
            this.Name = "EquipmentSetupPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private NNR.CoPackageInspector.CustomControl.View.TitleBar _titleBar;
    }
}
