namespace MOT.Forms
{
    partial class Main
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
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            this.cmsPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabController = new VisualPlus.Toolkit.Controls.Navigation.VisualTabControl();
            this.tpMain = new VisualPlus.Toolkit.Child.VisualTabPage();
            this.lvLibrary = new MOT.Controls.MusicListView();
            this.cmsLibrary = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToUpNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.openDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.songInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpUpNext = new VisualPlus.Toolkit.Child.VisualTabPage();
            this.lvUpNext = new MOT.Controls.MusicListView();
            this.cmsUpNext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpHistory = new VisualPlus.Toolkit.Child.VisualTabPage();
            this.lvHistory = new MOT.Controls.MusicListView();
            this.cmsHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tpLogging = new VisualPlus.Toolkit.Child.VisualTabPage();
            this.rtbLog = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.lbPlaylists = new System.Windows.Forms.ListBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseVolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.muteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAudioController = new System.Windows.Forms.Panel();
            this.audioControllerHost = new MOT.Controls.AudioController();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.editMetaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDuplicatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumCoverFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPlaylist.SuspendLayout();
            this.tabController.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.cmsLibrary.SuspendLayout();
            this.tpUpNext.SuspendLayout();
            this.cmsUpNext.SuspendLayout();
            this.tpHistory.SuspendLayout();
            this.cmsHistory.SuspendLayout();
            this.tpLogging.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.visualGroupBox1.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.panelAudioController.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsPlaylist
            // 
            this.cmsPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.cmsPlaylist.Name = "cmsPlaylist";
            this.cmsPlaylist.Size = new System.Drawing.Size(118, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.RenameToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // tabController
            // 
            this.tabController.Controls.Add(this.tpMain);
            this.tabController.Controls.Add(this.tpUpNext);
            this.tabController.Controls.Add(this.tpHistory);
            this.tabController.Controls.Add(this.tpLogging);
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabController.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabController.ItemSize = new System.Drawing.Size(100, 25);
            this.tabController.Location = new System.Drawing.Point(270, 3);
            this.tabController.MinimumSize = new System.Drawing.Size(144, 85);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.SelectorAlignment = System.Windows.Forms.TabAlignment.Top;
            this.tabController.SelectorSpacing = 10;
            this.tabController.SelectorThickness = 4;
            this.tabController.SelectorType = VisualPlus.Toolkit.Controls.Navigation.VisualTabControl.SelectorTypes.Arrow;
            this.tabController.SelectorVisible = true;
            this.tabController.Separator = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.tabController.SeparatorSpacing = 2;
            this.tabController.SeparatorThickness = 2F;
            this.tabController.Size = new System.Drawing.Size(662, 394);
            this.tabController.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabController.State = VisualPlus.Enumerators.MouseStates.Hover;
            this.tabController.TabIndex = 14;
            this.tabController.TabMenu = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tabController.TabSelector = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tabController.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.Transparent;
            this.tpMain.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tpMain.Border.Rounding = 6;
            this.tpMain.Border.Thickness = 1;
            this.tpMain.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
            this.tpMain.Border.Visible = false;
            this.tpMain.Controls.Add(this.lvLibrary);
            this.tpMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tpMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.tpMain.HeaderImage = null;
            this.tpMain.Image = null;
            this.tpMain.ImageSize = new System.Drawing.Size(16, 16);
            this.tpMain.Location = new System.Drawing.Point(4, 29);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(654, 361);
            this.tpMain.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tpMain.TabIndex = 1;
            this.tpMain.TabNormal = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tpMain.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.tpMain.Text = "Library";
            this.tpMain.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tpMain.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.tpMain.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.tpMain.TextSelected = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            // 
            // lvLibrary
            // 
            this.lvLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLibrary.ContextMenuStrip = this.cmsLibrary;
            this.lvLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLibrary.FullRowSelect = true;
            this.lvLibrary.GridLines = true;
            this.lvLibrary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLibrary.HideSelection = false;
            this.lvLibrary.Location = new System.Drawing.Point(0, 0);
            this.lvLibrary.Name = "lvLibrary";
            this.lvLibrary.Size = new System.Drawing.Size(654, 361);
            this.lvLibrary.TabIndex = 0;
            this.lvLibrary.UseCompatibleStateImageBehavior = false;
            this.lvLibrary.View = System.Windows.Forms.View.Details;
            this.lvLibrary.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.Library_ItemMouseHover);
            this.lvLibrary.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Library_MouseClick);
            this.lvLibrary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Library_MouseDoubleClick);
            // 
            // cmsLibrary
            // 
            this.cmsLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playSongToolStripMenuItem,
            this.addToUpNextToolStripMenuItem,
            this.addToPlaylistToolStripMenuItem,
            this.toolStripSeparator6,
            this.openDirectoryToolStripMenuItem,
            this.toolStripSeparator7,
            this.songInfoToolStripMenuItem});
            this.cmsLibrary.Name = "cmsPlaylist";
            this.cmsLibrary.Size = new System.Drawing.Size(163, 126);
            // 
            // playSongToolStripMenuItem
            // 
            this.playSongToolStripMenuItem.Enabled = false;
            this.playSongToolStripMenuItem.Name = "playSongToolStripMenuItem";
            this.playSongToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.playSongToolStripMenuItem.Text = "Play Song";
            this.playSongToolStripMenuItem.Click += new System.EventHandler(this.PlaySongToolStripMenuItem_Click);
            // 
            // addToUpNextToolStripMenuItem
            // 
            this.addToUpNextToolStripMenuItem.Enabled = false;
            this.addToUpNextToolStripMenuItem.Name = "addToUpNextToolStripMenuItem";
            this.addToUpNextToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addToUpNextToolStripMenuItem.Text = "Add to up next";
            this.addToUpNextToolStripMenuItem.Click += new System.EventHandler(this.AddToUpNextToolStripMenuItem_Click);
            // 
            // addToPlaylistToolStripMenuItem
            // 
            this.addToPlaylistToolStripMenuItem.Enabled = false;
            this.addToPlaylistToolStripMenuItem.Name = "addToPlaylistToolStripMenuItem";
            this.addToPlaylistToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addToPlaylistToolStripMenuItem.Text = "Add to Playlist";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(159, 6);
            // 
            // openDirectoryToolStripMenuItem
            // 
            this.openDirectoryToolStripMenuItem.Enabled = false;
            this.openDirectoryToolStripMenuItem.Name = "openDirectoryToolStripMenuItem";
            this.openDirectoryToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openDirectoryToolStripMenuItem.Text = "Open directory...";
            this.openDirectoryToolStripMenuItem.Click += new System.EventHandler(this.OpenDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(159, 6);
            // 
            // songInfoToolStripMenuItem
            // 
            this.songInfoToolStripMenuItem.Enabled = false;
            this.songInfoToolStripMenuItem.Name = "songInfoToolStripMenuItem";
            this.songInfoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.songInfoToolStripMenuItem.Text = "Song Info";
            this.songInfoToolStripMenuItem.Click += new System.EventHandler(this.SongInfoToolStripMenuItem_Click);
            // 
            // tpUpNext
            // 
            this.tpUpNext.BackColor = System.Drawing.Color.Transparent;
            this.tpUpNext.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tpUpNext.Border.Rounding = 6;
            this.tpUpNext.Border.Thickness = 1;
            this.tpUpNext.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
            this.tpUpNext.Border.Visible = false;
            this.tpUpNext.Controls.Add(this.lvUpNext);
            this.tpUpNext.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tpUpNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.tpUpNext.HeaderImage = null;
            this.tpUpNext.Image = null;
            this.tpUpNext.ImageSize = new System.Drawing.Size(16, 16);
            this.tpUpNext.Location = new System.Drawing.Point(4, 29);
            this.tpUpNext.Name = "tpUpNext";
            this.tpUpNext.Size = new System.Drawing.Size(654, 361);
            this.tpUpNext.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tpUpNext.TabIndex = 4;
            this.tpUpNext.TabNormal = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tpUpNext.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.tpUpNext.Text = "Up Next";
            this.tpUpNext.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tpUpNext.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.tpUpNext.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.tpUpNext.TextSelected = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            // 
            // lvUpNext
            // 
            this.lvUpNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUpNext.ContextMenuStrip = this.cmsUpNext;
            this.lvUpNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUpNext.FullRowSelect = true;
            this.lvUpNext.GridLines = true;
            this.lvUpNext.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvUpNext.HideSelection = false;
            this.lvUpNext.Location = new System.Drawing.Point(0, 0);
            this.lvUpNext.Name = "lvUpNext";
            this.lvUpNext.Size = new System.Drawing.Size(654, 361);
            this.lvUpNext.TabIndex = 0;
            this.lvUpNext.UseCompatibleStateImageBehavior = false;
            this.lvUpNext.View = System.Windows.Forms.View.Details;
            this.lvUpNext.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.UpNext_ItemMouseHover);
            this.lvUpNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpNext_MouseClick);
            // 
            // cmsUpNext
            // 
            this.cmsUpNext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.toolStripSeparator5,
            this.clearToolStripMenuItem});
            this.cmsUpNext.Name = "cmsUpNext";
            this.cmsUpNext.Size = new System.Drawing.Size(118, 54);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(114, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // tpHistory
            // 
            this.tpHistory.BackColor = System.Drawing.Color.Transparent;
            this.tpHistory.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tpHistory.Border.Rounding = 6;
            this.tpHistory.Border.Thickness = 1;
            this.tpHistory.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
            this.tpHistory.Border.Visible = false;
            this.tpHistory.Controls.Add(this.lvHistory);
            this.tpHistory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tpHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.tpHistory.HeaderImage = null;
            this.tpHistory.Image = null;
            this.tpHistory.ImageSize = new System.Drawing.Size(16, 16);
            this.tpHistory.Location = new System.Drawing.Point(4, 29);
            this.tpHistory.Name = "tpHistory";
            this.tpHistory.Size = new System.Drawing.Size(654, 361);
            this.tpHistory.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tpHistory.TabIndex = 3;
            this.tpHistory.TabNormal = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tpHistory.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.tpHistory.Text = "History";
            this.tpHistory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tpHistory.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.tpHistory.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.tpHistory.TextSelected = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            // 
            // lvHistory
            // 
            this.lvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvHistory.ContextMenuStrip = this.cmsHistory;
            this.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHistory.FullRowSelect = true;
            this.lvHistory.GridLines = true;
            this.lvHistory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvHistory.HideSelection = false;
            this.lvHistory.Location = new System.Drawing.Point(0, 0);
            this.lvHistory.Name = "lvHistory";
            this.lvHistory.Size = new System.Drawing.Size(654, 361);
            this.lvHistory.TabIndex = 0;
            this.lvHistory.UseCompatibleStateImageBehavior = false;
            this.lvHistory.View = System.Windows.Forms.View.Details;
            this.lvHistory.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.History_ItemMouseHover);
            this.lvHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.History_MouseClick);
            // 
            // cmsHistory
            // 
            this.cmsHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRemove,
            this.toolStripSeparator8,
            this.toolStripMenuItemClear});
            this.cmsHistory.Name = "cmsUpNext";
            this.cmsHistory.Size = new System.Drawing.Size(118, 54);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Enabled = false;
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemRemove.Text = "Remove";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.RemoveHistoryItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(114, 6);
            // 
            // toolStripMenuItemClear
            // 
            this.toolStripMenuItemClear.Enabled = false;
            this.toolStripMenuItemClear.Name = "toolStripMenuItemClear";
            this.toolStripMenuItemClear.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemClear.Text = "Clear";
            this.toolStripMenuItemClear.Click += new System.EventHandler(this.ClearHistory_Click);
            // 
            // tpLogging
            // 
            this.tpLogging.BackColor = System.Drawing.Color.Transparent;
            this.tpLogging.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tpLogging.Border.Rounding = 6;
            this.tpLogging.Border.Thickness = 1;
            this.tpLogging.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
            this.tpLogging.Border.Visible = false;
            this.tpLogging.Controls.Add(this.rtbLog);
            this.tpLogging.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tpLogging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(181)))), ((int)(((byte)(187)))));
            this.tpLogging.HeaderImage = null;
            this.tpLogging.Image = null;
            this.tpLogging.ImageSize = new System.Drawing.Size(16, 16);
            this.tpLogging.Location = new System.Drawing.Point(4, 29);
            this.tpLogging.Name = "tpLogging";
            this.tpLogging.Size = new System.Drawing.Size(654, 361);
            this.tpLogging.TabHover = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.tpLogging.TabIndex = 2;
            this.tpLogging.TabNormal = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(73)))));
            this.tpLogging.TabSelected = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(88)))));
            this.tpLogging.Text = "Logging";
            this.tpLogging.TextAlignment = System.Drawing.StringAlignment.Center;
            this.tpLogging.TextImageRelation = VisualPlus.Toolkit.Child.VisualTabPage.TextImageRelations.Text;
            this.tpLogging.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.tpLogging.TextSelected = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            // 
            // rtbLog
            // 
            this.rtbLog.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.rtbLog.BackColorState.Enabled = System.Drawing.Color.Black;
            this.rtbLog.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rtbLog.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.rtbLog.Border.HoverVisible = true;
            this.rtbLog.Border.Rounding = 6;
            this.rtbLog.Border.Thickness = 1;
            this.rtbLog.Border.Type = VisualPlus.Enumerators.ShapeType.Rectangle;
            this.rtbLog.Border.Visible = true;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.rtbLog.ForeColor = System.Drawing.Color.White;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.MaxLength = 2147483647;
            this.rtbLog.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.rtbLog.ShowSelectionMargin = false;
            this.rtbLog.Size = new System.Drawing.Size(654, 361);
            this.rtbLog.TabIndex = 0;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.rtbLog.TextStyle = textStyle3;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.visualGroupBox1, 0, 0);
            this.tlpMain.Controls.Add(this.tabController, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.01727F));
            this.tlpMain.Size = new System.Drawing.Size(935, 400);
            this.tlpMain.TabIndex = 17;
            // 
            // visualGroupBox1
            // 
            this.visualGroupBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualGroupBox1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualGroupBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualGroupBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualGroupBox1.Border.HoverVisible = true;
            this.visualGroupBox1.Border.Rounding = 6;
            this.visualGroupBox1.Border.Thickness = 1;
            this.visualGroupBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox1.Border.Visible = true;
            this.visualGroupBox1.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox1.Controls.Add(this.lbPlaylists);
            this.visualGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualGroupBox1.Image = null;
            this.visualGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.visualGroupBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox1.Name = "visualGroupBox1";
            this.visualGroupBox1.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox1.Separator = true;
            this.visualGroupBox1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualGroupBox1.Size = new System.Drawing.Size(261, 394);
            this.visualGroupBox1.TabIndex = 19;
            this.visualGroupBox1.Text = "Playlists";
            this.visualGroupBox1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualGroupBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox1.TextStyle = textStyle1;
            this.visualGroupBox1.TitleBoxHeight = 25;
            // 
            // lbPlaylists
            // 
            this.lbPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbPlaylists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPlaylists.ContextMenuStrip = this.cmsPlaylist;
            this.lbPlaylists.FormattingEnabled = true;
            this.lbPlaylists.Items.AddRange(new object[] {
            "All Music"});
            this.lbPlaylists.Location = new System.Drawing.Point(3, 29);
            this.lbPlaylists.Name = "lbPlaylists";
            this.lbPlaylists.Size = new System.Drawing.Size(255, 351);
            this.lbPlaylists.TabIndex = 1;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 586);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(935, 22);
            this.ssMain.TabIndex = 19;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(125, 17);
            this.tsslStatus.Text = "Status: %StatusCode%";
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playbackToolStripMenuItem,
            this.audioToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(935, 24);
            this.msMain.TabIndex = 20;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openFileToolStripMenuItem.Text = "Open File...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openFolderToolStripMenuItem.Text = "Open Folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // playbackToolStripMenuItem
            // 
            this.playbackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.nextToolStripMenuItem});
            this.playbackToolStripMenuItem.Name = "playbackToolStripMenuItem";
            this.playbackToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.playbackToolStripMenuItem.Text = "Playback";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            this.previousToolStripMenuItem.Click += new System.EventHandler(this.PreviousToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.NextToolStripMenuItem_Click);
            // 
            // audioToolStripMenuItem
            // 
            this.audioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.increaseVolumeToolStripMenuItem,
            this.decreaseVolumeToolStripMenuItem,
            this.toolStripSeparator4,
            this.muteToolStripMenuItem});
            this.audioToolStripMenuItem.Name = "audioToolStripMenuItem";
            this.audioToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.audioToolStripMenuItem.Text = "Audio";
            // 
            // increaseVolumeToolStripMenuItem
            // 
            this.increaseVolumeToolStripMenuItem.Name = "increaseVolumeToolStripMenuItem";
            this.increaseVolumeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.increaseVolumeToolStripMenuItem.Text = "Increase Volume";
            this.increaseVolumeToolStripMenuItem.Click += new System.EventHandler(this.IncreaseVolumeToolStripMenuItem_Click);
            // 
            // decreaseVolumeToolStripMenuItem
            // 
            this.decreaseVolumeToolStripMenuItem.Name = "decreaseVolumeToolStripMenuItem";
            this.decreaseVolumeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decreaseVolumeToolStripMenuItem.Text = "Decrease Volume";
            this.decreaseVolumeToolStripMenuItem.Click += new System.EventHandler(this.DecreaseVolumeToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // muteToolStripMenuItem
            // 
            this.muteToolStripMenuItem.CheckOnClick = true;
            this.muteToolStripMenuItem.Name = "muteToolStripMenuItem";
            this.muteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.muteToolStripMenuItem.Text = "Mute";
            this.muteToolStripMenuItem.Click += new System.EventHandler(this.MuteToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator9,
            this.albumCoverFinderToolStripMenuItem,
            this.editMetaDataToolStripMenuItem,
            this.findDuplicatesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistToolStripMenuItem,
            this.toolStripSeparator2,
            this.alwaysOnTopToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Checked = true;
            this.playlistToolStripMenuItem.CheckOnClick = true;
            this.playlistToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.PlaylistToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always on top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.AlwaysOnTopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panelAudioController
            // 
            this.panelAudioController.BackColor = System.Drawing.Color.Transparent;
            this.panelAudioController.Controls.Add(this.audioControllerHost);
            this.panelAudioController.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAudioController.Location = new System.Drawing.Point(0, 424);
            this.panelAudioController.Name = "panelAudioController";
            this.panelAudioController.Size = new System.Drawing.Size(935, 162);
            this.panelAudioController.TabIndex = 21;
            // 
            // audioControllerHost
            // 
            this.audioControllerHost.BackColor = System.Drawing.Color.Gainsboro;
            this.audioControllerHost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.audioControllerHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioControllerHost.History = null;
            this.audioControllerHost.Library = null;
            this.audioControllerHost.Location = new System.Drawing.Point(0, 0);
            this.audioControllerHost.Name = "audioControllerHost";
            this.audioControllerHost.PlayButtonEnabled = false;
            this.audioControllerHost.Size = new System.Drawing.Size(935, 162);
            this.audioControllerHost.TabIndex = 0;
            this.audioControllerHost.UpNext = null;
            this.audioControllerHost.Volume = 70;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(177, 6);
            // 
            // editMetaDataToolStripMenuItem
            // 
            this.editMetaDataToolStripMenuItem.Enabled = false;
            this.editMetaDataToolStripMenuItem.Name = "editMetaDataToolStripMenuItem";
            this.editMetaDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editMetaDataToolStripMenuItem.Text = "Edit Meta Data";
            // 
            // findDuplicatesToolStripMenuItem
            // 
            this.findDuplicatesToolStripMenuItem.Enabled = false;
            this.findDuplicatesToolStripMenuItem.Name = "findDuplicatesToolStripMenuItem";
            this.findDuplicatesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findDuplicatesToolStripMenuItem.Text = "Find Duplicates";
            // 
            // albumCoverFinderToolStripMenuItem
            // 
            this.albumCoverFinderToolStripMenuItem.Enabled = false;
            this.albumCoverFinderToolStripMenuItem.Name = "albumCoverFinderToolStripMenuItem";
            this.albumCoverFinderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.albumCoverFinderToolStripMenuItem.Text = "Album Cover Finder";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 608);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.panelAudioController);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.ssMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "Main";
            this.Text = "Music Organization Tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.cmsPlaylist.ResumeLayout(false);
            this.tabController.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.cmsLibrary.ResumeLayout(false);
            this.tpUpNext.ResumeLayout(false);
            this.cmsUpNext.ResumeLayout(false);
            this.tpHistory.ResumeLayout(false);
            this.cmsHistory.ResumeLayout(false);
            this.tpLogging.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.visualGroupBox1.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.panelAudioController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VisualPlus.Toolkit.Controls.Navigation.VisualTabControl tabController;
        private VisualPlus.Toolkit.Child.VisualTabPage tpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private VisualPlus.Toolkit.Child.VisualTabPage tpLogging;
        private System.Windows.Forms.ContextMenuStrip cmsPlaylist;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox rtbLog;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseVolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem muteToolStripMenuItem;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private VisualPlus.Toolkit.Child.VisualTabPage tpHistory;
        private VisualPlus.Toolkit.Child.VisualTabPage tpUpNext;
        private System.Windows.Forms.ListBox lbPlaylists;
        private Controls.MusicListView lvHistory;
        private Controls.MusicListView lvLibrary;
        private Controls.MusicListView lvUpNext;
        private System.Windows.Forms.Panel panelAudioController;
        private System.Windows.Forms.ContextMenuStrip cmsLibrary;
        private System.Windows.Forms.ToolStripMenuItem playSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToUpNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem openDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem songInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUpNext;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsHistory;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClear;
        private Controls.AudioController audioControllerHost;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem editMetaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDuplicatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumCoverFinderToolStripMenuItem;
    }
}

