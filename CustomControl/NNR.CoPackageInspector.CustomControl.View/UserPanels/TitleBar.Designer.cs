namespace NNR.CoPackageInspector.CustomControl.View
{
    partial class TitleBar
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
            this._returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _returnButton
            // 
            this._returnButton.BackColor = System.Drawing.SystemColors.Control;
            this._returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._returnButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._returnButton.Image = global::NNR.CoPackageInspector.CustomControl.View.Properties.Resources.return_mid;
            this._returnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._returnButton.Location = new System.Drawing.Point(927, 0);
            this._returnButton.Name = "_returnButton";
            this._returnButton.Size = new System.Drawing.Size(115, 79);
            this._returnButton.TabIndex = 0;
            this._returnButton.Text = "戻る";
            this._returnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._returnButton.UseVisualStyleBackColor = false;
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._returnButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(1042, 79);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _returnButton;
    }
}
