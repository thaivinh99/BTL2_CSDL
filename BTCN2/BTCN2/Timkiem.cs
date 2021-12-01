using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTCN2
{
    public partial class Timkiem : Form
    {
        public Timkiem()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=THAIVINHOFFORTU;Initial Catalog = VINH_BTL2; Integrated Security = True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void Timkiem_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }

        public void hienthi()
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"select ID_BOOK, CURRENT_BOOK_PRICE, N_BOOK, BOOK_PRICE, N_PUBLISHER, PUBLISHED_YEAR, PUBLISHED_TIME FROM BOOK";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                listView1.Items.Add(docdulieu[0].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[1].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[2].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[3].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[4].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[5].ToString());
                listView1.Items[i].SubItems.Add(docdulieu[6].ToString());


                i++;
            }
            ketnoi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"INSERT INTO BOOK(ID_BOOK, CURRENT_BOOK_PRICE, N_BOOK, BOOK_PRICE, N_PUBLISHER, PUBLISHED_YEAR, PUBLISHED_TIME)
VALUES              (N'" + txt_idbook.Text + @" ' ,N' " + txt_currentprice.Text + @" ', N'" + txt_nbook.Text + @" ', N'" + txt_bookprice.Text + @" ' , N'" + txt_np.Text + @" ', N'" + txt_py.Text + @" ', N'" + txt_pt.Text + @" ')";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"UPDATE BOOK SET
                ID_BOOK = N'" + txt_idbook.Text + @" ', 
                CURRENT_BOOK_PRICE = N' " + txt_currentprice.Text + @" ',
                N_BOOK = N'" + txt_nbook.Text + @" ',
                BOOK_PRICE = N'" + txt_bookprice.Text + @" ' ,
                N_PUBLISHER = N'" + txt_np.Text + @" ',
                PUBLISHED_YEAR = N'" + txt_py.Text + @" ',
                PUBLISHED_TIME = N'" + txt_pt.Text + @" '
WHERE           (ID_BOOK = N'" + txt_idbook.Text + @" ')";

            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ketnoi.Open();
            sql = @"DELETE FROM BOOK WHERE (ID_BOOK = N'" + txt_idbook.Text + @" ' )";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            hienthi();     
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

       
    }

}
