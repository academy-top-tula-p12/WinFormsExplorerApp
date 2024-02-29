namespace WinFormsExplorerApp
{
    partial class ExplorerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExplorerForm));
            splitContainer1 = new SplitContainer();
            treeDirs = new TreeView();
            imgsSmall = new ImageList(components);
            btnDetails = new Button();
            btnList = new Button();
            btnSmall = new Button();
            btnLarge = new Button();
            listDir = new ListView();
            fileName = new ColumnHeader();
            imgsLarge = new ImageList(components);
            fileSize = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeDirs);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnDetails);
            splitContainer1.Panel2.Controls.Add(btnList);
            splitContainer1.Panel2.Controls.Add(btnSmall);
            splitContainer1.Panel2.Controls.Add(btnLarge);
            splitContainer1.Panel2.Controls.Add(listDir);
            splitContainer1.Size = new Size(799, 522);
            splitContainer1.SplitterDistance = 213;
            splitContainer1.TabIndex = 0;
            // 
            // treeDirs
            // 
            treeDirs.Dock = DockStyle.Fill;
            treeDirs.ImageIndex = 0;
            treeDirs.ImageList = imgsSmall;
            treeDirs.Location = new Point(0, 0);
            treeDirs.Name = "treeDirs";
            treeDirs.SelectedImageIndex = 0;
            treeDirs.Size = new Size(213, 522);
            treeDirs.TabIndex = 0;
            treeDirs.BeforeExpand += treeDirs_BeforeExpand;
            treeDirs.BeforeSelect += treeDirs_BeforeSelect;
            // 
            // imgsSmall
            // 
            imgsSmall.ColorDepth = ColorDepth.Depth32Bit;
            imgsSmall.ImageStream = (ImageListStreamer)resources.GetObject("imgsSmall.ImageStream");
            imgsSmall.TransparentColor = Color.Transparent;
            imgsSmall.Images.SetKeyName(0, "folder.jpg");
            imgsSmall.Images.SetKeyName(1, "WORD.png");
            imgsSmall.Images.SetKeyName(2, "EXCEL.png");
            imgsSmall.Images.SetKeyName(3, "PDF.png");
            imgsSmall.Images.SetKeyName(4, "JPG.png");
            imgsSmall.Images.SetKeyName(5, "PNG.png");
            imgsSmall.Images.SetKeyName(6, "TEXT.png");
            imgsSmall.Images.SetKeyName(7, "OTHER.png");
            // 
            // btnDetails
            // 
            btnDetails.Location = new Point(308, 469);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(86, 41);
            btnDetails.TabIndex = 1;
            btnDetails.Text = "Details";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += btnDetails_Click;
            // 
            // btnList
            // 
            btnList.Location = new Point(205, 469);
            btnList.Name = "btnList";
            btnList.Size = new Size(86, 41);
            btnList.TabIndex = 1;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnSmall
            // 
            btnSmall.Location = new Point(104, 469);
            btnSmall.Name = "btnSmall";
            btnSmall.Size = new Size(86, 41);
            btnSmall.TabIndex = 1;
            btnSmall.Text = "Small";
            btnSmall.UseVisualStyleBackColor = true;
            btnSmall.Click += btnSmall_Click;
            // 
            // btnLarge
            // 
            btnLarge.Location = new Point(3, 469);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(86, 41);
            btnLarge.TabIndex = 1;
            btnLarge.Text = "Large";
            btnLarge.UseVisualStyleBackColor = true;
            btnLarge.Click += btnLarge_Click;
            // 
            // listDir
            // 
            listDir.Columns.AddRange(new ColumnHeader[] { fileName, fileSize });
            listDir.LargeImageList = imgsLarge;
            listDir.Location = new Point(3, 0);
            listDir.Name = "listDir";
            listDir.Size = new Size(579, 464);
            listDir.SmallImageList = imgsSmall;
            listDir.TabIndex = 0;
            listDir.UseCompatibleStateImageBehavior = false;
            listDir.View = View.List;
            // 
            // fileName
            // 
            fileName.Text = "Name";
            fileName.Width = 160;
            // 
            // imgsLarge
            // 
            imgsLarge.ColorDepth = ColorDepth.Depth32Bit;
            imgsLarge.ImageStream = (ImageListStreamer)resources.GetObject("imgsLarge.ImageStream");
            imgsLarge.TransparentColor = Color.Transparent;
            imgsLarge.Images.SetKeyName(0, "folder.jpg");
            imgsLarge.Images.SetKeyName(1, "WORD.png");
            imgsLarge.Images.SetKeyName(2, "EXCEL.png");
            imgsLarge.Images.SetKeyName(3, "PDF.png");
            imgsLarge.Images.SetKeyName(4, "JPG.png");
            imgsLarge.Images.SetKeyName(5, "PNG.png");
            imgsLarge.Images.SetKeyName(6, "TEXT.png");
            imgsLarge.Images.SetKeyName(7, "OTHER.png");
            // 
            // fileSize
            // 
            fileSize.Text = "Size";
            // 
            // ExplorerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 522);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ExplorerForm";
            Text = "Проводник";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView treeDirs;
        private ListView listDir;
        private ImageList imgsLarge;
        private ImageList imgsSmall;
        private Button btnDetails;
        private Button btnList;
        private Button btnSmall;
        private Button btnLarge;
        private ColumnHeader fileName;
        private ColumnHeader fileSize;
    }
}
