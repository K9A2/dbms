namespace dbms
{
    partial class frm_insert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_factor = new System.Windows.Forms.GroupBox();
            this.txt_avgFactor = new System.Windows.Forms.TextBox();
            this.lbl_avgFactor = new System.Windows.Forms.Label();
            this.txt_factor_09 = new System.Windows.Forms.TextBox();
            this.txt_factor_08 = new System.Windows.Forms.TextBox();
            this.txt_factor_07 = new System.Windows.Forms.TextBox();
            this.lbl_factor_09 = new System.Windows.Forms.Label();
            this.lbl_factor_08 = new System.Windows.Forms.Label();
            this.lbl_factor_07 = new System.Windows.Forms.Label();
            this.lbl_cite_07 = new System.Windows.Forms.Label();
            this.lbl_cite_08 = new System.Windows.Forms.Label();
            this.lbl_cite_09 = new System.Windows.Forms.Label();
            this.txt_cite_07 = new System.Windows.Forms.TextBox();
            this.txt_cite_08 = new System.Windows.Forms.TextBox();
            this.txt_cite_09 = new System.Windows.Forms.TextBox();
            this.grp_cite = new System.Windows.Forms.GroupBox();
            this.grp_basic = new System.Windows.Forms.GroupBox();
            this.cbo_isTop = new System.Windows.Forms.ComboBox();
            this.cbo_className = new System.Windows.Forms.ComboBox();
            this.cbo_classID = new System.Windows.Forms.ComboBox();
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_isTop = new System.Windows.Forms.Label();
            this.lbl_classID = new System.Windows.Forms.Label();
            this.lbl_multiClass = new System.Windows.Forms.Label();
            this.txt_multiClass = new System.Windows.Forms.TextBox();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.txt_issn = new System.Windows.Forms.TextBox();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_className = new System.Windows.Forms.Label();
            this.lbl_issn = new System.Windows.Forms.Label();
            this.lbl_sname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grp_factor.SuspendLayout();
            this.grp_cite.SuspendLayout();
            this.grp_basic.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_factor
            // 
            this.grp_factor.Controls.Add(this.txt_avgFactor);
            this.grp_factor.Controls.Add(this.lbl_avgFactor);
            this.grp_factor.Controls.Add(this.txt_factor_09);
            this.grp_factor.Controls.Add(this.txt_factor_08);
            this.grp_factor.Controls.Add(this.txt_factor_07);
            this.grp_factor.Controls.Add(this.lbl_factor_09);
            this.grp_factor.Controls.Add(this.lbl_factor_08);
            this.grp_factor.Controls.Add(this.lbl_factor_07);
            this.grp_factor.Location = new System.Drawing.Point(394, 12);
            this.grp_factor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_factor.Name = "grp_factor";
            this.grp_factor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_factor.Size = new System.Drawing.Size(416, 192);
            this.grp_factor.TabIndex = 1;
            this.grp_factor.TabStop = false;
            this.grp_factor.Text = "影响因子";
            // 
            // txt_avgFactor
            // 
            this.txt_avgFactor.Location = new System.Drawing.Point(276, 137);
            this.txt_avgFactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_avgFactor.Name = "txt_avgFactor";
            this.txt_avgFactor.ReadOnly = true;
            this.txt_avgFactor.Size = new System.Drawing.Size(112, 28);
            this.txt_avgFactor.TabIndex = 45;
            // 
            // lbl_avgFactor
            // 
            this.lbl_avgFactor.AutoSize = true;
            this.lbl_avgFactor.Location = new System.Drawing.Point(30, 143);
            this.lbl_avgFactor.Name = "lbl_avgFactor";
            this.lbl_avgFactor.Size = new System.Drawing.Size(215, 18);
            this.lbl_avgFactor.TabIndex = 45;
            this.lbl_avgFactor.Text = "2007-2009年平均影响因子";
            // 
            // txt_factor_09
            // 
            this.txt_factor_09.Location = new System.Drawing.Point(188, 29);
            this.txt_factor_09.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_factor_09.Name = "txt_factor_09";
            this.txt_factor_09.Size = new System.Drawing.Size(200, 28);
            this.txt_factor_09.TabIndex = 33;
            this.txt_factor_09.Leave += new System.EventHandler(this.txt_factor_09_Leave);
            // 
            // txt_factor_08
            // 
            this.txt_factor_08.Location = new System.Drawing.Point(188, 64);
            this.txt_factor_08.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_factor_08.Name = "txt_factor_08";
            this.txt_factor_08.Size = new System.Drawing.Size(200, 28);
            this.txt_factor_08.TabIndex = 34;
            this.txt_factor_08.Leave += new System.EventHandler(this.txt_factor_08_Leave);
            // 
            // txt_factor_07
            // 
            this.txt_factor_07.Location = new System.Drawing.Point(188, 101);
            this.txt_factor_07.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_factor_07.Name = "txt_factor_07";
            this.txt_factor_07.Size = new System.Drawing.Size(200, 28);
            this.txt_factor_07.TabIndex = 35;
            this.txt_factor_07.Leave += new System.EventHandler(this.txt_factor_07_Leave);
            // 
            // lbl_factor_09
            // 
            this.lbl_factor_09.AutoSize = true;
            this.lbl_factor_09.Location = new System.Drawing.Point(30, 35);
            this.lbl_factor_09.Name = "lbl_factor_09";
            this.lbl_factor_09.Size = new System.Drawing.Size(134, 18);
            this.lbl_factor_09.TabIndex = 39;
            this.lbl_factor_09.Text = "2009年影响因子";
            // 
            // lbl_factor_08
            // 
            this.lbl_factor_08.AutoSize = true;
            this.lbl_factor_08.Location = new System.Drawing.Point(30, 70);
            this.lbl_factor_08.Name = "lbl_factor_08";
            this.lbl_factor_08.Size = new System.Drawing.Size(134, 18);
            this.lbl_factor_08.TabIndex = 40;
            this.lbl_factor_08.Text = "2008年影响因子";
            // 
            // lbl_factor_07
            // 
            this.lbl_factor_07.AutoSize = true;
            this.lbl_factor_07.Location = new System.Drawing.Point(30, 107);
            this.lbl_factor_07.Name = "lbl_factor_07";
            this.lbl_factor_07.Size = new System.Drawing.Size(134, 18);
            this.lbl_factor_07.TabIndex = 41;
            this.lbl_factor_07.Text = "2007年影响因子";
            // 
            // lbl_cite_07
            // 
            this.lbl_cite_07.AutoSize = true;
            this.lbl_cite_07.Location = new System.Drawing.Point(30, 108);
            this.lbl_cite_07.Name = "lbl_cite_07";
            this.lbl_cite_07.Size = new System.Drawing.Size(152, 18);
            this.lbl_cite_07.TabIndex = 44;
            this.lbl_cite_07.Text = "2007年总被引频次";
            // 
            // lbl_cite_08
            // 
            this.lbl_cite_08.AutoSize = true;
            this.lbl_cite_08.Location = new System.Drawing.Point(30, 73);
            this.lbl_cite_08.Name = "lbl_cite_08";
            this.lbl_cite_08.Size = new System.Drawing.Size(152, 18);
            this.lbl_cite_08.TabIndex = 43;
            this.lbl_cite_08.Text = "2008年总被引频次";
            // 
            // lbl_cite_09
            // 
            this.lbl_cite_09.AutoSize = true;
            this.lbl_cite_09.Location = new System.Drawing.Point(30, 38);
            this.lbl_cite_09.Name = "lbl_cite_09";
            this.lbl_cite_09.Size = new System.Drawing.Size(152, 18);
            this.lbl_cite_09.TabIndex = 42;
            this.lbl_cite_09.Text = "2009年总被引频次";
            // 
            // txt_cite_07
            // 
            this.txt_cite_07.Location = new System.Drawing.Point(188, 102);
            this.txt_cite_07.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cite_07.Name = "txt_cite_07";
            this.txt_cite_07.Size = new System.Drawing.Size(200, 28);
            this.txt_cite_07.TabIndex = 38;
            // 
            // txt_cite_08
            // 
            this.txt_cite_08.Location = new System.Drawing.Point(188, 67);
            this.txt_cite_08.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cite_08.Name = "txt_cite_08";
            this.txt_cite_08.Size = new System.Drawing.Size(200, 28);
            this.txt_cite_08.TabIndex = 37;
            // 
            // txt_cite_09
            // 
            this.txt_cite_09.Location = new System.Drawing.Point(188, 32);
            this.txt_cite_09.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cite_09.Name = "txt_cite_09";
            this.txt_cite_09.Size = new System.Drawing.Size(200, 28);
            this.txt_cite_09.TabIndex = 36;
            // 
            // grp_cite
            // 
            this.grp_cite.Controls.Add(this.txt_cite_09);
            this.grp_cite.Controls.Add(this.lbl_cite_07);
            this.grp_cite.Controls.Add(this.txt_cite_08);
            this.grp_cite.Controls.Add(this.lbl_cite_08);
            this.grp_cite.Controls.Add(this.txt_cite_07);
            this.grp_cite.Controls.Add(this.lbl_cite_09);
            this.grp_cite.Location = new System.Drawing.Point(394, 211);
            this.grp_cite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_cite.Name = "grp_cite";
            this.grp_cite.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_cite.Size = new System.Drawing.Size(416, 161);
            this.grp_cite.TabIndex = 45;
            this.grp_cite.TabStop = false;
            this.grp_cite.Text = "引用数";
            // 
            // grp_basic
            // 
            this.grp_basic.Controls.Add(this.cbo_isTop);
            this.grp_basic.Controls.Add(this.cbo_className);
            this.grp_basic.Controls.Add(this.cbo_classID);
            this.grp_basic.Controls.Add(this.lbl_cname);
            this.grp_basic.Controls.Add(this.lbl_note);
            this.grp_basic.Controls.Add(this.lbl_isTop);
            this.grp_basic.Controls.Add(this.lbl_classID);
            this.grp_basic.Controls.Add(this.lbl_multiClass);
            this.grp_basic.Controls.Add(this.txt_multiClass);
            this.grp_basic.Controls.Add(this.txt_cname);
            this.grp_basic.Controls.Add(this.txt_note);
            this.grp_basic.Controls.Add(this.txt_issn);
            this.grp_basic.Controls.Add(this.txt_sname);
            this.grp_basic.Controls.Add(this.txt_fname);
            this.grp_basic.Controls.Add(this.lbl_className);
            this.grp_basic.Controls.Add(this.lbl_issn);
            this.grp_basic.Controls.Add(this.lbl_sname);
            this.grp_basic.Controls.Add(this.lbl_fname);
            this.grp_basic.Location = new System.Drawing.Point(15, 12);
            this.grp_basic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_basic.Name = "grp_basic";
            this.grp_basic.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grp_basic.Size = new System.Drawing.Size(345, 412);
            this.grp_basic.TabIndex = 46;
            this.grp_basic.TabStop = false;
            this.grp_basic.Text = "基本信息";
            // 
            // cbo_isTop
            // 
            this.cbo_isTop.FormattingEnabled = true;
            this.cbo_isTop.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cbo_isTop.Location = new System.Drawing.Point(125, 271);
            this.cbo_isTop.Name = "cbo_isTop";
            this.cbo_isTop.Size = new System.Drawing.Size(200, 26);
            this.cbo_isTop.TabIndex = 55;
            // 
            // cbo_className
            // 
            this.cbo_className.FormattingEnabled = true;
            this.cbo_className.Items.AddRange(new object[] {
            "地学",
            "地学天文",
            "工程技术",
            "管理科学",
            "化学",
            "环境科学",
            "农林科学",
            "社会科学",
            "生物",
            "数学",
            "物理",
            "医学",
            "综合性期刊"});
            this.cbo_className.Location = new System.Drawing.Point(125, 168);
            this.cbo_className.Name = "cbo_className";
            this.cbo_className.Size = new System.Drawing.Size(200, 26);
            this.cbo_className.TabIndex = 54;
            // 
            // cbo_classID
            // 
            this.cbo_classID.FormattingEnabled = true;
            this.cbo_classID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbo_classID.Location = new System.Drawing.Point(125, 237);
            this.cbo_classID.Name = "cbo_classID";
            this.cbo_classID.Size = new System.Drawing.Size(200, 26);
            this.cbo_classID.TabIndex = 53;
            // 
            // lbl_cname
            // 
            this.lbl_cname.AutoSize = true;
            this.lbl_cname.Location = new System.Drawing.Point(16, 138);
            this.lbl_cname.Name = "lbl_cname";
            this.lbl_cname.Size = new System.Drawing.Size(80, 18);
            this.lbl_cname.TabIndex = 52;
            this.lbl_cname.Text = "中文名称";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(18, 310);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(44, 18);
            this.lbl_note.TabIndex = 51;
            this.lbl_note.Text = "备注";
            // 
            // lbl_isTop
            // 
            this.lbl_isTop.AutoSize = true;
            this.lbl_isTop.Location = new System.Drawing.Point(16, 277);
            this.lbl_isTop.Name = "lbl_isTop";
            this.lbl_isTop.Size = new System.Drawing.Size(107, 18);
            this.lbl_isTop.TabIndex = 50;
            this.lbl_isTop.Text = "是否Top期刊";
            // 
            // lbl_classID
            // 
            this.lbl_classID.AutoSize = true;
            this.lbl_classID.Location = new System.Drawing.Point(16, 242);
            this.lbl_classID.Name = "lbl_classID";
            this.lbl_classID.Size = new System.Drawing.Size(80, 18);
            this.lbl_classID.TabIndex = 49;
            this.lbl_classID.Text = "大类分区";
            // 
            // lbl_multiClass
            // 
            this.lbl_multiClass.AutoSize = true;
            this.lbl_multiClass.Location = new System.Drawing.Point(16, 208);
            this.lbl_multiClass.Name = "lbl_multiClass";
            this.lbl_multiClass.Size = new System.Drawing.Size(44, 18);
            this.lbl_multiClass.TabIndex = 48;
            this.lbl_multiClass.Text = "复分";
            // 
            // txt_multiClass
            // 
            this.txt_multiClass.Location = new System.Drawing.Point(125, 202);
            this.txt_multiClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_multiClass.Name = "txt_multiClass";
            this.txt_multiClass.Size = new System.Drawing.Size(200, 28);
            this.txt_multiClass.TabIndex = 46;
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(125, 132);
            this.txt_cname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(200, 28);
            this.txt_cname.TabIndex = 45;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(125, 306);
            this.txt_note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_note.MaxLength = 255;
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(200, 87);
            this.txt_note.TabIndex = 44;
            // 
            // txt_issn
            // 
            this.txt_issn.Location = new System.Drawing.Point(125, 97);
            this.txt_issn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_issn.Name = "txt_issn";
            this.txt_issn.Size = new System.Drawing.Size(200, 28);
            this.txt_issn.TabIndex = 41;
            // 
            // txt_sname
            // 
            this.txt_sname.Location = new System.Drawing.Point(125, 62);
            this.txt_sname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(200, 28);
            this.txt_sname.TabIndex = 40;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(125, 28);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(200, 28);
            this.txt_fname.TabIndex = 39;
            // 
            // lbl_className
            // 
            this.lbl_className.AutoSize = true;
            this.lbl_className.Location = new System.Drawing.Point(16, 173);
            this.lbl_className.Name = "lbl_className";
            this.lbl_className.Size = new System.Drawing.Size(80, 18);
            this.lbl_className.TabIndex = 38;
            this.lbl_className.Text = "大类名称";
            // 
            // lbl_issn
            // 
            this.lbl_issn.AutoSize = true;
            this.lbl_issn.Location = new System.Drawing.Point(16, 103);
            this.lbl_issn.Name = "lbl_issn";
            this.lbl_issn.Size = new System.Drawing.Size(44, 18);
            this.lbl_issn.TabIndex = 37;
            this.lbl_issn.Text = "ISSN";
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Location = new System.Drawing.Point(16, 68);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(80, 18);
            this.lbl_sname.TabIndex = 36;
            this.lbl_sname.Text = "刊名简称";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(16, 34);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(80, 18);
            this.lbl_fname.TabIndex = 35;
            this.lbl_fname.Text = "刊名全称";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(394, 379);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(416, 43);
            this.btn_insert.TabIndex = 47;
            this.btn_insert.Text = "插入";
            this.btn_insert.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(824, 29);
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel1.Text = "提示信息：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 24);
            this.toolStripStatusLabel2.Text = "无";
            // 
            // frm_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.grp_basic);
            this.Controls.Add(this.grp_cite);
            this.Controls.Add(this.grp_factor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_insert";
            this.Text = "插入数据";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_insert_FormClosing);
            this.grp_factor.ResumeLayout(false);
            this.grp_factor.PerformLayout();
            this.grp_cite.ResumeLayout(false);
            this.grp_cite.PerformLayout();
            this.grp_basic.ResumeLayout(false);
            this.grp_basic.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_factor;
        private System.Windows.Forms.TextBox txt_avgFactor;
        private System.Windows.Forms.Label lbl_avgFactor;
        private System.Windows.Forms.TextBox txt_factor_09;
        private System.Windows.Forms.TextBox txt_factor_08;
        private System.Windows.Forms.TextBox txt_factor_07;
        private System.Windows.Forms.Label lbl_factor_09;
        private System.Windows.Forms.Label lbl_factor_08;
        private System.Windows.Forms.Label lbl_factor_07;
        private System.Windows.Forms.Label lbl_cite_07;
        private System.Windows.Forms.Label lbl_cite_08;
        private System.Windows.Forms.Label lbl_cite_09;
        private System.Windows.Forms.TextBox txt_cite_07;
        private System.Windows.Forms.TextBox txt_cite_08;
        private System.Windows.Forms.TextBox txt_cite_09;
        private System.Windows.Forms.GroupBox grp_cite;
        private System.Windows.Forms.GroupBox grp_basic;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_isTop;
        private System.Windows.Forms.Label lbl_classID;
        private System.Windows.Forms.Label lbl_multiClass;
        private System.Windows.Forms.TextBox txt_multiClass;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox txt_issn;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_className;
        private System.Windows.Forms.Label lbl_issn;
        private System.Windows.Forms.Label lbl_sname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ComboBox cbo_classID;
        private System.Windows.Forms.ComboBox cbo_isTop;
        private System.Windows.Forms.ComboBox cbo_className;
    }
}