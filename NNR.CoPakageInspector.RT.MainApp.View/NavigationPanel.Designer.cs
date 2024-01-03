namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class NavigationPanel
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
            this._buttonOverView = new System.Windows.Forms.Button();
            this._buttonEquipmentSetup = new System.Windows.Forms.Button();
            this._buttonAutoPilot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonOverView
            // 
            this._buttonOverView.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonOverView.Location = new System.Drawing.Point(0, 3);
            this._buttonOverView.Name = "_buttonOverView";
            this._buttonOverView.Size = new System.Drawing.Size(169, 60);
            this._buttonOverView.TabIndex = 0;
            this._buttonOverView.Text = "OverView";
            this._buttonOverView.UseVisualStyleBackColor = true;
            this._buttonOverView.Click += new System.EventHandler(this._buttonOverView_Click);
            // 
            // _buttonEquipmentSetup
            // 
            this._buttonEquipmentSetup.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonEquipmentSetup.Location = new System.Drawing.Point(175, 3);
            this._buttonEquipmentSetup.Name = "_buttonEquipmentSetup";
            this._buttonEquipmentSetup.Size = new System.Drawing.Size(169, 60);
            this._buttonEquipmentSetup.TabIndex = 1;
            this._buttonEquipmentSetup.Text = "Equipment Setup";
            this._buttonEquipmentSetup.UseVisualStyleBackColor = true;
            this._buttonEquipmentSetup.Click += new System.EventHandler(this._buttonEquipmentSetup_Click);
            // 
            // _buttonAutoPilot
            // 
            this._buttonAutoPilot.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonAutoPilot.Location = new System.Drawing.Point(350, 3);
            this._buttonAutoPilot.Name = "_buttonAutoPilot";
            this._buttonAutoPilot.Size = new System.Drawing.Size(169, 60);
            this._buttonAutoPilot.TabIndex = 2;
            this._buttonAutoPilot.Text = "AutoPilot";
            this._buttonAutoPilot.UseVisualStyleBackColor = true;
            this._buttonAutoPilot.Click += new System.EventHandler(this._buttonAutoPilot_Click);
            // 
            // NavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonAutoPilot);
            this.Controls.Add(this._buttonEquipmentSetup);
            this.Controls.Add(this._buttonOverView);
            this.Name = "NavigationPanel";
            this.Size = new System.Drawing.Size(1045, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonOverView;
        private System.Windows.Forms.Button _buttonEquipmentSetup;
        private System.Windows.Forms.Button _buttonAutoPilot;
    }
}
