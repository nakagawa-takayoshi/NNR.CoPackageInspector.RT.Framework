namespace NNR.CoPakageInspector.RT.MainApp.View
{
    partial class AutoPilotPanel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._titleBar = new NNR.CoPakageInspector.RT.MainApp.View.TitleBar();
            this.autoPilotOperationPanel1 = new NNR.CoPakageInspector.RT.MainApp.View.AutoPilotOperationPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.autoPilotOperationPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._titleBar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 760);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _titleBar
            // 
            this._titleBar.Captions = "AutoPilot";
            this._titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._titleBar.Location = new System.Drawing.Point(2, 2);
            this._titleBar.Margin = new System.Windows.Forms.Padding(2);
            this._titleBar.Name = "_titleBar";
            this._titleBar.Size = new System.Drawing.Size(1038, 45);
            this._titleBar.TabIndex = 0;
            // 
            // autoPilotOperationPanel1
            // 
            this.autoPilotOperationPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoPilotOperationPanel1.Location = new System.Drawing.Point(3, 52);
            this.autoPilotOperationPanel1.Name = "autoPilotOperationPanel1";
            this.autoPilotOperationPanel1.Size = new System.Drawing.Size(1036, 600);
            this.autoPilotOperationPanel1.TabIndex = 1;
            // 
            // AutoPilotPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AutoPilotPanel";
            this.Size = new System.Drawing.Size(1042, 760);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TitleBar _titleBar;
        private AutoPilotOperationPanel autoPilotOperationPanel1;
    }
}
