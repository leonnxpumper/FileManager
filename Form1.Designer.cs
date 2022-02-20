namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Name_FileName = new System.Windows.Forms.Label();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_name_FileType = new System.Windows.Forms.Label();
            this.lbl_FileType = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(713, 12);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(75, 23);
            this.btn_Go.TabIndex = 1;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.btn_Go_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(93, 12);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(603, 20);
            this.txt_FilePath.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 346);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "iDoc.png");
            this.iconList.Images.SetKeyName(1, "iDocX.png");
            this.iconList.Images.SetKeyName(2, "ijpeg.png");
            this.iconList.Images.SetKeyName(3, "ijpg.png");
            this.iconList.Images.SetKeyName(4, "ipdf.png");
            this.iconList.Images.SetKeyName(5, "iUnknown.png");
            this.iconList.Images.SetKeyName(6, "iFolder.png");
            this.iconList.Images.SetKeyName(7, "iPng.png");
            this.iconList.Images.SetKeyName(8, "itxt.png");
            this.iconList.Images.SetKeyName(9, "izip.png");
            this.iconList.Images.SetKeyName(10, "iexcel.png");
            // 
            // lbl_Name_FileName
            // 
            this.lbl_Name_FileName.AutoSize = true;
            this.lbl_Name_FileName.Location = new System.Drawing.Point(22, 414);
            this.lbl_Name_FileName.Name = "lbl_Name_FileName";
            this.lbl_Name_FileName.Size = new System.Drawing.Size(54, 13);
            this.lbl_Name_FileName.TabIndex = 4;
            this.lbl_Name_FileName.Text = "File Name";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(90, 414);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(0, 13);
            this.lbl_FileName.TabIndex = 5;
            // 
            // lbl_name_FileType
            // 
            this.lbl_name_FileType.AutoSize = true;
            this.lbl_name_FileType.Location = new System.Drawing.Point(637, 414);
            this.lbl_name_FileType.Name = "lbl_name_FileType";
            this.lbl_name_FileType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_name_FileType.Size = new System.Drawing.Size(50, 13);
            this.lbl_name_FileType.TabIndex = 6;
            this.lbl_name_FileType.Text = "File Type";
            // 
            // lbl_FileType
            // 
            this.lbl_FileType.AutoSize = true;
            this.lbl_FileType.Location = new System.Drawing.Point(739, 414);
            this.lbl_FileType.Name = "lbl_FileType";
            this.lbl_FileType.Size = new System.Drawing.Size(0, 13);
            this.lbl_FileType.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // createFIleToolStripMenuItem
            // 
            this.createFIleToolStripMenuItem.Name = "createFIleToolStripMenuItem";
            this.createFIleToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.createFIleToolStripMenuItem.Text = "Create File";
            // 
            // createNewDirectoryToolStripMenuItem
            // 
            this.createNewDirectoryToolStripMenuItem.Name = "createNewDirectoryToolStripMenuItem";
            this.createNewDirectoryToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.createNewDirectoryToolStripMenuItem.Text = "Create New Directory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FileType);
            this.Controls.Add(this.lbl_name_FileType);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.lbl_Name_FileName);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.btn_Go);
            this.Controls.Add(this.btn_Back);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbl_Name_FileName;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label lbl_name_FileType;
        private System.Windows.Forms.Label lbl_FileType;
        private System.Windows.Forms.ImageList iconList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createFIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDirectoryToolStripMenuItem;
    }
}

