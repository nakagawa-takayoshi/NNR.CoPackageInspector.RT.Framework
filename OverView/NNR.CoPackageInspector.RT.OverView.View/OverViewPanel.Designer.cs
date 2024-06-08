using NNR.CoPackageInspector.CustomControl.View;
using System.Collections.Generic;

namespace NNR.CoPackageInspector.RT.OverView.View
{
    partial class OverViewPanel
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
            this._tableLayoutOverViewTop = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar1 = new NNR.CoPackageInspector.CustomControl.View.TitleBar();
            this.overViewLoaderPanel1 = new NNR.CoPackageInspector.RT.OverView.View.UserControls.OverViewLoaderPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this._tableLayoutOverViewTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._tableLayoutOverViewTop, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.titleBar1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1042, 760);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _tableLayoutOverViewTop
            // 
            this._tableLayoutOverViewTop.ColumnCount = 2;
            this._tableLayoutOverViewTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86196F));
            this._tableLayoutOverViewTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.13804F));
            this._tableLayoutOverViewTop.Controls.Add(this.overViewLoaderPanel1, 0, 0);
            this._tableLayoutOverViewTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutOverViewTop.Location = new System.Drawing.Point(3, 63);
            this._tableLayoutOverViewTop.Name = "_tableLayoutOverViewTop";
            this._tableLayoutOverViewTop.RowCount = 2;
            this._tableLayoutOverViewTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.02399F));
            this._tableLayoutOverViewTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.97601F));
            this._tableLayoutOverViewTop.Size = new System.Drawing.Size(1036, 694);
            this._tableLayoutOverViewTop.TabIndex = 1;
            // 
            // titleBar1
            // 
            this.titleBar1.Captions = "OviewView";
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar1.FontSize = 24;
            this.titleBar1.IsReturnButton = false;
            this.titleBar1.Location = new System.Drawing.Point(1, 1);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(1);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(1040, 58);
            this.titleBar1.TabIndex = 2;
            // 
            // overViewLoaderPanel1
            // 
            this.overViewLoaderPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overViewLoaderPanel1.Location = new System.Drawing.Point(3, 3);
            this.overViewLoaderPanel1.Name = "overViewLoaderPanel1";
            this.overViewLoaderPanel1.RowCount = 2;
            this.overViewLoaderPanel1.Size = new System.Drawing.Size(199, 355);
            this.overViewLoaderPanel1.TabIndex = 0;
            // 
            // OverViewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OverViewPanel";
            this.Size = new System.Drawing.Size(1042, 760);
            this.tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutOverViewTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutOverViewTop;
        private TitleBar titleBar1;
        private UserControls.OverViewLoaderPanel overViewLoaderPanel1;
    }
}
