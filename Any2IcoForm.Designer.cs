
namespace Any2Ico
{
    partial class Any2IcoForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Any2IcoForm));
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.OpenFolderBtn = new System.Windows.Forms.Button();
            this.OriginalFileList = new System.Windows.Forms.CheckedListBox();
            this.ConvertFileListBox = new System.Windows.Forms.ListBox();
            this.ConvertActionBtn = new System.Windows.Forms.Button();
            this.ConvertProgress = new System.Windows.Forms.ProgressBar();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SelectAllBtn = new System.Windows.Forms.Button();
            this.SavePathBox = new System.Windows.Forms.TextBox();
            this.SaveFolderBtn = new System.Windows.Forms.Button();
            this.DeselectBtn = new System.Windows.Forms.Button();
            this.IconSize = new System.Windows.Forms.ComboBox();
            this.extType = new System.Windows.Forms.ComboBox();
            this.tp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenFileBtn.Location = new System.Drawing.Point(10, 16);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(64, 23);
            this.OpenFileBtn.TabIndex = 1;
            this.OpenFileBtn.Text = "OpenFile";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // OpenFolderBtn
            // 
            this.OpenFolderBtn.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OpenFolderBtn.Location = new System.Drawing.Point(80, 16);
            this.OpenFolderBtn.Name = "OpenFolderBtn";
            this.OpenFolderBtn.Size = new System.Drawing.Size(80, 23);
            this.OpenFolderBtn.TabIndex = 2;
            this.OpenFolderBtn.Text = "OpenFolder";
            this.OpenFolderBtn.UseVisualStyleBackColor = true;
            this.OpenFolderBtn.Click += new System.EventHandler(this.OpenFolderBtn_Click);
            // 
            // OriginalFileList
            // 
            this.OriginalFileList.CheckOnClick = true;
            this.OriginalFileList.FormattingEnabled = true;
            this.OriginalFileList.Location = new System.Drawing.Point(10, 51);
            this.OriginalFileList.Name = "OriginalFileList";
            this.OriginalFileList.Size = new System.Drawing.Size(258, 292);
            this.OriginalFileList.TabIndex = 5;
            this.OriginalFileList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OriginalFileList_ItemCheck);
            this.OriginalFileList.SelectedIndexChanged += new System.EventHandler(this.OriginalFileList_SelectedIndexChanged);
            // 
            // ConvertFileListBox
            // 
            this.ConvertFileListBox.FormattingEnabled = true;
            this.ConvertFileListBox.ItemHeight = 14;
            this.ConvertFileListBox.Location = new System.Drawing.Point(353, 79);
            this.ConvertFileListBox.Name = "ConvertFileListBox";
            this.ConvertFileListBox.Size = new System.Drawing.Size(266, 270);
            this.ConvertFileListBox.TabIndex = 4;
            this.ConvertFileListBox.SelectedIndexChanged += new System.EventHandler(this.ConvertFileListBox_SelectedIndexChanged);
            // 
            // ConvertActionBtn
            // 
            this.ConvertActionBtn.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvertActionBtn.Location = new System.Drawing.Point(278, 223);
            this.ConvertActionBtn.Name = "ConvertActionBtn";
            this.ConvertActionBtn.Size = new System.Drawing.Size(64, 23);
            this.ConvertActionBtn.TabIndex = 6;
            this.ConvertActionBtn.Text = "Convert";
            this.ConvertActionBtn.UseVisualStyleBackColor = true;
            this.ConvertActionBtn.Click += new System.EventHandler(this.ConvertActionBtn_Click);
            // 
            // ConvertProgress
            // 
            this.ConvertProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConvertProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ConvertProgress.Location = new System.Drawing.Point(225, 76);
            this.ConvertProgress.Name = "ConvertProgress";
            this.ConvertProgress.Size = new System.Drawing.Size(171, 2);
            this.ConvertProgress.TabIndex = 7;
            this.ConvertProgress.Visible = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(434, 16);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "All Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(353, 16);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SelectAllBtn
            // 
            this.SelectAllBtn.Location = new System.Drawing.Point(164, 16);
            this.SelectAllBtn.Name = "SelectAllBtn";
            this.SelectAllBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectAllBtn.TabIndex = 10;
            this.SelectAllBtn.Text = "Select All";
            this.SelectAllBtn.UseVisualStyleBackColor = true;
            this.SelectAllBtn.Click += new System.EventHandler(this.SelectAllBtn_Click);
            // 
            // SavePathBox
            // 
            this.SavePathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SavePathBox.CausesValidation = false;
            this.SavePathBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.SavePathBox.Location = new System.Drawing.Point(353, 51);
            this.SavePathBox.Name = "SavePathBox";
            this.SavePathBox.ReadOnly = true;
            this.SavePathBox.Size = new System.Drawing.Size(264, 21);
            this.SavePathBox.TabIndex = 11;
            this.SavePathBox.Text = "Save Path";
            this.SavePathBox.WordWrap = false;
            // 
            // SaveFolderBtn
            // 
            this.SaveFolderBtn.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveFolderBtn.Location = new System.Drawing.Point(537, 16);
            this.SaveFolderBtn.Name = "SaveFolderBtn";
            this.SaveFolderBtn.Size = new System.Drawing.Size(80, 23);
            this.SaveFolderBtn.TabIndex = 3;
            this.SaveFolderBtn.Text = "SaveFolder";
            this.SaveFolderBtn.UseVisualStyleBackColor = true;
            this.SaveFolderBtn.Click += new System.EventHandler(this.SaveFolderBtn_Click);
            // 
            // DeselectBtn
            // 
            this.DeselectBtn.Location = new System.Drawing.Point(245, 16);
            this.DeselectBtn.Name = "DeselectBtn";
            this.DeselectBtn.Size = new System.Drawing.Size(75, 23);
            this.DeselectBtn.TabIndex = 12;
            this.DeselectBtn.Text = "Deselect";
            this.DeselectBtn.UseVisualStyleBackColor = true;
            this.DeselectBtn.Click += new System.EventHandler(this.DeselectBtn_Click);
            // 
            // IconSize
            // 
            this.IconSize.FormattingEnabled = true;
            this.IconSize.Location = new System.Drawing.Point(278, 51);
            this.IconSize.Name = "IconSize";
            this.IconSize.Size = new System.Drawing.Size(64, 22);
            this.IconSize.TabIndex = 13;
            // 
            // extType
            // 
            this.extType.FormattingEnabled = true;
            this.extType.Location = new System.Drawing.Point(278, 91);
            this.extType.Name = "extType";
            this.extType.Size = new System.Drawing.Size(64, 22);
            this.extType.TabIndex = 14;
            // 
            // tp
            // 
            this.tp.AutoSize = true;
            this.tp.Location = new System.Drawing.Point(278, 178);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(56, 18);
            this.tp.TabIndex = 15;
            this.tp.Text = "Clear";
            this.tp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "White\r\nTransparent";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Any2IcoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.extType);
            this.Controls.Add(this.IconSize);
            this.Controls.Add(this.DeselectBtn);
            this.Controls.Add(this.SavePathBox);
            this.Controls.Add(this.SelectAllBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ConvertProgress);
            this.Controls.Add(this.ConvertActionBtn);
            this.Controls.Add(this.OriginalFileList);
            this.Controls.Add(this.ConvertFileListBox);
            this.Controls.Add(this.SaveFolderBtn);
            this.Controls.Add(this.OpenFolderBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Any2IcoForm";
            this.Text = "Any Image to ICO";
            this.Load += new System.EventHandler(this.Any2IcoForm_Load);
            this.LocationChanged += new System.EventHandler(this.Any2IcoForm_LocationChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button OpenFolderBtn;
        public System.Windows.Forms.CheckedListBox OriginalFileList;
        private System.Windows.Forms.ListBox ConvertFileListBox;
        private System.Windows.Forms.Button ConvertActionBtn;
        private System.Windows.Forms.ProgressBar ConvertProgress;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SelectAllBtn;
        private System.Windows.Forms.TextBox SavePathBox;
        private System.Windows.Forms.Button SaveFolderBtn;
        private System.Windows.Forms.Button DeselectBtn;
        private System.Windows.Forms.ComboBox IconSize;
        private System.Windows.Forms.ComboBox extType;
        private System.Windows.Forms.CheckBox tp;
        private System.Windows.Forms.Label label1;
    }
}

