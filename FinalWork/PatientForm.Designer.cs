namespace FinalWork
{
    partial class PatientForm 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.labelData = new System.Windows.Forms.Label();
            this.upperpanel = new System.Windows.Forms.Panel();
            this.BackToMenu = new System.Windows.Forms.Label();
            this.hideForm = new System.Windows.Forms.Label();
            this.NumberMedCard = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelMName = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.MName = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelHouseNumber = new System.Windows.Forms.Label();
            this.HouseNumber = new System.Windows.Forms.TextBox();
            this.labelApartment = new System.Windows.Forms.Label();
            this.Apartment = new System.Windows.Forms.TextBox();
            this.labelDob = new System.Windows.Forms.Label();
            this.DoB = new System.Windows.Forms.TextBox();
            this.labellabelAnAdress = new System.Windows.Forms.Label();
            this.labelInsCompany = new System.Windows.Forms.Label();
            this.AnApartment = new System.Windows.Forms.TextBox();
            this.labelAnApartment = new System.Windows.Forms.Label();
            this.AnHouseNumber = new System.Windows.Forms.TextBox();
            this.labelAnHouseNumber = new System.Windows.Forms.Label();
            this.labelAnStreet = new System.Windows.Forms.Label();
            this.AnStreet = new System.Windows.Forms.TextBox();
            this.InsCompany = new System.Windows.Forms.TextBox();
            this.labelInsNumber = new System.Windows.Forms.Label();
            this.InsNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.PatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelWorkPlace = new System.Windows.Forms.Label();
            this.PatientWork = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.PatientPost = new System.Windows.Forms.TextBox();
            this.adressbox = new System.Windows.Forms.CheckBox();
            this.cardnumber = new System.Windows.Forms.Label();
            this.addingcard = new System.Windows.Forms.Button();
            this.ClearForm = new System.Windows.Forms.Button();
            this.DobError = new System.Windows.Forms.Label();
            this.phoneError = new System.Windows.Forms.Label();
            this.upperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelData.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelData.Location = new System.Drawing.Point(505, 36);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(575, 51);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Создание медицинской карты";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.upperpanel.Controls.Add(this.BackToMenu);
            this.upperpanel.Controls.Add(this.hideForm);
            this.upperpanel.Controls.Add(this.labelData);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1564, 125);
            this.upperpanel.TabIndex = 1;
            this.upperpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperpanel_MouseDown);
            this.upperpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upperpanel_MouseMove);
            // 
            // BackToMenu
            // 
            this.BackToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.BackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMenu.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToMenu.ForeColor = System.Drawing.Color.White;
            this.BackToMenu.Location = new System.Drawing.Point(1530, -1);
            this.BackToMenu.Name = "BackToMenu";
            this.BackToMenu.Size = new System.Drawing.Size(34, 38);
            this.BackToMenu.TabIndex = 90;
            this.BackToMenu.Text = "←";
            this.BackToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToMenu.Click += new System.EventHandler(this.BacktoMenu_Click);
            this.BackToMenu.MouseEnter += new System.EventHandler(this.BacktoMenu_MouseEnter);
            this.BackToMenu.MouseLeave += new System.EventHandler(this.BackToMenu_MouseLeave);
            // 
            // hideForm
            // 
            this.hideForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hideForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.hideForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideForm.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hideForm.ForeColor = System.Drawing.Color.White;
            this.hideForm.Location = new System.Drawing.Point(1464, -1);
            this.hideForm.Name = "hideForm";
            this.hideForm.Size = new System.Drawing.Size(34, 38);
            this.hideForm.TabIndex = 89;
            this.hideForm.Text = "_";
            this.hideForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hideForm.Click += new System.EventHandler(this.hideForm_Click);
            this.hideForm.MouseEnter += new System.EventHandler(this.hideForm_MouseEnter);
            this.hideForm.MouseLeave += new System.EventHandler(this.hideForm_MouseLeave);
            // 
            // NumberMedCard
            // 
            this.NumberMedCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumberMedCard.AutoSize = true;
            this.NumberMedCard.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberMedCard.Location = new System.Drawing.Point(517, 151);
            this.NumberMedCard.Name = "NumberMedCard";
            this.NumberMedCard.Size = new System.Drawing.Size(450, 51);
            this.NumberMedCard.TabIndex = 2;
            this.NumberMedCard.Text = "Медицинская карта № ";
            this.NumberMedCard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSname.Location = new System.Drawing.Point(39, 253);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(150, 39);
            this.labelSname.TabIndex = 3;
            this.labelSname.Text = "Фамилия";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFName.Location = new System.Drawing.Point(39, 313);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(80, 39);
            this.labelFName.TabIndex = 4;
            this.labelFName.Text = "Имя";
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMName.Location = new System.Drawing.Point(39, 375);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(153, 39);
            this.labelMName.TabIndex = 5;
            this.labelMName.Text = "Отчество";
            // 
            // SName
            // 
            this.SName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SName.Location = new System.Drawing.Point(235, 253);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(300, 39);
            this.SName.TabIndex = 6;
            this.SName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SName_KeyPress);
            this.SName.Validating += new System.ComponentModel.CancelEventHandler(this.SName_Validating);
            // 
            // FName
            // 
            this.FName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.FName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FName.Location = new System.Drawing.Point(165, 313);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(300, 39);
            this.FName.TabIndex = 7;
            this.FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FName_KeyPress);
            this.FName.Validating += new System.ComponentModel.CancelEventHandler(this.FName_Validating);
            // 
            // MName
            // 
            this.MName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.MName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MName.Location = new System.Drawing.Point(235, 375);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(300, 39);
            this.MName.TabIndex = 8;
            this.MName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MName_KeyPress);
            this.MName.Validating += new System.ComponentModel.CancelEventHandler(this.MName_Validating);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAdress.Location = new System.Drawing.Point(39, 499);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(271, 39);
            this.labelAdress.TabIndex = 9;
            this.labelAdress.Text = "Адрес прописки: ";
            // 
            // Street
            // 
            this.Street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.Street.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Street.Location = new System.Drawing.Point(387, 501);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(300, 39);
            this.Street.TabIndex = 10;
            this.Street.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Street_KeyPress);
            this.Street.Validating += new System.ComponentModel.CancelEventHandler(this.Street_Validating);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStreet.Location = new System.Drawing.Point(322, 499);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(59, 39);
            this.labelStreet.TabIndex = 11;
            this.labelStreet.Text = "ул.";
            // 
            // labelHouseNumber
            // 
            this.labelHouseNumber.AutoSize = true;
            this.labelHouseNumber.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHouseNumber.Location = new System.Drawing.Point(711, 499);
            this.labelHouseNumber.Name = "labelHouseNumber";
            this.labelHouseNumber.Size = new System.Drawing.Size(72, 39);
            this.labelHouseNumber.TabIndex = 12;
            this.labelHouseNumber.Text = "дом";
            // 
            // HouseNumber
            // 
            this.HouseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.HouseNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HouseNumber.Location = new System.Drawing.Point(789, 501);
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.Size = new System.Drawing.Size(300, 39);
            this.HouseNumber.TabIndex = 13;
            this.HouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HouseNumber_KeyPress);
            // 
            // labelApartment
            // 
            this.labelApartment.AutoSize = true;
            this.labelApartment.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelApartment.Location = new System.Drawing.Point(1121, 499);
            this.labelApartment.Name = "labelApartment";
            this.labelApartment.Size = new System.Drawing.Size(59, 39);
            this.labelApartment.TabIndex = 14;
            this.labelApartment.Text = "кв.";
            // 
            // Apartment
            // 
            this.Apartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.Apartment.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Apartment.Location = new System.Drawing.Point(1186, 501);
            this.Apartment.Name = "Apartment";
            this.Apartment.Size = new System.Drawing.Size(300, 39);
            this.Apartment.TabIndex = 15;
            this.Apartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apartment_KeyPress);
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDob.Location = new System.Drawing.Point(39, 439);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(416, 39);
            this.labelDob.TabIndex = 16;
            this.labelDob.Text = "Дата рождения (дд.мм.гггг)";
            // 
            // DoB
            // 
            this.DoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.DoB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoB.Location = new System.Drawing.Point(456, 441);
            this.DoB.Name = "DoB";
            this.DoB.Size = new System.Drawing.Size(300, 39);
            this.DoB.TabIndex = 17;
            this.DoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DoB_KeyPress);
            // 
            // labellabelAnAdress
            // 
            this.labellabelAnAdress.AutoSize = true;
            this.labellabelAnAdress.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labellabelAnAdress.Location = new System.Drawing.Point(39, 559);
            this.labellabelAnAdress.Name = "labellabelAnAdress";
            this.labellabelAnAdress.Size = new System.Drawing.Size(308, 39);
            this.labellabelAnAdress.TabIndex = 18;
            this.labellabelAnAdress.Text = "Адрес проживания: ";
            // 
            // labelInsCompany
            // 
            this.labelInsCompany.AutoSize = true;
            this.labelInsCompany.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInsCompany.Location = new System.Drawing.Point(39, 681);
            this.labelInsCompany.Name = "labelInsCompany";
            this.labelInsCompany.Size = new System.Drawing.Size(314, 39);
            this.labelInsCompany.TabIndex = 25;
            this.labelInsCompany.Text = "Страховая компания";
            // 
            // AnApartment
            // 
            this.AnApartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.AnApartment.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnApartment.Location = new System.Drawing.Point(1209, 561);
            this.AnApartment.Name = "AnApartment";
            this.AnApartment.Size = new System.Drawing.Size(300, 39);
            this.AnApartment.TabIndex = 31;
            this.AnApartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnApartment_KeyPress);
            // 
            // labelAnApartment
            // 
            this.labelAnApartment.AutoSize = true;
            this.labelAnApartment.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnApartment.Location = new System.Drawing.Point(1144, 559);
            this.labelAnApartment.Name = "labelAnApartment";
            this.labelAnApartment.Size = new System.Drawing.Size(59, 39);
            this.labelAnApartment.TabIndex = 30;
            this.labelAnApartment.Text = "кв.";
            // 
            // AnHouseNumber
            // 
            this.AnHouseNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.AnHouseNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnHouseNumber.Location = new System.Drawing.Point(812, 561);
            this.AnHouseNumber.Name = "AnHouseNumber";
            this.AnHouseNumber.Size = new System.Drawing.Size(300, 39);
            this.AnHouseNumber.TabIndex = 29;
            this.AnHouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnHouseNumber_KeyPress);
            // 
            // labelAnHouseNumber
            // 
            this.labelAnHouseNumber.AutoSize = true;
            this.labelAnHouseNumber.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnHouseNumber.Location = new System.Drawing.Point(734, 559);
            this.labelAnHouseNumber.Name = "labelAnHouseNumber";
            this.labelAnHouseNumber.Size = new System.Drawing.Size(72, 39);
            this.labelAnHouseNumber.TabIndex = 28;
            this.labelAnHouseNumber.Text = "дом";
            // 
            // labelAnStreet
            // 
            this.labelAnStreet.AutoSize = true;
            this.labelAnStreet.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnStreet.Location = new System.Drawing.Point(345, 559);
            this.labelAnStreet.Name = "labelAnStreet";
            this.labelAnStreet.Size = new System.Drawing.Size(59, 39);
            this.labelAnStreet.TabIndex = 27;
            this.labelAnStreet.Text = "ул.";
            // 
            // AnStreet
            // 
            this.AnStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.AnStreet.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnStreet.Location = new System.Drawing.Point(410, 561);
            this.AnStreet.Name = "AnStreet";
            this.AnStreet.Size = new System.Drawing.Size(300, 39);
            this.AnStreet.TabIndex = 26;
            this.AnStreet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnStreet_KeyPress);
            this.AnStreet.Validating += new System.ComponentModel.CancelEventHandler(this.AnStreet_Validating);
            // 
            // InsCompany
            // 
            this.InsCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.InsCompany.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsCompany.Location = new System.Drawing.Point(359, 681);
            this.InsCompany.Name = "InsCompany";
            this.InsCompany.Size = new System.Drawing.Size(300, 39);
            this.InsCompany.TabIndex = 32;
            this.InsCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsCompany_KeyPress);
            // 
            // labelInsNumber
            // 
            this.labelInsNumber.AutoSize = true;
            this.labelInsNumber.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInsNumber.Location = new System.Drawing.Point(665, 681);
            this.labelInsNumber.Name = "labelInsNumber";
            this.labelInsNumber.Size = new System.Drawing.Size(158, 39);
            this.labelInsNumber.TabIndex = 33;
            this.labelInsNumber.Text = "№ полиса";
            // 
            // InsNumber
            // 
            this.InsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.InsNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InsNumber.Location = new System.Drawing.Point(829, 681);
            this.InsNumber.Name = "InsNumber";
            this.InsNumber.Size = new System.Drawing.Size(300, 39);
            this.InsNumber.TabIndex = 34;
            this.InsNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InsNumber_KeyPress);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(39, 746);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(141, 39);
            this.labelPhoneNumber.TabIndex = 35;
            this.labelPhoneNumber.Text = "Телефон";
            // 
            // PatientPhoneNumber
            // 
            this.PatientPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.PatientPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientPhoneNumber.Location = new System.Drawing.Point(186, 748);
            this.PatientPhoneNumber.Name = "PatientPhoneNumber";
            this.PatientPhoneNumber.Size = new System.Drawing.Size(300, 39);
            this.PatientPhoneNumber.TabIndex = 36;
            this.PatientPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientPhoneNumber_KeyPress);
            // 
            // labelWorkPlace
            // 
            this.labelWorkPlace.AutoSize = true;
            this.labelWorkPlace.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWorkPlace.Location = new System.Drawing.Point(39, 806);
            this.labelWorkPlace.Name = "labelWorkPlace";
            this.labelWorkPlace.Size = new System.Drawing.Size(223, 39);
            this.labelWorkPlace.TabIndex = 37;
            this.labelWorkPlace.Text = "Место работы";
            // 
            // PatientWork
            // 
            this.PatientWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.PatientWork.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientWork.Location = new System.Drawing.Point(268, 808);
            this.PatientWork.Name = "PatientWork";
            this.PatientWork.Size = new System.Drawing.Size(600, 39);
            this.PatientWork.TabIndex = 38;
            this.PatientWork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientWork_KeyPress);
            this.PatientWork.Validating += new System.ComponentModel.CancelEventHandler(this.PatientWork_Validating);
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPost.Location = new System.Drawing.Point(874, 806);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(179, 39);
            this.labelPost.TabIndex = 39;
            this.labelPost.Text = "Должность";
            // 
            // PatientPost
            // 
            this.PatientPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.PatientPost.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientPost.Location = new System.Drawing.Point(1059, 807);
            this.PatientPost.Name = "PatientPost";
            this.PatientPost.Size = new System.Drawing.Size(500, 39);
            this.PatientPost.TabIndex = 40;
            this.PatientPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatientPost_KeyPress);
            this.PatientPost.Validating += new System.ComponentModel.CancelEventHandler(this.PatientPost_Validating);
            // 
            // adressbox
            // 
            this.adressbox.AutoSize = true;
            this.adressbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adressbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adressbox.Location = new System.Drawing.Point(52, 614);
            this.adressbox.Name = "adressbox";
            this.adressbox.Size = new System.Drawing.Size(210, 37);
            this.adressbox.TabIndex = 41;
            this.adressbox.Text = "как в прописке";
            this.adressbox.UseVisualStyleBackColor = true;
            this.adressbox.CheckedChanged += new System.EventHandler(this.adressbox_CheckedChanged);
            // 
            // cardnumber
            // 
            this.cardnumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cardnumber.AutoSize = true;
            this.cardnumber.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cardnumber.Location = new System.Drawing.Point(973, 151);
            this.cardnumber.Name = "cardnumber";
            this.cardnumber.Size = new System.Drawing.Size(44, 51);
            this.cardnumber.TabIndex = 42;
            this.cardnumber.Text = "1";
            this.cardnumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addingcard
            // 
            this.addingcard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addingcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.addingcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addingcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.addingcard.FlatAppearance.BorderSize = 0;
            this.addingcard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.addingcard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.addingcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addingcard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addingcard.Location = new System.Drawing.Point(702, 898);
            this.addingcard.Name = "addingcard";
            this.addingcard.Size = new System.Drawing.Size(174, 52);
            this.addingcard.TabIndex = 43;
            this.addingcard.Text = "Добавить";
            this.addingcard.UseVisualStyleBackColor = false;
            this.addingcard.Click += new System.EventHandler(this.addingcard_Click);
            // 
            // ClearForm
            // 
            this.ClearForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.ClearForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClearForm.FlatAppearance.BorderSize = 0;
            this.ClearForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.ClearForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.ClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearForm.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearForm.Location = new System.Drawing.Point(1139, 253);
            this.ClearForm.Name = "ClearForm";
            this.ClearForm.Size = new System.Drawing.Size(233, 81);
            this.ClearForm.TabIndex = 44;
            this.ClearForm.Text = "Очистить форму";
            this.ClearForm.UseVisualStyleBackColor = false;
            this.ClearForm.Click += new System.EventHandler(this.ClearForm_Click);
            // 
            // DobError
            // 
            this.DobError.AutoSize = true;
            this.DobError.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DobError.ForeColor = System.Drawing.Color.Red;
            this.DobError.Location = new System.Drawing.Point(456, 483);
            this.DobError.Name = "DobError";
            this.DobError.Size = new System.Drawing.Size(0, 15);
            this.DobError.TabIndex = 45;
            // 
            // phoneError
            // 
            this.phoneError.AutoSize = true;
            this.phoneError.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneError.ForeColor = System.Drawing.Color.Red;
            this.phoneError.Location = new System.Drawing.Point(186, 790);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(0, 15);
            this.phoneError.TabIndex = 46;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1564, 986);
            this.Controls.Add(this.phoneError);
            this.Controls.Add(this.DobError);
            this.Controls.Add(this.ClearForm);
            this.Controls.Add(this.addingcard);
            this.Controls.Add(this.cardnumber);
            this.Controls.Add(this.adressbox);
            this.Controls.Add(this.PatientPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.PatientWork);
            this.Controls.Add(this.labelWorkPlace);
            this.Controls.Add(this.PatientPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.InsNumber);
            this.Controls.Add(this.labelInsNumber);
            this.Controls.Add(this.InsCompany);
            this.Controls.Add(this.AnApartment);
            this.Controls.Add(this.labelAnApartment);
            this.Controls.Add(this.AnHouseNumber);
            this.Controls.Add(this.labelAnHouseNumber);
            this.Controls.Add(this.labelAnStreet);
            this.Controls.Add(this.AnStreet);
            this.Controls.Add(this.labelInsCompany);
            this.Controls.Add(this.labellabelAnAdress);
            this.Controls.Add(this.DoB);
            this.Controls.Add(this.labelDob);
            this.Controls.Add(this.Apartment);
            this.Controls.Add(this.labelApartment);
            this.Controls.Add(this.HouseNumber);
            this.Controls.Add(this.labelHouseNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.SName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelSname);
            this.Controls.Add(this.NumberMedCard);
            this.Controls.Add(this.upperpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PatientForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PatientForm_MouseMove);
            this.upperpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelData;
        private Panel upperpanel;
        private Label NumberMedCard;
        private Label labelSname;
        private Label labelFName;
        private Label labelMName;
        private TextBox SName;
        private TextBox FName;
        private TextBox MName;
        private Label labelAdress;
        private TextBox Street;
        private Label labelStreet;
        private Label labelHouseNumber;
        private TextBox HouseNumber;
        private Label labelApartment;
        private TextBox Apartment;
        private Label labelDob;
        private TextBox DoB;
        private Label labellabelAnAdress;
        private Label labelInsCompany;
        private TextBox AnApartment;
        private Label labelAnApartment;
        private TextBox AnHouseNumber;
        private Label labelAnHouseNumber;
        private Label labelAnStreet;
        private TextBox AnStreet;
        private TextBox InsCompany;
        private Label labelInsNumber;
        private TextBox InsNumber;
        private Label labelPhoneNumber;
        private TextBox PatientPhoneNumber;
        private Label labelWorkPlace;
        private TextBox PatientWork;
        private Label labelPost;
        private TextBox PatientPost;
        private CheckBox adressbox;
        private Label cardnumber;
        private Button addingcard;
        private Button ClearForm;
        private Label DobError;
        private Label phoneError;
        private Label hideForm;
        private Label BackToMenu;
    }
}