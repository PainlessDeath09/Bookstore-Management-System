namespace Bookstore_Management_System
{
    partial class AppBody
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookPage = new System.Windows.Forms.TabPage();
            this.buyPage = new System.Windows.Forms.TabPage();
            this.transPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.bookDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.pub_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isbn_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.author_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accno_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.did = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.bookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bookDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.bookPage);
            this.tabControl1.Controls.Add(this.buyPage);
            this.tabControl1.Controls.Add(this.transPage);
            this.tabControl1.Controls.Add(this.settingsPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1352, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // bookPage
            // 
            this.bookPage.Controls.Add(this.bookDetails);
            this.bookPage.Controls.Add(this.search);
            this.bookPage.Controls.Add(this.clr);
            this.bookPage.Controls.Add(this.del);
            this.bookPage.Controls.Add(this.update);
            this.bookPage.Controls.Add(this.add);
            this.bookPage.Controls.Add(this.dataGridView1);
            this.bookPage.Controls.Add(this.label1);
            this.bookPage.Controls.Add(this.textBox1);
            this.bookPage.Location = new System.Drawing.Point(4, 25);
            this.bookPage.Name = "bookPage";
            this.bookPage.Padding = new System.Windows.Forms.Padding(3);
            this.bookPage.Size = new System.Drawing.Size(1344, 736);
            this.bookPage.TabIndex = 0;
            this.bookPage.Text = "Books";
            this.bookPage.UseVisualStyleBackColor = true;
            // 
            // buyPage
            // 
            this.buyPage.Location = new System.Drawing.Point(4, 25);
            this.buyPage.Name = "buyPage";
            this.buyPage.Padding = new System.Windows.Forms.Padding(3);
            this.buyPage.Size = new System.Drawing.Size(1344, 736);
            this.buyPage.TabIndex = 1;
            this.buyPage.Text = "Buy";
            this.buyPage.UseVisualStyleBackColor = true;
            // 
            // transPage
            // 
            this.transPage.Location = new System.Drawing.Point(4, 25);
            this.transPage.Name = "transPage";
            this.transPage.Size = new System.Drawing.Size(1344, 736);
            this.transPage.TabIndex = 2;
            this.transPage.Text = "Transactions";
            this.transPage.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.Location = new System.Drawing.Point(4, 25);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(1344, 736);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID Number:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(140, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 162);
            this.dataGridView1.TabIndex = 2;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(270, 382);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(110, 50);
            this.add.TabIndex = 3;
            this.add.Text = "Add New";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(492, 382);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(110, 50);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(714, 382);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(110, 50);
            this.del.TabIndex = 5;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            // 
            // clr
            // 
            this.clr.Location = new System.Drawing.Point(936, 382);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(110, 50);
            this.clr.TabIndex = 6;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(563, 90);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(110, 50);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // bookDetails
            // 
            this.bookDetails.Controls.Add(this.did);
            this.bookDetails.Controls.Add(this.label7);
            this.bookDetails.Controls.Add(this.accno_textbox);
            this.bookDetails.Controls.Add(this.label6);
            this.bookDetails.Controls.Add(this.author_textbox);
            this.bookDetails.Controls.Add(this.label5);
            this.bookDetails.Controls.Add(this.isbn_textbox);
            this.bookDetails.Controls.Add(this.label4);
            this.bookDetails.Controls.Add(this.pub_textbox);
            this.bookDetails.Controls.Add(this.label3);
            this.bookDetails.Controls.Add(this.name_textbox);
            this.bookDetails.Controls.Add(this.label2);
            this.bookDetails.Location = new System.Drawing.Point(22, 484);
            this.bookDetails.Name = "bookDetails";
            this.bookDetails.Size = new System.Drawing.Size(1304, 212);
            this.bookDetails.TabIndex = 8;
            this.bookDetails.TabStop = false;
            this.bookDetails.Text = "Book Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(248, 97);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(234, 22);
            this.name_textbox.TabIndex = 1;
            // 
            // pub_textbox
            // 
            this.pub_textbox.Location = new System.Drawing.Point(248, 154);
            this.pub_textbox.Name = "pub_textbox";
            this.pub_textbox.Size = new System.Drawing.Size(234, 22);
            this.pub_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher:";
            // 
            // isbn_textbox
            // 
            this.isbn_textbox.Location = new System.Drawing.Point(914, 97);
            this.isbn_textbox.Name = "isbn_textbox";
            this.isbn_textbox.Size = new System.Drawing.Size(234, 22);
            this.isbn_textbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(855, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN:";
            // 
            // author_textbox
            // 
            this.author_textbox.Location = new System.Drawing.Point(914, 154);
            this.author_textbox.Name = "author_textbox";
            this.author_textbox.Size = new System.Drawing.Size(234, 22);
            this.author_textbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(845, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Author:";
            // 
            // accno_textbox
            // 
            this.accno_textbox.Location = new System.Drawing.Point(568, 44);
            this.accno_textbox.Name = "accno_textbox";
            this.accno_textbox.Size = new System.Drawing.Size(234, 22);
            this.accno_textbox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Acc No:";
            // 
            // did
            // 
            this.did.Location = new System.Drawing.Point(568, 129);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(234, 22);
            this.did.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(499, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "DID:";
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 783);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppBody";
            this.Text = "Bookstore Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppBody_FormClosed);
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.tabControl1.ResumeLayout(false);
            this.bookPage.ResumeLayout(false);
            this.bookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bookDetails.ResumeLayout(false);
            this.bookDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage buyPage;
        private System.Windows.Forms.TabPage transPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.GroupBox bookDetails;
        private System.Windows.Forms.TextBox accno_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox author_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isbn_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pub_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox did;
        private System.Windows.Forms.Label label7;
    }
}