namespace NNR.CoPackageInspector.CustomControl.View.UserPanels
{
    partial class LoaderPanel
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
            this._groupBoxLoader = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // _groupBoxLoader
            // 
            this._groupBoxLoader.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._groupBoxLoader.Location = new System.Drawing.Point(27, 22);
            this._groupBoxLoader.Name = "_groupBoxLoader";
            this._groupBoxLoader.Size = new System.Drawing.Size(128, 82);
            this._groupBoxLoader.TabIndex = 0;
            this._groupBoxLoader.TabStop = false;
            this._groupBoxLoader.Text = "Loader1";
            // 
            // LoaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._groupBoxLoader);
            this.Name = "LoaderPanel";
            this.Size = new System.Drawing.Size(177, 134);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBoxLoader;
    }
}
