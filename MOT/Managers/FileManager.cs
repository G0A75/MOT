#region Namespace

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using MOT.Structure;

#endregion

namespace MOT.Managers
{
    internal class FileManager
    {
        #region Methods

        /// <summary>Retrieves all music files in the specified directory.</summary>
        /// <param name="directory">The directory to browse.</param>
        /// <param name="includeSubDirectories">Include searching sub directory.</param>
        /// <returns>The <see cref="FileInfo" />.</returns>
        public static List<string> LoadMusicFiles(string directory, bool includeSubDirectories = true)
        {
            return SearchDirectory(directory, Extension.SupportedExtensions(), includeSubDirectories).Select(file => file).ToList();
        }

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
                    // ignored
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

        #endregion
    }
}