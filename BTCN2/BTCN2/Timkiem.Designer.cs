namespace BTCN2
{
    partial class Timkiem
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
            this.txt_idbook = new System.Windows.Forms.TextBox();
            this.txt_currentprice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDBOOK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CURRENT_BOOK_PRICE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_BOOK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BOOK_PRICE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.N_PUBLISHER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PUBLISHEDYEAR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PUBLISHEDTIME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_nbook = new System.Windows.Forms.TextBox();
            this.txt_bookprice = new System.Windows.Forms.TextBox();
            this.txt_np = new System.Windows.Forms.TextBox();
            this.txt_py = new System.Windows.Forms.TextBox();
            this.txt_pt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_idbook
            // 
            this.txt_idbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idbook.Location = new System.Drawing.Point(288, 23);
            this.txt_idbook.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idbook.Name = "txt_idbook";
            this.txt_idbook.Size = new System.Drawing.Size(250, 24);
            this.txt_idbook.TabIndex = 0;
            // 
            // txt_currentprice
            // 
            this.txt_currentprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentprice.Location = new System.Drawing.Point(288, 74);
            this.txt_currentprice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_currentprice.Name = "txt_currentprice";
            this.txt_currentprice.Size = new System.Drawing.Size(250, 24);
            this.txt_currentprice.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(303, 224);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(558, 224);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 54);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(816, 224);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 54);
            this.button4.TabIndex = 11;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDBOOK,
            this.CURRENT_BOOK_PRICE,
            this.N_BOOK,
            this.BOOK_PRICE,
            this.N_PUBLISHER,
            this.PUBLISHEDYEAR,
            this.PUBLISHEDTIME});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 339);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1082, 435);
            this.listView1.TabIndex = 11;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDBOOK
            // 
            this.IDBOOK.Text = "IDBOOK";
            this.IDBOOK.Width = 80;
            // 
            // CURRENT_BOOK_PRICE
            // 
            this.CURRENT_BOOK_PRICE.Text = "CURRENT_BOOK_PRICE";
            this.CURRENT_BOOK_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CURRENT_BOOK_PRICE.Width = 200;
            // 
            // N_BOOK
            // 
            this.N_BOOK.Text = "N_BOOK";
            this.N_BOOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N_BOOK.Width = 200;
            // 
            // BOOK_PRICE
            // 
            this.BOOK_PRICE.Text = "BOOK_PRICE";
            this.BOOK_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BOOK_PRICE.Width = 130;
            // 
            // N_PUBLISHER
            // 
            this.N_PUBLISHER.Text = "N_PUBLISHER";
            this.N_PUBLISHER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.N_PUBLISHER.Width = 130;
            // 
            // PUBLISHEDYEAR
            // 
            this.PUBLISHEDYEAR.Text = "PUBLISHEDYEAR";
            this.PUBLISHEDYEAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PUBLISHEDYEAR.Width = 150;
            // 
            // PUBLISHEDTIME
            // 
            this.PUBLISHEDTIME.Text = "PUBLISHEDTIME";
            this.PUBLISHEDTIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PUBLISHEDTIME.Width = 200;
            // 
            // txt_nbook
            // 
            this.txt_nbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nbook.Location = new System.Drawing.Point(288, 126);
            this.txt_nbook.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nbook.Name = "txt_nbook";
            this.txt_nbook.Size = new System.Drawing.Size(250, 24);
            this.txt_nbook.TabIndex = 2;
            // 
            // txt_bookprice
            // 
            this.txt_bookprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bookprice.Location = new System.Drawing.Point(288, 180);
            this.txt_bookprice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_bookprice.Name = "txt_bookprice";
            this.txt_bookprice.Size = new System.Drawing.Size(250, 24);
            this.txt_bookprice.TabIndex = 3;
            // 
            // txt_np
            // 
            this.txt_np.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_np.Location = new System.Drawing.Point(802, 23);
            this.txt_np.Margin = new System.Windows.Forms.Padding(4);
            this.txt_np.Name = "txt_np";
            this.txt_np.Size = new System.Drawing.Size(250, 24);
            this.txt_np.TabIndex = 4;
            // 
            // txt_py
            // 
            this.txt_py.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_py.Location = new System.Drawing.Point(802, 74);
            this.txt_py.Margin = new System.Windows.Forms.Padding(4);
            this.txt_py.Name = "txt_py";
            this.txt_py.Size = new System.Drawing.Size(250, 24);
            this.txt_py.TabIndex = 5;
            // 
            // txt_pt
            // 
            this.txt_pt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pt.Location = new System.Drawing.Point(802, 126);
            this.txt_pt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pt.Name = "txt_pt";
            this.txt_pt.Size = new System.Drawing.Size(250, 24);
            this.txt_pt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID BOOK : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_pt);
            this.panel1.Controls.Add(this.txt_py);
            this.panel1.Controls.Add(this.txt_np);
            this.panel1.Controls.Add(this.txt_bookprice);
            this.panel1.Controls.Add(this.txt_nbook);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_currentprice);
            this.panel1.Controls.Add(this.txt_idbook);
            this.panel1.Location = new System.Drawing.Point(66, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 292);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "PUBLISHEDTIME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(626, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "PUBLISHEDYEAR :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(626, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "N_PUBLISHER :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "BOOK_PRICE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "N_BOOK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "CURRENT_BOOK_PRICE :";
            // 
            // Timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(1213, 793);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Timkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều chỉnh thông tin cửa hàng";
            this.Load += new System.EventHandler(this.Timkiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idbook;
        private System.Windows.Forms.TextBox txt_currentprice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDBOOK;
        private System.Windows.Forms.ColumnHeader CURRENT_BOOK_PRICE;
        private System.Windows.Forms.ColumnHeader BOOK_PRICE;
        private System.Windows.Forms.ColumnHeader N_PUBLISHER;
        private System.Windows.Forms.ColumnHeader PUBLISHEDYEAR;
        private System.Windows.Forms.ColumnHeader PUBLISHEDTIME;
        private System.Windows.Forms.TextBox txt_nbook;
        private System.Windows.Forms.TextBox txt_bookprice;
        private System.Windows.Forms.TextBox txt_np;
        private System.Windows.Forms.TextBox txt_py;
        private System.Windows.Forms.TextBox txt_pt;
        private System.Windows.Forms.ColumnHeader N_BOOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}