
namespace NNR.CoPackageInspectorApp
{
    partial class MainAppForm
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this._mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this._navigationSplitContainer = new System.Windows.Forms.SplitContainer();
            this.navigationPanel1 = new NNR.CoPakageInspector.RT.MainApp.View.NavigationPanel();
            this._subPanel = new NNR.CoPakageInspector.RT.MainApp.View.SubPanel();
            ((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).BeginInit();
            this._mainSplitContainer.Panel1.SuspendLayout();
            this._mainSplitContainer.Panel2.SuspendLayout();
            this._mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._navigationSplitContainer)).BeginInit();
            this._navigationSplitContainer.Panel2.SuspendLayout();
            this._navigationSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainSplitContainer
            // 
            resources.ApplyResources(this._mainSplitContainer, "_mainSplitContainer");
            this._mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this._mainSplitContainer.Name = "_mainSplitContainer";
            // 
            // _mainSplitContainer.Panel1
            // 
            this._mainSplitContainer.Panel1.Controls.Add(this._navigationSplitContainer);
            // 
            // _mainSplitContainer.Panel2
            // 
            this._mainSplitContainer.Panel2.Controls.Add(this._subPanel);
            // 
            // _navigationSplitContainer
            // 
            resources.ApplyResources(this._navigationSplitContainer, "_navigationSplitContainer");
            this._navigationSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this._navigationSplitContainer.Name = "_navigationSplitContainer";
            // 
            // _navigationSplitContainer.Panel2
            // 
            this._navigationSplitContainer.Panel2.Controls.Add(this.navigationPanel1);
            // 
            // navigationPanel1
            // 
            resources.ApplyResources(this.navigationPanel1, "navigationPanel1");
            this.navigationPanel1.Name = "navigationPanel1";
            // 
            // _subPanel
            // 
            this._subPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this._subPanel, "_subPanel");
            this._subPanel.Name = "_subPanel";
            // 
            // MainAppForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._mainSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainAppForm";
            this._mainSplitContainer.Panel1.ResumeLayout(false);
            this._mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mainSplitContainer)).EndInit();
            this._mainSplitContainer.ResumeLayout(false);
            this._navigationSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._navigationSplitContainer)).EndInit();
            this._navigationSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _mainSplitContainer;
        private CoPakageInspector.RT.MainApp.View.SubPanel _subPanel;
        private System.Windows.Forms.SplitContainer _navigationSplitContainer;
        private CoPakageInspector.RT.MainApp.View.NavigationPanel navigationPanel1;
    }
}

