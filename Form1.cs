using Asso.Launcher.Classes;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TableLayout;
using DevExpress.XtraGrid.Views.Tile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asso.Launcher
{
    public partial class Form1 : Form
    {
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

            tileView1.OptionsTiles.Orientation = Orientation.Vertical;

            TableColumnDefinition tableColumnDefinition1 = new TableColumnDefinition();
            TableColumnDefinition tableColumnDefinition2 = new TableColumnDefinition();
            TableColumnDefinition tableColumnDefinition3 = new TableColumnDefinition();
            TableColumnDefinition tableColumnDefinition4 = new TableColumnDefinition();

            TableRowDefinition tableRowDefinition1 = new TableRowDefinition();
            TableRowDefinition tableRowDefinition2 = new TableRowDefinition();
            TableRowDefinition tableRowDefinition3 = new TableRowDefinition();

            TileViewItemElement tileViewItemElement1 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement2 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement3 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement4 = new TileViewItemElement();
            TileViewItemElement tileViewItemElement5 = new TileViewItemElement();


            tableColumnDefinition1.Length.Value = 15D;
            tableColumnDefinition2.Length.Value = 81D;
            tableColumnDefinition3.Length.Value = 75D;
            tableColumnDefinition4.Length.Value = 10D;

            tileView1.TileColumns.Add(tableColumnDefinition1);
            tileView1.TileColumns.Add(tableColumnDefinition2);
            tileView1.TileColumns.Add(tableColumnDefinition3);
            tileView1.TileColumns.Add(tableColumnDefinition4);
            tileView1.TileRows.Add(tableRowDefinition1);
            tileView1.TileRows.Add(tableRowDefinition2);
            tileView1.TileRows.Add(tableRowDefinition3);

            //tileViewItemElement1.Column = tileView1.Columns["ID"];
            tileViewItemElement1.Image = SystemIcons.Question.ToBitmap();//tileView1.Columns["Picture"];
            tileViewItemElement1.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            //tileViewItemElement1.Text = "colID";
            tileViewItemElement1.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileViewItemElement2.Column = tileView1.Columns["Name"];
            tileViewItemElement2.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 2;

            tileViewItemElement2.Text = "colParentID";
            tileViewItemElement2.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileViewItemElement3.Column = tileView1.Columns["Name"];
            tileViewItemElement3.ColumnIndex = 2;

            tileViewItemElement3.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.RowIndex = 2;
            tileViewItemElement3.Text = "colName";
            tileViewItemElement3.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileViewItemElement4.Column = tileView1.Columns["Name"];
            tileViewItemElement4.ColumnIndex = 3;
            tileViewItemElement4.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            tileViewItemElement4.Text = "colTypeOfObject";
            tileViewItemElement4.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileViewItemElement5.Column = tileView1.Columns["Name"];
            tileViewItemElement5.ColumnIndex = 1;
            tileViewItemElement5.ImageOptions.ImageAlignment = TileItemContentAlignment.MiddleCenter;
            tileViewItemElement5.ImageOptions.ImageScaleMode = TileItemImageScaleMode.Squeeze;
            tileViewItemElement5.RowIndex = 1;
            tileViewItemElement5.Text = "colRecordDate";
            tileViewItemElement5.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileView1.TileTemplate.Add(tileViewItemElement1);
            tileView1.TileTemplate.Add(tileViewItemElement2);
            tileView1.TileTemplate.Add(tileViewItemElement3);
            tileView1.TileTemplate.Add(tileViewItemElement4);
            tileView1.TileTemplate.Add(tileViewItemElement5);
        }

      
    }
}
