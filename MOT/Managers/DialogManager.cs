#region Namespace

using System;
using System.Windows.Forms;

using MOT.Structure;

#endregion

namespace MOT.Managers
{
    internal class DialogManager
    {
        #region Methods

        /// <summary>Loads the music file browser.</summary>
        /// <returns>The <see cref="string" />.</returns>
        public static string[] LoadMusicFileBrowser()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        Title = @"Open file/s",
                        Multiselect = true,
                        FileName = string.Empty,
                        Filter = Extension.SupportedExtensionFilter()
                    };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileNames;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return null;
            }
        }

        /// <summary>Launch the music folder browse dialog.</summary>
        /// <param name="rootFolder">The root folder where the browsing starts from.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string LoadMusicFolderBrowser(Environment.SpecialFolder rootFolder = Environment.SpecialFolder.MyComputer)
        {
            string selectedPath;

            using (FolderBrowserDialog musicFolderDialog = new FolderBrowserDialog { RootFolder = rootFolder })
            {
                selectedPath = string.Empty;

                if (musicFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = musicFolderDialog.SelectedPath;
                }
            }

            return selectedPath;
        }

        #endregion
    }
}