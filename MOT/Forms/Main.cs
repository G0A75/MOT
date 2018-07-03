#region Namespace

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using MOT.Managers;
using MOT.Utilities;

using NAudio.Wave;

#endregion

namespace MOT.Forms
{
    /// <summary>The main form.</summary>
    public partial class Main : Form
    {
        #region Variables

        private int defaultPlaylistWidth;
        private int historyHoverItemIndex;
        private int libraryHoverItemIndex;
        private int upNextHoverItemIndex;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="Main" /> class.</summary>
        public Main()
        {
            InitializeComponent();
            defaultPlaylistWidth = 267;
        }

        #endregion

        #region Methods

        /// <summary>Add playlist item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog createPlaylist = new InputDialog(@"Create new playlist", string.Empty, @"Playlist name");
            DialogResult dialogResult = createPlaylist.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                lbPlaylists.Items.Add(createPlaylist.InputResult);
                addToPlaylistToolStripMenuItem.DropDownItems.Add(createPlaylist.InputResult);
            }
        }

        /// <summary>Add to up next item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void AddToUpNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvLibrary.SelectedItems)
            {
                string filePath = lvLibrary.GetFilePath(item.Index);
                ListViewItem nextItemToAdd = ListManager.CreateItem(filePath);
                lvUpNext.Items.Add(nextItemToAdd);
            }

            UpdateCollectionsCount();
        }

        /// <summary>Always on top view.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void AlwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>Mute the volume.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void AudioController_PlayButtonClick(object sender, EventArgs e)
        {
            switch (audioControllerHost.PlaybackState)
            {
                case PlaybackState.Stopped:
                    {
                        playSongToolStripMenuItem.Enabled = true;
                        stopToolStripMenuItem.Enabled = false;
                        break;
                    }

                case PlaybackState.Playing:
                    {
                        playSongToolStripMenuItem.Enabled = true;
                        playSongToolStripMenuItem.Text = @"Pause";
                        stopToolStripMenuItem.Enabled = true;
                        break;
                    }

                case PlaybackState.Paused:
                    {
                        playSongToolStripMenuItem.Enabled = true;
                        stopToolStripMenuItem.Enabled = true;
                        playSongToolStripMenuItem.Text = @"Play";
                        break;
                    }

                default:
                    {
                        throw new ArgumentOutOfRangeException();
                    }
            }
        }

        /// <summary>Occurs when the song completed.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void AudioController1_SongCompleted(object sender, EventArgs e)
        {
            UpdateCollectionsCount();
        }

        /// <summary>The check for update item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/daveit1000/MOT/releases");
        }

        /// <summary>Clear history click event.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ClearHistory_Click(object sender, EventArgs e)
        {
            lvHistory.Items.Clear();
            UpdateCollectionsCount();
        }

        /// <summary>Clear up next click event.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvUpNext.Items.Clear();
            UpdateCollectionsCount();
        }

        /// <summary>Decrease the volume.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void DecreaseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioControllerHost.DecreaseVolume(10);
            muteToolStripMenuItem.Checked = false;
        }

        /// <summary>Delete playlist.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbPlaylists.Items.RemoveAt(lbPlaylists.SelectedIndex);
            UpdatePlayListsMenu();
        }

        /// <summary>Help menu item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/daveit1000/MOT/wiki");
        }

        /// <summary>Occurs when the history item mouse hovers.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void History_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            historyHoverItemIndex = e.Item.Index;
        }

        /// <summary>The lists mouse click event..</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void History_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (historyHoverItemIndex > -1)
                {
                    toolStripMenuItemRemove.Enabled = true;
                    toolStripMenuItemClear.Enabled = true;
                }
                else
                {
                    toolStripMenuItemRemove.Enabled = false;
                    toolStripMenuItemClear.Enabled = false;
                }
            }
        }

        /// <summary>Imports the file to the music library.</summary>
        /// <param name="files">The file to import.</param>
        private void ImportMusic(IEnumerable<string> files)
        {
            var importList = files.ToList();
            if (importList.ToList().Count == 0)
            {
                Debug.WriteLine("No files to import.");
                return;
            }

            foreach (string fileName in importList.ToList().ToList())
            {
                ListViewItem item = ListManager.CreateItem(fileName);

                // Prevents the user from adding duplicates.
                if (!lvLibrary.Items.Contains(item))
                {
                    lvLibrary.Items.Add(item);
                }
            }

            if (lvLibrary.Items.Count > 0)
            {
                lvLibrary.FocusedItem = lvLibrary.Items[0];
                lvLibrary.Items[0].Selected = true;
                lvLibrary.Select();
                lvLibrary.EnsureVisible(0);
            }

            UpdateCollectionsCount();
        }

        /// <summary>Increase the volume.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void IncreaseVolumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioControllerHost.IncreaseVolume(10);
            muteToolStripMenuItem.Checked = false;
        }

        /// <summary>Occurs when the library item mouse hovers.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void Library_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            libraryHoverItemIndex = e.Item.Index;
        }

        /// <summary>The lists mouse click event..</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void Library_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (libraryHoverItemIndex > -1)
                {
                    playSongToolStripMenuItem.Enabled = true;
                    addToUpNextToolStripMenuItem.Enabled = true;
                    addToPlaylistToolStripMenuItem.Enabled = true;
                    openDirectoryToolStripMenuItem.Enabled = true;
                    songInfoToolStripMenuItem.Enabled = true;
                }
                else
                {
                    playSongToolStripMenuItem.Enabled = false;
                    addToUpNextToolStripMenuItem.Enabled = false;
                    addToPlaylistToolStripMenuItem.Enabled = false;
                    openDirectoryToolStripMenuItem.Enabled = false;
                    songInfoToolStripMenuItem.Enabled = false;
                }
            }
        }

        /// <summary>Occurs when the library was double clicked.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void Library_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lvLibrary.SelectedItems[0].Index;
            string path = lvLibrary.GetFilePath(index);
            audioControllerHost.PlaySong(path);
        }

        /// <summary>Load playlist.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Load playlist supported file types.
            UpdatePlayListsMenu();
        }

        /// <summary>The main application load.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void Main_Load(object sender, EventArgs e)
        {
            UpdateStatus("Initializing MOT...");

#if !DEBUG

// Show developer logging.
            tabController.TabPages[tabController.TabPages.Count - 1].Dispose();
#endif
            stopToolStripMenuItem.Enabled = false;
            playToolStripMenuItem.Enabled = false;
            nextToolStripMenuItem.Enabled = false;
            previousToolStripMenuItem.Enabled = false;

            lbPlaylists.SelectedIndex = 0;
            tabController.SelectedIndex = 0;

            historyHoverItemIndex = -1;
            libraryHoverItemIndex = -1;
            upNextHoverItemIndex = -1;

            audioControllerHost.Library = lvLibrary;
            audioControllerHost.UpNext = lvUpNext;
            audioControllerHost.History = lvHistory;

            audioControllerHost.SongCompleted += AudioController1_SongCompleted;
            audioControllerHost.PlayButtonClick += AudioController_PlayButtonClick;

            UpdateCollectionsCount();
            UpdatePlayListsMenu();

            UpdateStatus("Ready to Rock!");
        }

        /// <summary>Mute the volume.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void MuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioControllerHost.ToggleMute();
        }

        /// <summary>Next song item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void NextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioControllerHost.NextSong();
            UpdateCollectionsCount();
        }

        /// <summary>Open directory item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void OpenDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = lvLibrary.GetFilePath(lvLibrary.SelectedIndices[0]);
            string directoryName = Path.GetDirectoryName(filePath);

            if (Directory.Exists(directoryName))
            {
                Process.Start(directoryName);
            }
        }

        /// <summary>Open file.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var files = DialogManager.LoadMusicFileBrowser();
            ImportMusic(files);
        }

        /// <summary>The button load folder.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string musicFolder = DialogManager.LoadMusicFolderBrowser();
            var libraryList = FileManager.LoadMusicFiles(musicFolder);

            if (libraryList.Count != 0)
            {
                ImportMusic(libraryList);
            }
            else
            {
                UpdateStatus("No music files found.");
            }
        }

        /// <summary>Toggle playlist view.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void PlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playlistToolStripMenuItem.Checked)
            {
                tlpMain.ColumnStyles[0].Width = defaultPlaylistWidth;
            }
            else
            {
                tlpMain.ColumnStyles[0].Width = 0;
            }
        }

        /// <summary>TogglePlayState menu item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void PlaySongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lvLibrary.SelectedItems[0].Index;
            string path = lvLibrary.GetFilePath(index);
            audioControllerHost.PlaySong(path);
        }

        /// <summary>TogglePlayState music.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = lvLibrary.SelectedItems[0].Index;
            string path = lvLibrary.GetFilePath(index);
            audioControllerHost.TogglePlayState(path);

            if (audioControllerHost.Playing)
            {
                stopToolStripMenuItem.Enabled = true;
                playToolStripMenuItem.Text = @"Pause";
            }
            else
            {
                stopToolStripMenuItem.Enabled = false;
                playToolStripMenuItem.Text = @"Play";
            }
        }

        /// <summary>Previous song item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void PreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioControllerHost.PreviousSong();
            UpdateCollectionsCount();
        }

        /// <summary>Quit the application.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Remove history item click event.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void RemoveHistoryItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvHistory.SelectedItems)
            {
                lvHistory.Items.Remove(item);
            }

            UpdateCollectionsCount();
        }

        /// <summary>Remove item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvUpNext.SelectedItems)
            {
                lvUpNext.Items.Remove(item);
            }

            UpdateCollectionsCount();
        }

        /// <summary>Rename playlist item.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string itemText = lbPlaylists.GetItemText(lbPlaylists.SelectedItem);

            InputDialog renamePlaylist = new InputDialog("Rename playlist", itemText, "New playlist name");
            DialogResult dialogResult = renamePlaylist.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                lbPlaylists.Items[lbPlaylists.SelectedIndex] = renamePlaylist.InputResult;
                UpdatePlayListsMenu();
            }
        }

        /// <summary>Song info properties dialog.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void SongInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = lvLibrary.GetFilePath(lvLibrary.SelectedIndices[0]);
                PropertiesDialog.Show(filePath);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        /// <summary>Stop any playing music.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioControllerHost.Stop();
            stopToolStripMenuItem.Enabled = false;
            playToolStripMenuItem.Text = @"Play";
        }

        /// <summary>Update the collections count.</summary>
        private void UpdateCollectionsCount()
        {
            if ((lvLibrary.Items.Count > 0) || (lvUpNext.Items.Count > 0))
            {
                audioControllerHost.PlayButtonEnabled = true;
                playToolStripMenuItem.Enabled = true;
            }
            else
            {
                audioControllerHost.PlayButtonEnabled = false;
                playToolStripMenuItem.Enabled = false;
            }

            if (lvUpNext.Items.Count > 0)
            {
                nextToolStripMenuItem.Enabled = true;
            }
            else
            {
                nextToolStripMenuItem.Enabled = false;
            }

            if (lvHistory.Items.Count > 0)
            {
                previousToolStripMenuItem.Enabled = true;
            }
            else
            {
                previousToolStripMenuItem.Enabled = false;
            }

            string library = $@"Library ({lvLibrary.Items.Count})";
            string upNext = $@"Up Next ({lvUpNext.Items.Count})";
            string history = $@"History ({lvHistory.Items.Count})";

            if (tabController.TabPages[0].InvokeRequired)
            {
                tabController.TabPages[0].Invoke(new MethodInvoker(delegate
                    {
                        tabController.TabPages[0].Text = library;
                    }));
            }
            else
            {
                tabController.TabPages[0].Text = library;
            }

            if (tabController.TabPages[1].InvokeRequired)
            {
                tabController.TabPages[1].Invoke(new MethodInvoker(delegate
                    {
                        tabController.TabPages[1].Text = upNext;
                    }));
            }
            else
            {
                tabController.TabPages[1].Text = upNext;
            }

            if (tabController.TabPages[2].InvokeRequired)
            {
                tabController.TabPages[2].Invoke(new MethodInvoker(delegate
                    {
                        tabController.TabPages[2].Text = history;
                    }));
            }
            else
            {
                tabController.TabPages[2].Text = history;
            }
        }

        /// <summary>Updates the right-click play lists menu.</summary>
        private void UpdatePlayListsMenu()
        {
            addToPlaylistToolStripMenuItem.DropDownItems.Clear();

            foreach (string playListItem in lbPlaylists.Items)
            {
                addToPlaylistToolStripMenuItem.DropDownItems.Add(playListItem);
            }
        }

        /// <summary>Update the status.</summary>
        /// <param name="text">The text.</param>
        private void UpdateStatus(string text)
        {
            string formattedText = $"{DateTime.Now.ToLongTimeString()}: {text}";
            tsslStatus.Text = $@"Status: {text}";
            rtbLog.Text += formattedText + Environment.NewLine;
        }

        /// <summary>Occurs when the up next item mouse hovers.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void UpNext_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            upNextHoverItemIndex = e.Item.Index;
        }

        /// <summary>The lists mouse click event..</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void UpNext_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (upNextHoverItemIndex > -1)
                {
                    removeToolStripMenuItem.Enabled = true;
                    clearToolStripMenuItem.Enabled = true;
                }
                else
                {
                    removeToolStripMenuItem.Enabled = false;
                    clearToolStripMenuItem.Enabled = false;
                }
            }
        }

        #endregion
    }
}