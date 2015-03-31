namespace ProjectGarden
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Pond", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Crop", 7, 6);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Shrub", 7, 6);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tree", 7, 6);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Triangle", 4, 4);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Rectangle", 3, 3);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Square");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Trapezoid");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Parallelogram");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Polygon");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Circle", 5, 5);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Ellipse");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sector");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Random");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Land Type", 7, 6, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Field1", 0, 0);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Field2", 1, 1);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Field3", 2, 2);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Land Style", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCropStat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPictureBox
            // 
            this.gridPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridPictureBox.Location = new System.Drawing.Point(235, 68);
            this.gridPictureBox.Name = "gridPictureBox";
            this.gridPictureBox.Size = new System.Drawing.Size(833, 475);
            this.gridPictureBox.TabIndex = 0;
            this.gridPictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1268, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // treeView1
            // 
            this.treeView1.CausesValidation = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 68);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "Node6";
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node7";
            treeNode2.Text = "Node7";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Node8";
            treeNode4.Name = "Node9";
            treeNode4.Text = "Node9";
            treeNode5.Name = "Node10";
            treeNode5.Text = "Node10";
            treeNode6.Name = "PondView";
            treeNode6.Text = "Pond";
            treeNode7.ImageIndex = 7;
            treeNode7.Name = "cropView";
            treeNode7.SelectedImageIndex = 6;
            treeNode7.Text = "Crop";
            treeNode8.ImageIndex = 7;
            treeNode8.Name = "shrubView";
            treeNode8.SelectedImageIndex = 6;
            treeNode8.Text = "Shrub";
            treeNode9.ImageIndex = 7;
            treeNode9.Name = "treeView";
            treeNode9.SelectedImageIndex = 6;
            treeNode9.Text = "Tree";
            treeNode10.ImageIndex = 4;
            treeNode10.Name = "triangleNode";
            treeNode10.SelectedImageIndex = 4;
            treeNode10.Text = "Triangle";
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "rectangleNode";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "Rectangle";
            treeNode12.Name = "squareNode";
            treeNode12.Text = "Square";
            treeNode13.Name = "trapezoidNode";
            treeNode13.Text = "Trapezoid";
            treeNode14.Name = "parallelogramNode";
            treeNode14.Text = "Parallelogram";
            treeNode15.Name = "polygonNode";
            treeNode15.Text = "Polygon";
            treeNode16.ImageIndex = 5;
            treeNode16.Name = "circleNode";
            treeNode16.SelectedImageIndex = 5;
            treeNode16.Text = "Circle";
            treeNode17.Name = "ellipseNode";
            treeNode17.Text = "Ellipse";
            treeNode18.Name = "sectorNode";
            treeNode18.Text = "Sector";
            treeNode19.Name = "randomNode";
            treeNode19.Text = "Random";
            treeNode20.ImageIndex = 7;
            treeNode20.Name = "landTypeView";
            treeNode20.SelectedImageIndex = 6;
            treeNode20.Text = "Land Type";
            treeNode21.ImageIndex = 0;
            treeNode21.Name = "field1";
            treeNode21.SelectedImageIndex = 0;
            treeNode21.Text = "Field1";
            treeNode22.ImageIndex = 1;
            treeNode22.Name = "field2";
            treeNode22.SelectedImageIndex = 1;
            treeNode22.Text = "Field2";
            treeNode23.ImageIndex = 2;
            treeNode23.Name = "field3";
            treeNode23.SelectedImageIndex = 2;
            treeNode23.Text = "Field3";
            treeNode24.ImageKey = "(default)";
            treeNode24.Name = "landStyleView";
            treeNode24.SelectedImageIndex = 6;
            treeNode24.Text = "Land Style";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode20,
            treeNode24});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(216, 465);
            this.treeView1.TabIndex = 2;
            this.treeView1.TabStop = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "field1");
            this.imageList1.Images.SetKeyName(1, "field2");
            this.imageList1.Images.SetKeyName(2, "field3");
            this.imageList1.Images.SetKeyName(3, "Rectangle");
            this.imageList1.Images.SetKeyName(4, "triangle");
            this.imageList1.Images.SetKeyName(5, "circle");
            this.imageList1.Images.SetKeyName(6, "icon_collapse.png");
            this.imageList1.Images.SetKeyName(7, "icon_expand.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCropStat);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1087, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 475);
            this.panel1.TabIndex = 3;
            // 
            // btnCropStat
            // 
            this.btnCropStat.Location = new System.Drawing.Point(3, 83);
            this.btnCropStat.Name = "btnCropStat";
            this.btnCropStat.Size = new System.Drawing.Size(75, 23);
            this.btnCropStat.TabIndex = 3;
            this.btnCropStat.Text = "Crop Stat";
            this.btnCropStat.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "OutCome";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(84, 8);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 13);
            this.lblCost.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cost(BDT)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.gridPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        


        #endregion

        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCropStat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ImageList imageList1;
    }
}

