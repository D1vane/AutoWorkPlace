namespace FinalWork
{
    partial class SearchCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCard));
            this.upperpanel = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.Scardnumber = new System.Windows.Forms.Label();
            this.SDoB = new System.Windows.Forms.TextBox();
            this.labelDoB = new System.Windows.Forms.Label();
            this.SMName = new System.Windows.Forms.TextBox();
            this.SFName = new System.Windows.Forms.TextBox();
            this.SSName = new System.Windows.Forms.TextBox();
            this.labelMName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelSname = new System.Windows.Forms.Label();
            this.searchingcard = new System.Windows.Forms.Button();
            this.SDobError = new System.Windows.Forms.Label();
            this.hideForm = new System.Windows.Forms.Label();
            this.BacktoMenu = new System.Windows.Forms.Label();
            this.upperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.upperpanel.Controls.Add(this.labelTitle);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1564, 125);
            this.upperpanel.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(521, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(575, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Поиск медицинской карты";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Scardnumber
            // 
            this.Scardnumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Scardnumber.AutoSize = true;
            this.Scardnumber.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Scardnumber.Location = new System.Drawing.Point(1024, 141);
            this.Scardnumber.Name = "Scardnumber";
            this.Scardnumber.Size = new System.Drawing.Size(0, 51);
            this.Scardnumber.TabIndex = 44;
            this.Scardnumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SDoB
            // 
            this.SDoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SDoB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDoB.Location = new System.Drawing.Point(447, 417);
            this.SDoB.Name = "SDoB";
            this.SDoB.Size = new System.Drawing.Size(300, 39);
            this.SDoB.TabIndex = 52;
            this.SDoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SDoB_KeyPress);
            // 
            // labelDoB
            // 
            this.labelDoB.AutoSize = true;
            this.labelDoB.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDoB.Location = new System.Drawing.Point(30, 415);
            this.labelDoB.Name = "labelDoB";
            this.labelDoB.Size = new System.Drawing.Size(416, 39);
            this.labelDoB.TabIndex = 51;
            this.labelDoB.Text = "Дата рождения (дд.мм.гггг)";
            // 
            // SMName
            // 
            this.SMName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SMName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SMName.Location = new System.Drawing.Point(226, 351);
            this.SMName.Name = "SMName";
            this.SMName.Size = new System.Drawing.Size(300, 39);
            this.SMName.TabIndex = 50;
            this.SMName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SMName_KeyPress);
            this.SMName.Validating += new System.ComponentModel.CancelEventHandler(this.SMName_Validating);
            // 
            // SFName
            // 
            this.SFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SFName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SFName.Location = new System.Drawing.Point(156, 289);
            this.SFName.Name = "SFName";
            this.SFName.Size = new System.Drawing.Size(300, 39);
            this.SFName.TabIndex = 49;
            this.SFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SFName_KeyPress);
            this.SFName.Validating += new System.ComponentModel.CancelEventHandler(this.SFName_Validating);
            // 
            // SSName
            // 
            this.SSName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SSName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SSName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SSName.Location = new System.Drawing.Point(226, 229);
            this.SSName.Name = "SSName";
            this.SSName.Size = new System.Drawing.Size(300, 39);
            this.SSName.TabIndex = 48;
            this.SSName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SSName_KeyPress);
            this.SSName.Validating += new System.ComponentModel.CancelEventHandler(this.SSName_Validating);
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMName.Location = new System.Drawing.Point(30, 351);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(153, 39);
            this.labelMName.TabIndex = 47;
            this.labelMName.Text = "Отчество";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFName.Location = new System.Drawing.Point(30, 289);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(80, 39);
            this.labelFName.TabIndex = 46;
            this.labelFName.Text = "Имя";
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSname.Location = new System.Drawing.Point(30, 229);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(150, 39);
            this.labelSname.TabIndex = 45;
            this.labelSname.Text = "Фамилия";
            // 
            // searchingcard
            // 
            this.searchingcard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchingcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.searchingcard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchingcard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.searchingcard.FlatAppearance.BorderSize = 0;
            this.searchingcard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.searchingcard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.searchingcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchingcard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchingcard.Location = new System.Drawing.Point(695, 879);
            this.searchingcard.Name = "searchingcard";
            this.searchingcard.Size = new System.Drawing.Size(174, 52);
            this.searchingcard.TabIndex = 78;
            this.searchingcard.Text = "Поиск";
            this.searchingcard.UseVisualStyleBackColor = false;
            this.searchingcard.Click += new System.EventHandler(this.searchingcard_Click);
            // 
            // SDobError
            // 
            this.SDobError.AutoSize = true;
            this.SDobError.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SDobError.ForeColor = System.Drawing.Color.Red;
            this.SDobError.Location = new System.Drawing.Point(456, 459);
            this.SDobError.Name = "SDobError";
            this.SDobError.Size = new System.Drawing.Size(0, 15);
            this.SDobError.TabIndex = 87;
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
            this.hideForm.TabIndex = 92;
            this.hideForm.Text = "_";
            this.hideForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hideForm.Click += new System.EventHandler(this.hideForm_Click);
            this.hideForm.MouseEnter += new System.EventHandler(this.hideForm_MouseEnter);
            this.hideForm.MouseLeave += new System.EventHandler(this.hideForm_MouseLeave);
            // 
            // BacktoMenu
            // 
            this.BacktoMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BacktoMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.BacktoMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BacktoMenu.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BacktoMenu.ForeColor = System.Drawing.Color.White;
            this.BacktoMenu.Location = new System.Drawing.Point(1530, -1);
            this.BacktoMenu.Name = "BacktoMenu";
            this.BacktoMenu.Size = new System.Drawing.Size(34, 38);
            this.BacktoMenu.TabIndex = 93;
            this.BacktoMenu.Text = "←";
            this.BacktoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BacktoMenu.Click += new System.EventHandler(this.BacktoMenu_Click);
            this.BacktoMenu.MouseEnter += new System.EventHandler(this.BacktoMenu_MouseEnter);
            this.BacktoMenu.MouseLeave += new System.EventHandler(this.BacktoMenu_MouseLeave);
            // 
            // SearchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1564, 986);
            this.Controls.Add(this.BacktoMenu);
            this.Controls.Add(this.hideForm);
            this.Controls.Add(this.SDobError);
            this.Controls.Add(this.searchingcard);
            this.Controls.Add(this.SDoB);
            this.Controls.Add(this.labelDoB);
            this.Controls.Add(this.SMName);
            this.Controls.Add(this.SFName);
            this.Controls.Add(this.SSName);
            this.Controls.Add(this.labelMName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelSname);
            this.Controls.Add(this.Scardnumber);
            this.Controls.Add(this.upperpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchCard";
            this.Load += new System.EventHandler(this.SearchCard_Load);
            this.upperpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel upperpanel;
        private Label labelTitle;
        private Label Scardnumber;
        private TextBox SDoB;
        private Label labelDoB;
        private TextBox SMName;
        private TextBox SFName;
        private TextBox SSName;
        private Label labelMName;
        private Label labelFName;
        private Label labelSname;
        private Button searchingcard;
        private Label SDobError;
        private Label hideForm;
        private Label BacktoMenu;
    }
}