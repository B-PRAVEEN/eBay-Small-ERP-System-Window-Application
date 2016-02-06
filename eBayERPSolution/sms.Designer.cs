namespace eBayERPSolution
{
    partial class sms
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
            this.customernumbertbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.smsmessagetbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.smstemplatecbox = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Number:";
            // 
            // customernumbertbox
            // 
            this.customernumbertbox.Location = new System.Drawing.Point(112, 33);
            this.customernumbertbox.Name = "customernumbertbox";
            this.customernumbertbox.Size = new System.Drawing.Size(271, 20);
            this.customernumbertbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // smsmessagetbox
            // 
            this.smsmessagetbox.Location = new System.Drawing.Point(112, 105);
            this.smsmessagetbox.Multiline = true;
            this.smsmessagetbox.Name = "smsmessagetbox";
            this.smsmessagetbox.Size = new System.Drawing.Size(271, 109);
            this.smsmessagetbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Template";
            // 
            // smstemplatecbox
            // 
            this.smstemplatecbox.FormattingEnabled = true;
            this.smstemplatecbox.Items.AddRange(new object[] {
            "Processing",
            "Shipped",
            "Delivered",
            "Feedback",
            "Custom"});
            this.smstemplatecbox.Location = new System.Drawing.Point(112, 69);
            this.smstemplatecbox.Name = "smstemplatecbox";
            this.smstemplatecbox.Size = new System.Drawing.Size(271, 21);
            this.smstemplatecbox.TabIndex = 5;
            this.smstemplatecbox.SelectedIndexChanged += new System.EventHandler(this.smstemplatecbox_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 289);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(410, 331);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.smstemplatecbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smsmessagetbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customernumbertbox);
            this.Controls.Add(this.label1);
            this.Name = "sms";
            this.Text = "SMS - ERP System For eBay Sellers";
            this.Load += new System.EventHandler(this.sms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customernumbertbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox smsmessagetbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox smstemplatecbox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}