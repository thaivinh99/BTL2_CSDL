namespace BTCN2
{
    partial class BookEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bangthongtinsach = new System.Windows.Forms.ListView();
            this.dtdvAccount = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bangthongtinsach);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 275);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sách";
            // 
            // bangthongtinsach
            // 
            this.bangthongtinsach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bangthongtinsach.BackColor = System.Drawing.SystemColors.Info;
            this.bangthongtinsach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bangthongtinsach.CheckBoxes = true;
            this.bangthongtinsach.GridLines = true;
            this.bangthongtinsach.HideSelection = false;
            this.bangthongtinsach.Location = new System.Drawing.Point(25, 8);
            this.bangthongtinsach.Name = "bangthongtinsach";
            this.bangthongtinsach.Size = new System.Drawing.Size(931, 256);
            this.bangthongtinsach.TabIndex = 0;
            this.bangthongtinsach.TileSize = new System.Drawing.Size(200, 40);
            this.bangthongtinsach.UseCompatibleStateImageBehavior = false;
            this.bangthongtinsach.View = System.Windows.Forms.View.Details;

            // 
            // dtdvAccount
            // 
            this.dtdvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdvAccount.Location = new System.Drawing.Point(13, 291);
            this.dtdvAccount.Name = "dtdvAccount";
            this.dtdvAccount.Size = new System.Drawing.Size(472, 220);
            this.dtdvAccount.TabIndex = 2;
            // 
            // BookEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 523);
            this.Controls.Add(this.dtdvAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "BookEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookEdit";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtdvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView bangthongtinsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtdvAccount;
    }
}