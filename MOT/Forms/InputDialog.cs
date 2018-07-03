#region Namespace

using System;
using System.Windows.Forms;

#endregion

namespace MOT.Forms
{
    /// <summary>The input dialog.</summary>
    public partial class InputDialog : Form
    {
        #region Constructors

        /// <summary>Initializes a new instance of the <see cref="InputDialog" /> class.</summary>
        /// <param name="title">The window title.</param>
        /// <param name="text">The default text</param>
        /// <param name="watermarkText">The default watermark text.</param>
        public InputDialog(string title, string text, string watermarkText)
        {
            InitializeComponent();
            Text = title;
            tbInput.Text = text;
            tbInput.Watermark.Text = watermarkText;
        }

        #endregion

        #region Properties

        /// <summary>Gets the input string result.</summary>
        public string InputResult { get; private set; }

        #endregion

        #region Methods

        /// <summary>OK Button.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void BtOK_Click(object sender, EventArgs e)
        {
            InputResult = tbInput.Text;
            DialogResult = DialogResult.OK;
        }

        /// <summary>Input Text Changed Event.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event args.</param>
        private void TbInput_TextChanged(object sender, EventArgs e)
        {
            btOK.Enabled = tbInput.Text.Length > 0;
        }

        #endregion
    }
}