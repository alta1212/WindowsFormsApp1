using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection cont;
        SqlCommand comd;
        DataTable dt;
        SqlDataAdapter adap;
        string data = "Data Source=(local);Initial Catalog=qlsv;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        public void ketNoi()
        {

            cont = new SqlConnection(data);

            // Mở
            if (cont.State == ConnectionState.Closed)
                cont.Open();
        }
        public void ngatketNoi()
        {
            cont = new SqlConnection(data);
            // Đóng
            if (cont.State == ConnectionState.Open)
                cont.Close();
        }
       public void load()
        {
            dt = new DataTable();
            comd = new SqlCommand("select * from sinhvien", cont);
            adap = new SqlDataAdapter(comd);
            adap.Fill(dt);
            dssv.DataSource = dt;
        }
        private void bntxoa_Click(object sender, EventArgs e)
        {
            ketNoi();
            comd = new SqlCommand("delete from sinhvien where masv = '"+txtmasv.Text+"'", cont);
            comd.ExecuteNonQuery();
            load();
            ngatketNoi();
            MessageBox.Show("xong");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ketNoi();
            load();
            ngatketNoi();
        }

        private void bntsua_Click(object sender, EventArgs e)
        {
            ketNoi();
            comd = new SqlCommand("update sinhvien set tensv='"+txthoten.Text+ "',quequan='" + txtquequan.Text + "' where masv = '" + txtmasv.Text + "'", cont);
            comd.ExecuteNonQuery();
            load();
            ngatketNoi();
            MessageBox.Show("xong");
        }

        private void bntseach_Click(object sender, EventArgs e)
        {
            ketNoi();
            dt = new DataTable();
            comd = new SqlCommand("select * from sinhvien where masv='"+txtmasv.Text+"'", cont);
            comd.ExecuteNonQuery();
            adap = new SqlDataAdapter(comd);
            adap.Fill(dt);
            dssv.DataSource = dt;
            ngatketNoi();
        }

        private void bntnhap_Click(object sender, EventArgs e)
        {
            ketNoi();
            dt = new DataTable();
            comd = new SqlCommand("insert into sinhvien (masv,tensv,quequan)values('"+txtmasv.Text+ "','" + txthoten.Text + "','" + txtquequan.Text + "')", cont);
            comd.ExecuteNonQuery();
            load();
            ngatketNoi();
        }

        private void dssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txthoten.Text = dssv.Rows[i].Cells[0].Value.ToString();
                txthoten.Text = dssv.Rows[i].Cells[1].Value.ToString();
                txtquequan.Text = dssv.Rows[i].Cells[2].Value.ToString();
               
            }
            catch
            { }
        }




        private void txtmasv_Leave(object sender, EventArgs e)
        {
            if(txtmasv.Text=="")
            {
                txtmasv.Focus();
            }    
            else
            {
      
            ketNoi();
            dt = new DataTable();
            comd = new SqlCommand("select * from sinhvien where masv='" + txtmasv.Text + "'", cont);
            adap = new SqlDataAdapter(comd);
            adap.Fill(dt);

           if(dt.Rows.Count > 0)
            {
                txthoten.Text = dt.Rows[0]["tensv"].ToString();
                txtquequan.Text = dt.Rows[0]["quequan"].ToString();
            }
           else
            {
                txthoten.Text = null;
                txtquequan.Text = null;
            }
            ngatketNoi();
          }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("bạn có muốn thoát", "thoát",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }
    }
}
