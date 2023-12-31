namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class MainMenuPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuPanel));
            this._buttonOverView = new System.Windows.Forms.Button();
            this._buttonAutoPilot = new System.Windows.Forms.Button();
            this._buttonEquipment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonOverView
            // 
            resources.ApplyResources(this._buttonOverView, "_buttonOverView");
            this._buttonOverView.Name = "_buttonOverView";
            this._buttonOverView.UseVisualStyleBackColor = true;
            this._buttonOverView.Click += new System.EventHandler(this._buttonOverView_Click);
            // 
            // _buttonAutoPilot
            // 
            resources.ApplyResources(this._buttonAutoPilot, "_buttonAutoPilot");
            this._buttonAutoPilot.Name = "_buttonAutoPilot";
            this._buttonAutoPilot.UseVisualStyleBackColor = true;
            this._buttonAutoPilot.Click += new System.EventHandler(this._buttonAutoPilot_Click);
            // 
            // _buttonEquipment
            // 
            resources.ApplyResources(this._buttonEquipment, "_buttonEquipment");
            this._buttonEquipment.Name = "_buttonEquipment";
            this._buttonEquipment.UseVisualStyleBackColor = true;
            this._buttonEquipment.Click += new System.EventHandler(this._buttonEquipment_Click);
            // 
            // MainMenuPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonEquipment);
            this.Controls.Add(this._buttonAutoPilot);
            this.Controls.Add(this._buttonOverView);
            this.Name = "MainMenuPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonOverView;
        private System.Windows.Forms.Button _buttonAutoPilot;
        private System.Windows.Forms.Button _buttonEquipment;
    }
}
