using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork
{
    public partial class Editingcardcs : Form
    {
        MedicalCard medical = new MedicalCard();
        CardMenu cardmenu = new CardMenu();
        Excel excel = new Excel("База данных Регистратора", 1);
        System.Windows.Forms.Timer formTimer = new System.Windows.Forms.Timer(); // таймер для проверки всего окна
        int cardnumber; // переменная для хранения введенного номера карты 
        public Editingcardcs(CardMenu menu,MedicalCard card)

        {
            medical = card;
            cardmenu = menu;
            InitializeComponent();
        }

        private void DataForEditing_Click(object sender, EventArgs e) // получение данных для редактирования по номеру карты
        {
            if (CardNumberforEd.Text != "")
                cardnumber = int.Parse(CardNumberforEd.Text);
            string[,] temp = medical.Editcard(cardnumber + 1,excel);
            Editcardnumber.Text = Convert.ToString(cardnumber);
            EditSName.Text = temp[0, 1];
            EditFName.Text = temp[0, 2];
            EditMName.Text = temp[0, 3];
            EditDoB.Text = temp[0, 4];
            EditStreet.Text = temp[0, 5];
            EditHouseNumber.Text = temp[0, 6];
            EditApartment.Text = temp[0, 7];
            EditAnStreet.Text = temp[0, 8];
            EditAnHouseNumber.Text = temp[0, 9];
            EditAnApartment.Text = temp[0, 10];
            EditInsCompany.Text = temp[0, 11];
            EditInsNumber.Text = temp[0, 12];
            EditPatientPhoneNumber.Text = temp[0, 13];
            EditPatientWork.Text = temp[0, 14];
            EditPatientPost.Text = temp[0, 15];
            CardNumberforEd.Text = "";
        }

        private void CardNumberforEd_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            else e.Handled = true;
        }

        private void editingcard_Click(object sender, EventArgs e) // применение изменений в медицинской карте
        {
            medical.FirstName = EditFName.Text;
            medical.SecondName = EditSName.Text;
            medical.MiddleName = EditMName.Text;
            medical.DateOfBirth = EditDoB.Text;
            medical.Street = EditStreet.Text;
            medical.HouseNumber = EditHouseNumber.Text;
            medical.Apartment = EditApartment.Text;
            medical.PhoneNumber = EditPatientPhoneNumber.Text;
            medical.Post = EditPatientPost.Text;
            medical.WorkPlace = EditPatientWork.Text;
            medical.InsuranceNumber = EditInsNumber.Text;
            medical.InsuranceCompany = EditInsCompany.Text;
            medical.AnStreet = EditAnStreet.Text;
            medical.AnHouseNumber = EditAnHouseNumber.Text;
            medical.AnApartment = EditAnApartment.Text;

            medical.EddingCard(cardnumber,excel);
            

            EditFName.Text = "";
            EditSName.Text = "";
            EditMName.Text = "";
            EditDoB.Text = "";
            EditStreet.Text = "";
            EditHouseNumber.Text = "";
            EditApartment.Text = "";
            EditPatientPhoneNumber.Text = "";
            EditPatientPost.Text = "";
            EditPatientWork.Text = "";
            EditInsNumber.Text = "";
            EditInsCompany.Text = "";
            EditAnStreet.Text = "";
            EditAnHouseNumber.Text = "";
            EditAnApartment.Text = "";
            Editadressbox.Checked = false;
            Editcardnumber.Text = "";
        }

        private void EditSName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditFName.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditFName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditMName.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditMName_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditDoB.Focus();
            }
        }

        private void EditDoB_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == '.')
            {
                return;
            }
            else e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditStreet.Focus();
            }
        }

        private void EditStreet_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            else e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditHouseNumber.Focus();
            }
        }

        private void EditHouseNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditApartment.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == '/')
            {
                return;
            }
            else e.Handled = true;

        }

        private void EditApartment_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditAnStreet.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            else e.Handled = true;

        }

        private void EditAnStreet_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditAnHouseNumber.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '-')
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditAnHouseNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditAnApartment.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || (e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == '/')
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditAnApartment_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditInsCompany.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditInsCompany_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditInsNumber.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '"')
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditInsNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditPatientPhoneNumber.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8)
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditPatientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditPatientWork.Focus();
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == '-')
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditPatientWork_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                EditPatientPost.Focus();
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back || e.KeyChar == '"')
            {
                return;
            }
            else e.Handled = true;
        }

        private void EditPatientPost_KeyPress(object sender, KeyPressEventArgs e) // ограничения для вводимых значений
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (EditPatientPost.Text != "")
                {
                    if (EditPatientPost.Text[0] != EditPatientPost.Text.ToUpper()[0])
                    {
                        string temp = "";
                        temp += EditPatientPost.Text.ToUpper()[0];
                        for (int i = 1; i < EditPatientPost.TextLength; i++)
                        {
                            temp += EditPatientPost.Text[i];
                        }
                        EditPatientPost.Text = temp;
                    }
                }
            }
            if ((e.KeyChar >= 'А' && e.KeyChar <= 'я') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            else e.Handled = true;
        }

        private void Editadressbox_CheckedChanged(object sender, EventArgs e) // добавление фактического адреса проживания, если он соответствует адресу по прописке
        {
            if (Editadressbox.Checked == true)
            {
                EditAnStreet.Text = "";
                EditAnHouseNumber.Text = "";
                EditAnApartment.Text = "";
                EditAnStreet.Text = EditStreet.Text;
                EditAnHouseNumber.Text = EditHouseNumber.Text;
                EditAnApartment.Text = EditApartment.Text;
            }
            else
            {
                EditAnStreet.Text = "";
                EditAnHouseNumber.Text = "";
                EditAnApartment.Text = "";
            }
            
        }
        System.Drawing.Point lastpoint;
        private void Editingcardcs_MouseMove(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Editingcardcs_MouseDown(object sender, MouseEventArgs e) // перемещение окна с помощью мыши
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

        private void EditLastCard_Click(object sender, EventArgs e) // получение данных последней добавленной карты
        {

            cardnumber = medical.CountCard-1;
            string[,] temp = medical.Editcard(medical.CountCard,excel);
            Editcardnumber.Text = Convert.ToString(medical.CountCard-1);
            EditSName.Text = temp[0, 1];
            EditFName.Text = temp[0, 2];
            EditMName.Text = temp[0, 3];
            EditDoB.Text = temp[0, 4];
            EditStreet.Text = temp[0, 5];
            EditHouseNumber.Text = temp[0, 6];
            EditApartment.Text = temp[0, 7];
            EditAnStreet.Text = temp[0, 8];
            EditAnHouseNumber.Text = temp[0, 9];
            EditAnApartment.Text = temp[0, 10];
            EditInsCompany.Text = temp[0, 11];
            EditInsNumber.Text = temp[0, 12];
            EditPatientPhoneNumber.Text = temp[0, 13];
            EditPatientWork.Text = temp[0, 14];
            EditPatientPost.Text = temp[0, 15];

        }

        private void StepBackCM_Click(object sender, EventArgs e) // вернуться в окно для работы с медицинскими картами
        {

            excel.Close();
            cardmenu.Show();
            formTimer.Stop();
            Close();
        }

        private void EditSName_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditSName.Text != "")
            {
                if (EditSName.Text[0] != EditSName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditSName.Text.ToUpper()[0];
                    for (int i = 1; i < EditSName.TextLength; i++)
                    {
                        temp += EditSName.Text[i];
                    }
                    EditSName.Text = temp;
                }
            }
        }

        private void EditFName_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditFName.Text != "")
            {
                if (EditFName.Text[0] != EditFName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditFName.Text.ToUpper()[0];
                    for (int i = 1; i < EditFName.TextLength; i++)
                    {
                        temp += EditFName.Text[i];
                    }
                    EditFName.Text = temp;
                }
            }
        }

        private void EditMName_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditMName.Text != "")
            {
                if (EditMName.Text[0] != EditMName.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditMName.Text.ToUpper()[0];
                    for (int i = 1; i < EditMName.TextLength; i++)
                    {
                        temp += EditMName.Text[i];
                    }
                    EditMName.Text = temp;
                }
            }
        }

        private void EditStreet_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditStreet.Text != "")
            {
                if (EditStreet.Text[0] != EditStreet.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditStreet.Text.ToUpper()[0];
                    for (int i = 1; i < EditStreet.TextLength; i++)
                    {
                        temp += EditStreet.Text[i];
                    }
                    EditStreet.Text = temp;
                }
            }
        }

        private void EditAnStreet_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditAnStreet.Text != "")
            {
                if (EditAnStreet.Text[0] != EditAnStreet.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditAnStreet.Text.ToUpper()[0];
                    for (int i = 1; i < EditAnStreet.TextLength; i++)
                    {
                        temp += EditAnStreet.Text[i];
                    }
                    EditAnStreet.Text = temp;
                }
            }
        }

        private void EditPatientWork_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditPatientWork.Text != "")
            {
                if (EditPatientWork.Text[0] != EditPatientWork.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditPatientWork.Text.ToUpper()[0];
                    for (int i = 1; i < EditPatientWork.TextLength; i++)
                    {
                        temp += EditPatientWork.Text[i];
                    }
                    EditPatientWork.Text = temp;
                }
            }
        }

        private void EditPatientPost_Validating(object sender, CancelEventArgs e) // если введена строка с маленькой буквы, делает первую букву заглавной
        {
            if (EditPatientPost.Text != "")
            {
                if (EditPatientPost.Text[0] != EditPatientPost.Text.ToUpper()[0])
                {
                    string temp = "";
                    temp += EditPatientPost.Text.ToUpper()[0];
                    for (int i = 1; i < EditPatientPost.TextLength; i++)
                    {
                        temp += EditPatientPost.Text[i];
                    }
                    EditPatientPost.Text = temp;
                }
            }
        }

        private void CardNumberforEd_TextChanged(object sender, EventArgs e) // проверка вводимого номера карты
        {
            if (CardNumberforEd.Text != "" && (medical.CountCard - 1 != 0))
                EditLastCard.Enabled = false;
            if (CardNumberforEd.Text == "" && (medical.CountCard - 1 != 0))
                EditLastCard.Enabled = true;

        }
        private void FormTimer_Tick(object sender,EventArgs e) // проверка всего окна на корректное заполнение
        {


            if (CardNumberforEd.Text != "")
            {
                if (int.Parse(CardNumberforEd.Text) > (medical.CountCard - 1) || int.Parse(CardNumberforEd.Text) == 0)
                {
                    DataForEditingError.Text = $"Номер последней добавленной карты - {medical.CountCard - 1}";
                    DataForEditing.Enabled = false;
                }
                else
                {
                    DataForEditing.Enabled = true;
                    DataForEditingError.Text = "";
                }
            }
            else
            {
                DataForEditing.Enabled = false;
                DataForEditingError.Text = "";
            }

            if (medical.CountCard - 1 == 0)
            {
                EditLastCard.Enabled = false;
            }
            if (EditDoB.TextLength == 10)
            {
                if (EditDoB.Text[2] != '.' || EditDoB.Text[5] != '.')
                {
                    EditDobError.Text = "Некорректный ввод даты рождения. Пример ввода: 18.10.2003";
                }
                else
                {
                    string todaydate = DateTime.Today.Day + "." + DateTime.Today.Month + "." + DateTime.Today.Year;
                    EditDobError.Text = "";
                    try
                    {
                        DateOnly.Parse(EditDoB.Text);
                        if (DateOnly.Parse(todaydate) < DateOnly.Parse(EditDoB.Text) || DateOnly.Parse(todaydate).Year - DateOnly.Parse(EditDoB.Text).Year >= 120)
                        {
                            EditDobError.Text = "Введите реальную дату рождения";
                        }
                    }
                    catch (Exception)
                    {
                        EditDobError.Text = "Введите существующую дату";
                    }
                }
            }
            else
            {
                if (EditDoB.Text != "")
                    EditDobError.Text = "Некорректный ввод даты рождения. Пример ввода: 18.10.2003";
            }

            if (EditPatientPhoneNumber.TextLength == 15)
            {
                if (EditPatientPhoneNumber.Text[1] != '-' || EditPatientPhoneNumber.Text[5] != '-' || EditPatientPhoneNumber.Text[9] != '-' || EditPatientPhoneNumber.Text[12] != '-')
                {
                    EditphoneError.Text = "Неверный формат ввода номера телефона. Пример ввода 8-900-100-10-10";
                }
                else
                {
                    if (EditPatientPhoneNumber.Text[2] != '9')
                    {
                        EditphoneError.Text = "Неверный оператор телефона";
                    }
                    else
                    {
                        EditphoneError.Text = "";
                    }
                }
            }
            else
            {
                if (EditPatientPhoneNumber.Text != "")
                    EditphoneError.Text = "Неверный формат ввода номера телефона. Пример ввода 8-900-100-10-10";
            }

            if (EditSName.Text != "" && EditFName.Text != "" && EditMName.Text != "" && EditDoB.Text != "" && EditStreet.Text != "" && EditHouseNumber.Text != "" && EditApartment.Text != ""
                && EditAnStreet.Text != "" && EditAnHouseNumber.Text != "" && EditAnApartment.Text != "" && EditInsCompany.Text != "" && EditInsNumber.Text != "" && EditPatientPhoneNumber.Text != ""
                && EditPatientWork.Text != "" && EditPatientPost.Text != "" && EditphoneError.Text == "" && EditDobError.Text == "" && Editcardnumber.Text != "")
                editingcard.Enabled = true;
            else
            {

                editingcard.Enabled = false;
            }

        }
        private void Editingcardcs_Load(object sender, EventArgs e)
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

        private void StepBackCM_MouseEnter(object sender, EventArgs e) // функция содержащая в себе определенные события при наведении мыши на кнопку
        {
            StepBackCM.ForeColor = Color.Blue;
            ToolTip t = new ToolTip();
            t.SetToolTip(StepBackCM, "В меню медицинских карт");
        }

        private void StepBackCM_MouseLeave(object sender, EventArgs e) // функция содержащая в себе определенные события при отведении мыши от кнопки
        {
            StepBackCM.ForeColor = Color.White;
        }
    }
}
