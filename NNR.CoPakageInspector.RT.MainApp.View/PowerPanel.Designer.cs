﻿
namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class PowerPanel
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
            this._buttonPowerOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonPowerOff
            // 
            this._buttonPowerOff.Location = new System.Drawing.Point(188, 4);
            this._buttonPowerOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._buttonPowerOff.Name = "_buttonPowerOff";
            this._buttonPowerOff.Size = new System.Drawing.Size(44, 36);
            this._buttonPowerOff.TabIndex = 0;
            this._buttonPowerOff.Text = "終了";
            this._buttonPowerOff.UseVisualStyleBackColor = true;
            this._buttonPowerOff.Click += new System.EventHandler(this._buttonPowerOff_Click);
            // 
            // PowerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonPowerOff);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PowerPanel";
            this.Size = new System.Drawing.Size(240, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonPowerOff;
    }
}