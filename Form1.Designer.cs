namespace Asso.Launcher
{
    partial class Form1
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lcRecentFiles = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.labelControlAppTitle = new DevExpress.XtraEditors.LabelControl();
            this.gcToolOptions = new DevExpress.XtraGrid.GridControl();
            this.tileViewAssoLaunchOptions = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRecentFiles = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRecentFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcToolOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewAssoLaunchOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecentFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lcRecentFiles);
            this.layoutControl1.Controls.Add(this.labelControlAppTitle);
            this.layoutControl1.Controls.Add(this.gcToolOptions);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2235, -106, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(702, 409);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "lcMain";
            // 
            // lcRecentFiles
            // 
            this.lcRecentFiles.Location = new System.Drawing.Point(12, 58);
            this.lcRecentFiles.Name = "lcRecentFiles";
            this.lcRecentFiles.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2111, 241, 650, 400);
            this.lcRecentFiles.Root = this.layoutControlGroup1;
            this.lcRecentFiles.Size = new System.Drawing.Size(337, 339);
            this.lcRecentFiles.TabIndex = 6;
            this.lcRecentFiles.Text = "layoutControl2";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(337, 339);
            // 
            // labelControlAppTitle
            // 
            this.labelControlAppTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlAppTitle.Appearance.Options.UseFont = true;
            this.labelControlAppTitle.Appearance.Options.UseTextOptions = true;
            this.labelControlAppTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControlAppTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlAppTitle.Location = new System.Drawing.Point(12, 12);
            this.labelControlAppTitle.Name = "labelControlAppTitle";
            this.labelControlAppTitle.Size = new System.Drawing.Size(678, 42);
            this.labelControlAppTitle.StyleController = this.layoutControl1;
            this.labelControlAppTitle.TabIndex = 5;
            this.labelControlAppTitle.Text = "Asso Suite";
            // 
            // gcToolOptions
            // 
            this.gcToolOptions.Location = new System.Drawing.Point(353, 58);
            this.gcToolOptions.MainView = this.tileViewAssoLaunchOptions;
            this.gcToolOptions.Name = "gcToolOptions";
            this.gcToolOptions.Size = new System.Drawing.Size(337, 339);
            this.gcToolOptions.TabIndex = 4;
            this.gcToolOptions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewAssoLaunchOptions});
            // 
            // tileViewAssoLaunchOptions
            // 
            this.tileViewAssoLaunchOptions.GridControl = this.gcToolOptions;
            this.tileViewAssoLaunchOptions.Name = "tileViewAssoLaunchOptions";
            this.tileViewAssoLaunchOptions.OptionsTiles.ColumnCount = 1;
            this.tileViewAssoLaunchOptions.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lciRecentFiles});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(702, 409);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcToolOptions;
            this.layoutControlItem1.Location = new System.Drawing.Point(341, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(341, 343);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.labelControlAppTitle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(682, 46);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciRecentFiles
            // 
            this.lciRecentFiles.Control = this.lcRecentFiles;
            this.lciRecentFiles.Location = new System.Drawing.Point(0, 46);
            this.lciRecentFiles.Name = "lciRecentFiles";
            this.lciRecentFiles.Size = new System.Drawing.Size(341, 343);
            this.lciRecentFiles.TextSize = new System.Drawing.Size(0, 0);
            this.lciRecentFiles.TextVisible = false;
            this.lciRecentFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lciRecentFiles_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Asso Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRecentFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcToolOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewAssoLaunchOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRecentFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcToolOptions;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewAssoLaunchOptions;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControlAppTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControl lcRecentFiles;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciRecentFiles;
    }
}

