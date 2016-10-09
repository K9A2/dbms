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
    public partial class frm_insert : Form
    {
        //状态栏提示信息
        string msg_fname = "";
        string msg_sname = "";
        //string msg_

        public frm_insert()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_insert_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 确认窗体中各输入控件内是否还有数据
        /// </summary>
        /// <returns>true为无数据；false为有数据</returns>
        private bool ConfirmExit()
        {
            //判断所有输入框是否都被清空
            if(txt_fname.Text.ToString()=="" &&
                txt_sname.Text.ToString()=="" &&
                txt_issn.Text.ToString()=="" &&
                txt_cname.Text.ToString()=="" &&
                cbx_className.SelectedItem.ToString()=="" &&
                txt_multiClass.Text.ToString()=="" &&
                cbx_classID.SelectedItem.ToString()=="" &&
                cbx_isTop.SelectedItem.ToString()=="" &&
                txt_note.Text.ToString()=="" &&
                txt_factor_09.Text.ToString()=="" &&
                txt_factor_08.Text.ToString()=="" &&
                txt_factor_07.Text.ToString()=="" &&
                txt_cite_09.Text.ToString()=="" &&
                txt_cite_08.Text.ToString()=="" &&
                txt_cite_07.Text.ToString()==""
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void frm_insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = new DialogResult();

            if (ConfirmExit())
            {
                //无数据则退出
                e.Cancel = false;
            }
            else
            {
                //有数据则询问用户的意见
                dr = MessageBox.Show("是否舍弃输入的数据而退出插入窗口？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    //用户确认舍弃更改，则退出
                    e.Cancel = false;
                }
                else
                {
                    //用户取消退出
                    e.Cancel = true;
                }
            }
        }
    }
}
