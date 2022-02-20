using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string filePath = "D:/";
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        private bool copying  = false;
        private bool moving = false;
        private string pathFiletoCopyMove = "";
        private string nameFiletoCopyMove = ""; 
        public Form1()
        {
            InitializeComponent();
            CreateHeadersAndFillListView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_FilePath.Text = filePath;
            loadFilesAndDirectory();
        }



        private void btn_Back_Click(object sender, EventArgs e)
        {
            goBack();
            loadBtn_Action();
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {
            loadBtn_Action();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                currentlySelectedItemName = e.Item.Text;
                FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    //It will show us the directory name on address bar
                    isFile = false;
                    txt_FilePath.Text = filePath + "/" + currentlySelectedItemName;
                }
                else
                {
                    isFile = true;
                }
            }
            catch (Exception ex)
            {
                isFile = false;
            }
            

        }

        public void removeBackSlash()
        {
            string path = txt_FilePath.Text;
            if((path.LastIndexOf("/") == path.Length - 1) && path!="D:/")
            {
                txt_FilePath.Text=path.Substring(0, path.Length-1);
            }
        }

        public void goBack()
        {
            try
            {
                removeBackSlash();
                string path = txt_FilePath.Text;
                path=path.Substring(0,path.LastIndexOf('/'));
                this.isFile = false; //It will be a directory
                txt_FilePath.Text=path;
                removeBackSlash();
            }
            catch (Exception)
            {
                throw;
            }
        }



        private void loadFilesAndDirectory()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileInfo = new FileInfo(tempFilePath);
                    lbl_FileName.Text = fileInfo.Name;
                    lbl_FileType.Text = fileInfo.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);

                    Process.Start(tempFilePath); //You can Open Files with this
                }
                else
                {

                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // With this will get all files from the directory
                    DirectoryInfo[] dirs = fileList.GetDirectories();// With this will get additional directories from the directory
                    string fileExtension = "";
                    listView1.Items.Clear();
                    //Adding Files
                    for (int i = 0; i < files.Length; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = files[i].Name;
                        
                        fileExtension= files[i].Extension.ToLower();
                        switch (fileExtension)
                        {
                            case ".doc":
                            case ".docx":
                                lvi.ImageIndex = 0;
                                //listView1.Items.Add(files[i].Name,0);
                                break;
                            case ".jpeg":
                            case ".jpg":
                                lvi.ImageIndex = 2;
                                //listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".png":
                                lvi.ImageIndex = 2;
                                //listView1.Items.Add(files[i].Name, 2);
                                break ;
                            case ".pdf":
                                lvi.ImageIndex = 4;
                                //listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".txt":
                                lvi.ImageIndex = 8;
                                //listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".zip":
                                lvi.ImageIndex = 9;
                                //listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".xls":
                            case ".xlsx":
                                lvi.ImageIndex = 10;
                                //listView1.Items.Add(files[i].Name, 4);
                                break;
                            default:
                                lvi.ImageIndex = 5;
                                //listView1.Items.Add(files[i].Name, 5);
                                break;
                        }
                        lvi.SubItems.Add( new ListViewItem.ListViewSubItem().Text=files[i].Extension);
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = files[i].Length.ToString());
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = files[i].LastWriteTime.ToString());
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = files[i].Attributes.ToString());
                        listView1.Items.Add(lvi);
                    }

                    //Adding Directories
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = dirs[i].Name;
                        lvi.ImageIndex = 6;

                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dirs[i].Extension);
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = "<DIR>");
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dirs[i].LastWriteTime.ToString());
                        lvi.SubItems.Add(new ListViewItem.ListViewSubItem().Text = dirs[i].Attributes.ToString());
                        listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    lbl_FileName.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
            

        }
        private void loadBtn_Action()
        {
            removeBackSlash();
            filePath = txt_FilePath.Text;
            loadFilesAndDirectory();
            isFile = false;


        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadBtn_Action();
        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Width = 250;
            colHead.Text = "Filename";
            this.listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 50;
            colHead.Text = "Ext";
            this.listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 100;
            colHead.Text = "Size";
            this.listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 200;
            colHead.Text = "Date";
            this.listView1.Columns.Add(colHead);

            colHead = new ColumnHeader();
            colHead.Width = 176;
            colHead.Text = "Attr";
            this.listView1.Columns.Add(colHead);
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            { 
                var focusedItem = listView1.FocusedItem;
                ContextMenu cm = new ContextMenu();
                listView1.ContextMenu = cm;
                if (focusedItem.Bounds.Contains(e.Location))
                {
                        if (focusedItem != null)
                        {
                            cm.MenuItems.Add(new MenuItem("Rename", OnMenuItemClick));
                            cm.MenuItems.Add(new MenuItem("Delete", OnMenuDelete));
                            cm.MenuItems.Add(new MenuItem("Copy", OnMenuCopy));
                            cm.MenuItems.Add(new MenuItem("Move", OnMenuMove));
                            cm.MenuItems.Add(new MenuItem("Paste", OnMenuPaste));
                        }    
                }
                
            }
        }

        //RENAME

        private void OnMenuItemClick(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].BeginEdit();
        }
        private void OnMenuDelete(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            FileInfo fileinfo = new FileInfo(filePath + "/" + currentlySelectedItemName);
            File.Delete(fileinfo.FullName);
            currentlySelectedItemName = "";
            listView1.SelectedItems[0].Remove();
        }

        private void OnMenuCopy(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            FileInfo fileinfo = new FileInfo(filePath + "/" + currentlySelectedItemName);
            copying = true;
            pathFiletoCopyMove = fileinfo.FullName;
            nameFiletoCopyMove = fileinfo.Name;
        }
        private void OnMenuMove(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            FileInfo fileinfo = new FileInfo(filePath + "/" + currentlySelectedItemName);
            moving = true;
            pathFiletoCopyMove = fileinfo.FullName;
            nameFiletoCopyMove = fileinfo.Name;
        }
        private void OnMenuPaste(object sender, EventArgs e)
        {
            if (copying)
            {
                File.Copy(pathFiletoCopyMove, filePath + "/" + nameFiletoCopyMove);
            }
            if (moving)
            {
                File.Move(pathFiletoCopyMove, filePath + "/" + nameFiletoCopyMove);
            }
            copying = false;
            moving = false;
        }

        private void onNewtxtFile(object sender, EventArgs e)
        {
            listView1.CreateControl();
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            string newName = Convert.ToString(e.Label);
            ListViewItem item = listView1.SelectedItems[0];
            FileInfo fileinfo = new FileInfo(filePath + "/" + currentlySelectedItemName);

            fileinfo.MoveTo(fileinfo.Directory.FullName + "\\" + newName);
            currentlySelectedItemName=newName;
            listView1.Items[0].Text = newName;
            
        }







        //DELETE
    }
}
