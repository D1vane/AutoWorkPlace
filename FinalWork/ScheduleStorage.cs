using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork
{
    public partial class ScheduleStorage : Form
    {
        Menu menu = new Menu();
        Excel excel = new Excel("Информация о специалистах", 1);
        int countSpecialists, countColumnSpecialisation, countColumnSpecialist; // переменные для хранения информации о строках и столбцах в файле excel
        static int specialisationindex = - 1, dayindex = -1; // переменные для хранения выбранных элементов в списках
        public int Specialisationindex { get { return specialisationindex; } set { specialisationindex = value; } }
        public int Dayindex { get { return dayindex; } set { dayindex = value; } }
        public ScheduleStorage()
        {
            excel.Close();
        }
        public ScheduleStorage(Menu menu,int day,int specialisation) // конструктор, в котором восстанавливаются данные с предыдущей сессии
        {
            InitializeComponent();
            countSpecialists = excel.RowsCount();
            countColumnSpecialisation = excel.SearchTitle("_Специальность");
            int countColumnSName = excel.SearchTitle("_Фамилия");
            string specialisationrec = "";
            int tempspec = 2;
            int countColumn = excel.ColumnsCount(1);
            excel.SortRows(2, countColumn, countColumnSpecialisation);

            for (int j = tempspec; j <= countSpecialists; j++) // получение списка специальностей по которым не все врачи отдыхают
            {
                string profession = excel.ReadColumns(j, countColumnSpecialisation);
                tempspec++;
                if (profession != specialisationrec)
                {

                    Specialisation.Items.Add(profession);


                    specialisationrec = profession;
                }
            }
            excel.SortRows(2, countColumn, countColumnSName);

            specialisationindex = specialisation;
            dayindex = day;
            this.menu = menu;
            
            if (specialisationindex >= 0)
                Specialisation.SelectedIndex = specialisationindex;
            if (dayindex >= 0)
                DaysOfWeek.SelectedIndex = dayindex;

        }

        private void BacktoMenu_Click(object sender, EventArgs e) // вернуться в меню с сохранением текущего состояния
        {
            specialisationindex = Specialisation.SelectedIndex;
            dayindex = DaysOfWeek.SelectedIndex;
            excel.Close();
            menu.Show();
            Close();
        }

        private void hideForm_MouseEnter(object sender, EventArgs e) // функция содержащая в себе определенные события при наведении мыши на кнопку
        {
            hideForm.ForeColor = Color.Blue;
            ToolTip t = new ToolTip();
            t.SetToolTip(hideForm, "Свернуть");
        }

        private void hideForm_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            hideForm.ForeColor = Color.White;
        }

        private void hideForm_Click(object sender, EventArgs e) // свернуть окно
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BacktoMenu_MouseEnter(object sender, EventArgs e) // функция содержащая в себе определенные события при наведении мыши на кнопку
        {
            BacktoMenu.ForeColor = Color.Blue;
            ToolTip t = new ToolTip();
            t.SetToolTip(BacktoMenu, "Вернуться в главное меню");
        }
        System.Drawing.Point lastpoint;
        private void upperpanel_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void upperpanel_MouseDown(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            lastpoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void DaysOfWeek_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void DaysOfWeek_MouseDown(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            lastpoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void Specialisation_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Specialisation_MouseDown(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            lastpoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void Specialists_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Specialists_MouseDown(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            lastpoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void BacktoMenu_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            BacktoMenu.ForeColor = Color.White;
        }

        private void Specialisation_SelectedIndexChanged(object sender, EventArgs e) // описание состояния окна при выборе специализации
        {
            countSpecialists = excel.RowsCount();
            countColumnSpecialisation = excel.SearchTitle("Специальность");
            countColumnSpecialist = excel.SearchTitle(DaysOfWeek.Text);

            int countNumberofDistrict = excel.SearchTitle("№ Участка");
            int countNumberofCabinet = excel.SearchTitle("Кабинет");
            string cabinet = "";
            string district = "";
            Specialists.Items.Clear();
            string specialisation = Specialisation.Text;

            if (excel.RowsCount() != 0)
            {

                for (int i = 2; i <= countSpecialists; i++)
                {
                    string profession = excel.ReadColumns(i, countColumnSpecialisation, specialisation);
                    if (profession != "")
                    {
                        string[,] specialist = excel.ReadCells(i, 3);
                        string time = excel.ReadColumns(i, countColumnSpecialist);
                        cabinet = excel.ReadColumns(i, countNumberofCabinet);
                        if (specialisation == "Терапевт")
                        {
                            district = excel.ReadColumns(i, countNumberofDistrict);
                            
                            Specialists.Items.Add("№ участка" + " " + district + " " + specialist[0, 0] + " " + specialist[0, 1] + " " + specialist[0, 2] + " " + time + " " + "(" + cabinet + ")");
                        }

                        else Specialists.Items.Add(specialist[0, 0] + " " + specialist[0, 1] + " " + specialist[0, 2] + " " + time + " " + "(" + cabinet + ")");
                    }
                }

            }

        }

        private void DaysOfWeek_SelectedIndexChanged(object sender, EventArgs e) // описания состояния окна при выборе дня недели
        {
            Specialisation.Enabled = true;
            if (Specialists.Items.Count != 0)
            {

                Specialists.Items.Clear();
                string specialisation = Specialisation.Text;
                countColumnSpecialist = excel.SearchTitle(DaysOfWeek.Text);
                int countNumberofDistrict = excel.SearchTitle("№ Участка");
                int countNumberofCabinet = excel.SearchTitle("Кабинет");
                string cabinet = "";
                string district = "";
                if (excel.RowsCount() != 0)
                {

                    for (int i = 2; i <= countSpecialists; i++)
                    {
                        string profession = excel.ReadColumns(i, countColumnSpecialisation, specialisation);
                        if (profession != "")
                        {
                            string[,] specialist = excel.ReadCells(i, 3);
                            string time = excel.ReadColumns(i, countColumnSpecialist);
                            cabinet = excel.ReadColumns(i, countNumberofCabinet);
                            if (specialisation == "Терапевт")
                            {
                                district = excel.ReadColumns(i, countNumberofDistrict);
                                Specialists.Items.Add("№ участка" + " " + district + " " + specialist[0, 0] + " " + specialist[0, 1] + " " + specialist[0, 2] + " " + time + " " + "(" + cabinet + ")");
                            }
                            else Specialists.Items.Add(specialist[0, 0] + " " + specialist[0, 1] + " " + specialist[0, 2] + " " + time + " " + "(" + cabinet + ")");
                        }
                    }

                }
            }
        }
    }
}

