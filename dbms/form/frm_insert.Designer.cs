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
<<<<<<< HEAD
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
=======
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(350, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "影响因子";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(245, 114);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 25);
            this.textBox8.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "2007-2009年平均影响因子";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 24);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(178, 25);
            this.textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(167, 53);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 25);
            this.textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(167, 84);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(178, 25);
            this.textBox7.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "2009年影响因子";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 15);
            this.label11.TabIndex = 40;
            this.label11.Text = "2008年影响因子";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 41;
            this.label12.Text = "2007年影响因子";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "2008年总被引频次";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 15);
            this.label15.TabIndex = 43;
            this.label15.Text = "2008年总被引频次";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 15);
            this.label14.TabIndex = 42;
            this.label14.Text = "2009年总被引频次";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(167, 85);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(178, 25);
            this.textBox11.TabIndex = 38;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(167, 56);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(178, 25);
            this.textBox10.TabIndex = 37;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(167, 27);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(178, 25);
            this.textBox9.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(350, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 134);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "引用数";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Controls.Add(this.textBox14);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 343);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基本信息";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
>>>>>>> origin/master
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
<<<<<<< HEAD
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
=======
            this.listBox1.Location = new System.Drawing.Point(105, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 19);
            this.listBox1.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 52;
            this.label19.Text = "中文名称";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 51;
            this.label18.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 50;
            this.label7.Text = "是否Top期刊";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "大类分区";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "复分";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(105, 226);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(178, 25);
            this.textBox16.TabIndex = 47;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(105, 168);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(178, 25);
            this.textBox15.TabIndex = 46;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(105, 110);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(178, 25);
            this.textBox14.TabIndex = 45;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(105, 255);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.MaxLength = 255;
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(178, 73);
            this.textBox13.TabIndex = 44;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 139);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 25);
            this.textBox4.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 81);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 25);
            this.textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 25);
            this.textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 25);
            this.textBox1.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 38;
            this.label4.Text = "大类名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "ISSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "刊名简称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "刊名全称";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(350, 316);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(370, 36);
            this.button.TabIndex = 47;
            this.button.Text = "插入";
            this.button.UseVisualStyleBackColor = true;
>>>>>>> origin/master
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
<<<<<<< HEAD
            this.statusStrip1.Location = new System.Drawing.Point(0, 444);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(824, 29);
=======
            this.statusStrip1.Location = new System.Drawing.Point(0, 369);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(732, 25);
>>>>>>> origin/master
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
<<<<<<< HEAD
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 24);
=======
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
>>>>>>> origin/master
            this.toolStripStatusLabel1.Text = "提示信息：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
<<<<<<< HEAD
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 24);
=======
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(24, 20);
>>>>>>> origin/master
            this.toolStripStatusLabel2.Text = "无";
            // 
            // frm_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(824, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.grp_basic);
            this.Controls.Add(this.grp_cite);
            this.Controls.Add(this.grp_factor);
=======
            this.ClientSize = new System.Drawing.Size(732, 394);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
>>>>>>> origin/master
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frm_insert";
            this.Text = "插入数据";
<<<<<<< HEAD
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_insert_FormClosing);
            this.grp_factor.ResumeLayout(false);
            this.grp_factor.PerformLayout();
            this.grp_cite.ResumeLayout(false);
            this.grp_cite.PerformLayout();
            this.grp_basic.ResumeLayout(false);
            this.grp_basic.PerformLayout();
=======
            this.Load += new System.EventHandler(this.frm_insert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
>>>>>>> origin/master
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD
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
=======
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
>>>>>>> origin/master
    }
}