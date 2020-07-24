using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Calendar
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        public string CurData// Повертають день, місяць, рік
        {
            get
            {
                DateTime dt = monthCalendar1.SelectionStart;
                return dt.ToString("dddd", new CultureInfo("uk-Ua"));
            }
        }

        public string CurMonth
        {
            get
            {
                DateTime dm = monthCalendar1.SelectionStart;
                return dm.ToString("MMMM", new CultureInfo("uk-Ua"));
            }
        }
        public string CurYear
        {
            get
            {
                DateTime dy = monthCalendar1.SelectionStart;
                return dy.ToString("yyyy", new CultureInfo("uk-Ua"));
            }
        }
        //   
        public void Calendar_Design()
        {
            //Дизайн календаря

            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Info;
            this.monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(
                                     ((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(192)));
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Purple;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(
                                     ((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
        }

        public void DayS()
        {
            // Сьогоднішня дата

            DateTime today = this.monthCalendar1.TodayDate;
            DateTime vacationStart = today.AddMonths(0);
            DateTime vacationEnd = vacationStart.AddDays(1);
            this.monthCalendar1.SelectionStart = vacationStart.AddDays(1);
            this.monthCalendar1.SelectionEnd = vacationEnd.AddDays(-1);

            monthCalendar1.MaxSelectionCount = 1;

            // monthCalendar1.SelectionEnd = today.AddDays(-7);
            today = monthCalendar1.SelectionStart;
            string ds = CurData;
            string dm = CurMonth;
            string dy = CurYear;
            string data = today.Day.ToString() + " " + dm + "," + dy + " р.," + " " + ds;
            label2.Text = data;
            label2.Visible = true;

        }
        public void day_Full()
        {
            //Заповнити таблицю Календар по днях
            dataDay.RowTemplate.Height = 50;
            int k = 8;// к-сть годин з 8 години до 22 години
            for (int i = 0; i < 15; i++) //цикл  щоб створити 15 рядків
            {
                dataDay.Rows.Add(k.ToString() + ".00");// виводить час в першій колонці
                k++;
            }
            dataDay.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 10F, FontStyle.Bold);// шрифт 
            //відключити сортування
            foreach (DataGridViewColumn column in dataDay.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Заголовок відключити
            dataDay.RowHeadersVisible = false;

            // розтягнути другий стовпчик на всю ширину
            dataDay.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        public void week_Full()
        {
            //Заповнити таблицю Календар по тижнях
            dataWeek.RowTemplate.Height = 80;//висота рядків
            dataWeek.Columns[0].Width = 50;// ширина стовпця першого
            dataWeek.Rows[0].Height = 50;// висота першого рядка
            for (int i = 2; i <= 7; i++)  // ширина семи стовпців на тижднень
            {
                dataWeek.Columns[i].Width = 200;
            }
            int l = 8;// к-сть год
            for (int i = 0; i < 15; i++) // к-сть рядків
            {
                dataWeek.Rows.Add(l.ToString() + ".00");
                l++;
            }
            dataWeek.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 10F, FontStyle.Bold);// шрифт 
            // вирівнювання тексту в заголовках
            foreach (DataGridViewColumn column in dataDay.Columns)
            {
                // column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            //відключити сортування
            foreach (DataGridViewColumn column in dataWeek.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Заголовок відключити
            dataWeek.RowHeadersVisible = false;

            // розтягнути всі стовпці
            int n = dataWeek.Columns.Count;
            for (int i = 1; i < n; i++)
            {
                dataWeek.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


        }
        public void month_Full()
        {
            //Заповнити таблицю Календар по місяцях
            dataMonth.RowTemplate.Height = 60;//висота рядків
            for (int i = 0; i < 7; i++)// розміри стовпців таблиці
            {
                dataMonth.Columns[i].Width = 200;
            }
            int m = 0;
            for (int j = 0; j <= 6; j++)// додаємо рядки до таблиці
            {
                dataMonth.Rows.Add();
                m++;
            }
            //відключити сортування
            foreach (DataGridViewColumn column in dataMonth.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Заголовок відключити
            dataMonth.RowHeadersVisible = false;
            // розтягнути всі стовпці
            int n = dataMonth.Columns.Count;
            for (int i = 0; i < n; i++)
            {
                dataMonth.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

        // заповнення календар тиждень даними
        public void week_Calendar()
        {
            for (int m = 1; m < 8; m++)
            {

                DateTime d2 = monthCalendar1.SelectionRange.Start;
                d2 = monthCalendar1.SelectionStart;
                string ds = CurData;
                string dm = CurMonth;
                string dy = CurYear;
                // monthCalendar1.SelectionStart = d2.AddDays(0);
                monthCalendar1.SelectionStart = d2.AddDays(1);
                string dw = week_my(ds);
                dataWeek.Columns[m].HeaderText = (d2.Day).ToString() + " " + dm + " " + dy + " р." + dw;

            }

        }


        public string week_my(string ds)
        {
            string dw = "";

            switch (ds)
            {
                case "понеділок": dw = "Пн."; break;
                case "вівторок": dw = "Вт"; break;
                case "середа": dw = "Ср"; break;
                case "четвер": dw = "Чт"; break;
                case "п'ятниця": dw = "Пт"; break;
                case "субота": dw = "Сб"; break;
                case "неділя": dw = "Нд"; break;

            }
            return dw;
        }
        public void WeekCalendarRight() //тиждень вперед або вибрана дата
        {
            DateTime week = monthCalendar1.SelectionRange.Start;//Вибір тижня
            int i = (int)monthCalendar1.SelectionStart.DayOfWeek;
            week = monthCalendar1.SelectionStart;
            monthCalendar1.SelectionStart = week.AddDays(7);

            for (int m = 1; m < 8; m++)
            {
                DateTime d2 = monthCalendar1.SelectionRange.Start;
                d2 = monthCalendar1.SelectionStart;

                string ds = CurData;
                string dm = CurMonth;
                string dy = CurYear;
                monthCalendar1.SelectionStart = d2.AddDays(1);
                string dw = week_my(ds);
                dataWeek.Columns[m].HeaderText = (d2.Day).ToString() + " " + dm + " " + dy + " р." + dw;

            }
        }
        public void WeekCalendarLeft()// Тиждень назад
        {
            DateTime week = monthCalendar1.SelectionRange.Start;
            int i = (int)monthCalendar1.SelectionStart.DayOfWeek;
            week = monthCalendar1.SelectionStart;
            monthCalendar1.SelectionStart = week.AddDays(-7);
            monthCalendar1.SelectionEnd = week.AddDays(-1 + 1);//Зняття виділення дати


            for (int m = 7; m >= 1; m--)
            {
                DateTime d2 = monthCalendar1.SelectionRange.Start;
                d2 = monthCalendar1.SelectionStart;
                string ds = CurData;
                string dm = CurMonth;
                string dy = CurYear;
                string dw = week_my(ds);
                monthCalendar1.SelectionStart = d2.AddDays(-1);
                dataWeek.Columns[m].HeaderText = (d2.Day).ToString() + " " + dm + " " + dy + " р. " + dw;

            }
        }
        public void Day_Right()//день вперед
        {
            DateTime dt = monthCalendar1.SelectionStart;
            string data = dt.Day + "." + dt.Month + "." + dt.Year;

            DateTime d = monthCalendar1.SelectionRange.Start;
            int i = (int)monthCalendar1.SelectionStart.DayOfWeek;
            label3.Text = i.ToString();
            d = monthCalendar1.SelectionStart;
            label4.Text = d.ToString();
            monthCalendar1.SelectionStart = d.AddDays(1);

            DateTime dt1 = monthCalendar1.SelectionStart;
            DateTime d1 = monthCalendar1.SelectionRange.Start;
            string ds = CurData;
            string dm = CurMonth;
            string dy = CurYear;

            label2.Text = (d1.Day).ToString() + " " + dm + "," + dy + " р.," + " " + ds;
            label2.Visible = true;
        }
        public void Day_Left()// день назад
        {
            DateTime dt = monthCalendar1.SelectionStart;
            string data = dt.Day + "." + dt.Month + "." + dt.Year;

            DateTime d = monthCalendar1.SelectionRange.Start;
            int i = (int)monthCalendar1.SelectionStart.DayOfWeek;
            d = monthCalendar1.SelectionStart;
            monthCalendar1.SelectionStart = d.AddDays(-1);

            DateTime dt1 = monthCalendar1.SelectionStart;
            DateTime d1 = monthCalendar1.SelectionRange.Start;
            string ds = CurData;
            string dm = CurMonth;
            string dy = CurYear;

            label2.Text = (d1.Day).ToString() + " " + dm + "," + dy + " р.," + " " + ds;
            label2.Visible = true;
            monthCalendar1.SelectionEnd = d1.AddDays(-1 + 1);//Знімає виділення
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Load
            // Оформлення календаря
            Calendar_Design();//дизайн
            DayS();//день сьогодні

            day_Full();//формування таблиць календарів
            week_Full();
            month_Full();

            week_Calendar();//ініціалізація календаря по тижнях




        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DrawDayOfWeek();

            // You can acquire the range using this property accessor.
            SelectionRange range = monthCalendar1.SelectionRange;
            DateTime start = range.Start;
            DateTime end = range.End;

            // Alternatively, you can use the SelectionStart and End properties.
            DateTime startB = monthCalendar1.SelectionStart;
            DateTime endB = monthCalendar1.SelectionEnd;


            textBox1.Text = monthCalendar1.SelectionStart.DayOfWeek.ToString();

            DateTime dt = monthCalendar1.SelectionStart;
            string data = dt.Day + "." + dt.Month + "." + dt.Year;

            textBox2.Text = dt.Day.ToString();
            textBox3.Text = dt.Month.ToString();
            textBox4.Text = dt.Year.ToString();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Change
            //  MessageBox.Show("DateChanged: " +monthCalendar1.SelectionRange.ToString());

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

           
            // Вибір дати в календарі
            label1.Text = "Дата:" + monthCalendar1.SelectionStart.ToShortDateString().ToString();

            DateTime dt = monthCalendar1.SelectionStart;
            string data = dt.Day + "." + dt.Month + "." + dt.Year;

            string ds = CurData;
            string dm = CurMonth;
            string dy = CurYear;
            label2.Text = dt.Day.ToString() + " " + dm + "," + dy + " р.," + " " + ds;
            label2.Visible = true;


            //відображення вибраного тижня
          //    week_Calendar();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Click

            dataWeek.Rows[2].Cells[3].Value = label1.Text;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //вперед день
            Day_Right();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //назад день
            Day_Left();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Today дата сьогодні
            DayS();
            week_Calendar();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Вправо тиждень

            WeekCalendarRight();


        }
        private void button8_Click(object sender, EventArgs e)
        {
            // вліво тиждень
            WeekCalendarLeft();

        }

		private void dataWeek_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
            for (int i = 0; i < dataWeek.SelectedCells.Count; i++)
            {
                if (dataWeek.SelectedCells[i].Style.BackColor == Color.Blue)
                {
                    dataWeek.SelectedCells[i].Style.BackColor = Color.White;
                }
                else
                {
                    dataWeek.SelectedCells[i].Style.BackColor = Color.Blue;
                }
            }
        }
    }
	
}
