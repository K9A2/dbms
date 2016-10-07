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

namespace dbms
{
    public partial class frm_login : Form
    {

        public static ToolStripStatusLabel tss_label;



        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string strCon = "Data Source=WIN-GAKRS4HUKBD;Initial Catalog=dbms;Integrated Security=True";
            string uname = tbx_username.Text.Trim();
            string upass = tbx_pass.Text.Trim();
            string strSql = "select * from dbo.view_user where uname='" + uname + "'and upass='" + upass + "'";

            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("登录失败，请输入正确的用户名和密码");
            }
            else if (uname == dt.Rows[0][1].ToString() && upass == dt.Rows[0][2].ToString())
            {
                
                MessageBox.Show("登录成功");
                frm_main myForm = new frm_main();
                frm_main.uname = uname;
                frm_main.uid = dt.Rows[0][0].ToString();
                frm_main.uright = Int32.Parse(dt.Rows[0][3].ToString());
                conn.Dispose();
                Dispose();
            }

        }
    }
}
