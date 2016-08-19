namespace August18
{
    partial class BookForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.priceTbx = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.resultLv = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.publisherTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isbnTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.authorTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryTbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Price";
            // 
            // priceTbx
            // 
            this.priceTbx.Location = new System.Drawing.Point(99, 142);
            this.priceTbx.Name = "priceTbx";
            this.priceTbx.Size = new System.Drawing.Size(100, 20);
            this.priceTbx.TabIndex = 32;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(108, 226);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(88, 23);
            this.btnModify.TabIndex = 31;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(12, 226);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 23);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(108, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 197);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // resultLv
            // 
            this.resultLv.Location = new System.Drawing.Point(214, 12);
            this.resultLv.Name = "resultLv";
            this.resultLv.Size = new System.Drawing.Size(464, 237);
            this.resultLv.TabIndex = 27;
            this.resultLv.UseCompatibleStateImageBehavior = false;
            this.resultLv.View = System.Windows.Forms.View.Details;
            this.resultLv.SelectedIndexChanged += new System.EventHandler(this.resultLv_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Publisher";
            // 
            // publisherTbx
            // 
            this.publisherTbx.Location = new System.Drawing.Point(99, 116);
            this.publisherTbx.Name = "publisherTbx";
            this.publisherTbx.Size = new System.Drawing.Size(100, 20);
            this.publisherTbx.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "ISBN";
            // 
            // isbnTbx
            // 
            this.isbnTbx.Location = new System.Drawing.Point(99, 90);
            this.isbnTbx.Name = "isbnTbx";
            this.isbnTbx.Size = new System.Drawing.Size(100, 20);
            this.isbnTbx.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Author";
            // 
            // authorTbx
            // 
            this.authorTbx.Location = new System.Drawing.Point(99, 64);
            this.authorTbx.Name = "authorTbx";
            this.authorTbx.Size = new System.Drawing.Size(100, 20);
            this.authorTbx.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Title";
            // 
            // titleTbx
            // 
            this.titleTbx.Location = new System.Drawing.Point(99, 38);
            this.titleTbx.Name = "titleTbx";
            this.titleTbx.Size = new System.Drawing.Size(100, 20);
            this.titleTbx.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(99, 12);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(100, 20);
            this.idTbx.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Category";
            // 
            // categoryTbx
            // 
            this.categoryTbx.Location = new System.Drawing.Point(99, 168);
            this.categoryTbx.Name = "categoryTbx";
            this.categoryTbx.Size = new System.Drawing.Size(100, 20);
            this.categoryTbx.TabIndex = 34;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 264);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.categoryTbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTbx);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.resultLv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publisherTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isbnTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTbx);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceTbx;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView resultLv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox publisherTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isbnTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox categoryTbx;
    }
}