namespace TekstEditor
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
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSadrzaj.Location = new System.Drawing.Point(3, 79);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(979, 879);
            this.txtSadrzaj.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(68, 42);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "&Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(228, 18);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 2;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(228, 49);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(100, 20);
            this.txtReplace.TabIndex = 3;
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(172, 21);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(27, 13);
            this.lblFind.TabIndex = 4;
            this.lblFind.Text = "Find";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(172, 52);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(47, 13);
            this.lblReplace.TabIndex = 5;
            this.lblReplace.Text = "Replace";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(368, 18);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(72, 51);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "&Find and replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZavrsi.Location = new System.Drawing.Point(687, 22);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(81, 42);
            this.btnZavrsi.TabIndex = 7;
            this.btnZavrsi.Text = "&Zavrsi program";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(518, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Snimi fajl (Save As...)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnZavrsi;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtSadrzaj);
            this.MinimumSize = new System.Drawing.Size(1000, 400);
            this.Name = "Form1";
            this.Text = "Marko Lazarevic s11-18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

