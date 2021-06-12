using Asso.Launcher.Classes;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asso.Launcher
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public Form1()
        {
            InitializeComponent();

            labelControlAppTitle.Text += " v." + AppUtilities.GetCurrentAppVersion();

            if(true)
            {
                lciRecentFiles.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            FillRecentOpenedFileGrid();
        }

        private void FillRecentOpenedFileGrid()
        {
            gcToolOptions.DataSource = Asso.Launcher.Data.AssoToolForLaunch.LoadData();

            tileViewAssoLaunchOptions.OptionsTiles.Orientation = Orientation.Vertical;

            TableColumnDefinition tableColumnDefinition1 = new TableColumnDefinition();
            TableColumnDefinition tableColumnDefinition2 = new TableColumnDefinition();

            TableRowDefinition tableRowDefinition1 = new TableRowDefinition();
            TableRowDefinition tableRowDefinition2 = new TableRowDefinition();

            TileViewItemElement tileViewItemElement1 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement2 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement3 = new TileViewItemElement();
            //TileViewItemElement tileViewItemElement4 = new TileViewItemElement();
            //TileViewItemElement tileViewItemElement5 = new TileViewItemElement();


            tableColumnDefinition1.Length.Value = 15D;
            tableColumnDefinition2.Length.Value = 81D;

            tileViewAssoLaunchOptions.TileColumns.Add(tableColumnDefinition1);
            tileViewAssoLaunchOptions.TileColumns.Add(tableColumnDefinition2);
            
            tileViewAssoLaunchOptions.TileRows.Add(tableRowDefinition1);
            tileViewAssoLaunchOptions.TileRows.Add(tableRowDefinition2);

            //tileViewItemElement1.Column = tileView1.Columns["ID"];
            tileViewItemElement1.Image = SystemIcons.Question.ToBitmap();//tileView1.Columns["Picture"];
            tileViewItemElement1.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            //tileViewItemElement1.Text = "colID";
            tileViewItemElement1.TextAlignment = TileItemContentAlignment.MiddleCenter;
            
            tileViewItemElement1.ColumnIndex = 0;
            tileViewItemElement1.RowIndex = 0;

            tileViewItemElement2.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Hovered.Options.UseFont = true;
            tileViewItemElement2.Appearance.Hovered.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileViewItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileViewItemElement2.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Pressed.Options.UseFont = true;
            tileViewItemElement2.Appearance.Pressed.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tileViewItemElement2.Appearance.Selected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Selected.Options.UseFont = true;
            tileViewItemElement2.Appearance.Selected.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Selected.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            tileViewItemElement2.Appearance.Selected.Options.UseFont = true;
            tileViewItemElement2.Appearance.Selected.Options.UseTextOptions = true;
            tileViewItemElement2.Column = tileViewAssoLaunchOptions.Columns["Name"];
            tileViewItemElement2.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.ColumnIndex = 1;
            tileViewItemElement2.RowIndex = 0;

            tileViewItemElement2.Text = "";
            tileViewItemElement2.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileViewItemElement3.Column = tileViewAssoLaunchOptions.Columns["Description"];
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "";
            tileViewItemElement3.TextAlignment = TileItemContentAlignment.MiddleCenter;

            //tileViewItemElement4.Column = tileView1.Columns["Name"];
            //tileViewItemElement4.ColumnIndex = 3;
            //tileViewItemElement4.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            //tileViewItemElement4.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            //tileViewItemElement4.Text = "colTypeOfObject";
            //tileViewItemElement4.TextAlignment = TileItemContentAlignment.MiddleCenter;

            //tileViewItemElement5.Column = tileView1.Columns["Name"];
            //tileViewItemElement5.ColumnIndex = 1;
            //tileViewItemElement5.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            //tileViewItemElement5.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            //tileViewItemElement5.RowIndex = 1;
            //tileViewItemElement5.Text = "colRecordDate";
            //tileViewItemElement5.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileViewAssoLaunchOptions.TileTemplate.Add(tileViewItemElement1);
            tileViewAssoLaunchOptions.TileTemplate.Add(tileViewItemElement2);
            tileViewAssoLaunchOptions.TileTemplate.Add(tileViewItemElement3);
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void lciRecentFiles_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button != MouseButtons.Left)
            //    return;
            
            //CustomBarControl barControl = (CustomBarControl)sender;
            //var link = lciRecentFiles.GetLinkByPoint(Control.MousePosition, true);
            
            //if (link != null)
            //    return;

            //ReleaseCapture();
            //SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
