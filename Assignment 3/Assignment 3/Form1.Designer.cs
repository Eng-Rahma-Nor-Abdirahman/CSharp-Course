namespace FileManagementSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.grpFileOperation = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpFileContents = new System.Windows.Forms.GroupBox();
            this.lstFileContents = new System.Windows.Forms.ListBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.grpFileOperation.SuspendLayout();
            this.grpFileContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(-3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(928, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Management system ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnterText
            // 
            this.lblEnterText.AutoSize = true;
            this.lblEnterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterText.Location = new System.Drawing.Point(12, 62);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(165, 25);
            this.lblEnterText.TabIndex = 1;
            this.lblEnterText.Text = "ENTER TEXT : ";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 90);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(899, 108);
            this.txtContent.TabIndex = 2;
            // 
            // grpFileOperation
            // 
            this.grpFileOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpFileOperation.Controls.Add(this.btnOpen);
            this.grpFileOperation.Controls.Add(this.btnAppend);
            this.grpFileOperation.Controls.Add(this.btnClear);
            this.grpFileOperation.Controls.Add(this.btnDelete);
            this.grpFileOperation.Controls.Add(this.btnRead);
            this.grpFileOperation.Controls.Add(this.btnCreate);
            this.grpFileOperation.Location = new System.Drawing.Point(12, 223);
            this.grpFileOperation.Name = "grpFileOperation";
            this.grpFileOperation.Size = new System.Drawing.Size(224, 378);
            this.grpFileOperation.TabIndex = 3;
            this.grpFileOperation.TabStop = false;
            this.grpFileOperation.Text = "File Operations";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SlateGray;
            this.btnClear.Location = new System.Drawing.Point(19, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 51);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear File";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(19, 259);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 51);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete File";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRead.Location = new System.Drawing.Point(19, 88);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(166, 51);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.Location = new System.Drawing.Point(19, 31);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(166, 51);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "create File";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // grpFileContents
            // 
            this.grpFileContents.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpFileContents.Controls.Add(this.lstFileContents);
            this.grpFileContents.Location = new System.Drawing.Point(268, 219);
            this.grpFileContents.Name = "grpFileContents";
            this.grpFileContents.Size = new System.Drawing.Size(643, 344);
            this.grpFileContents.TabIndex = 4;
            this.grpFileContents.TabStop = false;
            this.grpFileContents.Text = "File Contents";
            // 
            // lstFileContents
            // 
            this.lstFileContents.FormattingEnabled = true;
            this.lstFileContents.ItemHeight = 16;
            this.lstFileContents.Items.AddRange(new object[] {
            "file contents will appear here"});
            this.lstFileContents.Location = new System.Drawing.Point(17, 23);
            this.lstFileContents.Name = "lstFileContents";
            this.lstFileContents.Size = new System.Drawing.Size(607, 308);
            this.lstFileContents.TabIndex = 0;
            // 
            // btnAppend
            // 
            this.btnAppend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAppend.Location = new System.Drawing.Point(19, 202);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(166, 51);
            this.btnAppend.TabIndex = 7;
            this.btnAppend.Text = "Append  File";
            this.btnAppend.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.SlateGray;
            this.btnOpen.Location = new System.Drawing.Point(19, 145);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(166, 51);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 628);
            this.Controls.Add(this.grpFileContents);
            this.Controls.Add(this.grpFileOperation);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblEnterText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpFileOperation.ResumeLayout(false);
            this.grpFileContents.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnterText;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.GroupBox grpFileOperation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFileContents;
        private System.Windows.Forms.ListBox lstFileContents;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnOpen;
    }
}

