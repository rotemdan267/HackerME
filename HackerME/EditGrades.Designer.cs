namespace HackerME
{
    partial class EditGrades
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDotNet = new System.Windows.Forms.Label();
            this.lblHTML = new System.Windows.Forms.Label();
            this.lblCSS = new System.Windows.Forms.Label();
            this.lblCore = new System.Windows.Forms.Label();
            this.lblOOP = new System.Windows.Forms.Label();
            this.txtDotNet = new System.Windows.Forms.TextBox();
            this.txtHTML = new System.Windows.Forms.TextBox();
            this.txtCSS = new System.Windows.Forms.TextBox();
            this.txtCore = new System.Windows.Forms.TextBox();
            this.txtOOP = new System.Windows.Forms.TextBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDotNet
            // 
            this.lblDotNet.AutoSize = true;
            this.lblDotNet.Location = new System.Drawing.Point(76, 79);
            this.lblDotNet.Name = "lblDotNet";
            this.lblDotNet.Size = new System.Drawing.Size(61, 15);
            this.lblDotNet.TabIndex = 0;
            this.lblDotNet.Text = ".NET Basic";
            // 
            // lblHTML
            // 
            this.lblHTML.AutoSize = true;
            this.lblHTML.Location = new System.Drawing.Point(76, 118);
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Size = new System.Drawing.Size(39, 15);
            this.lblHTML.TabIndex = 0;
            this.lblHTML.Text = "HTML";
            // 
            // lblCSS
            // 
            this.lblCSS.AutoSize = true;
            this.lblCSS.Location = new System.Drawing.Point(76, 151);
            this.lblCSS.Name = "lblCSS";
            this.lblCSS.Size = new System.Drawing.Size(27, 15);
            this.lblCSS.TabIndex = 0;
            this.lblCSS.Text = "CSS";
            // 
            // lblCore
            // 
            this.lblCore.AutoSize = true;
            this.lblCore.Location = new System.Drawing.Point(76, 189);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(32, 15);
            this.lblCore.TabIndex = 0;
            this.lblCore.Text = "Core";
            // 
            // lblOOP
            // 
            this.lblOOP.AutoSize = true;
            this.lblOOP.Location = new System.Drawing.Point(76, 226);
            this.lblOOP.Name = "lblOOP";
            this.lblOOP.Size = new System.Drawing.Size(32, 15);
            this.lblOOP.TabIndex = 0;
            this.lblOOP.Text = "OOP";
            // 
            // txtDotNet
            // 
            this.txtDotNet.Location = new System.Drawing.Point(151, 76);
            this.txtDotNet.Name = "txtDotNet";
            this.txtDotNet.Size = new System.Drawing.Size(46, 23);
            this.txtDotNet.TabIndex = 1;
            // 
            // txtHTML
            // 
            this.txtHTML.Location = new System.Drawing.Point(151, 115);
            this.txtHTML.Name = "txtHTML";
            this.txtHTML.Size = new System.Drawing.Size(46, 23);
            this.txtHTML.TabIndex = 1;
            // 
            // txtCSS
            // 
            this.txtCSS.Location = new System.Drawing.Point(151, 148);
            this.txtCSS.Name = "txtCSS";
            this.txtCSS.Size = new System.Drawing.Size(46, 23);
            this.txtCSS.TabIndex = 1;
            // 
            // txtCore
            // 
            this.txtCore.Location = new System.Drawing.Point(151, 186);
            this.txtCore.Name = "txtCore";
            this.txtCore.Size = new System.Drawing.Size(46, 23);
            this.txtCore.TabIndex = 1;
            // 
            // txtOOP
            // 
            this.txtOOP.Location = new System.Drawing.Point(151, 223);
            this.txtOOP.Name = "txtOOP";
            this.txtOOP.Size = new System.Drawing.Size(46, 23);
            this.txtOOP.TabIndex = 1;
            // 
            // txtStudent
            // 
            this.txtStudent.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudent.Location = new System.Drawing.Point(76, 36);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(220, 16);
            this.txtStudent.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(138, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.txtOOP);
            this.Controls.Add(this.txtCore);
            this.Controls.Add(this.txtCSS);
            this.Controls.Add(this.txtHTML);
            this.Controls.Add(this.txtDotNet);
            this.Controls.Add(this.lblOOP);
            this.Controls.Add(this.lblCore);
            this.Controls.Add(this.lblCSS);
            this.Controls.Add(this.lblHTML);
            this.Controls.Add(this.lblDotNet);
            this.Name = "EditGrades";
            this.Size = new System.Drawing.Size(369, 357);
            this.Load += new System.EventHandler(this.EditGrades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDotNet;
        private System.Windows.Forms.Label lblHTML;
        private System.Windows.Forms.Label lblCSS;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.Label lblOOP;
        private System.Windows.Forms.TextBox txtDotNet;
        private System.Windows.Forms.TextBox txtHTML;
        private System.Windows.Forms.TextBox txtCSS;
        private System.Windows.Forms.TextBox txtCore;
        private System.Windows.Forms.TextBox txtOOP;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Button btnSave;
    }
}
