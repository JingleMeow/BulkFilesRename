using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkFilesRename
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.fileList.AutoGenerateColumns = false;
            this.previewList.AutoGenerateColumns = false;
            Helper.Template = this.txtTemplate.Text;
            Helper.StartingNumber = (int)this.numStartFrom.Value;
        }

        private void filesList_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                Helper.FileItems.Add(new FileItem(file));
            }
            Helper.FileItems = Helper.FileItems.OrderBy(fi => fi.FileName).ToList();
            this.fileList.DataSource = Helper.FileItems;
            this.previewList.DataSource = Helper.FileItems;
        }

        private void fileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void fileList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<int> toRemove = new List<int>();
                for (int i = 0; i < this.fileList.SelectedRows.Count; i++)
                {
                    var row = this.fileList.SelectedRows[i];
                    toRemove.Add(row.Index);
                }
                toRemove.Sort();
                for (int i = toRemove.Count - 1; i >= 0; i--)
                {
                    Helper.FileItems.RemoveAt(toRemove[i]);
                }

                this.fileList.DataSource = Helper.FileItems.ToList();
                this.previewList.DataSource = Helper.FileItems.ToList();
            }
        }

        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            Helper.Template = this.txtTemplate.Text;
            this.previewList.Refresh();
        }

        private void numStartFrom_ValueChanged(object sender, EventArgs e)
        {
            Helper.StartingNumber = (int)this.numStartFrom.Value;
            this.previewList.Refresh();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            foreach (var file in Helper.FileItems)
            {
                file.Rename();
            }
            this.fileList.Refresh();
            MessageBox.Show("All files renamed.", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
