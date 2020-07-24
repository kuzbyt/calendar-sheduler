namespace Calendar
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataDay = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataWeek = new System.Windows.Forms.DataGridView();
			this.Час = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ПН = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ВТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.СР = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ЧТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ПТ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.СБ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.НД = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataMonth = new System.Windows.Forms.DataGridView();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataDay)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataWeek)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataMonth)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Bisque;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.monthCalendar1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(197, 565);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Вибір дати";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 532);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Дата:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(133, 529);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(43, 30);
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar1.BackColor = System.Drawing.Color.Maroon;
			this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 3);
			this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 1;
			this.monthCalendar1.TitleBackColor = System.Drawing.Color.Gold;
			this.monthCalendar1.TrailingForeColor = System.Drawing.Color.DarkOrange;
			this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(197, 529);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(871, 36);
			this.panel1.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(490, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(322, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "label3";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(211, 6);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(67, 20);
			this.textBox4.TabIndex = 17;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(154, 6);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(51, 20);
			this.textBox3.TabIndex = 16;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(92, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(56, 20);
			this.textBox2.TabIndex = 15;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(43, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(43, 20);
			this.textBox1.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Bisque;
			this.panel2.Controls.Add(this.button8);
			this.panel2.Controls.Add(this.button7);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(197, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(871, 42);
			this.panel2.TabIndex = 14;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.PeachPuff;
			this.button8.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button8.Location = new System.Drawing.Point(540, 4);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(39, 35);
			this.button8.TabIndex = 22;
			this.button8.Text = "<<";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.PeachPuff;
			this.button7.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button7.Location = new System.Drawing.Point(585, 4);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 35);
			this.button7.TabIndex = 21;
			this.button7.Text = ">>";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.PeachPuff;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button4.Location = new System.Drawing.Point(51, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 35);
			this.button4.TabIndex = 18;
			this.button4.Text = "сьогодні";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.PapayaWhip;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Purple;
			this.label2.Location = new System.Drawing.Point(195, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(339, 35);
			this.label2.TabIndex = 17;
			this.label2.Text = "label2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Visible = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.PeachPuff;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(154, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 35);
			this.button3.TabIndex = 16;
			this.button3.Text = ">>";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.PeachPuff;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(6, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(39, 35);
			this.button2.TabIndex = 15;
			this.button2.Text = "<<";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tabControl1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(197, 42);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(871, 487);
			this.panel3.TabIndex = 15;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(871, 487);
			this.tabControl1.TabIndex = 6;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tabPage1.Controls.Add(this.dataDay);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(863, 461);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "День";
			// 
			// dataDay
			// 
			this.dataDay.BackgroundColor = System.Drawing.Color.OldLace;
			this.dataDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataDay.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataDay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataDay.Location = new System.Drawing.Point(3, 3);
			this.dataDay.Name = "dataDay";
			this.dataDay.Size = new System.Drawing.Size(857, 455);
			this.dataDay.TabIndex = 0;
			// 
			// Column1
			// 
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column1.HeaderText = "Час";
			this.Column1.Name = "Column1";
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column2.HeaderText = "Запис";
			this.Column2.MinimumWidth = 500;
			this.Column2.Name = "Column2";
			this.Column2.Width = 10000;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tabPage2.Controls.Add(this.dataWeek);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(863, 461);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Тиждень";
			// 
			// dataWeek
			// 
			this.dataWeek.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataWeek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Час,
            this.ПН,
            this.ВТ,
            this.СР,
            this.ЧТ,
            this.ПТ,
            this.СБ,
            this.НД});
			this.dataWeek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataWeek.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataWeek.Location = new System.Drawing.Point(3, 3);
			this.dataWeek.Name = "dataWeek";
			this.dataWeek.RowHeadersVisible = false;
			this.dataWeek.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataWeek.RowTemplate.Height = 50;
			this.dataWeek.Size = new System.Drawing.Size(857, 455);
			this.dataWeek.TabIndex = 6;
			this.dataWeek.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataWeek_CellMouseUp);
			// 
			// Час
			// 
			this.Час.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Час.DefaultCellStyle = dataGridViewCellStyle5;
			this.Час.HeaderText = "Час";
			this.Час.Name = "Час";
			this.Час.ReadOnly = true;
			// 
			// ПН
			// 
			this.ПН.HeaderText = "";
			this.ПН.Name = "ПН";
			// 
			// ВТ
			// 
			this.ВТ.HeaderText = "";
			this.ВТ.Name = "ВТ";
			// 
			// СР
			// 
			this.СР.HeaderText = "";
			this.СР.Name = "СР";
			// 
			// ЧТ
			// 
			this.ЧТ.HeaderText = "";
			this.ЧТ.Name = "ЧТ";
			// 
			// ПТ
			// 
			this.ПТ.HeaderText = "";
			this.ПТ.Name = "ПТ";
			// 
			// СБ
			// 
			this.СБ.HeaderText = "";
			this.СБ.Name = "СБ";
			// 
			// НД
			// 
			this.НД.HeaderText = "";
			this.НД.Name = "НД";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.tabPage3.Controls.Add(this.dataMonth);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(863, 461);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Місяць";
			// 
			// dataMonth
			// 
			this.dataMonth.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.dataMonth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataMonth.Location = new System.Drawing.Point(3, 3);
			this.dataMonth.Name = "dataMonth";
			this.dataMonth.Size = new System.Drawing.Size(857, 455);
			this.dataMonth.TabIndex = 0;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "понеділок";
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "вівторок";
			this.Column4.Name = "Column4";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "середа";
			this.Column6.Name = "Column6";
			// 
			// Column7
			// 
			this.Column7.HeaderText = "четвер";
			this.Column7.Name = "Column7";
			// 
			// Column8
			// 
			this.Column8.HeaderText = "п\'ятниця";
			this.Column8.Name = "Column8";
			// 
			// Column9
			// 
			this.Column9.HeaderText = "субота";
			this.Column9.Name = "Column9";
			// 
			// Column10
			// 
			this.Column10.HeaderText = "неділя";
			this.Column10.Name = "Column10";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 565);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Calendat Sheduler";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataDay)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataWeek)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataMonth)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataDay;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataWeek;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dataMonth;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		public System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Час;
		private System.Windows.Forms.DataGridViewTextBoxColumn ПН;
		private System.Windows.Forms.DataGridViewTextBoxColumn ВТ;
		private System.Windows.Forms.DataGridViewTextBoxColumn СР;
		private System.Windows.Forms.DataGridViewTextBoxColumn ЧТ;
		private System.Windows.Forms.DataGridViewTextBoxColumn ПТ;
		private System.Windows.Forms.DataGridViewTextBoxColumn СБ;
		private System.Windows.Forms.DataGridViewTextBoxColumn НД;
	}
}

