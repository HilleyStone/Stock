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

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Name_txtBox.Text = "";
            Password_txtBox.Clear();
            Name_txtBox.Focus();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            //TO-DO: Check login username & password
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-HL4H91B\\HILLEYSTONE;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                FROM [Stock].[dbo].[Login] Where UserName='"+ Name_txtBox.Text +"' and Password='"+ Password_txtBox.Text+ "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain main = new StockMain();
                main.Show(); 
            }
            else
            {
                MessageBox.Show("Invalid User Password..!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear_btn_Click(sender, e);
            }
        }
    }
}