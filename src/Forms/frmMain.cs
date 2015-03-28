using System;
using System.IO;
using System.Windows.Forms;
using BIN_Editor.r3d;
using Microsoft.Win32;

namespace BIN_Editor
{
    public partial class frmMain : Form
    {
        private FileSystem fs;


        public frmMain()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code by florian0 (stagetwo.eu)\r\nbased on WarInc FileExtractor by learn_more (unknowncheats.me)", "About");
        }

        private void openBINFiles_Click(object sender, EventArgs e)
        {

			OpenFileDialog dlg = new OpenFileDialog ();
			dlg.Title = "Select the first file e.g. XX_00.bin";

            Console.WriteLine("Show file-select dialog");
			if (dlg.ShowDialog() != DialogResult.OK)
            {
                Console.WriteLine("File-selection aborted");
                return;
            }

			string path = Path.GetDirectoryName (dlg.FileName);
			string prefix = Path.GetFileName (dlg.FileName);
        
			Console.WriteLine("Using {0} as Installation Path", path);
            
            openBINFiles.Enabled = false;

			string pf = prefix.Split ('_') [0];

			fs = new FileSystem(path, pf);

            tsl_filecount.Text = "Found " + fs.FileCount.ToString() + " Files";
            tsl_fileversion.Text = "r3dFS-Version: " + fs.Version.ToString();

            TreeNode rootnode = new TreeNode("ROOT");

            foreach (Folder folder in fs.Root.Folders)
                AddSubfolders(rootnode, folder);

            tv_folders.Nodes.Add(rootnode);

        }

        private TreeNode SearchNode(TreeNodeCollection nodes, string Key)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == Key)
                {
                    return node;
                }
            }
            return null;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string MakeSizeReadable(int size)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = size;

            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }

        private void tsm_extract_file_Click(object sender, EventArgs e)
        {
            Folder folder = fs.GetFolderFromPath(txt_currentPath.Text);

            foreach (ListViewItem item in lv_files.SelectedItems)
            {
                BIN_Editor.r3d.File file = folder.GetFile(item.Text);
                fs.ExtractFile(file);
            }

        }

        private void extractFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Folder folder = fs.GetFolderFromPath(tv_folders.SelectedNode.FullPath);

            foreach (BIN_Editor.r3d.File file in folder.Files)
            {
                fs.ExtractFile(file);
            }

        }

        private void AddSubfolders(TreeNode node, Folder folder)
        {
            TreeNode newnode = new TreeNode(folder.Name);

            node.Nodes.Add(newnode);

            foreach (Folder subfolder in folder.Folders)
            {
                AddSubfolders(newnode, subfolder);
            }
        }

        private void tv_folders_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Make CurrentPath visible in textBox
            txt_currentPath.Text = e.Node.FullPath;

            // Hide listView to increase performance
            lv_files.Visible = false;

            // Remove all items
            lv_files.Items.Clear();

            // Get CurrentFolder-Object
            Folder currentFolder = fs.GetFolderFromPath(e.Node.FullPath);

            // Add Files in Folder to ListView
            foreach (BIN_Editor.r3d.File file in currentFolder.Files)
            {
                ListViewItem item = new ListViewItem(file.Name);

                item.ImageIndex = 2;

                item.SubItems.Add(file.StoreInfo.ToString()); ;
                item.SubItems.Add(file.VolumeIndex.ToString());
                item.SubItems.Add(MakeSizeReadable(file.RealSize));
                item.SubItems.Add(MakeSizeReadable(file.CompressedSize));
                item.SubItems.Add(file.CRC32.ToString("X8"));
                item.SubItems.Add(file.Offset.ToString("X8"));

                lv_files.Items.Add(item);
            }

            lv_files.Visible = true;
        }

        private void closeBINFiles_Click(object sender, EventArgs e)
        {
            tv_folders.Nodes.Clear();
            
        }
    }
}
