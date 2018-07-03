#region Namespace

using System;
using System.ComponentModel;
using System.Windows.Forms;

#endregion

namespace MOT.Controls
{
    public class MusicListView : ListView
    {
        #region Variables

        private ColumnHeader durationHeader;
        private ColumnHeader pathHeader;
        private ColumnHeader sizeHeader;
        private ColumnHeader titleHeader;

        #endregion

        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="MusicListView" /> class.</summary>
        public MusicListView()
        {
            BorderStyle = BorderStyle.None;
            GridLines = true;
            FullRowSelect = true;
            HeaderStyle = ColumnHeaderStyle.Nonclickable;
            HideSelection = false;
            MultiSelect = true;
            View = View.Details;

            titleHeader = new ColumnHeader
                {
                    Text = @"File Name",
                    Width = 200
                };

            durationHeader = new ColumnHeader
                {
                    Text = @"Duration",
                    Width = 80
                };

            sizeHeader = new ColumnHeader
                {
                    Text = @"Size",
                    Width = 80
                };

            pathHeader = new ColumnHeader
                {
                    Text = @"Path",
                    Width = 350
                };

            Columns.Add(titleHeader);
            Columns.Add(durationHeader);
            Columns.Add(sizeHeader);
            Columns.Add(pathHeader);
        }

        #endregion

        #region Properties

        /// <summary>Retrieves a value determining whether the list view has an item selected.</summary>
        [Browsable(false)]
        public bool ItemSelected
        {
            get
            {
                return (Items.Count > 0) && (SelectedItems.Count > 0);
            }
        }

        #endregion

        #region Methods

        /// <summary>Retrieves the path of the column.</summary>
        /// <param name="index">The column.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string GetFilePath(int index)
        {
            if ((index > Items.Count) || (index < 0))
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            return Items[index].SubItems[pathHeader.Index].Text;
        }

        #endregion
    }
}