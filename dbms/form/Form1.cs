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
    public partial class frm_main : Form
    {
        //数据库连接字符串
        public string strCon = "Data Source=WIN-GAKRS4HUKBD;Initial Catalog=dbms;Integrated Security=True";

        public static string uid = "";
        public static string uname = "";
        public static int uright = 0;

        public frm_main()
        {
            InitializeComponent();
            dgv_main.ReadOnly = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //主窗体查找按钮
            //指定要链接的数据库的链接字段    
            SqlHandler handler = new SqlHandler(strCon);
            SqlConnection conn = handler.Link();
            string strTarget = txt_inout_frm_main.Text.ToString().Trim();
            string strClass = lsb_select_frm_main.SelectedItem.ToString().Trim();
            //实现模糊查询
            string strSql = "select * from dbo.view_all where " + strClass + " like '%" + strTarget + "%'";
            dgv_main.DataSource = handler.Query(conn, strSql);
            handler.Disopse(conn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsb_select_frm_main.SelectedIndex = 0;
        }

        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uname != "")
            {
                //已有用户登录
                MessageBox.Show("已有用户登录，请先注销再登录");
            }
            else
            {
                //还没有用户登录
                frm_login login = new frm_login(strCon);
                login.Owner = this;
                login.ShowDialog();
                tss_label.Text = "用户" + uname + "已登录";
                if (uright == 1)
                {
                    //即用户为管理员，给予用户所有修改的权限
                    注销ToolStripMenuItem.Enabled = true;
                    功能ToolStripMenuItem.Enabled = true;
                    报表ToolStripMenuItem.Enabled = true;
                }
                else
                {
                    //用户为普通用户，仅允许用户检索查看数据
                    注销ToolStripMenuItem.Enabled = true;
                    报表ToolStripMenuItem.Enabled = true;
                    功能ToolStripMenuItem.Enabled = true;
                    增加ToolStripMenuItem.Enabled = false;
                    删除ToolStripMenuItem.Enabled = false;
                    修改ToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清理跟用户有关的信息
            uid = "";
            uname = "";
            uright = 0;
            tss_label.Text = "您尚未登录，无法进行操作";
            //清理查询结果
            dgv_main.Rows.Clear();
            //清理数据库链接
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清理数据库链接
            //退出程序
            Environment.Exit(0);
        }

        private void 查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_select select = new frm_select(strCon);
            select.Show();
        }
    }
}
