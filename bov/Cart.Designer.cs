﻿namespace bov
{
    partial class Cart
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteThisOrderLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_TVA = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_TVA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back to the catalog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(757, 365);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteThisOrderLineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 36);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            this.contextMenuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseUp);
            // 
            // deleteThisOrderLineToolStripMenuItem
            // 
            this.deleteThisOrderLineToolStripMenuItem.Name = "deleteThisOrderLineToolStripMenuItem";
            this.deleteThisOrderLineToolStripMenuItem.Size = new System.Drawing.Size(247, 32);
            this.deleteThisOrderLineToolStripMenuItem.Text = "Delete this order line";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Right click on the order line that you want to delete ";
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(1004, 188);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(100, 26);
            this.Lastname.TabIndex = 5;
            this.Lastname.TextChanged += new System.EventHandler(this.Lastname_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1168, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(904, 188);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(94, 20);
            this.label_lastname.TabIndex = 7;
            this.label_lastname.Text = "Last Name :";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Location = new System.Drawing.Point(904, 235);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(88, 20);
            this.label_firstname.TabIndex = 8;
            this.label_firstname.Text = "Firstname :";
            this.label_firstname.Click += new System.EventHandler(this.label_firstname_Click);
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(904, 281);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(67, 20);
            this.label_adress.TabIndex = 9;
            this.label_adress.Text = "Adress :";
            // 
            // label_TVA
            // 
            this.label_TVA.AutoSize = true;
            this.label_TVA.Location = new System.Drawing.Point(904, 324);
            this.label_TVA.Name = "label_TVA";
            this.label_TVA.Size = new System.Drawing.Size(48, 20);
            this.label_TVA.TabIndex = 10;
            this.label_TVA.Text = "TVA :";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Location = new System.Drawing.Point(1004, 235);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(100, 26);
            this.textBox_firstname.TabIndex = 11;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(1004, 281);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(100, 26);
            this.textBox_adress.TabIndex = 12;
            // 
            // textBox_TVA
            // 
            this.textBox_TVA.Location = new System.Drawing.Point(1004, 324);
            this.textBox_TVA.Name = "textBox_TVA";
            this.textBox_TVA.Size = new System.Drawing.Size(100, 26);
            this.textBox_TVA.TabIndex = 13;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1728, 787);
            this.Controls.Add(this.textBox_TVA);
            this.Controls.Add(this.textBox_adress);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.label_TVA);
            this.Controls.Add(this.label_adress);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Cart";
            this.Text = "Cart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteThisOrderLineToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_TVA;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox textBox_TVA;
    }
}