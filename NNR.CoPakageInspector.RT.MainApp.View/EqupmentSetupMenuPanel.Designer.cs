namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class EqupmentSetupMenuPanel
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
            this.titleBar1 = new NNR.CoPakageInspector.RT.MainApp.View.TitleBar();
            this._buttonWorkpieceSetting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.Captions = "Menu";
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.FontSize = 14;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(240, 30);
            this.titleBar1.TabIndex = 0;
            // 
            // _buttonWorkpieceSetting
            // 
            this._buttonWorkpieceSetting.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonWorkpieceSetting.Location = new System.Drawing.Point(38, 57);
            this._buttonWorkpieceSetting.Name = "_buttonWorkpieceSetting";
            this._buttonWorkpieceSetting.Size = new System.Drawing.Size(166, 54);
            this._buttonWorkpieceSetting.TabIndex = 1;
            this._buttonWorkpieceSetting.Text = "ワーク設定";
            this._buttonWorkpieceSetting.UseVisualStyleBackColor = true;
            this._buttonWorkpieceSetting.Click += new System.EventHandler(this._buttonWorkpieceSetting_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(38, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "マニュアル操作";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EqupmentSetupMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this._buttonWorkpieceSetting);
            this.Controls.Add(this.titleBar1);
            this.Name = "EqupmentSetupMenuPanel";
            this.Size = new System.Drawing.Size(240, 641);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar1;
        private System.Windows.Forms.Button _buttonWorkpieceSetting;
        private System.Windows.Forms.Button button2;
    }
}
