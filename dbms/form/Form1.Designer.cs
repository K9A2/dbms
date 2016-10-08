namespace dbms
{
    partial class frm_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.sts_down = new System.Windows.Forms.StatusStrip();
            this.tss_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全收藏刊物报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全Top期刊报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.影响因子报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年藏刊影因子报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年藏刊影因子报表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.年藏刊影因子报表ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.引用数报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年藏刊引用数报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年藏刊引用数报表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.年藏刊引用数报表ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_select_frm_main = new System.Windows.Forms.Button();
            this.lsb_select_frm_main = new System.Windows.Forms.ListBox();
            this.txt_inout_frm_main = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.sts_down.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // dgv_main
            // 
            this.dgv_main.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Enabled = false;
            this.dgv_main.Location = new System.Drawing.Point(12, 60);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 27;
            this.dgv_main.Size = new System.Drawing.Size(658, 365);
            this.dgv_main.TabIndex = 3;
            // 
            // sts_down
            // 
            this.sts_down.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sts_down.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_label});
            this.sts_down.Location = new System.Drawing.Point(0, 428);
            this.sts_down.Name = "sts_down";
            this.sts_down.Size = new System.Drawing.Size(682, 25);
            this.sts_down.TabIndex = 5;
            this.sts_down.Text = "您尚未登录";
            // 
            // tss_label
            // 
            this.tss_label.Name = "tss_label";
            this.tss_label.Size = new System.Drawing.Size(189, 20);
            this.tss_label.Text = "您尚未登录，无法进行操作";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.登录ToolStripMenuItem.Text = "登录";
            this.登录ToolStripMenuItem.Click += new System.EventHandler(this.登录ToolStripMenuItem_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Enabled = false;
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 功能ToolStripMenuItem
            // 
            this.功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.查找ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.功能ToolStripMenuItem.Enabled = false;
            this.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            this.功能ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.功能ToolStripMenuItem.Text = "功能";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.增加ToolStripMenuItem.Text = "增加";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查找ToolStripMenuItem.Text = "查找";
            this.查找ToolStripMenuItem.Click += new System.EventHandler(this.查找ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.修改ToolStripMenuItem.Text = "修改";
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全收藏刊物报表ToolStripMenuItem,
            this.全Top期刊报表ToolStripMenuItem,
            this.影响因子报表ToolStripMenuItem,
            this.引用数报表ToolStripMenuItem});
            this.报表ToolStripMenuItem.Enabled = false;
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 全收藏刊物报表ToolStripMenuItem
            // 
            this.全收藏刊物报表ToolStripMenuItem.Name = "全收藏刊物报表ToolStripMenuItem";
            this.全收藏刊物报表ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.全收藏刊物报表ToolStripMenuItem.Text = "全收藏刊物报表";
            // 
            // 全Top期刊报表ToolStripMenuItem
            // 
            this.全Top期刊报表ToolStripMenuItem.Name = "全Top期刊报表ToolStripMenuItem";
            this.全Top期刊报表ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.全Top期刊报表ToolStripMenuItem.Text = "全Top期刊报表";
            // 
            // 影响因子报表ToolStripMenuItem
            // 
            this.影响因子报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.年藏刊影因子报表ToolStripMenuItem,
            this.年藏刊影因子报表ToolStripMenuItem1,
            this.年藏刊影因子报表ToolStripMenuItem2});
            this.影响因子报表ToolStripMenuItem.Name = "影响因子报表ToolStripMenuItem";
            this.影响因子报表ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.影响因子报表ToolStripMenuItem.Text = "藏刊影响因子报表";
            // 
            // 年藏刊影因子报表ToolStripMenuItem
            // 
            this.年藏刊影因子报表ToolStripMenuItem.Name = "年藏刊影因子报表ToolStripMenuItem";
            this.年藏刊影因子报表ToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.年藏刊影因子报表ToolStripMenuItem.Text = "2009年藏刊影响因子报表";
            // 
            // 年藏刊影因子报表ToolStripMenuItem1
            // 
            this.年藏刊影因子报表ToolStripMenuItem1.Name = "年藏刊影因子报表ToolStripMenuItem1";
            this.年藏刊影因子报表ToolStripMenuItem1.Size = new System.Drawing.Size(255, 26);
            this.年藏刊影因子报表ToolStripMenuItem1.Text = "2008年藏刊影响因子报表";
            // 
            // 年藏刊影因子报表ToolStripMenuItem2
            // 
            this.年藏刊影因子报表ToolStripMenuItem2.Name = "年藏刊影因子报表ToolStripMenuItem2";
            this.年藏刊影因子报表ToolStripMenuItem2.Size = new System.Drawing.Size(255, 26);
            this.年藏刊影因子报表ToolStripMenuItem2.Text = "2007年藏刊影响因子报表";
            // 
            // 引用数报表ToolStripMenuItem
            // 
            this.引用数报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.年藏刊引用数报表ToolStripMenuItem,
            this.年藏刊引用数报表ToolStripMenuItem1,
            this.年藏刊引用数报表ToolStripMenuItem2});
            this.引用数报表ToolStripMenuItem.Name = "引用数报表ToolStripMenuItem";
            this.引用数报表ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.引用数报表ToolStripMenuItem.Text = "藏刊引用数报表";
            // 
            // 年藏刊引用数报表ToolStripMenuItem
            // 
            this.年藏刊引用数报表ToolStripMenuItem.Name = "年藏刊引用数报表ToolStripMenuItem";
            this.年藏刊引用数报表ToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.年藏刊引用数报表ToolStripMenuItem.Text = "2009年藏刊引用数报表";
            // 
            // 年藏刊引用数报表ToolStripMenuItem1
            // 
            this.年藏刊引用数报表ToolStripMenuItem1.Name = "年藏刊引用数报表ToolStripMenuItem1";
            this.年藏刊引用数报表ToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.年藏刊引用数报表ToolStripMenuItem1.Text = "2008年藏刊引用数报表";
            // 
            // 年藏刊引用数报表ToolStripMenuItem2
            // 
            this.年藏刊引用数报表ToolStripMenuItem2.Name = "年藏刊引用数报表ToolStripMenuItem2";
            this.年藏刊引用数报表ToolStripMenuItem2.Size = new System.Drawing.Size(240, 26);
            this.年藏刊引用数报表ToolStripMenuItem2.Text = "2007年藏刊引用数报表";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.功能ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_select_frm_main
            // 
            this.btn_select_frm_main.Location = new System.Drawing.Point(514, 32);
            this.btn_select_frm_main.Name = "btn_select_frm_main";
            this.btn_select_frm_main.Size = new System.Drawing.Size(75, 23);
            this.btn_select_frm_main.TabIndex = 2;
            this.btn_select_frm_main.Text = "查找";
            this.btn_select_frm_main.UseVisualStyleBackColor = true;
            this.btn_select_frm_main.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lsb_select_frm_main
            // 
            this.lsb_select_frm_main.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsb_select_frm_main.FormattingEnabled = true;
            this.lsb_select_frm_main.ItemHeight = 20;
            this.lsb_select_frm_main.Items.AddRange(new object[] {
            "刊名全称",
            "刊名简称",
            "ISSN"});
            this.lsb_select_frm_main.Location = new System.Drawing.Point(12, 31);
            this.lsb_select_frm_main.Name = "lsb_select_frm_main";
            this.lsb_select_frm_main.Size = new System.Drawing.Size(120, 24);
            this.lsb_select_frm_main.TabIndex = 6;
            // 
            // txt_inout_frm_main
            // 
            this.txt_inout_frm_main.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_inout_frm_main.Location = new System.Drawing.Point(138, 33);
            this.txt_inout_frm_main.Name = "txt_inout_frm_main";
            this.txt_inout_frm_main.Size = new System.Drawing.Size(370, 23);
            this.txt_inout_frm_main.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(595, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "删除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_inout_frm_main);
            this.Controls.Add(this.lsb_select_frm_main);
            this.Controls.Add(this.sts_down);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.btn_select_frm_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "期刊信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.sts_down.ResumeLayout(false);
            this.sts_down.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_main;
        private System.Windows.Forms.StatusStrip sts_down;
        private System.Windows.Forms.ToolStripStatusLabel tss_label;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全收藏刊物报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全Top期刊报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 影响因子报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年藏刊影因子报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年藏刊影因子报表ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 年藏刊影因子报表ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 引用数报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年藏刊引用数报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年藏刊引用数报表ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 年藏刊引用数报表ToolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_select_frm_main;
        private System.Windows.Forms.ListBox lsb_select_frm_main;
        private System.Windows.Forms.TextBox txt_inout_frm_main;
        private System.Windows.Forms.Button button1;
    }
}

