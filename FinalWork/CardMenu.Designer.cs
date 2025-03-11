namespace FinalWork
{
    partial class CardMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardMenu));
            this.AddCard = new System.Windows.Forms.Button();
            this.EditCard = new System.Windows.Forms.Button();
            this.SearchMedCard = new System.Windows.Forms.Button();
            this.hideForm = new System.Windows.Forms.Label();
            this.BackToMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddCard
            // 
            this.AddCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.AddCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.AddCard.FlatAppearance.BorderSize = 0;
            this.AddCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.AddCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.AddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCard.Location = new System.Drawing.Point(654, 233);
            this.AddCard.Name = "AddCard";
            this.AddCard.Size = new System.Drawing.Size(257, 85);
            this.AddCard.TabIndex = 0;
            this.AddCard.Text = "Создать мед. карту";
            this.AddCard.UseVisualStyleBackColor = false;
            this.AddCard.Click += new System.EventHandler(this.AddCard_Click);
            // 
            // EditCard
            // 
            this.EditCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.EditCard.CausesValidation = false;
            this.EditCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.EditCard.FlatAppearance.BorderSize = 0;
            this.EditCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.EditCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.EditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditCard.Location = new System.Drawing.Point(654, 354);
            this.EditCard.Name = "EditCard";
            this.EditCard.Size = new System.Drawing.Size(257, 85);
            this.EditCard.TabIndex = 1;
            this.EditCard.Text = "Редактировать мед. карту";
            this.EditCard.UseVisualStyleBackColor = false;
            this.EditCard.Click += new System.EventHandler(this.EditCard_Click);
            // 
            // SearchMedCard
            // 
            this.SearchMedCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchMedCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.SearchMedCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchMedCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SearchMedCard.FlatAppearance.BorderSize = 0;
            this.SearchMedCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.SearchMedCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.SearchMedCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchMedCard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchMedCard.Location = new System.Drawing.Point(654, 475);
            this.SearchMedCard.Name = "SearchMedCard";
            this.SearchMedCard.Size = new System.Drawing.Size(257, 85);
            this.SearchMedCard.TabIndex = 4;
            this.SearchMedCard.Text = "Поиск мед. карты";
            this.SearchMedCard.UseVisualStyleBackColor = false;
            this.SearchMedCard.Click += new System.EventHandler(this.SearchMedCard_Click);
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
            this.hideForm.TabIndex = 87;
            this.hideForm.Text = "_";
            this.hideForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hideForm.Click += new System.EventHandler(this.hideForm_Click);
            this.hideForm.MouseEnter += new System.EventHandler(this.hideForm_MouseEnter);
            this.hideForm.MouseLeave += new System.EventHandler(this.hideForm_MouseLeave);
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
            this.BackToMenu.TabIndex = 88;
            this.BackToMenu.Text = "←";
            this.BackToMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackToMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackToMenu_MouseClick);
            this.BackToMenu.MouseEnter += new System.EventHandler(this.BackToMenu_MouseEnter);
            this.BackToMenu.MouseLeave += new System.EventHandler(this.BackToMenu_MouseLeave);
            // 
            // CardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1564, 986);
            this.Controls.Add(this.BackToMenu);
            this.Controls.Add(this.hideForm);
            this.Controls.Add(this.SearchMedCard);
            this.Controls.Add(this.EditCard);
            this.Controls.Add(this.AddCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CardMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddCard;
        private Button EditCard;
        private Button SearchMedCard;
        private Label hideForm;
        private Label BackToMenu;
    }
}