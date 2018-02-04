namespace MOT
{
    #region Namespace

    using System;
    using System.Collections.Generic;
    using System.IO;
    using VisualPlus;

    #endregion

    internal class FileHelper
    {
        #region Events

        /// <summary>Searches the directory for files.</summary>
        /// <param name="directory">The directory to search.</param>
        /// <param name="extensionFilter">The extension filter.</param>
        /// <param name="includeSubDirectories">Include searching sub directory.</param>
        /// <returns>The List<see cref="string" />.</returns>
        public static IEnumerable<string> SearchDirectory(string directory, List<string> extensionFilter, bool includeSubDirectories = false)
        {
            if (string.IsNullOrEmpty(directory))
            {
                try
                {
                    throw new ArgumentNullException($"The {nameof(directory)} cannot be null or empty.");
                }
                catch
                {

                }
                
                }

            if (extensionFilter.Count == 0)
            {
                throw new ArgumentNullException($"The {nameof(extensionFilter)} cannot be empty.");
            }

            var _files = new List<string>();

            try
            {
                SearchOption _searchOption = !includeSubDirectories ? SearchOption.TopDirectoryOnly : SearchOption.AllDirectories;

                foreach (string _extension in extensionFilter)
                {
                    _files.AddRange(Directory.GetFiles(directory, _extension, _searchOption));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return _files;
        }

        /// <summary>Example usage.</summary>
        /*private void Usage()
        {
            var _extensions = new List<string>
                {
                    "*.mp3",
                    "*.mp4",
                    "*.wma"
                };
            
           // VisualListBox visualListBox1 = new VisualListBox();
           /// visualListBox1.Items.Clear();

            var _files = SearchDirectory(@"C:\Folder", _extensions, false);

            foreach (string _file in _files)
            {
              //  visualListBox1.Items.Add(_file);
            }
        }
        */
        #endregion
    }
}