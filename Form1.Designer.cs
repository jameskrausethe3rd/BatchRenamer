
namespace BatchRenamer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_OpenFolder = new System.Windows.Forms.Button();
            this.folderSeasonPrefix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileEpisodePrefix = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_userSelection = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.startSeasonNumber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fileExtension = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.showName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fileSeasonPrefix = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_OpenFolder
            // 
            this.btn_OpenFolder.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenFolder.Location = new System.Drawing.Point(12, 12);
            this.btn_OpenFolder.Name = "btn_OpenFolder";
            this.btn_OpenFolder.Size = new System.Drawing.Size(153, 39);
            this.btn_OpenFolder.TabIndex = 0;
            this.btn_OpenFolder.Text = "Open Folder";
            this.btn_OpenFolder.UseVisualStyleBackColor = true;
            this.btn_OpenFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderSeasonPrefix
            // 
            this.folderSeasonPrefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderSeasonPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.folderSeasonPrefix.FormattingEnabled = true;
            this.folderSeasonPrefix.Items.AddRange(new object[] {
            "S",
            "Series",
            "Season"});
            this.folderSeasonPrefix.Location = new System.Drawing.Point(12, 285);
            this.folderSeasonPrefix.Name = "folderSeasonPrefix";
            this.folderSeasonPrefix.Size = new System.Drawing.Size(246, 32);
            this.folderSeasonPrefix.TabIndex = 1;
            this.folderSeasonPrefix.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder Season Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Episode Prefix";
            // 
            // fileEpisodePrefix
            // 
            this.fileEpisodePrefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileEpisodePrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fileEpisodePrefix.FormattingEnabled = true;
            this.fileEpisodePrefix.Items.AddRange(new object[] {
            "E",
            "Episode"});
            this.fileEpisodePrefix.Location = new System.Drawing.Point(13, 433);
            this.fileEpisodePrefix.Name = "fileEpisodePrefix";
            this.fileEpisodePrefix.Size = new System.Drawing.Size(246, 32);
            this.fileEpisodePrefix.TabIndex = 4;
            this.fileEpisodePrefix.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selected Folder:";
            // 
            // lbl_userSelection
            // 
            this.lbl_userSelection.AutoSize = true;
            this.lbl_userSelection.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userSelection.Location = new System.Drawing.Point(149, 63);
            this.lbl_userSelection.Name = "lbl_userSelection";
            this.lbl_userSelection.Size = new System.Drawing.Size(216, 22);
            this.lbl_userSelection.TabIndex = 6;
            this.lbl_userSelection.Text = "Please make a selection";
            // 
            // btn_rename
            // 
            this.btn_rename.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rename.Location = new System.Drawing.Point(180, 12);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(153, 39);
            this.btn_rename.TabIndex = 7;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.btn_rename_Click);
            // 
            // startSeasonNumber
            // 
            this.startSeasonNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSeasonNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startSeasonNumber.FormattingEnabled = true;
            this.startSeasonNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.startSeasonNumber.Location = new System.Drawing.Point(12, 141);
            this.startSeasonNumber.Name = "startSeasonNumber";
            this.startSeasonNumber.Size = new System.Drawing.Size(246, 32);
            this.startSeasonNumber.TabIndex = 8;
            this.startSeasonNumber.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Starting Season Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rename files with extension:";
            // 
            // fileExtension
            // 
            this.fileExtension.Enabled = false;
            this.fileExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fileExtension.FormattingEnabled = true;
            this.fileExtension.Location = new System.Drawing.Point(13, 212);
            this.fileExtension.Name = "fileExtension";
            this.fileExtension.Size = new System.Drawing.Size(245, 32);
            this.fileExtension.TabIndex = 11;
            this.fileExtension.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preview:";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeView1.Location = new System.Drawing.Point(284, 141);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(386, 176);
            this.treeView1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Show Name";
            // 
            // showName
            // 
            this.showName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.showName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.showName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.showName.Location = new System.Drawing.Point(12, 503);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(246, 29);
            this.showName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "File Season Prefix";
            // 
            // fileSeasonPrefix
            // 
            this.fileSeasonPrefix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSeasonPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fileSeasonPrefix.FormattingEnabled = true;
            this.fileSeasonPrefix.Items.AddRange(new object[] {
            "S",
            "Series",
            "Season"});
            this.fileSeasonPrefix.Location = new System.Drawing.Point(12, 359);
            this.fileSeasonPrefix.Name = "fileSeasonPrefix";
            this.fileSeasonPrefix.Size = new System.Drawing.Size(246, 32);
            this.fileSeasonPrefix.TabIndex = 17;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 547);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fileSeasonPrefix);
            this.Controls.Add(this.showName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fileExtension);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startSeasonNumber);
            this.Controls.Add(this.btn_rename);
            this.Controls.Add(this.lbl_userSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileEpisodePrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderSeasonPrefix);
            this.Controls.Add(this.btn_OpenFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenFolder;
        private System.Windows.Forms.ComboBox folderSeasonPrefix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fileEpisodePrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_userSelection;
        private System.Windows.Forms.Button btn_rename;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox startSeasonNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fileExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox showName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fileSeasonPrefix;
    }
}

