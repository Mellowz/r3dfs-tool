namespace BIN_Editor
{
	partial class frmMain
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.ms_mainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openBINFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.closeBINFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.everythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedItemssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedFolderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.selectedFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ss_mainStatus = new System.Windows.Forms.StatusStrip();
			this.tsl_filecount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsl_fileversion = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tv_folders = new System.Windows.Forms.TreeView();
			this.cmenu_folders = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.extractFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.il_list_small = new System.Windows.Forms.ImageList(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lv_files = new System.Windows.Forms.ListView();
			this.clh_filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clh_storeinfo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clh_volumeindex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clh_realsize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clh_compressedsize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clh_crc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clh_offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cmenu_filelist = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsm_extract_file = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_currentPath = new System.Windows.Forms.TextBox();
			this.ms_mainMenu.SuspendLayout();
			this.ss_mainStatus.SuspendLayout();
			//((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.cmenu_folders.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.cmenu_filelist.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ms_mainMenu
			// 
			this.ms_mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.searchToolStripMenuItem,
			this.extractToolStripMenuItem,
			this.modifyToolStripMenuItem,
			this.helpToolStripMenuItem});
			this.ms_mainMenu.Location = new System.Drawing.Point(0, 0);
			this.ms_mainMenu.Name = "ms_mainMenu";
			this.ms_mainMenu.Size = new System.Drawing.Size(1089, 24);
			this.ms_mainMenu.TabIndex = 0;
			this.ms_mainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openBINFiles,
			this.closeBINFiles,
			this.toolStripSeparator1,
			this.btn_exit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openBINFiles
			// 
			this.openBINFiles.Name = "openBINFiles";
			this.openBINFiles.Size = new System.Drawing.Size(184, 22);
			this.openBINFiles.Text = "Open BIN-Files";
			this.openBINFiles.Click += new System.EventHandler(this.openBINFiles_Click);
			// 
			// closeBINFiles
			// 
			this.closeBINFiles.Enabled = false;
			this.closeBINFiles.Name = "closeBINFiles";
			this.closeBINFiles.Size = new System.Drawing.Size(184, 22);
			this.closeBINFiles.Text = "Close BIN-Files";
			this.closeBINFiles.Click += new System.EventHandler(this.closeBINFiles_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
			// 
			// btn_exit
			// 
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(184, 22);
			this.btn_exit.Text = "Exit";
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Enabled = false;
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.searchToolStripMenuItem.Text = "Search";
			// 
			// extractToolStripMenuItem
			// 
			this.extractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectedFolderToolStripMenuItem,
			this.selectedFilesToolStripMenuItem,
			this.toolStripSeparator2,
			this.everythingToolStripMenuItem});
			this.extractToolStripMenuItem.Enabled = false;
			this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
			this.extractToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.extractToolStripMenuItem.Text = "Extract";
			// 
			// selectedFolderToolStripMenuItem
			// 
			this.selectedFolderToolStripMenuItem.Name = "selectedFolderToolStripMenuItem";
			this.selectedFolderToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.selectedFolderToolStripMenuItem.Text = "Selected Folder";
			// 
			// selectedFilesToolStripMenuItem
			// 
			this.selectedFilesToolStripMenuItem.Name = "selectedFilesToolStripMenuItem";
			this.selectedFilesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.selectedFilesToolStripMenuItem.Text = "Selected File(s)";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(151, 6);
			// 
			// everythingToolStripMenuItem
			// 
			this.everythingToolStripMenuItem.Name = "everythingToolStripMenuItem";
			this.everythingToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.everythingToolStripMenuItem.Text = "Everything";
			// 
			// modifyToolStripMenuItem
			// 
			this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.replaceToolStripMenuItem,
			this.removeToolStripMenuItem});
			this.modifyToolStripMenuItem.Enabled = false;
			this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
			this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.modifyToolStripMenuItem.Text = "Modify";
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectedFolderToolStripMenuItem1,
			this.selectedItemssToolStripMenuItem});
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.replaceToolStripMenuItem.Text = "Replace";
			// 
			// selectedFolderToolStripMenuItem1
			// 
			this.selectedFolderToolStripMenuItem1.Name = "selectedFolderToolStripMenuItem1";
			this.selectedFolderToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
			this.selectedFolderToolStripMenuItem1.Text = "Selected Folder";
			// 
			// selectedItemssToolStripMenuItem
			// 
			this.selectedItemssToolStripMenuItem.Name = "selectedItemssToolStripMenuItem";
			this.selectedItemssToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.selectedItemssToolStripMenuItem.Text = "Selected Items(s)";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.selectedFolderToolStripMenuItem2,
			this.selectedFilesToolStripMenuItem1});
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// selectedFolderToolStripMenuItem2
			// 
			this.selectedFolderToolStripMenuItem2.Name = "selectedFolderToolStripMenuItem2";
			this.selectedFolderToolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
			this.selectedFolderToolStripMenuItem2.Text = "Selected Folder";
			// 
			// selectedFilesToolStripMenuItem1
			// 
			this.selectedFilesToolStripMenuItem1.Name = "selectedFilesToolStripMenuItem1";
			this.selectedFilesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
			this.selectedFilesToolStripMenuItem1.Text = "Selected File(s)";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// ss_mainStatus
			// 
			this.ss_mainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsl_filecount,
			this.tsl_fileversion});
			this.ss_mainStatus.Location = new System.Drawing.Point(0, 637);
			this.ss_mainStatus.Name = "ss_mainStatus";
			this.ss_mainStatus.Size = new System.Drawing.Size(1089, 22);
			this.ss_mainStatus.TabIndex = 1;
			this.ss_mainStatus.Text = "statusStrip1";
			// 
			// tsl_filecount
			// 
			this.tsl_filecount.Name = "tsl_filecount";
			this.tsl_filecount.Size = new System.Drawing.Size(77, 17);
			this.tsl_filecount.Text = "Found X Files";
			// 
			// tsl_fileversion
			// 
			this.tsl_fileversion.Name = "tsl_fileversion";
			this.tsl_fileversion.Size = new System.Drawing.Size(135, 17);
			this.tsl_fileversion.Text = "r3dFS Version: Unknown";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tv_folders);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(1089, 613);
			this.splitContainer1.SplitterDistance = 307;
			this.splitContainer1.TabIndex = 2;
			// 
			// tv_folders
			// 
			this.tv_folders.ContextMenuStrip = this.cmenu_folders;
			this.tv_folders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_folders.ImageIndex = 0;
			this.tv_folders.ImageList = this.il_list_small;
			this.tv_folders.Location = new System.Drawing.Point(0, 0);
			this.tv_folders.Name = "tv_folders";
			this.tv_folders.SelectedImageIndex = 0;
			this.tv_folders.Size = new System.Drawing.Size(307, 613);
			this.tv_folders.TabIndex = 0;
			this.tv_folders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_folders_AfterSelect);
			// 
			// cmenu_folders
			// 
			this.cmenu_folders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.extractFolderToolStripMenuItem,
			this.toolStripSeparator4,
			this.addFolderToolStripMenuItem});
			this.cmenu_folders.Name = "cmenu_folders";
			this.cmenu_folders.Size = new System.Drawing.Size(146, 54);
			// 
			// extractFolderToolStripMenuItem
			// 
			this.extractFolderToolStripMenuItem.Name = "extractFolderToolStripMenuItem";
			this.extractFolderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.extractFolderToolStripMenuItem.Text = "Extract Folder";
			this.extractFolderToolStripMenuItem.Click += new System.EventHandler(this.extractFolderToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
			// 
			// addFolderToolStripMenuItem
			// 
			this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
			this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.addFolderToolStripMenuItem.Text = "Add Folder";
			// 
			// il_list_small
			// 
			this.il_list_small.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il_list_small.ImageStream")));
			this.il_list_small.TransparentColor = System.Drawing.Color.Transparent;
			this.il_list_small.Images.SetKeyName(0, "folder.png");
			this.il_list_small.Images.SetKeyName(1, "page_white.png");
			this.il_list_small.Images.SetKeyName(2, "page.png");
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lv_files, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 613);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lv_files
			// 
			this.lv_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.clh_filename,
			this.clh_storeinfo,
			this.clh_volumeindex,
			this.clh_realsize,
			this.clh_compressedsize,
			this.clh_crc,
			this.clh_offset});
			this.lv_files.ContextMenuStrip = this.cmenu_filelist;
			this.lv_files.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_files.FullRowSelect = true;
			this.lv_files.Location = new System.Drawing.Point(0, 22);
			this.lv_files.Margin = new System.Windows.Forms.Padding(0);
			this.lv_files.Name = "lv_files";
			this.lv_files.Size = new System.Drawing.Size(778, 591);
			this.lv_files.SmallImageList = this.il_list_small;
			this.lv_files.TabIndex = 4;
			this.lv_files.UseCompatibleStateImageBehavior = false;
			this.lv_files.View = System.Windows.Forms.View.Details;
			// 
			// clh_filename
			// 
			this.clh_filename.Text = "FileName";
			this.clh_filename.Width = 211;
			// 
			// clh_storeinfo
			// 
			this.clh_storeinfo.Text = "StoreInfo";
			this.clh_storeinfo.Width = 131;
			// 
			// clh_volumeindex
			// 
			this.clh_volumeindex.Text = "VI";
			this.clh_volumeindex.Width = 32;
			// 
			// clh_realsize
			// 
			this.clh_realsize.Text = "RealSize";
			this.clh_realsize.Width = 93;
			// 
			// clh_compressedsize
			// 
			this.clh_compressedsize.Text = "CompressedSize";
			this.clh_compressedsize.Width = 108;
			// 
			// clh_crc
			// 
			this.clh_crc.Text = "CRC32";
			this.clh_crc.Width = 71;
			// 
			// clh_offset
			// 
			this.clh_offset.Text = "Offset";
			this.clh_offset.Width = 66;
			// 
			// cmenu_filelist
			// 
			this.cmenu_filelist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsm_extract_file,
			this.toolStripSeparator3,
			this.addFileToolStripMenuItem});
			this.cmenu_filelist.Name = "cmenu_filelist";
			this.cmenu_filelist.Size = new System.Drawing.Size(144, 54);
			// 
			// tsm_extract_file
			// 
			this.tsm_extract_file.Name = "tsm_extract_file";
			this.tsm_extract_file.Size = new System.Drawing.Size(143, 22);
			this.tsm_extract_file.Text = "Extract File(s)";
			this.tsm_extract_file.Click += new System.EventHandler(this.tsm_extract_file_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(140, 6);
			// 
			// addFileToolStripMenuItem
			// 
			this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
			this.addFileToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.addFileToolStripMenuItem.Text = "Add File(s)";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txt_currentPath);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(778, 22);
			this.panel1.TabIndex = 5;
			// 
			// txt_currentPath
			// 
			this.txt_currentPath.Dock = System.Windows.Forms.DockStyle.Top;
			this.txt_currentPath.Location = new System.Drawing.Point(0, 0);
			this.txt_currentPath.Name = "txt_currentPath";
			this.txt_currentPath.ReadOnly = true;
			this.txt_currentPath.Size = new System.Drawing.Size(778, 20);
			this.txt_currentPath.TabIndex = 0;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1089, 659);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.ss_mainStatus);
			this.Controls.Add(this.ms_mainMenu);
			this.MainMenuStrip = this.ms_mainMenu;
			this.Name = "frmMain";
			this.Text = "r3dFS Explorer - florian0 for StageTwo";
			this.ms_mainMenu.ResumeLayout(false);
			this.ms_mainMenu.PerformLayout();
			this.ss_mainStatus.ResumeLayout(false);
			this.ss_mainStatus.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			//((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.cmenu_folders.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.cmenu_filelist.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip ms_mainMenu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.StatusStrip ss_mainStatus;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView tv_folders;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem btn_exit;
		private System.Windows.Forms.ToolStripMenuItem openBINFiles;
		private System.Windows.Forms.ToolStripMenuItem closeBINFiles;
		private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectedFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectedFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem everythingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectedFolderToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem selectedItemssToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectedFolderToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem selectedFilesToolStripMenuItem1;
		private System.Windows.Forms.ImageList il_list_small;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel tsl_filecount;
		private System.Windows.Forms.ToolStripStatusLabel tsl_fileversion;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ContextMenuStrip cmenu_filelist;
		private System.Windows.Forms.ToolStripMenuItem tsm_extract_file;
		private System.Windows.Forms.ContextMenuStrip cmenu_folders;
		private System.Windows.Forms.ToolStripMenuItem extractFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
		private System.Windows.Forms.ListView lv_files;
		private System.Windows.Forms.ColumnHeader clh_filename;
		private System.Windows.Forms.ColumnHeader clh_storeinfo;
		private System.Windows.Forms.ColumnHeader clh_volumeindex;
		private System.Windows.Forms.ColumnHeader clh_realsize;
		private System.Windows.Forms.ColumnHeader clh_compressedsize;
		private System.Windows.Forms.ColumnHeader clh_crc;
		private System.Windows.Forms.ColumnHeader clh_offset;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_currentPath;
	}
}

