﻿
namespace NNR.CoPakageInspector.RT.MainApp.View.Dialogs
{
    partial class ApplicationExitAskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._exitComboxBox = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _exitComboxBox
            // 
            this._exitComboxBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._exitComboxBox.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this._exitComboxBox.FormattingEnabled = true;
            this._exitComboxBox.Location = new System.Drawing.Point(98, 78);
            this._exitComboxBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._exitComboxBox.Name = "_exitComboxBox";
            this._exitComboxBox.Size = new System.Drawing.Size(411, 37);
            this._exitComboxBox.TabIndex = 0;
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(140, 162);
            this._okButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(148, 54);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this._okButton_Click);
            // 
            // _cancelButton
            // 
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(345, 162);
            this._cancelButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(138, 54);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            this._cancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // ApplicationExitAskForm
            // 
            this.AcceptButton = this._okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(633, 244);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._exitComboxBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationExitAskForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "装置の終了";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _exitComboxBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
    }
}