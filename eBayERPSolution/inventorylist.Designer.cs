namespace eBayERPSolution
{
    partial class inventorylist
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.skutbox = new System.Windows.Forms.TextBox();
            this.productnametbox = new System.Windows.Forms.TextBox();
            this.productnamel = new System.Windows.Forms.Label();
            this.paisapayidprimarykeytbox = new System.Windows.Forms.TextBox();
            this.paisapayidl = new System.Windows.Forms.Label();
            this.qtytbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricetbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saleslistgrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleslistgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 220);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INVENTORY LIST";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add to List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SKU";
            // 
            // skutbox
            // 
            this.skutbox.Location = new System.Drawing.Point(93, 50);
            this.skutbox.Name = "skutbox";
            this.skutbox.Size = new System.Drawing.Size(100, 20);
            this.skutbox.TabIndex = 6;
            // 
            // productnametbox
            // 
            this.productnametbox.Location = new System.Drawing.Point(93, 101);
            this.productnametbox.Name = "productnametbox";
            this.productnametbox.Size = new System.Drawing.Size(658, 20);
            this.productnametbox.TabIndex = 8;
            // 
            // productnamel
            // 
            this.productnamel.AutoSize = true;
            this.productnamel.Location = new System.Drawing.Point(12, 104);
            this.productnamel.Name = "productnamel";
            this.productnamel.Size = new System.Drawing.Size(75, 13);
            this.productnamel.TabIndex = 7;
            this.productnamel.Text = "Product Name";
            // 
            // paisapayidprimarykeytbox
            // 
            this.paisapayidprimarykeytbox.Location = new System.Drawing.Point(578, 50);
            this.paisapayidprimarykeytbox.Name = "paisapayidprimarykeytbox";
            this.paisapayidprimarykeytbox.ReadOnly = true;
            this.paisapayidprimarykeytbox.Size = new System.Drawing.Size(173, 20);
            this.paisapayidprimarykeytbox.TabIndex = 10;
            // 
            // paisapayidl
            // 
            this.paisapayidl.AutoSize = true;
            this.paisapayidl.ForeColor = System.Drawing.SystemColors.Info;
            this.paisapayidl.Location = new System.Drawing.Point(514, 53);
            this.paisapayidl.Name = "paisapayidl";
            this.paisapayidl.Size = new System.Drawing.Size(65, 13);
            this.paisapayidl.TabIndex = 9;
            this.paisapayidl.Text = "PaisaPay ID";
            // 
            // qtytbox
            // 
            this.qtytbox.Location = new System.Drawing.Point(398, 50);
            this.qtytbox.Name = "qtytbox";
            this.qtytbox.Size = new System.Drawing.Size(100, 20);
            this.qtytbox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(363, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "QTY";
            // 
            // pricetbox
            // 
            this.pricetbox.Location = new System.Drawing.Point(245, 50);
            this.pricetbox.Name = "pricetbox";
            this.pricetbox.Size = new System.Drawing.Size(100, 20);
            this.pricetbox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(208, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // saleslistgrid
            // 
            this.saleslistgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleslistgrid.Location = new System.Drawing.Point(12, 147);
            this.saleslistgrid.Name = "saleslistgrid";
            this.saleslistgrid.Size = new System.Drawing.Size(739, 189);
            this.saleslistgrid.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "SALES LIST";
            // 
            // inventorylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(764, 605);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saleslistgrid);
            this.Controls.Add(this.pricetbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qtytbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paisapayidprimarykeytbox);
            this.Controls.Add(this.paisapayidl);
            this.Controls.Add(this.productnametbox);
            this.Controls.Add(this.productnamel);
            this.Controls.Add(this.skutbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "inventorylist";
            this.Text = "ERP Solution For eBay Sellers-Inventory List";
            this.Load += new System.EventHandler(this.inventorylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleslistgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skutbox;
        private System.Windows.Forms.TextBox productnametbox;
        private System.Windows.Forms.Label productnamel;
        private System.Windows.Forms.TextBox paisapayidprimarykeytbox;
        private System.Windows.Forms.Label paisapayidl;
        private System.Windows.Forms.TextBox qtytbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pricetbox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView saleslistgrid;
        private System.Windows.Forms.Label label5;
    }
}