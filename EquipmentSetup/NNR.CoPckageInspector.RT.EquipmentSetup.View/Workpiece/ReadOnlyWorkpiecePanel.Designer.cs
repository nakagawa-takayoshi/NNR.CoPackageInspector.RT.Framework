namespace NNR.CoPckageInspector.RT.EquipmentSetup.View.Workpiece
{
    partial class ReadOnlyWorkpiecePanel
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
            this.label1 = new System.Windows.Forms.Label();
            this._labelName = new System.Windows.Forms.Label();
            this._textWidth = new System.Windows.Forms.Label();
            this._textHeight = new System.Windows.Forms.Label();
            this._textName = new System.Windows.Forms.Label();
            this._labelGuid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(19, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Size";
            // 
            // _labelName
            // 
            this._labelName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelName.Location = new System.Drawing.Point(19, 17);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(81, 26);
            this._labelName.TabIndex = 5;
            this._labelName.Text = "Name";
            // 
            // _textWidth
            // 
            this._textWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textWidth.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._textWidth.Location = new System.Drawing.Point(123, 62);
            this._textWidth.Name = "_textWidth";
            this._textWidth.Size = new System.Drawing.Size(120, 28);
            this._textWidth.TabIndex = 10;
            this._textWidth.Text = "0";
            this._textWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _textHeight
            // 
            this._textHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textHeight.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._textHeight.Location = new System.Drawing.Point(286, 62);
            this._textHeight.Name = "_textHeight";
            this._textHeight.Size = new System.Drawing.Size(120, 28);
            this._textHeight.TabIndex = 11;
            this._textHeight.Text = "0";
            this._textHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _textName
            // 
            this._textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._textName.Location = new System.Drawing.Point(123, 13);
            this._textName.Name = "_textName";
            this._textName.Size = new System.Drawing.Size(279, 28);
            this._textName.TabIndex = 12;
            this._textName.Text = "0";
            this._textName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _labelGuid
            // 
            this._labelGuid.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._labelGuid.Location = new System.Drawing.Point(488, 17);
            this._labelGuid.Name = "_labelGuid";
            this._labelGuid.Size = new System.Drawing.Size(81, 26);
            this._labelGuid.TabIndex = 13;
            this._labelGuid.Text = "GUID";
            // 
            // ReadOnlyWorkpiecePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._labelGuid);
            this.Controls.Add(this._textName);
            this.Controls.Add(this._textHeight);
            this.Controls.Add(this._textWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._labelName);
            this.Name = "ReadOnlyWorkpiecePanel";
            this.Size = new System.Drawing.Size(1042, 130);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.Label _textWidth;
        private System.Windows.Forms.Label _textHeight;
        private System.Windows.Forms.Label _textName;
        private System.Windows.Forms.Label _labelGuid;
    }
}
