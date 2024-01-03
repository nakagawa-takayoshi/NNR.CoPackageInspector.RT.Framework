namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class OverViewMenuPanel
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
            this._buttonRecipeSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.Captions = "Main";
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.FontSize = 14;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(2);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(234, 40);
            this.titleBar1.TabIndex = 0;
            // 
            // _buttonRecipeSetup
            // 
            this._buttonRecipeSetup.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._buttonRecipeSetup.Location = new System.Drawing.Point(36, 76);
            this._buttonRecipeSetup.Name = "_buttonRecipeSetup";
            this._buttonRecipeSetup.Size = new System.Drawing.Size(168, 54);
            this._buttonRecipeSetup.TabIndex = 1;
            this._buttonRecipeSetup.Text = "レシピ設定";
            this._buttonRecipeSetup.UseVisualStyleBackColor = true;
            // 
            // OverViewMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonRecipeSetup);
            this.Controls.Add(this.titleBar1);
            this.Name = "OverViewMenuPanel";
            this.Size = new System.Drawing.Size(234, 595);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar1;
        private System.Windows.Forms.Button _buttonRecipeSetup;
    }
}
