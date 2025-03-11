using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork
{
    public partial class Recording : Form
    {
        Excel excel = new Excel("Информация о специалистах", 1);
        Excel excel2 = new Excel("Время записи", 1);
        Menu recordmenu = new Menu();
        System.Windows.Forms.Timer formTimer = new System.Windows.Forms.Timer(); // таймер для проверки всего окна
        string specialisation = ""; // переменная для хранения информации о специальности
        string starttime = "",endtime = ""; // переменные для хранения времени начала и окончания рабочего дня специалистов
        int timerecording,countSpecialists, countColumnSpecialist, countColumnSpecialisation; // переменные для хранения информации о строках и столбцах в файле excel
        static int specialisationIndex = -1, specialistIndex = -1, timeIndex = -1; // переменные для хранения выбранных элементах в списках
        string currentDay; // переменная для хранения текущего дня недели
        public int SpecialisationIndex { get { return specialisationIndex; } set { specialisationIndex = value; } }
        public int SpecialistIndex { get { return specialistIndex; } set { specialistIndex = value; } }
        public int TimeIndex { get { return timeIndex; } set { timeIndex = value; } }
        public string CurrentDayofWeek { get { return currentDay; } set { currentDay = value; } }
        List<string> recordedTime = new List<string>(); // список для записи записанного времени
        DateTime date = DateTime.Now;
        public Recording()
        {
            excel.Close();
            excel2.Close();
            
        }
        public Recording(Menu menu,int specialisation,int specialist,int time,string day) // конструктор, в котором восстанавливается предыдущее состояние окна
        {
            

            recordmenu = menu;
            InitializeComponent();
            specialisationIndex = specialisation;
            specialistIndex = specialist;
            timeIndex = time;
            currentDay = day;
            CurrentDay.Text = Convert.ToString(CultureInfo.GetCultureInfo("RU-ru").DateTimeFormat.GetDayName(date.DayOfWeek)); // отображение текущего дня недели
            if (CurrentDay.Text != "")
            {
                if (CurrentDay.Text[0] != CurrentDay.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += CurrentDay.Text.ToUpper()[0];
                    for (int i = 1; i < CurrentDay.Text.Length; i++)
                    {
                        temp += CurrentDay.Text[i];
                    }
                    CurrentDay.Text = temp;
                }
            }
            if (currentDay != null)
            {
                if (currentDay != CurrentDay.Text)
                {
                    excel2.ws.Cells.ClearContents();
                    excel2.wb.Save();
                }
            }
        }

        private void SpecialistCB_SelectedIndexChanged(object sender, EventArgs e) // функция описывающая состояние окна при выборе специалиста
        {
            if (SpecialistCB.Text != "")
            {   if (recordedTime.Count > 0)
                recordedTime.Clear();
                recordedTime.Add(SpecialistCB.Text);
                TimeRecordingCB.Items.Clear();
                TimeRecordingCB.Text = "";
                string specialist = SpecialistCB.Text;
                if (excel.RowsCount() != 0)
                {
                    
                    for (int d = 1; d <= countSpecialists; d++)
                    {
                        if (specialist == excel2.ws.Cells[d, 1].Value2)
                        {
                            timerecording = d;
                            break;
                        }
                    }
                    
                    for (int i = 2; i <= countSpecialists; i++)
                    {
                        string[,] temp = excel.ReadCells(i, 3);
                        
                        string tempsfmName = temp[0, 0] + " " + temp[0, 1] + " " + temp[0, 2];
                        if (specialist == tempsfmName)
                        {
                            string time = excel.ReadColumns(i, countColumnSpecialist, specialisation);

                            if (time != "" && time != "Выходной")
                            {
                                double periodofTime = double.Parse(excel.ReadColumns(i, excel.SearchTitle("Время приема(мин)"), specialisation));
                                int j = 0;
                                while (time[j] != '-')
                                {
                                    
                                    starttime += time[j];
                                    j++;
                                }
                                j++;
                                while (j < time.Length)
                                {
                                    endtime += time[j];
                                    j++;
                                }
                                TimeOnly timeOnly = TimeOnly.Parse(starttime);
                                string[,] strings = {{ }}; 
                                if (timerecording > 0)
                                strings = excel2.ReadCells(timerecording);
                                while (timeOnly < TimeOnly.Parse(endtime))
                                {
                                    if (timerecording > 0)
                                    {
                                        for (int c = 1; c < strings.Length; c++)
                                        {
                                            if (timeOnly == TimeOnly.Parse(strings[0, c]))
                                            {
                                                
                                                timeOnly = timeOnly.AddMinutes(periodofTime);
                                            }
                                        }   
                                    }
                                    if (timeOnly != TimeOnly.Parse(endtime))
                                        TimeRecordingCB.Items.Add(timeOnly);

                                    timeOnly = timeOnly.AddMinutes(periodofTime);
                                }

                                starttime = "";
                                endtime = "";
                            }
                            break;
                        }
                    }
                }
            }
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

        private void BacktoMenu_MouseEnter(object sender, EventArgs e)  // функция содержащая в себе определенные события при наведении мыши на кнопку
        {
            BacktoMenu.ForeColor = Color.Blue;
            ToolTip t = new ToolTip();
            t.SetToolTip(BacktoMenu, "Вернуться в главное меню");
        }
        System.Drawing.Point lastpoint;
        private void Recording_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Recording_MouseDown(object sender, MouseEventArgs e)  // перемещение окна с помощью мыши
        {
            lastpoint = new System.Drawing.Point(e.X, e.Y);
        }

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

        private void BacktoMenu_MouseLeave(object sender, EventArgs e) // перемещение окна с помощью мыши
        {
            BacktoMenu.ForeColor = Color.White;
        }

        private void BacktoMenu_Click(object sender, EventArgs e) // вернуться в меню с сохранением текущего состояния
            {
            specialisationIndex = SpecialisationCB.SelectedIndex;
            specialistIndex = SpecialistCB.SelectedIndex;
            timeIndex = TimeRecordingCB.SelectedIndex;
            currentDay = CurrentDay.Text;
            excel.Close();
            excel2.Close();
            formTimer.Stop();
            recordmenu.Show();
            Close();
            }

        private void SpecialisationCB_SelectedIndexChanged(object sender, EventArgs e) // функция описывающая состояние окна при выборе специальности
        {
            if (SpecialisationCB.Text != "")
            {
                SpecialistCB.Items.Clear();
                SpecialistCB.Text = "";
                TimeRecordingCB.Text = "";
                specialisation = SpecialisationCB.Text;

                if (excel.RowsCount() != 0)
                {
                    

                    for (int i = 2; i <= countSpecialists; i++)
                    {
                        string profession = excel.ReadColumns(i, countColumnSpecialisation, specialisation);
                        if (profession != "")
                        {
                            if (excel.ReadColumns(i, countColumnSpecialist) != "Выходной")
                            {
                                string[,] specialist = excel.ReadCells(i, 3);
                                SpecialistCB.Items.Add(specialist[0, 0] + " " + specialist[0, 1] + " " + specialist[0, 2]);
                            }
                        }
                    }
                }
            }
        }

        private void RecordingButton_Click(object sender, EventArgs e) // запись на выбранное время
        {
            
            if (MessageBox.Show($"Записать на {TimeRecordingCB.Text} ?", "Подтверждение записи", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                  
                if (TimeRecordingCB.SelectedItem.ToString().Length == 4)
                recordedTime.Add("0" + Convert.ToString(TimeRecordingCB.SelectedItem));
                else recordedTime.Add(Convert.ToString(TimeRecordingCB.SelectedItem));

                TimeRecordingCB.Items.Remove(TimeRecordingCB.SelectedItem);
                if (excel.RowsCount() != 0)
                {
                    for (int i = 1; i <= countSpecialists; i++)
                    {
                        if (excel2.ws.Cells[i, 1].Value2 == SpecialistCB.Text)
                        {
                            string[] temp = new string[1];
                            temp[0] = recordedTime.Last();
                            excel2.WriteCells(temp, i, temp.Length);
                            excel2.SortColumns(i);
                            break;
                        }
                        else
                        {
                            if (excel2.ws.Cells[i, 1].Value == null)
                            {
                                excel2.WriteCells(recordedTime.ToArray(), i, recordedTime.Count);
                                break;
                            }
                        }

                    }
                }
                
            }
            

        }
        private void FormTimer_Tick(object sender, EventArgs e) // проверка всего окна на корректность
        {
            if (TimeRecordingCB.Text != "")
            {
                RecordingButton.Enabled = true;
            }
            else RecordingButton.Enabled = false;

            if (SpecialisationCB.Text == "")
            {
                SpecialistCB.Enabled = false;
            }
            else SpecialistCB.Enabled = true;
            if (SpecialistCB.Text == "")
                TimeRecordingCB.Enabled = false;
            else TimeRecordingCB.Enabled = true;
        }
        private void Recording_Load(object sender, EventArgs e)
        {

            formTimer.Interval = 500;
            formTimer.Start();
            formTimer.Tick += new EventHandler(FormTimer_Tick);
            

            countColumnSpecialist = excel.SearchTitle(CurrentDay.Text);
            countSpecialists = excel.RowsCount();
            countColumnSpecialisation = excel.SearchTitle("_Специальность");
            int countColumnSName = excel.SearchTitle("_Фамилия");
            int countweekends = 0;
            int tempspec = 2;
            int countColumn = excel.ColumnsCount(1);
            excel.SortRows(2, countColumn, countColumnSpecialisation);

            for (int j = tempspec; j <= countSpecialists; j++) // получение списка специальностей по которым не все врачи отдыхают
                {
                    string profession = excel.ReadColumns(j, countColumnSpecialisation);
                    tempspec++;
                    if (profession != specialisation)
                    {
                    if (j != 2 && countweekends != 0)
                    {
                        SpecialisationCB.Items.Add(specialisation);
                    }
                    countweekends = 0;
                        if (excel.ReadColumns(j, countColumnSpecialist) != "Выходной")
                        {
                              countweekends++;
                        
                        }
                        
                        specialisation = profession;
                    }
                    else
                    {
                        if (excel.ReadColumns(j, countColumnSpecialist) != "Выходной")
                        {
                            countweekends++;
                        }
                    }
                }
            if (tempspec == countSpecialists+1 && countweekends != 0)
            {
                SpecialisationCB.Items.Add(specialisation);
            }
                
                excel.SortRows(2, countColumn, countColumnSName);
            if (specialisationIndex >= 0)
                SpecialisationCB.SelectedIndex = specialisationIndex;
            if (specialistIndex >= 0)
                SpecialistCB.SelectedIndex = specialistIndex;
            if (timeIndex >= 0)
                TimeRecordingCB.SelectedIndex = timeIndex;
        }
    }
}
