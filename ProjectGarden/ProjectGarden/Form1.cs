using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGarden.Models;

namespace ProjectGarden
{
    public partial class Form1 : Form
    {
        static int count = 0;
        private bool treeViewWasNewlyFocused = false;
        public Form1()
        {
            InitializeComponent();
            gridPictureBox.Paint+=gridPictureBox_Paint;
           // Settings.SelectedLandStyleImage
            Settings.SelectedLandStyleImage = imageList1.Images[0];

            DrawLand d = new DrawLand(gridPictureBox);

        }
        void gridPictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
           // throw new System.NotImplementedException();
            int pictureBoxHeight, pictureBoxWidth;
            pictureBoxHeight = gridPictureBox.Height;
            pictureBoxWidth = gridPictureBox.Width;


            Pen pen = new Pen(Color.FromArgb(30, 0, 0, 0));
            for(int i=0;i<=pictureBoxHeight;i=i+10)
            {
                e.Graphics.DrawLine(pen, 0, i,  pictureBoxWidth,i);
            }
            for (int i = 0; i <= pictureBoxWidth; i = i + 10)
            {
                e.Graphics.DrawLine(pen,  i,0,i, pictureBoxHeight);
            }

            Pen pen1 = new Pen(Color.FromArgb(80, 0, 0, 0));
            for (int i = 0; i <= pictureBoxHeight; i = i + 50)
            {
                e.Graphics.DrawLine(pen, 0, i, pictureBoxWidth, i);
            }
            for (int i = 0; i <= pictureBoxWidth; i = i + 50)
            {
                e.Graphics.DrawLine(pen, i, 0, i, pictureBoxHeight);
            }
        }

        void gridPictureBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
           
            //throw new System.NotImplementedException();
            //Console.WriteLine("click={0}", e.Clicks);
            //double x,y;
            //x = e.X / 10;
            //y = e.Y / 10;

            //if(e.X%10<=5)
            //{
            //    x = Math.Floor(x)*10;
            //}
            //else
            //{
            //    x = Math.Ceiling(x) * 10;
            //}

            //if(e.Y%10<=5)
            //{
            //    y = Math.Floor(y) * 10;
            //}
            //else
            //{
            //    y = Math.Ceiling(y) * 10;
            //}

            //    if (count == 0)
            //    {
            //        Console.WriteLine("mouse first click={0}", e.Location);
            //        Models.LandLayerModel.StartPoint.X =(int) x;
            //        Models.LandLayerModel.StartPoint.Y =(int) y;
            //        count++;
            //    }
            //    else
            //    {
            //        Models.LandLayerModel.SelectedPoint.Add(new Point { X = (int)x, Y = (int)y });

            //        for (int i = 0; i < Models.LandLayerModel.SelectedPoint.Count; i++)
            //        {
            //            Console.WriteLine("x={0},Y={1}", Models.LandLayerModel.SelectedPoint[i].X, Models.LandLayerModel.SelectedPoint[i].Y);
            //        }

            //    }
            


          //  PictureBox p = sender as PictureBox;
          //  p.Enabled = false;

        }

        //void treeView1_Click(object sender, TreeViewEventArgs e)
        //{
        //    Console.WriteLine(e.Node.Parent);

        //    if (e.Node.Parent == null)
        //    {
        //        if (e.Node.IsExpanded)
        //        {
        //            e.Node.Collapse();
        //            e.Node.ImageIndex = 7;
        //        }

        //        else
        //            e.Node.Expand();
        //    }
        //    else
        //    {
        //        if (e.Node.Parent.Text == "Land Type")
        //        {
        //            Settings.SelectedLandStyle = e.Node.Index;
        //        }

        //    }
        //}
        void treeView1_Click(object sender, System.EventArgs e)
        {
           TreeView tree = sender as TreeView;
           //Console.WriteLine(tree.SelectedNode.Text);
          //  TreeNode tree = sender as TreeNode;
            //if(tree.SelectedNode.Parent==null)
            //{
            //   tree.SelectedNode.Collapse();
            //}
            //else
            //{
            //    tree.SelectedNode.Expand();
            //}
            
            //throw new System.NotImplementedException();
        
        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.treeView1.Click += treeView1_Click;
           
          //  TreeView tree = sender as TreeView;
            //Console.WriteLine(e.Node.Parent);

            if (e.Node.Parent == null)
            {
                if (e.Node.IsExpanded)
                {
                    e.Node.Collapse();
                   // e.Node.ImageIndex = 7;
                }

                else
                    e.Node.Expand();
            }
            else
            {
                if (e.Node.Parent.Text == "Land Type")
                {
                    Settings.SelectedLandType = e.Node.Index;
                    LandLayerModel.IsCreateLandSelected = true;
                    
                    Console.WriteLine("index={0}", Settings.SelectedLandType);
                }
                else if(e.Node.Parent.Text == "Land Style")
                {
                    Settings.SelectedLandStyleImage = imageList1.Images[e.Node.ImageIndex];
                }

            }
        }

     

        private void TreeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (treeViewWasNewlyFocused)
            {
                e.Cancel = true;
                treeViewWasNewlyFocused = false;
            }
        }

        private void TreeView1_GotFocus(object sender, EventArgs e)
        {
            treeViewWasNewlyFocused = true;
        }

       

    }
}
