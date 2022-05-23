namespace w13_Kei
{
    partial class form_Player
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
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_PlayerId = new System.Windows.Forms.TextBox();
            this.tb_PlayerName = new System.Windows.Forms.TextBox();
            this.dtp_Birth = new System.Windows.Forms.DateTimePicker();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.nup_TeamNumber = new System.Windows.Forms.NumericUpDown();
            this.lb_Available = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cb_Nation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nup_TeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(42, 44);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(65, 54);
            this.btn_First.TabIndex = 0;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(128, 44);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(65, 54);
            this.btn_Prev.TabIndex = 1;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(223, 44);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(65, 54);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(307, 44);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(65, 54);
            this.btn_Last.TabIndex = 3;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BirthDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nationality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Team Number";
            // 
            // tb_PlayerId
            // 
            this.tb_PlayerId.Location = new System.Drawing.Point(167, 146);
            this.tb_PlayerId.Name = "tb_PlayerId";
            this.tb_PlayerId.Size = new System.Drawing.Size(121, 20);
            this.tb_PlayerId.TabIndex = 10;
            // 
            // tb_PlayerName
            // 
            this.tb_PlayerName.Location = new System.Drawing.Point(167, 185);
            this.tb_PlayerName.Name = "tb_PlayerName";
            this.tb_PlayerName.Size = new System.Drawing.Size(222, 20);
            this.tb_PlayerName.TabIndex = 11;
            // 
            // dtp_Birth
            // 
            this.dtp_Birth.CustomFormat = "dddd , MMMM dd, yyyy";
            this.dtp_Birth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Birth.Location = new System.Drawing.Point(167, 217);
            this.dtp_Birth.Name = "dtp_Birth";
            this.dtp_Birth.Size = new System.Drawing.Size(200, 20);
            this.dtp_Birth.TabIndex = 12;
            // 
            // cb_Team
            // 
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Team.Location = new System.Drawing.Point(167, 287);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(200, 21);
            this.cb_Team.TabIndex = 14;
            // 
            // nup_TeamNumber
            // 
            this.nup_TeamNumber.Location = new System.Drawing.Point(168, 314);
            this.nup_TeamNumber.Name = "nup_TeamNumber";
            this.nup_TeamNumber.Size = new System.Drawing.Size(120, 20);
            this.nup_TeamNumber.TabIndex = 15;
            this.nup_TeamNumber.ValueChanged += new System.EventHandler(this.nup_TeamNumber_ValueChanged);
            // 
            // lb_Available
            // 
            this.lb_Available.AutoSize = true;
            this.lb_Available.Location = new System.Drawing.Point(317, 316);
            this.lb_Available.Name = "lb_Available";
            this.lb_Available.Size = new System.Drawing.Size(50, 13);
            this.lb_Available.TabIndex = 16;
            this.lb_Available.Text = "Available";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(69, 356);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(124, 23);
            this.btn_Save.TabIndex = 17;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(232, 356);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 23);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cb_Nation
            // 
            this.cb_Nation.FormattingEnabled = true;
            this.cb_Nation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Nation.Location = new System.Drawing.Point(167, 258);
            this.cb_Nation.Name = "cb_Nation";
            this.cb_Nation.Size = new System.Drawing.Size(200, 21);
            this.cb_Nation.TabIndex = 19;
            // 
            // form_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 409);
            this.Controls.Add(this.cb_Nation);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lb_Available);
            this.Controls.Add(this.nup_TeamNumber);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.dtp_Birth);
            this.Controls.Add(this.tb_PlayerName);
            this.Controls.Add(this.tb_PlayerId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "form_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.form_Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_TeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_PlayerId;
        private System.Windows.Forms.TextBox tb_PlayerName;
        private System.Windows.Forms.DateTimePicker dtp_Birth;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.NumericUpDown nup_TeamNumber;
        private System.Windows.Forms.Label lb_Available;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cb_Nation;
    }
}

