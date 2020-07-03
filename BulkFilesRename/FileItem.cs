using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkFilesRename
{
    class FileItem
    {
        private readonly FileInfo file;

        public FileItem(string filePath)
        {
            this.file = new FileInfo(filePath);
        }

        public string FileName
        {
            get
            {
                return file.Name;
            }
        }

        public string NewName
        {
            get
            {
                return Helper.GetNewName(this);
            }
        }

        public void Rename()
        {
            this.file.MoveTo($@"{this.file.Directory.FullName}\{this.NewName}");
        }
    }
}
