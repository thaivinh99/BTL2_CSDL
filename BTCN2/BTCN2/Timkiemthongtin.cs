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
using System.Configuration;

namespace BTCN2
{
    public partial class Timkiemthongtin : Form
    {
        public Timkiemthongtin()
        {
            InitializeComponent();
        }
             
       



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using(DataTable dt = new DataTable("Customer"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT *FROM BOOK WHERE N_BOOK=@N_BOOK OR ID_BOOK=@ID_BOOK OR CURRENT_BOOK_PRICE=@CURRENT_BOOK_PRICE OR BOOK_PRICE =@BOOK_PRICE OR N_PUBLISHER=@N_PUBLISHER OR PUBLISHED_YEAR=@PUBLISHED_YEAR OR PUBLISHED_TIME=@PUBLISHED_TIME ", cn))
                        {               
                            cmd.Parameters.AddWithValue("ID_BOOK", txt_idbook.Text);
                            cmd.Parameters.AddWithValue("CURRENT_BOOK_PRICE", txt_currentprice.Text);
                            cmd.Parameters.AddWithValue("N_BOOK", txt_nbook.Text);
                            cmd.Parameters.AddWithValue("BOOK_PRICE", txt_bprice.Text);
                            cmd.Parameters.AddWithValue("N_PUBLISHER", txt_np.Text);
                            cmd.Parameters.AddWithValue("PUBLISHED_YEAR", txt_py.Text);
                            cmd.Parameters.AddWithValue("PUBLISHED_TIME", txt_pt.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView.DataSource = dt;
                            

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
