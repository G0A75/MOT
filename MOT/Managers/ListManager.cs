﻿#region Namespace

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

using MOT.Structure;

#endregion

namespace MOT.Managers
{
    internal class ListManager
    {
        #region Methods

        /// <summary>Creates the list item.</summary>
        /// <param name="file">The file.</param>
        /// <returns>The <see cref="ListViewItem" />.</returns>
        public static ListViewItem CreateItem(string file)
        {
            if (string.IsNullOrEmpty(file))
            {
                throw new NoNullAllowedException(nameof(file));
            }

            if (!File.Exists(file))
            {
                throw new FileNotFoundException(nameof(file));
            }

            FileInfo fileInfo = new FileInfo(file);

            ListViewItem item = new ListViewItem
                    {
                       Text = Path.GetFileNameWithoutExtension(fileInfo.FullName) 
                    };

            TimeSpan duration = MusicManager.GetSongDuration(fileInfo);

            ListViewItem.ListViewSubItem durationItem = new ListViewItem.ListViewSubItem
                    {
                       Text = MusicManager.FormatTimeSpan(duration) 
                    };

            ListViewItem.ListViewSubItem sizeItem = new ListViewItem.ListViewSubItem();
            Bytes fileSize = new Bytes(fileInfo.FullName)
                    {
                       Abbreviated = true 
                    };
            sizeItem.Text = fileSize.ToString();

            ListViewItem.ListViewSubItem pathItem = new ListViewItem.ListViewSubItem
                    {
                       Text = fileInfo.FullName 
                    };

            item.SubItems.Add(durationItem);
            item.SubItems.Add(sizeItem);
            item.SubItems.Add(pathItem);

            return item;
        }

        #endregion
    }
}