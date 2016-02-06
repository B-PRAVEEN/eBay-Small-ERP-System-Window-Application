namespace eBayERPSolution
{
    partial class sendmail
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
            this.templatelistbox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_attachment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bodytbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_toemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // templatelistbox
            // 
            this.templatelistbox.FormattingEnabled = true;
            this.templatelistbox.Items.AddRange(new object[] {
            "Ready To Ship QTY 1",
            "Ready To Ship QTY 2",
            "Packed And Ready TO Ship QTY 1",
            "Packed And Ready TO Ship QTY 2",
            "Shipped QTY 1",
            "Shipped QTY 2",
            "Delivered QTY 1"});
            this.templatelistbox.Location = new System.Drawing.Point(554, 12);
            this.templatelistbox.Name = "templatelistbox";
            this.templatelistbox.Size = new System.Drawing.Size(332, 21);
            this.templatelistbox.TabIndex = 52;
            this.templatelistbox.SelectedIndexChanged += new System.EventHandler(this.templatelistbox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(811, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 51;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_attachment
            // 
            this.txt_attachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_attachment.Location = new System.Drawing.Point(554, 49);
            this.txt_attachment.Name = "txt_attachment";
            this.txt_attachment.ReadOnly = true;
            this.txt_attachment.Size = new System.Drawing.Size(240, 22);
            this.txt_attachment.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(474, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Attachment";
            // 
            // bodytbox
            // 
            this.bodytbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodytbox.Location = new System.Drawing.Point(89, 88);
            this.bodytbox.Multiline = true;
            this.bodytbox.Name = "bodytbox";
            this.bodytbox.Size = new System.Drawing.Size(797, 208);
            this.bodytbox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Body";
            // 
            // txt_subject
            // 
            this.txt_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subject.Location = new System.Drawing.Point(89, 49);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(378, 22);
            this.txt_subject.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Subject";
            // 
            // txt_toemail
            // 
            this.txt_toemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_toemail.Location = new System.Drawing.Point(89, 12);
            this.txt_toemail.Name = "txt_toemail";
            this.txt_toemail.Size = new System.Drawing.Size(378, 22);
            this.txt_toemail.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "To";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(811, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(474, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Template";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 341);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(880, 23);
            this.progressBar1.TabIndex = 56;
            // 
            // sendmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(898, 367);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.templatelistbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_attachment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bodytbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_toemail);
            this.Controls.Add(this.label3);
            this.Name = "sendmail";
            this.Text = "Send Email-eBay ERP Solution 4 Sellers";
            this.Load += new System.EventHandler(this.sendmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox templatelistbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_attachment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bodytbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_toemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}