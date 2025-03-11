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
    public partial class SearchCard : Form
    {
        CardMenu cardMenu = new CardMenu();
        MedicalCard medicalCard = new MedicalCard();
        Excel excel = new Excel("База данных Регистратора", 1);
        System.Windows.Forms.Timer formTimer = new System.Windows.Forms.Timer(); // таймер для проверки окна на корректность
        List<int> countmas = new List<int>(); // список для хранения найденных медицинских карт
        int rowsCount;
        public SearchCard(CardMenu card)
        {
            cardMenu = card;
            InitializeComponent();
        }

        private void BacktoMenu_Click(object sender, EventArgs e) // вернуться в меню
        {
            excel.Close();
            cardMenu.Show();
            Close();
        }

        private void searchingcard_Click(object sender, EventArgs e) // поиск карты по введенным данным
        {
           
                if (excel.RowsCount() >= 2)
                {
                    rowsCount = excel.RowsCount();
                    for (int i = 2; i <= rowsCount; i++)
                    {
                        string[,] tempSearch = medicalCard.Editcard(i,excel);
                        if (SSName.Text == tempSearch[0, 1] && SFName.Text == tempSearch[0, 2] && SMName.Text == tempSearch[0, 3] && SDoB.Text == tempSearch[0, 4])
                        {
                            countmas.Add(i);
                        }
                    }
                if (countmas.Count > 0)
                {
                    if (countmas.Count > 1)
                        MessageBox.Show($"Найдено несколько совпадений", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int j = 0; j < countmas.Count; j++)
                    {
                        string[,] tempFound = medicalCard.Editcard(countmas[j],excel);
                        MessageBox.Show($"{j + 1}/{countmas.Count}\n\nМедицинская карта №{tempFound[0, 0]}\nФамилия: {tempFound[0, 1]}\nИмя: {tempFound[0, 2]}\nОтчество: {tempFound[0, 3]}\n" +
                            $"Дата рождения: {tempFound[0, 4]}\nАдрес проживания по прописке:\nУлица: {tempFound[0, 5]}, Дом: {tempFound[0, 6]}, " +
                            $"Квартира: {tempFound[0, 7]}\nФактический адрес проживания:\nУлица: {tempFound[0, 8]}, Дом: {tempFound[0, 9]}, " +
                            $"Квартира: {tempFound[0, 10]}\nСтраховая компания: {tempFound[0, 11]}\nНомер страховки: {tempFound[0, 12]}\n" +
                            $"Номер телефона: {tempFound[0, 13]}\nМесто работы: {tempFound[0, 14]}\nДолжность: {tempFound[0, 15]}", "Информация о пациенте", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    countmas.Clear();
                }
                else MessageBox.Show("Не найдено совпадений", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else MessageBox.Show("Файл с пациентами пустой!","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                SSName.Text = "";
                SFName.Text = "";
                SMName.Text = "";
                SDoB.Text = "";
            
        }

        private void SSName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SFName.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            else e.Handled = true;
        }

        private void SFName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SMName.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else e.Handled = true;
        }

        private void SMName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SDoB.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else e.Handled = true;
        }

        private void SDoB_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == '.')
            {
                return;
            }
            else e.Handled = true;
            
        }


        private void SSName_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (SSName.Text != "")
            {
                if (SSName.Text[0] != SSName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += SSName.Text.ToUpper()[0];
                    for (int i = 1; i < SSName.TextLength; i++)
                    {
                        temp += SSName.Text[i];
                    }
                    SSName.Text = temp;
                }
            }
        }

        private void SFName_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (SFName.Text != "")
            {
                if (SFName.Text[0] != SFName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += SFName.Text.ToUpper()[0];
                    for (int i = 1; i < SFName.TextLength; i++)
                    {
                        temp += SFName.Text[i];
                    }
                    SFName.Text = temp;
                }
            }
        }

        private void SMName_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (SMName.Text != "")
            {
                if (SMName.Text[0] != SMName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += SMName.Text.ToUpper()[0];
                    for (int i = 1; i < SMName.TextLength; i++)
                    {
                        temp += SMName.Text[i];
                    }
                    SMName.Text = temp;
                }
            }
        }
        private void FormTimer_Tick(object sender, EventArgs e) // проверка всего окна на корректность
        {
            if (SDoB.TextLength == 10)
            {
                if (SDoB.Text[2] != '.' || SDoB.Text[5] != '.')
                {
                    SDobError.Text = "Некорректный ввод даты рождения. Пример ввода: 18.10.2003";
                }
                else
                {
                    string todaydate = DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year;

                    SDobError.Text = "";
                    try
                    {
                        DateOnly.Parse(SDoB.Text);
                        if (DateOnly.Parse(todaydate) < DateOnly.Parse(SDoB.Text) || DateOnly.Parse(todaydate).Year - DateOnly.Parse(SDoB.Text).Year >=120)
                        {
                            SDobError.Text = "Введите реальную дату рождения";
                        }
                    }
                    catch (Exception)
                    {
                        SDobError.Text = "Введите существующую дату";
                    }
                }
            }
            else
            {
                if (SDoB.Text != "")
                    SDobError.Text = "Некорректный ввод даты рождения. Пример ввода: 18.10.2003";
            }

            bool flag = this.Controls.OfType<System.Windows.Forms.TextBox>().All(textbox => textbox.Text != "");
            if (flag == false || SDobError.Text != "")
            {
                searchingcard.Enabled = false;
            }
            else searchingcard.Enabled = true;
        }
        private void SearchCard_Load(object sender, EventArgs e)
        {
            
            formTimer.Interval = 500;
            formTimer.Start();
            formTimer.Tick += new EventHandler(FormTimer_Tick);
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
            t.SetToolTip(BacktoMenu, "В меню медицинских карт");
        }

        private void BacktoMenu_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            BacktoMenu.ForeColor = Color.White;
        }
    }
}
