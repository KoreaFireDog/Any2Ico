
namespace Any2Ico
{
    partial class ConvertView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertView));
            this.ConvertPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConvertPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertPreview
            // 
            this.ConvertPreview.Location = new System.Drawing.Point(2, 1);
            this.ConvertPreview.Name = "ConvertPreview";
            this.ConvertPreview.Size = new System.Drawing.Size(187, 186);
            this.ConvertPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ConvertPreview.TabIndex = 0;
            this.ConvertPreview.TabStop = false;
            // 
            // ConvertView
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(190, 188);
            this.Controls.Add(this.ConvertPreview);
            this.Font = new System.Drawing.Font("D2Coding", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertView";
            this.Text = "Convert View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConvertView_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ConvertPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ConvertPreview;
    }
}