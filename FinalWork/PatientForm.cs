using Microsoft.Office.Interop.Excel;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing.Design;

namespace FinalWork
{
    public partial class PatientForm : Form
    {
        MedicalCard medicalCard = new MedicalCard();
        CardMenu menu = new CardMenu();
        Excel excel = new Excel("База данных Регистратора", 1);
        System.Windows.Forms.Timer formTimer = new System.Windows.Forms.Timer(); // таймер для проверки всего окна на корректность ввода
        static bool savedata = false; // проверка, сохранялись ли данные с предыдущей сессии
        public PatientForm(CardMenu menu,MedicalCard card) // конструктор, в котором проверяется были ли сохранены данные в предыдущий раз 
        {
            medicalCard = card;
            if (medicalCard.CountCard > 1 && medicalCard.PhoneNumber != excel.ReadColumns(medicalCard.CountCard, excel.SearchTitle("Телефон")) && medicalCard.PhoneNumber != "-")
                savedata = true;
            else savedata = false;
            this.menu = menu;
            InitializeComponent();
        }

        public void AddSaveData() // добавление сохраненных ранее данных
        {
            cardnumber.Text = Convert.ToString(medicalCard.CountCard);
            if (savedata == true) 
            {
                SName.Text = medicalCard.SecondName;
                FName.Text = medicalCard.FirstName;
                MName.Text = medicalCard.MiddleName;
                DoB.Text = medicalCard.DateOfBirth;
                Street.Text = medicalCard.Street;
                HouseNumber.Text = medicalCard.HouseNumber;
                Apartment.Text = medicalCard.Apartment;
                AnStreet.Text = medicalCard.AnStreet;
                AnHouseNumber.Text = medicalCard.AnHouseNumber;
                AnApartment.Text = medicalCard.AnApartment;
                InsCompany.Text = medicalCard.InsuranceCompany;
                InsNumber.Text = medicalCard.InsuranceNumber;
                PatientPhoneNumber.Text = medicalCard.PhoneNumber;
                PatientWork.Text = medicalCard.WorkPlace;
                PatientPost.Text = medicalCard.Post;
                
            }
        }
        private void PatientPost_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений и перевод первой буквы в верхний регистр
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (PatientPost.Text != "")
                {
                    if (PatientPost.Text[0] != PatientPost.Text.ToUpper()[0])
                    {
                        string temp = "";
                        temp += PatientPost.Text.ToUpper()[0];
                        for (int i = 1; i < PatientPost.TextLength; i++)
                        {
                            temp += PatientPost.Text[i];
                        }
                        PatientPost.Text = temp;
                    }
                }
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void PatientWork_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PatientPost.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '"')
            {
                return;
            }
            e.Handled = true;
        }

        private void AnHouseNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AnApartment.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == '/')
            {
                return;
            }
            e.Handled = true;
            
        }

        private void AnStreet_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AnHouseNumber.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            e.Handled = true;
            
        }

        private void Apartment_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AnStreet.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void HouseNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Apartment.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == '/')
            {
                return;
            }
            e.Handled = true;
            
        }

        private void Street_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                HouseNumber.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            e.Handled = true;
            
        }

        private void DoB_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Street.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == '.')
            {
                return;
            }
            e.Handled = true;
            
        }

        private void MName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DoB.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void FName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {  
            if (e.KeyChar == (char)Keys.Enter)
            {
                MName.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void adressbox_CheckedChanged(object sender, EventArgs e) // если стоит галочка в окне, то записывает адрес по прописке в фактический адрес проживания
        {
            if (adressbox.Checked == true)
            {
                AnStreet.Text = Street.Text;
                AnHouseNumber.Text = HouseNumber.Text;
                AnApartment.Text = Apartment.Text;
            }
            else
            {
                AnStreet.Text = "";
                AnHouseNumber.Text = "";
                AnApartment.Text = "";
            }
        }

        private void addingcard_Click(object sender, EventArgs e) // добавление медицинской карты в файл excel
        {
            bool addcard = this.Controls.OfType<System.Windows.Forms.TextBox>().All(textbox => textbox.Text != "");
            if (addcard == true)
            {
                addingcard.Enabled = true;
                if (MessageBox.Show("Добавить медицинскую карту?", "Подтверждение ввода", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    cardnumber.Text = Convert.ToString(medicalCard.CountCard + 1);
                    medicalCard.FirstName = FName.Text;
                    medicalCard.SecondName = SName.Text;
                    medicalCard.MiddleName = MName.Text;
                    medicalCard.DateOfBirth = DoB.Text;
                    medicalCard.Street = Street.Text;
                    medicalCard.HouseNumber = HouseNumber.Text;
                    medicalCard.Apartment = Apartment.Text;
                    medicalCard.PhoneNumber = PatientPhoneNumber.Text;
                    medicalCard.Post = PatientPost.Text;
                    medicalCard.WorkPlace = PatientWork.Text;
                    medicalCard.InsuranceNumber = InsNumber.Text;
                    medicalCard.InsuranceCompany = InsCompany.Text;
                    medicalCard.AnStreet = AnStreet.Text;
                    medicalCard.AnHouseNumber = AnHouseNumber.Text;
                    medicalCard.AnApartment = AnApartment.Text;

                    
                    medicalCard.AddCard(medicalCard.CountCard, excel);
                    medicalCard.CountCard++;


                    FName.Text = "";
                    SName.Text = "";
                    MName.Text = "";
                    DoB.Text = "";
                    Street.Text = "";
                    HouseNumber.Text = "";
                    Apartment.Text = "";
                    PatientPhoneNumber.Text = "";
                    PatientPost.Text = "";
                    PatientWork.Text = "";
                    InsNumber.Text = "";
                    InsCompany.Text = "";
                    AnStreet.Text = "";
                    AnHouseNumber.Text = "";
                    AnApartment.Text = "";
                    adressbox.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("Необходимо заполнить все поля!");
                addingcard.Enabled = false;
            }
        }
        private void SName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                FName.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            e.Handled = true;
            
        }

       

        private void AnApartment_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                InsCompany.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void InsNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PatientPhoneNumber.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            e.Handled = true;
            
        }

        private void PatientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PatientWork.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == '-')
            {
                return;
            }
            e.Handled = true;
            
        }

        private void InsCompany_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений 
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                InsNumber.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '"')
            {
                return;
            }
            
            e.Handled = true;
        }

        private void BacktoMenu_Click(object sender, EventArgs e) // возвращение в окно для работы с медицинскими картами
        {
            bool flag = this.Controls.OfType<System.Windows.Forms.TextBox>().All(textbox => textbox.Text == "");
            if (flag == false)
            {
                if (MessageBox.Show("Сохранить данные?", "Сохранение данных", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    savedata = true;
                    medicalCard.FirstName = FName.Text;
                    medicalCard.SecondName = SName.Text;
                    medicalCard.MiddleName = MName.Text;
                    medicalCard.DateOfBirth = DoB.Text;
                    medicalCard.Street = Street.Text;
                    medicalCard.HouseNumber = HouseNumber.Text;
                    medicalCard.Apartment = Apartment.Text;
                    medicalCard.PhoneNumber = PatientPhoneNumber.Text;
                    medicalCard.Post = PatientPost.Text;
                    medicalCard.WorkPlace = PatientWork.Text;
                    medicalCard.InsuranceNumber = InsNumber.Text;
                    medicalCard.InsuranceCompany = InsCompany.Text;
                    medicalCard.AnStreet = AnStreet.Text;
                    medicalCard.AnHouseNumber = AnHouseNumber.Text;
                    medicalCard.AnApartment = AnApartment.Text;
                }
                else
                {
                    savedata = false;
                    medicalCard.PhoneNumber = "-";
                }
                
            }
            excel.Close();
            formTimer.Stop();
            menu.Show();
            Close();
        }
        System.Drawing.Point lastpoint;
        private void PatientForm_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void PatientForm_MouseDown(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
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

        private void ClearForm_Click(object sender, EventArgs e) // очистить форму
        {
            FName.Text = "";
            SName.Text = "";
            MName.Text = "";
            DoB.Text = "";
            Street.Text = "";
            HouseNumber.Text = "";
            Apartment.Text = "";
            PatientPhoneNumber.Text = "";
            PatientPost.Text = "";
            PatientWork.Text = "";
            InsNumber.Text = "";
            InsCompany.Text = "";
            AnStreet.Text = "";
            AnHouseNumber.Text = "";
            AnApartment.Text = "";
            adressbox.Checked = false;
        }

        private void SName_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (SName.Text != "")
            {   if (SName.Text[0] != SName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += SName.Text.ToUpper()[0];
                    for (int i  = 1 ; i < SName.TextLength;i++)
                    {
                        temp += SName.Text[i];
                    }
                    SName.Text = temp;
                }
            }
        }

        private void FName_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (FName.Text != "")
            {
                if (FName.Text[0] != FName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += FName.Text.ToUpper()[0];
                    for (int i = 1; i < FName.TextLength; i++)
                    {
                        temp += FName.Text[i];
                    }
                    FName.Text = temp;
                }
            }
        }

        private void MName_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (MName.Text != "")
            {
                if (MName.Text[0] != SName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += MName.Text.ToUpper()[0];
                    for (int i = 1; i < MName.TextLength; i++)
                    {
                        temp += MName.Text[i];
                    }
                    MName.Text = temp;
                }
            }
        }

        private void Street_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (Street.Text != "")
            {
                if (Street.Text[0] != Street.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += Street.Text.ToUpper()[0];
                    for (int i = 1; i < Street.TextLength; i++)
                    {
                        temp += Street.Text[i];
                    }
                    Street.Text = temp;
                }
            }
        }

        private void AnStreet_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (AnStreet.Text != "")
            {
                if (AnStreet.Text[0] != AnStreet.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += AnStreet.Text.ToUpper()[0];
                    for (int i = 1; i < AnStreet.TextLength; i++)
                    {
                        temp += AnStreet.Text[i];
                    }
                    AnStreet.Text = temp;
                }
            }
        }

        private void PatientWork_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (PatientWork.Text != "")
            {
                if (PatientWork.Text[0] != PatientWork.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += PatientWork.Text.ToUpper()[0];
                    for (int i = 1; i < PatientWork.TextLength; i++)
                    {
                        temp += PatientWork.Text[i];
                    }
                    PatientWork.Text = temp;
                }
            }
        }

        private void PatientPost_Validating(object sender, System.ComponentModel.CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (PatientPost.Text != "")
            {
                if (PatientPost.Text[0] != PatientPost.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += PatientPost.Text.ToUpper()[0];
                    for (int i = 1; i < PatientPost.TextLength; i++)
                    {
                        temp += PatientPost.Text[i];
                    }
                    PatientPost.Text = temp;
                }
            }
        }
        private void FormTimer_Tick(object sender,EventArgs e) // проверка всего окна на корректность заполнения
        {
            if (DoB.TextLength == 10)
            {
                if (DoB.Text[2] != '.' || DoB.Text[5] != '.')
                {
                    DobError.Text = "Некорректный ввод даты рождения. Пример ввода: 18.10.2003";
                }
                else
                {
                    string todaydate = DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year;
                    DobError.Text = "";
                    try
                    {
                        DateOnly.Parse(DoB.Text);
                        if (DateOnly.Parse(todaydate) < DateOnly.Parse(DoB.Text) || DateOnly.Parse(todaydate).Year - DateOnly.Parse(DoB.Text).Year >= 120)
                        {
                            DobError.Text = "Введите реальную дату рождения";
                        }
                    }
                    catch (Exception)
                    {
                        DobError.Text = "Введите существующую дату";
                    }
                }
            }
            else
            {
                if (DoB.Text != "")
                    DobError.Text = "Некорректный ввод даты рождения. Пример ввода: 18.10.2003";
            }

            if (PatientPhoneNumber.TextLength == 15)
            {
                if (PatientPhoneNumber.Text[1] != '-' || PatientPhoneNumber.Text[5] != '-' || PatientPhoneNumber.Text[9] != '-' || PatientPhoneNumber.Text[12] != '-')
                {
                    phoneError.Text = "Неверный формат ввода номера телефона. Пример ввода 8-900-100-10-10";
                }
                else
                {
                    if (PatientPhoneNumber.Text[2] != '9')
                    {
                        phoneError.Text = "Неверный оператор телефона";
                    }
                    else
                    {
                        phoneError.Text = "";
                    }
                }
            }
            else
            {
                if (PatientPhoneNumber.Text != "")
                    phoneError.Text = "Неверный формат ввода номера телефона. Пример ввода 8-900-100-10-10";
            }

            bool flag = this.Controls.OfType<System.Windows.Forms.TextBox>().All(textbox => textbox.Text == "");
            if (flag == true)
                ClearForm.Enabled = false;
            else ClearForm.Enabled = true;

            bool flag2 = this.Controls.OfType<System.Windows.Forms.TextBox>().All(textbox => textbox.Text != "");
            if (flag2 == false || phoneError.Text != "" || DobError.Text != "")
                addingcard.Enabled = false;
            else addingcard.Enabled = true;

        }
        private void PatientForm_Load(object sender, EventArgs e)
        {

            cardnumber.Text = Convert.ToString(medicalCard.CountCard);
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
            BackToMenu.ForeColor = Color.Blue;
            ToolTip t = new ToolTip();
            t.SetToolTip(BackToMenu, "В меню медицинских карт");
        }

        private void BackToMenu_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            BackToMenu.ForeColor = Color.White;
        }
    }
}