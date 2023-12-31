namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class AutoPilotMenuPanel
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
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._titleBar = new NNR.CoPakageInspector.RT.MainApp.View.TitleBar();
            this.autoPilotMenuCorePanel1 = new NNR.CoPakageInspector.RT.MainApp.View.AutoPilotMenuCorePanel();
            this._tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 1;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanel.Controls.Add(this._titleBar, 0, 0);
            this._tableLayoutPanel.Controls.Add(this.autoPilotMenuCorePanel1, 0, 1);
            this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 2;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(240, 641);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _titleBar
            // 
            this._titleBar.Captions = "Main, AutoPilot";
            this._titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleBar.FontSize = 14;
            this._titleBar.Location = new System.Drawing.Point(2, 2);
            this._titleBar.Margin = new System.Windows.Forms.Padding(2);
            this._titleBar.Name = "_titleBar";
            this._titleBar.Size = new System.Drawing.Size(236, 36);
            this._titleBar.TabIndex = 0;
            // 
            // autoPilotMenuCorePanel1
            // 
            this.autoPilotMenuCorePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoPilotMenuCorePanel1.Location = new System.Drawing.Point(3, 43);
            this.autoPilotMenuCorePanel1.Name = "autoPilotMenuCorePanel1";
            this.autoPilotMenuCorePanel1.Size = new System.Drawing.Size(234, 595);
            this.autoPilotMenuCorePanel1.TabIndex = 1;
            // 
            // AutoPilotMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tableLayoutPanel);
            this.Name = "AutoPilotMenuPanel";
            this.Size = new System.Drawing.Size(240, 641);
            this._tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private TitleBar _titleBar;
        private AutoPilotMenuCorePanel autoPilotMenuCorePanel1;
    }
}
