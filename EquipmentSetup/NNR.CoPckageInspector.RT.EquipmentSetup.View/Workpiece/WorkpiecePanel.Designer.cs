namespace NNR.CoPakageInspector.RT.MainApp.View.UserPanels
{
    partial class WorkpiecePanel
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
            this._labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this._numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelName
            // 
            this._labelName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelName.Location = new System.Drawing.Point(3, 12);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(81, 26);
            this._labelName.TabIndex = 0;
            this._labelName.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // _numericUpDownWidth
            // 
            this._numericUpDownWidth.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._numericUpDownWidth.Location = new System.Drawing.Point(105, 55);
            this._numericUpDownWidth.Name = "_numericUpDownWidth";
            this._numericUpDownWidth.Size = new System.Drawing.Size(120, 28);
            this._numericUpDownWidth.TabIndex = 2;
            this._numericUpDownWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _numericUpDownHeight
            // 
            this._numericUpDownHeight.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._numericUpDownHeight.Location = new System.Drawing.Point(271, 55);
            this._numericUpDownHeight.Name = "_numericUpDownHeight";
            this._numericUpDownHeight.Size = new System.Drawing.Size(120, 28);
            this._numericUpDownHeight.TabIndex = 3;
            this._numericUpDownHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(111, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 28);
            this.textBox1.TabIndex = 4;
            // 
            // WorkpiecePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._numericUpDownHeight);
            this.Controls.Add(this._numericUpDownWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._labelName);
            this.Name = "WorkpiecePanel";
            this.Size = new System.Drawing.Size(1042, 130);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown _numericUpDownHeight;
        private System.Windows.Forms.TextBox textBox1;
    }
}
