namespace DLL
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
            this.btnFill = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lbFill = new System.Windows.Forms.ListBox();
            this.lbRead = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(60, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "FIll list";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(202, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read list";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lbFill
            // 
            this.lbFill.FormattingEnabled = true;
            this.lbFill.ItemHeight = 16;
            this.lbFill.Location = new System.Drawing.Point(35, 74);
            this.lbFill.Name = "lbFill";
            this.lbFill.Size = new System.Drawing.Size(120, 228);
            this.lbFill.TabIndex = 2;
            // 
            // lbRead
            // 
            this.lbRead.FormattingEnabled = true;
            this.lbRead.ItemHeight = 16;
            this.lbRead.Location = new System.Drawing.Point(183, 74);
            this.lbRead.Name = "lbRead";
            this.lbRead.Size = new System.Drawing.Size(120, 228);
            this.lbRead.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 354);
            this.Controls.Add(this.lbRead);
            this.Controls.Add(this.lbFill);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnFill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lbFill;
        private System.Windows.Forms.ListBox lbRead;
    }
}

