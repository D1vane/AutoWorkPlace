using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
namespace FinalWork
{
    public partial class CardMenu : Form
    {
        Menu menu = new Menu();
        MedicalCard medcard = new MedicalCard();
        public CardMenu(Menu menu,MedicalCard medicalCard)
        {
            medcard = medicalCard;
            this.menu = menu;
            InitializeComponent();
        }
        public CardMenu()
        {
  
        }

        private void AddCard_Click(object sender, EventArgs e) // открытие окна с добавлением медицинской карты
        {
            PatientForm patient = new PatientForm(this,medcard);
            patient.AddSaveData();
            patient.Show();
            Hide();

        }

        private void EditCard_Click(object sender, EventArgs e) // окно с редактированием медицинской карты
        {
            Editingcardcs edit = new Editingcardcs(this,medcard);
            edit.Show();
            Hide();
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

        private void SearchMedCard_Click(object sender, EventArgs e) // открытие окна с поиском медицинской карты
        {
            
            SearchCard search = new SearchCard(this);
            search.Show();
            Hide();
        }

        private void hideForm_MouseEnter(object sender, EventArgs e) // функция содержащая в себе определенные события при наведении мыши на кнопку
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(hideForm, "Свернуть");
            hideForm.ForeColor = Color.Blue;

        }

        private void hideForm_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            hideForm.ForeColor = Color.White;
        }

        private void hideForm_Click(object sender, EventArgs e) // свернуть текущее окно
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BackToMenu_MouseEnter(object sender, EventArgs e) // функция содержащая в себе определенные события при наведении мыши на кнопку
        {

            ToolTip t = new ToolTip();
            t.SetToolTip(BackToMenu, "Вернуться в главное меню");
            BackToMenu.ForeColor = Color.Blue;
        }


        private void BackToMenu_MouseClick(object sender, MouseEventArgs e) // вернуться в главное меню
        {
            menu.Show();
            Close();
        }

        private void BackToMenu_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            BackToMenu.ForeColor = Color.White;
        }
    }
}
