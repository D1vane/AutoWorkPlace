namespace FinalWork
{
    partial class ScheduleStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleStorage));
            this.upperpanel = new System.Windows.Forms.Panel();
            this.BacktoMenu = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.DaysOfWeek = new System.Windows.Forms.ListBox();
            this.Specialisation = new System.Windows.Forms.ListBox();
            this.Specialists = new System.Windows.Forms.ListBox();
            this.hideForm = new System.Windows.Forms.Label();
            this.upperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.upperpanel.Controls.Add(this.BacktoMenu);
            this.upperpanel.Controls.Add(this.labelTitle);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1564, 125);
            this.upperpanel.TabIndex = 4;
            this.upperpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upperpanel_MouseDown);
            this.upperpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upperpanel_MouseMove);
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
            this.BacktoMenu.TabIndex = 92;
            this.BacktoMenu.Text = "←";
            this.BacktoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BacktoMenu.Click += new System.EventHandler(this.BacktoMenu_Click);
            this.BacktoMenu.MouseEnter += new System.EventHandler(this.BacktoMenu_MouseEnter);
            this.BacktoMenu.MouseLeave += new System.EventHandler(this.BacktoMenu_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(517, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(575, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Расписание работы врачей";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DaysOfWeek
            // 
            this.DaysOfWeek.BackColor = System.Drawing.Color.Cyan;
            this.DaysOfWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DaysOfWeek.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DaysOfWeek.FormattingEnabled = true;
            this.DaysOfWeek.ItemHeight = 26;
            this.DaysOfWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.DaysOfWeek.Location = new System.Drawing.Point(0, 125);
            this.DaysOfWeek.Name = "DaysOfWeek";
            this.DaysOfWeek.Size = new System.Drawing.Size(492, 862);
            this.DaysOfWeek.TabIndex = 45;
            this.DaysOfWeek.SelectedIndexChanged += new System.EventHandler(this.DaysOfWeek_SelectedIndexChanged);
            this.DaysOfWeek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DaysOfWeek_MouseDown);
            this.DaysOfWeek.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DaysOfWeek_MouseMove);
            // 
            // Specialisation
            // 
            this.Specialisation.BackColor = System.Drawing.Color.Cyan;
            this.Specialisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Specialisation.Enabled = false;
            this.Specialisation.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Specialisation.FormattingEnabled = true;
            this.Specialisation.ItemHeight = 26;
            this.Specialisation.Location = new System.Drawing.Point(488, 125);
            this.Specialisation.Name = "Specialisation";
            this.Specialisation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Specialisation.Size = new System.Drawing.Size(492, 862);
            this.Specialisation.TabIndex = 46;
            this.Specialisation.SelectedIndexChanged += new System.EventHandler(this.Specialisation_SelectedIndexChanged);
            this.Specialisation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Specialisation_MouseDown);
            this.Specialisation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Specialisation_MouseMove);
            // 
            // Specialists
            // 
            this.Specialists.BackColor = System.Drawing.Color.Cyan;
            this.Specialists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Specialists.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Specialists.FormattingEnabled = true;
            this.Specialists.ItemHeight = 26;
            this.Specialists.Location = new System.Drawing.Point(977, 125);
            this.Specialists.Name = "Specialists";
            this.Specialists.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Specialists.Size = new System.Drawing.Size(620, 862);
            this.Specialists.TabIndex = 47;
            this.Specialists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Specialists_MouseDown);
            this.Specialists.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Specialists_MouseMove);
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
            this.hideForm.TabIndex = 91;
            this.hideForm.Text = "_";
            this.hideForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hideForm.Click += new System.EventHandler(this.hideForm_Click);
            this.hideForm.MouseEnter += new System.EventHandler(this.hideForm_MouseEnter);
            this.hideForm.MouseLeave += new System.EventHandler(this.hideForm_MouseLeave);
            // 
            // ScheduleStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1564, 986);
            this.Controls.Add(this.hideForm);
            this.Controls.Add(this.Specialists);
            this.Controls.Add(this.Specialisation);
            this.Controls.Add(this.DaysOfWeek);
            this.Controls.Add(this.upperpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScheduleStorage";
            this.upperpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel upperpanel;
        private Label labelTitle;
        private ListBox DaysOfWeek;
        private ListBox Specialisation;
        private ListBox Specialists;
        private Label hideForm;
        private Label BacktoMenu;
    }
}