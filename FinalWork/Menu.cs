using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace FinalWork
{
    public partial class Menu : Form
    {
        MedicalCard medcard = new MedicalCard();
        Specialist specialist = new Specialist();
        ScheduleStorage scheduleStorage;
        Recording recording;
        static bool createfile = false; // флаг для создания файлов
        public Menu()
        {
            
        }
        public Menu (Excel excelmed,Excel exceltime) /* конструктор, в котором считывается информация о специалисте и медицинской карты из файлов
                                   и если это первый запуск - создаются файлы для медциниских карт и записанного времени */
        {
            InitializeComponent();
            try
            {
                medcard = medcard.CardDeserialisation(medcard);
                specialist = specialist.SpecialistDeserialisation(specialist);
            }
            catch (Exception)
            {
                medcard.CreateFile = true;
            }
            if (medcard.CreateFile == true)
            {
                createfile = true;
            }
            if (medcard.CountCard == 1 && createfile == true)
            {
                medcard.CreateFile = false;
                createfile = false;
                excelmed.CreateFile("База данных Регистратора");
                exceltime.CreateDefaultFile("Время записи");
                scheduleStorage = new ScheduleStorage();
                recording = new Recording();
                scheduleStorage.Dayindex = -1;
                scheduleStorage.Specialisationindex = -1;

                recording.SpecialisationIndex = -1;
                recording.SpecialistIndex = -1;
                recording.TimeIndex = -1;
                recording.CurrentDayofWeek = specialist.DayofWeek;
            }
            else
            {
                scheduleStorage = new ScheduleStorage();
                recording = new Recording();
                scheduleStorage.Dayindex = specialist.Day;
                scheduleStorage.Specialisationindex = specialist.Specialisation;

                recording.SpecialisationIndex = specialist.SpecialisationRecording;
                recording.SpecialistIndex = specialist.SpecialistName;
                recording.TimeIndex = specialist.SpecialistTime;
                recording.CurrentDayofWeek = specialist.DayofWeek;
            }
        }

        private void MedCard_Click(object sender, EventArgs e) // переход в окно для работы с медицинской картой
        {
            CardMenu cm = new CardMenu(this,medcard);
            cm.Show();
            Hide();
        }

        private void CloseMenu_MouseEnter(object sender, EventArgs e) // функция содержащая в себе определенные события при наведении мыши на кнопку 
        {
            CloseMenu.ForeColor = Color.Red;
            ToolTip t = new ToolTip();
            t.SetToolTip(CloseMenu, "Закрыть");
        }

        private void CloseMenu_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки 
        {
            CloseMenu.ForeColor = Color.White;
        }

        private void CloseMenu_Click(object sender, EventArgs e) // функция для закрытия программы, с сохранением текущего состояния программы
        {
            
            specialist.Day = scheduleStorage.Dayindex;
            specialist.Specialisation = scheduleStorage.Specialisationindex;
            specialist.SpecialisationRecording = recording.SpecialisationIndex;
            specialist.SpecialistName = recording.SpecialistIndex;
            specialist.SpecialistTime = recording.TimeIndex;
            specialist.DayofWeek = recording.CurrentDayofWeek;
            specialist.Serialisation();
            medcard.Serialisation();
            Close();
        }

        private void PatientRec_Click(object sender, EventArgs e) // открытие окна для записи пациентов на прием 
        {
            recording = new Recording(this,recording.SpecialisationIndex,recording.SpecialistIndex,recording.TimeIndex,recording.CurrentDayofWeek);
            recording.Show();
            Hide();
        }

        private void Schedule_Click(object sender, EventArgs e) // открытие окна для просмотра расписания врачей
        {
            scheduleStorage = new ScheduleStorage(this,scheduleStorage.Dayindex,scheduleStorage.Specialisationindex);
            Hide();
            scheduleStorage.Show();

        }

        private void hideForm_Click(object sender, EventArgs e) // свернуть текущее окно
        {
            WindowState = FormWindowState.Minimized;
            
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

        System.Drawing.Point lastpoint;
        private void Menu_MouseMove(object sender, MouseEventArgs e) // функция  для перемещения окна с помощью мыши 
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e) // функция  для перемещения окна с помощью мыши 
        {
            lastpoint = new System.Drawing.Point(e.X, e.Y);
        }
    }
}
