namespace Phones_and_abonents
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.admin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.Phone = new System.Windows.Forms.Label();
            this.akk = new System.Windows.Forms.Label();
            this.podsk = new System.Windows.Forms.Label();
            this.ybrat = new System.Windows.Forms.Label();
            this.vxod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.pas = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(233, 288);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(149, 42);
            this.admin.TabIndex = 0;
            this.admin.Text = "АДМИН";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Visible = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(442, 288);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(149, 42);
            this.user.TabIndex = 1;
            this.user.Text = "ПОЛЬЗОВАТЕЛЬ";
            this.user.UseVisualStyleBackColor = true;
            this.user.Visible = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Phone.Location = new System.Drawing.Point(226, 113);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(365, 42);
            this.Phone.TabIndex = 2;
            this.Phone.Text = "Телефоны и абоненты";
            // 
            // akk
            // 
            this.akk.AutoSize = true;
            this.akk.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.akk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.akk.Location = new System.Drawing.Point(104, 155);
            this.akk.Name = "akk";
            this.akk.Size = new System.Drawing.Size(625, 42);
            this.akk.TabIndex = 3;
            this.akk.Text = "Под каким аккаунтам вы хотите зайти?";
            this.akk.Visible = false;
            // 
            // podsk
            // 
            this.podsk.AutoSize = true;
            this.podsk.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.podsk.ForeColor = System.Drawing.SystemColors.Control;
            this.podsk.Location = new System.Drawing.Point(613, 207);
            this.podsk.Name = "podsk";
            this.podsk.Size = new System.Drawing.Size(73, 15);
            this.podsk.TabIndex = 4;
            this.podsk.Text = "Подсказка...";
            this.podsk.Visible = false;
            this.podsk.Click += new System.EventHandler(this.podsk_Click);
            // 
            // ybrat
            // 
            this.ybrat.AutoSize = true;
            this.ybrat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ybrat.ForeColor = System.Drawing.SystemColors.Control;
            this.ybrat.Location = new System.Drawing.Point(547, 240);
            this.ybrat.Name = "ybrat";
            this.ybrat.Size = new System.Drawing.Size(46, 15);
            this.ybrat.TabIndex = 5;
            this.ybrat.Text = "Убрать";
            this.ybrat.Visible = false;
            this.ybrat.Click += new System.EventHandler(this.ybrat_Click);
            // 
            // vxod
            // 
            this.vxod.Location = new System.Drawing.Point(334, 288);
            this.vxod.Name = "vxod";
            this.vxod.Size = new System.Drawing.Size(149, 42);
            this.vxod.TabIndex = 6;
            this.vxod.Text = "Далее";
            this.vxod.UseVisualStyleBackColor = true;
            this.vxod.Click += new System.EventHandler(this.vxod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(81, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Если вы хотите находить, удалять и добавлять номера, ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(79, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(686, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = " то вам необходимо зайти под админом (нажав кнопку ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(66, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(699, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = " \"Админ\"), если хотите просто найти необходимый вам ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(66, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(702, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = " номер, то нужно зайти под пользователем (удалять или ";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(227, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "добавлять вы не сможете)";
            this.label5.Visible = false;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(334, 265);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(149, 42);
            this.pass.TabIndex = 12;
            this.pass.Text = "Войти";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Visible = false;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(334, 153);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(149, 32);
            this.log.TabIndex = 13;
            this.log.Visible = false;
            // 
            // pas
            // 
            this.pas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pas.Location = new System.Drawing.Point(334, 201);
            this.pas.Name = "pas";
            this.pas.Size = new System.Drawing.Size(149, 32);
            this.pas.TabIndex = 14;
            this.pas.Visible = false;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.Control;
            this.login.Location = new System.Drawing.Point(257, 156);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(71, 23);
            this.login.TabIndex = 15;
            this.login.Text = "Логин:";
            this.login.Visible = false;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.ForeColor = System.Drawing.SystemColors.Control;
            this.password.Location = new System.Drawing.Point(247, 204);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(81, 23);
            this.password.TabIndex = 16;
            this.password.Text = "Пароль:";
            this.password.Visible = false;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.ForeColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(489, 292);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(39, 15);
            this.back.TabIndex = 17;
            this.back.Text = "Назад";
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vxod);
            this.Controls.Add(this.ybrat);
            this.Controls.Add(this.podsk);
            this.Controls.Add(this.akk);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.user);
            this.Controls.Add(this.admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телефоны и абоненты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label akk;
        private System.Windows.Forms.Label podsk;
        private System.Windows.Forms.Label ybrat;
        private System.Windows.Forms.Button vxod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox pas;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.Button button1;
    }
}

