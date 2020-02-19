using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public interface IMainForm
    {
        string FilePath { get;  }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            butOpenFile.Click += ButOpenFile_Click;
            butsavetext.Click += Butsavetext_Click;
            butSelectFile.Click += butSelectFile_Click;
            fieldContent.TextChanged += FieldContent_TextChanged;
            numFont.ValueChanged += numFont_ValueChanged;
        }
        #region Event
        private void FieldContent_TextChanged(object sender, EventArgs e)
        {
            if (ContentChanged != null) ContentChanged(this, EventArgs.Empty);
        }

        private void Butsavetext_Click(object sender, EventArgs e)
        {
            if (FileSaveClick != null) FileSaveClick(this, EventArgs.Empty);

        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
        }
         #endregion Event
        public string FilePath
        {
            get { return fdfilepath.Text; }
        }
        public string Content
        {
            get { return fieldContent.Text; }
            set { fieldContent.Text = value; }
        }
        public void SetSymbolCount(int count)
        {
            lbsumb.Text = count.ToString();
        }
       public event EventHandler FileOpenClick;
       public event EventHandler FileSaveClick;
       public event EventHandler ContentChanged;
        private void butSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text file|*.txt|All file|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fdfilepath.Text = dlg.FileName;
                if (FileOpenClick != null) FileOpenClick(this, EventArgs.Empty);
            }
        }
        private void numFont_ValueChanged(object sender, EventArgs e)
        {
            fieldContent.Font = new Font("Calibri", (float)numFont.Value);
        }
    }
}
