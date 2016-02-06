namespace eBayERPSolution
{
    partial class inventory
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productnametbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skutboxmain = new System.Windows.Forms.TextBox();
            this.inventorygrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventorygrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "SHOW ALL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(977, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 50;
            this.button3.Text = "CLOSE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "ADD INVENTORY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(894, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "RESET";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(214, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 52;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.search_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Product Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productnametbox
            // 
            this.productnametbox.Location = new System.Drawing.Point(93, 79);
            this.productnametbox.Name = "productnametbox";
            this.productnametbox.Size = new System.Drawing.Size(792, 20);
            this.productnametbox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(891, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "SKU";
            // 
            // skutboxmain
            // 
            this.skutboxmain.Location = new System.Drawing.Point(926, 76);
            this.skutboxmain.Name = "skutboxmain";
            this.skutboxmain.Size = new System.Drawing.Size(126, 20);
            this.skutboxmain.TabIndex = 58;
            // 
            // inventorygrid
            // 
            this.inventorygrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventorygrid.Location = new System.Drawing.Point(15, 136);
            this.inventorygrid.Name = "inventorygrid";
            this.inventorygrid.ReadOnly = true;
            this.inventorygrid.Size = new System.Drawing.Size(1037, 305);
            this.inventorygrid.TabIndex = 59;
            this.inventorygrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.inventorygrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventorygrid_RowEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "INVENTORY DETAILS";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 443);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1037, 23);
            this.progressBar1.TabIndex = 61;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 62;
            this.button5.Text = "DELETE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(376, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 63;
            this.button7.Text = "REFRESH";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1068, 478);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inventorygrid);
            this.Controls.Add(this.skutboxmain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productnametbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "inventory";
            this.Text = "inventory";
            this.Load += new System.EventHandler(this.inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventorygrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productnametbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skutboxmain;
        private System.Windows.Forms.DataGridView inventorygrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}