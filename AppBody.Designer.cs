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
            this.accno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rackCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.bookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.textBox1.Location = new System.Drawing.Point(480, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID Number:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accno,
            this.isbn,
            this.name,
            this.author,
            this.publisher,
            this.dep_id,
            this.dep_name,
            this.rackCode});
            this.dataGridView1.Location = new System.Drawing.Point(138, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 162);
            this.dataGridView1.TabIndex = 2;
            // 
            // accno
            // 
            this.accno.HeaderText = "Acc No";
            this.accno.MinimumWidth = 6;
            this.accno.Name = "accno";
            this.accno.Width = 125;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.Width = 125;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Publisher";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.Width = 125;
            // 
            // dep_id
            // 
            this.dep_id.HeaderText = "Department ID";
            this.dep_id.MinimumWidth = 6;
            this.dep_id.Name = "dep_id";
            this.dep_id.Width = 125;
            // 
            // dep_name
            // 
            this.dep_name.HeaderText = "Department Name";
            this.dep_name.MinimumWidth = 6;
            this.dep_name.Name = "dep_name";
            this.dep_name.Width = 125;
            // 
            // rackCode
            // 
            this.rackCode.HeaderText = "Rack Code";
            this.rackCode.MinimumWidth = 6;
            this.rackCode.Name = "rackCode";
            this.rackCode.Width = 125;
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
            this.tabControl1.ResumeLayout(false);
            this.bookPage.ResumeLayout(false);
            this.bookPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn accno;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn rackCode;
    }
}