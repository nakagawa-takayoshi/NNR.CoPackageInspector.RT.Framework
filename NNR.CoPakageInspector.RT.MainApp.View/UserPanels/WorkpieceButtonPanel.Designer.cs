namespace NNR.CoPakageInspector.RT.MainApp.View.UserPanels
{
    partial class WorkpieceButtonPanel
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
            this._buttonInner = new System.Windows.Forms.Button();
            this._workpiecePanel = new NNR.CoPakageInspector.RT.MainApp.View.UserPanels.ReadOnlyWorkpiecePanel();
            this._buttonInner.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonInner
            // 
            this._buttonInner.Controls.Add(this._workpiecePanel);
            this._buttonInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this._buttonInner.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this._buttonInner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this._buttonInner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonInner.Location = new System.Drawing.Point(0, 0);
            this._buttonInner.Name = "_buttonInner";
            this._buttonInner.Size = new System.Drawing.Size(1042, 150);
            this._buttonInner.TabIndex = 0;
            this._buttonInner.UseVisualStyleBackColor = true;
            this._buttonInner.Click += new System.EventHandler(this._buttonInner_Click);
            // 
            // _workpiecePanel
            // 
            this._workpiecePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._workpiecePanel.Location = new System.Drawing.Point(5, 5);
            this._workpiecePanel.Margin = new System.Windows.Forms.Padding(5);
            this._workpiecePanel.Name = "_workpiecePanel";
            this._workpiecePanel.Size = new System.Drawing.Size(1006, 123);
            this._workpiecePanel.TabIndex = 0;
            // 
            // WorkpieceButtonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._buttonInner);
            this.Name = "WorkpieceButtonPanel";
            this.Size = new System.Drawing.Size(1042, 150);
            this._buttonInner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonInner;
        private ReadOnlyWorkpiecePanel _workpiecePanel;
    }
}
