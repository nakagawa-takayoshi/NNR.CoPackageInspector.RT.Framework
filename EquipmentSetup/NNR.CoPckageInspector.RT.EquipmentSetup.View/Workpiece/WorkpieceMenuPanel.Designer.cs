namespace NNR.CoPckageInspector.RT.EquipmentSetup.View.Workpiece
{
    partial class WorkpieceMenuPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this._titleBar = new NNR.CoPakageInspector.RT.MainApp.View.TitleBar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(45, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "追加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _titleBar
            // 
            this._titleBar.Captions = "Menu,Workpiece";
            this._titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this._titleBar.FontSize = 14;
            this._titleBar.Location = new System.Drawing.Point(0, 0);
            this._titleBar.Margin = new System.Windows.Forms.Padding(2);
            this._titleBar.Name = "_titleBar";
            this._titleBar.Size = new System.Drawing.Size(240, 40);
            this._titleBar.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Image = global::NNR.CoPckageInspector.RT.EquipmentSetup.View.Properties.Resources.kkrn_icon_modoru_mini;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageKey = "(なし)";
            this.button2.Location = new System.Drawing.Point(45, 560);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "　戻る";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // WorkpieceMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this._titleBar);
            this.Controls.Add(this.button1);
            this.Name = "WorkpieceMenuPanel";
            this.Size = new System.Drawing.Size(240, 641);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CoPakageInspector.RT.MainApp.View.TitleBar _titleBar;
        private System.Windows.Forms.Button button2;
    }
}
