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
<<<<<<< HEAD
        //指示所有输入数据是否合法
        private bool isAcceptable = false;

        //状态栏提示信息

=======
        //状态栏提示信息
        string msg_fname = "";
        string msg_sname = "";
        string msg_
>>>>>>> origin/master

        public frm_insert()
        {
            InitializeComponent();

            //设置各下拉菜单的默认选项
            cbo_classID.SelectedIndex = 0;
            cbo_className.SelectedIndex = 0;
            cbo_isTop.SelectedIndex = 0;
        }

<<<<<<< HEAD
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

        private void txt_factor_09_Leave(object sender, EventArgs e)
        {
            CheckInputNumber(txt_factor_09.Text.ToString().Trim(), lbl_factor_09);
        }

        private void txt_factor_08_Leave(object sender, EventArgs e)
        {
            CheckInputNumber(txt_factor_08.Text.ToString().Trim(), lbl_factor_08);
        }

        private void txt_factor_07_Leave(object sender, EventArgs e)
        {
            CheckInputNumber(txt_factor_07.Text.ToString().Trim(), lbl_factor_07);
        }

        /// <summary>
        /// 检查输入的字符串是否为数字,并设置isAcceptable标志
        /// </summary>
        /// <returns>true为数字；false则为非纯数字</returns>
        private bool CheckInputNumber(string input, Label lbl)
        {
            float value = 0;
            if (!float.TryParse(input, out value))
            {
                MessageBox.Show("请在" + lbl.Text.ToString().Trim() + " 中输入数字");
                isAcceptable = false;
                return false;
            }
            else
            {
                isAcceptable = true;
                return true;
            }
        }

        /// <summary>
        /// 确认窗体中各输入控件内是否还有数据
        /// </summary>
        /// <returns>true为无数据；false为有数据</returns>
        private bool ConfirmExit()
        {
            //判断所有输入框是否都被清空
            if (txt_fname.Text.ToString() == "" &&
                txt_sname.Text.ToString() == "" &&
                txt_issn.Text.ToString() == "" &&
                txt_cname.Text.ToString() == "" &&
                cbo_className.SelectedItem.ToString() == "" &&
                txt_multiClass.Text.ToString() == "" &&
                cbo_classID.SelectedItem.ToString() == "" &&
                cbo_isTop.SelectedItem.ToString() == "" &&
                txt_note.Text.ToString() == "" &&
                txt_factor_09.Text.ToString() == "" &&
                txt_factor_08.Text.ToString() == "" &&
                txt_factor_07.Text.ToString() == "" &&
                txt_cite_09.Text.ToString() == "" &&
                txt_cite_08.Text.ToString() == "" &&
                txt_cite_07.Text.ToString() == ""
                )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

=======
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_insert_Load(object sender, EventArgs e)
        {
            
        }
>>>>>>> origin/master
    }
}
