using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class frm_select : Form
    {
        //数据库连接字符串
        private string strCon = "";

        public frm_select(string strCon)
        {
            InitializeComponent();
            this.strCon = strCon;
        }


    }
}
