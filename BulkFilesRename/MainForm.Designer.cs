namespace BulkFilesRename
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemplate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numStartFrom = new System.Windows.Forms.NumericUpDown();
            this.fileList = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previewList = new System.Windows.Forms.DataGridView();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numStartFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag and drop files here:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preview:";
            // 
            // txtTemplate
            // 
            this.txtTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTemplate.Location = new System.Drawing.Point(60, 494);
            this.txtTemplate.Name = "txtTemplate";
            this.txtTemplate.Size = new System.Drawing.Size(249, 20);
            this.txtTemplate.TabIndex = 4;
            this.txtTemplate.Text = "FileName{1}.ext";
            this.txtTemplate.TextChanged += new System.EventHandler(this.txtTemplate_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format:";
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(696, 492);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start From:";
            // 
            // numStartFrom
            // 
            this.numStartFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numStartFrom.Location = new System.Drawing.Point(379, 495);
            this.numStartFrom.Name = "numStartFrom";
            this.numStartFrom.Size = new System.Drawing.Size(88, 20);
            this.numStartFrom.TabIndex = 9;
            this.numStartFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartFrom.ValueChanged += new System.EventHandler(this.numStartFrom_ValueChanged);
            // 
            // fileList
            // 
            this.fileList.AllowDrop = true;
            this.fileList.AllowUserToAddRows = false;
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName});
            this.fileList.Location = new System.Drawing.Point(12, 31);
            this.fileList.Name = "fileList";
            this.fileList.ReadOnly = true;
            this.fileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileList.Size = new System.Drawing.Size(361, 453);
            this.fileList.TabIndex = 10;
            this.fileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.filesList_DragDrop);
            this.fileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileList_DragEnter);
            this.fileList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fileList_KeyUp);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "Files";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // previewList
            // 
            this.previewList.AllowUserToAddRows = false;
            this.previewList.AllowUserToDeleteRows = false;
            this.previewList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.previewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NewName});
            this.previewList.Location = new System.Drawing.Point(388, 31);
            this.previewList.Name = "previewList";
            this.previewList.ReadOnly = true;
            this.previewList.Size = new System.Drawing.Size(383, 453);
            this.previewList.TabIndex = 11;
            // 
            // NewName
            // 
            this.NewName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NewName.DataPropertyName = "NewName";
            this.NewName.HeaderText = "New Name";
            this.NewName.Name = "NewName";
            this.NewName.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 527);
            this.Controls.Add(this.previewList);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.numStartFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Bulk Files Rename";
            ((System.ComponentModel.ISupportInitialize)(this.numStartFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numStartFrom;
        private System.Windows.Forms.DataGridView fileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridView previewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
    }
}

