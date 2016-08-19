namespace August18
{
    partial class August18
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
            this.idTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTbx = new System.Windows.Forms.TextBox();
            this.resultLv = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.programTbx = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.searchCbx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTbx = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(96, 12);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(100, 20);
            this.idTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // firstNameTbx
            // 
            this.firstNameTbx.Location = new System.Drawing.Point(96, 38);
            this.firstNameTbx.Name = "firstNameTbx";
            this.firstNameTbx.Size = new System.Drawing.Size(100, 20);
            this.firstNameTbx.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // lastNameTbx
            // 
            this.lastNameTbx.Location = new System.Drawing.Point(96, 64);
            this.lastNameTbx.Name = "lastNameTbx";
            this.lastNameTbx.Size = new System.Drawing.Size(100, 20);
            this.lastNameTbx.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // addressTbx
            // 
            this.addressTbx.Location = new System.Drawing.Point(96, 90);
            this.addressTbx.Name = "addressTbx";
            this.addressTbx.Size = new System.Drawing.Size(100, 20);
            this.addressTbx.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // phoneTbx
            // 
            this.phoneTbx.Location = new System.Drawing.Point(96, 116);
            this.phoneTbx.Name = "phoneTbx";
            this.phoneTbx.Size = new System.Drawing.Size(100, 20);
            this.phoneTbx.TabIndex = 8;
            // 
            // resultLv
            // 
            this.resultLv.Location = new System.Drawing.Point(211, 12);
            this.resultLv.Name = "resultLv";
            this.resultLv.Size = new System.Drawing.Size(510, 208);
            this.resultLv.TabIndex = 10;
            this.resultLv.UseCompatibleStateImageBehavior = false;
            this.resultLv.View = System.Windows.Forms.View.Details;
            this.resultLv.SelectedIndexChanged += new System.EventHandler(this.resultLv_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(211, 272);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(12, 197);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(108, 197);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Program";
            // 
            // programTbx
            // 
            this.programTbx.Location = new System.Drawing.Point(96, 142);
            this.programTbx.Name = "programTbx";
            this.programTbx.Size = new System.Drawing.Size(100, 20);
            this.programTbx.TabIndex = 15;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(633, 272);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(88, 23);
            this.btnBook.TabIndex = 17;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // searchCbx
            // 
            this.searchCbx.FormattingEnabled = true;
            this.searchCbx.Items.AddRange(new object[] {
            "ID",
            "FIRST NAME",
            "LAST NAME",
            "ADDRESS",
            "PHONE",
            "PROGRAM"});
            this.searchCbx.Location = new System.Drawing.Point(6, 19);
            this.searchCbx.Name = "searchCbx";
            this.searchCbx.Size = new System.Drawing.Size(79, 21);
            this.searchCbx.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.searchTbx);
            this.groupBox1.Controls.Add(this.searchCbx);
            this.groupBox1.Location = new System.Drawing.Point(15, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 79);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchTbx
            // 
            this.searchTbx.Location = new System.Drawing.Point(96, 19);
            this.searchTbx.Name = "searchTbx";
            this.searchTbx.Size = new System.Drawing.Size(79, 20);
            this.searchTbx.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(96, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // August18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.programTbx);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.resultLv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTbx);
            this.Name = "August18";
            this.Text = "August18";
            this.Load += new System.EventHandler(this.August18_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneTbx;
        private System.Windows.Forms.ListView resultLv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox programTbx;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ComboBox searchCbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchTbx;
    }
}

