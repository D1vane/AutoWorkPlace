namespace FinalWork
{
    partial class Recording
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recording));
            this.upperpanel = new System.Windows.Forms.Panel();
            this.BacktoMenu = new System.Windows.Forms.Label();
            this.hideForm = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.RecordingButton = new System.Windows.Forms.Button();
            this.SpecialisationCB = new System.Windows.Forms.ComboBox();
            this.SpecialistCB = new System.Windows.Forms.ComboBox();
            this.TimeRecordingCB = new System.Windows.Forms.ComboBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSpecialisation = new System.Windows.Forms.Label();
            this.labelSpecialist = new System.Windows.Forms.Label();
            this.CurrentDay = new System.Windows.Forms.Label();
            this.Titleday = new System.Windows.Forms.Label();
            this.upperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.upperpanel.Controls.Add(this.BacktoMenu);
            this.upperpanel.Controls.Add(this.hideForm);
            this.upperpanel.Controls.Add(this.labelTitle);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1564, 125);
            this.upperpanel.TabIndex = 3;
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
            this.BacktoMenu.TabIndex = 91;
            this.BacktoMenu.Text = "←";
            this.BacktoMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BacktoMenu.Click += new System.EventHandler(this.BacktoMenu_Click);
            this.BacktoMenu.MouseEnter += new System.EventHandler(this.BacktoMenu_MouseEnter);
            this.BacktoMenu.MouseLeave += new System.EventHandler(this.BacktoMenu_MouseLeave);
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
            this.hideForm.TabIndex = 90;
            this.hideForm.Text = "_";
            this.hideForm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.hideForm.Click += new System.EventHandler(this.hideForm_Click);
            this.hideForm.MouseEnter += new System.EventHandler(this.hideForm_MouseEnter);
            this.hideForm.MouseLeave += new System.EventHandler(this.hideForm_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(395, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(575, 51);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Запись на прием";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RecordingButton
            // 
            this.RecordingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RecordingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.RecordingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.RecordingButton.FlatAppearance.BorderSize = 0;
            this.RecordingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.RecordingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.RecordingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordingButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecordingButton.Location = new System.Drawing.Point(732, 903);
            this.RecordingButton.Name = "RecordingButton";
            this.RecordingButton.Size = new System.Drawing.Size(174, 52);
            this.RecordingButton.TabIndex = 45;
            this.RecordingButton.Text = "Записать";
            this.RecordingButton.UseVisualStyleBackColor = false;
            this.RecordingButton.Click += new System.EventHandler(this.RecordingButton_Click);
            // 
            // SpecialisationCB
            // 
            this.SpecialisationCB.FormattingEnabled = true;
            this.SpecialisationCB.Location = new System.Drawing.Point(103, 243);
            this.SpecialisationCB.Name = "SpecialisationCB";
            this.SpecialisationCB.Size = new System.Drawing.Size(179, 28);
            this.SpecialisationCB.TabIndex = 46;
            this.SpecialisationCB.SelectedIndexChanged += new System.EventHandler(this.SpecialisationCB_SelectedIndexChanged);
            // 
            // SpecialistCB
            // 
            this.SpecialistCB.FormattingEnabled = true;
            this.SpecialistCB.Location = new System.Drawing.Point(448, 243);
            this.SpecialistCB.Name = "SpecialistCB";
            this.SpecialistCB.Size = new System.Drawing.Size(179, 28);
            this.SpecialistCB.TabIndex = 47;
            this.SpecialistCB.SelectedIndexChanged += new System.EventHandler(this.SpecialistCB_SelectedIndexChanged);
            // 
            // TimeRecordingCB
            // 
            this.TimeRecordingCB.FormattingEnabled = true;
            this.TimeRecordingCB.Location = new System.Drawing.Point(811, 243);
            this.TimeRecordingCB.Name = "TimeRecordingCB";
            this.TimeRecordingCB.Size = new System.Drawing.Size(179, 28);
            this.TimeRecordingCB.TabIndex = 48;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(833, 203);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(128, 22);
            this.labelTime.TabIndex = 49;
            this.labelTime.Text = "Время записи";
            // 
            // labelSpecialisation
            // 
            this.labelSpecialisation.AutoSize = true;
            this.labelSpecialisation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpecialisation.Location = new System.Drawing.Point(130, 203);
            this.labelSpecialisation.Name = "labelSpecialisation";
            this.labelSpecialisation.Size = new System.Drawing.Size(122, 22);
            this.labelSpecialisation.TabIndex = 50;
            this.labelSpecialisation.Text = "Направление";
            // 
            // labelSpecialist
            // 
            this.labelSpecialist.AutoSize = true;
            this.labelSpecialist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpecialist.Location = new System.Drawing.Point(482, 203);
            this.labelSpecialist.Name = "labelSpecialist";
            this.labelSpecialist.Size = new System.Drawing.Size(113, 22);
            this.labelSpecialist.TabIndex = 51;
            this.labelSpecialist.Text = "Специалист";
            // 
            // CurrentDay
            // 
            this.CurrentDay.AutoSize = true;
            this.CurrentDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentDay.Location = new System.Drawing.Point(1394, 922);
            this.CurrentDay.Name = "CurrentDay";
            this.CurrentDay.Size = new System.Drawing.Size(0, 22);
            this.CurrentDay.TabIndex = 52;
            // 
            // Titleday
            // 
            this.Titleday.AutoSize = true;
            this.Titleday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titleday.Location = new System.Drawing.Point(1394, 891);
            this.Titleday.Name = "Titleday";
            this.Titleday.Size = new System.Drawing.Size(118, 22);
            this.Titleday.TabIndex = 53;
            this.Titleday.Text = "День недели";
            // 
            // Recording
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(231)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1564, 986);
            this.Controls.Add(this.Titleday);
            this.Controls.Add(this.CurrentDay);
            this.Controls.Add(this.labelSpecialist);
            this.Controls.Add(this.labelSpecialisation);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.TimeRecordingCB);
            this.Controls.Add(this.SpecialistCB);
            this.Controls.Add(this.SpecialisationCB);
            this.Controls.Add(this.RecordingButton);
            this.Controls.Add(this.upperpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recording";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recording";
            this.Load += new System.EventHandler(this.Recording_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Recording_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Recording_MouseMove);
            this.upperpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel upperpanel;
        private Label labelTitle;
        private Button RecordingButton;
        private ComboBox SpecialisationCB;
        private ComboBox SpecialistCB;
        private ComboBox TimeRecordingCB;
        private Label labelTime;
        private Label labelSpecialisation;
        private Label labelSpecialist;
        private Label CurrentDay;
        private Label hideForm;
        private Label BacktoMenu;
        private Label Titleday;
    }
}