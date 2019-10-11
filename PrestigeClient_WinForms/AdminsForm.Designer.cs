namespace PrestigeClient_WinForms
{
    partial class AdminsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsForm));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblErrorSurname = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rdWarehouseWorker = new System.Windows.Forms.RadioButton();
            this.rdCashier = new System.Windows.Forms.RadioButton();
            this.lblErrorPatronymic = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            this.dateTimeDateBeginWork = new System.Windows.Forms.DateTimePicker();
            this.lblErrorDataBeginWork = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstCashiers = new System.Windows.Forms.ListBox();
            this.lstWarehouseWorkers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteCashiers = new System.Windows.Forms.Button();
            this.btnDeleteWareWorkers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAdmin.Location = new System.Drawing.Point(374, 109);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(0, 30);
            this.lblAdmin.TabIndex = 104;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 89);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(281, 533);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 44);
            this.btnExit.TabIndex = 99;
            this.btnExit.Text = "Перезайти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.25F);
            this.label2.Location = new System.Drawing.Point(97, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 30);
            this.label2.TabIndex = 83;
            this.label2.Text = "Добавление персонала в базу";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(264, 511);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 15);
            this.lblInfo.TabIndex = 82;
            this.lblInfo.Text = "* - Поля обязательные к заполнению";
            this.lblInfo.Visible = false;
            // 
            // lblErrorSurname
            // 
            this.lblErrorSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorSurname.AutoSize = true;
            this.lblErrorSurname.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorSurname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSurname.Location = new System.Drawing.Point(479, 302);
            this.lblErrorSurname.Name = "lblErrorSurname";
            this.lblErrorSurname.Size = new System.Drawing.Size(15, 19);
            this.lblErrorSurname.TabIndex = 81;
            this.lblErrorSurname.Text = "*";
            this.lblErrorSurname.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(479, 262);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(15, 19);
            this.lblErrorName.TabIndex = 80;
            this.lblErrorName.Text = "*";
            this.lblErrorName.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(28, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 79;
            this.label4.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(29, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Имя";
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSurname.BackColor = System.Drawing.Color.White;
            this.txtSurname.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtSurname.Location = new System.Drawing.Point(228, 299);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(244, 31);
            this.txtSurname.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtName.Location = new System.Drawing.Point(228, 259);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 31);
            this.txtName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(102, 533);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 44);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdWarehouseWorker
            // 
            this.rdWarehouseWorker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdWarehouseWorker.AutoSize = true;
            this.rdWarehouseWorker.Font = new System.Drawing.Font("Comic Sans MS", 13.75F);
            this.rdWarehouseWorker.Location = new System.Drawing.Point(255, 202);
            this.rdWarehouseWorker.Name = "rdWarehouseWorker";
            this.rdWarehouseWorker.Size = new System.Drawing.Size(180, 30);
            this.rdWarehouseWorker.TabIndex = 2;
            this.rdWarehouseWorker.TabStop = true;
            this.rdWarehouseWorker.Tag = "2";
            this.rdWarehouseWorker.Text = "Работник склада";
            this.rdWarehouseWorker.UseVisualStyleBackColor = true;
            // 
            // rdCashier
            // 
            this.rdCashier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdCashier.AutoSize = true;
            this.rdCashier.Font = new System.Drawing.Font("Comic Sans MS", 13.75F);
            this.rdCashier.Location = new System.Drawing.Point(95, 202);
            this.rdCashier.Name = "rdCashier";
            this.rdCashier.Size = new System.Drawing.Size(94, 30);
            this.rdCashier.TabIndex = 1;
            this.rdCashier.TabStop = true;
            this.rdCashier.Tag = "1";
            this.rdCashier.Text = "Кассир";
            this.rdCashier.UseVisualStyleBackColor = true;
            // 
            // lblErrorPatronymic
            // 
            this.lblErrorPatronymic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorPatronymic.AutoSize = true;
            this.lblErrorPatronymic.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorPatronymic.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPatronymic.Location = new System.Drawing.Point(479, 345);
            this.lblErrorPatronymic.Name = "lblErrorPatronymic";
            this.lblErrorPatronymic.Size = new System.Drawing.Size(15, 19);
            this.lblErrorPatronymic.TabIndex = 109;
            this.lblErrorPatronymic.Text = "*";
            this.lblErrorPatronymic.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label5.Location = new System.Drawing.Point(27, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 108;
            this.label5.Text = "Отчество";
            // 
            // txtPatronymic
            // 
            this.txtPatronymic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPatronymic.BackColor = System.Drawing.Color.White;
            this.txtPatronymic.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtPatronymic.Location = new System.Drawing.Point(228, 342);
            this.txtPatronymic.Name = "txtPatronymic";
            this.txtPatronymic.Size = new System.Drawing.Size(244, 31);
            this.txtPatronymic.TabIndex = 5;
            // 
            // dateTimeDateBeginWork
            // 
            this.dateTimeDateBeginWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimeDateBeginWork.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.dateTimeDateBeginWork.Location = new System.Drawing.Point(228, 472);
            this.dateTimeDateBeginWork.Name = "dateTimeDateBeginWork";
            this.dateTimeDateBeginWork.Size = new System.Drawing.Size(244, 31);
            this.dateTimeDateBeginWork.TabIndex = 8;
            // 
            // lblErrorDataBeginWork
            // 
            this.lblErrorDataBeginWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorDataBeginWork.AutoSize = true;
            this.lblErrorDataBeginWork.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorDataBeginWork.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDataBeginWork.Location = new System.Drawing.Point(478, 472);
            this.lblErrorDataBeginWork.Name = "lblErrorDataBeginWork";
            this.lblErrorDataBeginWork.Size = new System.Drawing.Size(15, 19);
            this.lblErrorDataBeginWork.TabIndex = 111;
            this.lblErrorDataBeginWork.Text = "*";
            this.lblErrorDataBeginWork.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label10.Location = new System.Drawing.Point(29, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 24);
            this.label10.TabIndex = 110;
            this.label10.Text = "Принятие на работу";
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLogin.Location = new System.Drawing.Point(479, 388);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(15, 19);
            this.lblErrorLogin.TabIndex = 115;
            this.lblErrorLogin.Text = "*";
            this.lblErrorLogin.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label6.Location = new System.Drawing.Point(29, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 114;
            this.label6.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtLogin.Location = new System.Drawing.Point(228, 385);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(244, 31);
            this.txtLogin.TabIndex = 6;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(479, 432);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(15, 19);
            this.lblErrorPassword.TabIndex = 118;
            this.lblErrorPassword.Text = "*";
            this.lblErrorPassword.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label8.Location = new System.Drawing.Point(29, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 117;
            this.label8.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtPassword.Location = new System.Drawing.Point(228, 429);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(244, 31);
            this.txtPassword.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(537, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 428);
            this.panel1.TabIndex = 119;
            // 
            // lstCashiers
            // 
            this.lstCashiers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstCashiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstCashiers.FormattingEnabled = true;
            this.lstCashiers.HorizontalScrollbar = true;
            this.lstCashiers.ItemHeight = 18;
            this.lstCashiers.Location = new System.Drawing.Point(575, 212);
            this.lstCashiers.Name = "lstCashiers";
            this.lstCashiers.Size = new System.Drawing.Size(436, 130);
            this.lstCashiers.TabIndex = 120;
            // 
            // lstWarehouseWorkers
            // 
            this.lstWarehouseWorkers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstWarehouseWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstWarehouseWorkers.FormattingEnabled = true;
            this.lstWarehouseWorkers.HorizontalScrollbar = true;
            this.lstWarehouseWorkers.ItemHeight = 18;
            this.lstWarehouseWorkers.Location = new System.Drawing.Point(574, 434);
            this.lstWarehouseWorkers.Name = "lstWarehouseWorkers";
            this.lstWarehouseWorkers.Size = new System.Drawing.Size(436, 130);
            this.lstWarehouseWorkers.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.25F);
            this.label1.Location = new System.Drawing.Point(631, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 30);
            this.label1.TabIndex = 122;
            this.label1.Text = "Удаление из базы сотрудников";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label7.Location = new System.Drawing.Point(762, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 123;
            this.label7.Text = "Кассиры";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label9.Location = new System.Drawing.Point(731, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 24);
            this.label9.TabIndex = 124;
            this.label9.Text = "Работники склада";
            // 
            // btnDeleteCashiers
            // 
            this.btnDeleteCashiers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteCashiers.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCashiers.Location = new System.Drawing.Point(696, 356);
            this.btnDeleteCashiers.Name = "btnDeleteCashiers";
            this.btnDeleteCashiers.Size = new System.Drawing.Size(212, 44);
            this.btnDeleteCashiers.TabIndex = 125;
            this.btnDeleteCashiers.Text = "Удалить кассира";
            this.btnDeleteCashiers.UseVisualStyleBackColor = true;
            this.btnDeleteCashiers.Click += new System.EventHandler(this.btnDeleteCashiers_Click);
            // 
            // btnDeleteWareWorkers
            // 
            this.btnDeleteWareWorkers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteWareWorkers.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteWareWorkers.Location = new System.Drawing.Point(696, 578);
            this.btnDeleteWareWorkers.Name = "btnDeleteWareWorkers";
            this.btnDeleteWareWorkers.Size = new System.Drawing.Size(212, 44);
            this.btnDeleteWareWorkers.TabIndex = 126;
            this.btnDeleteWareWorkers.Text = "Удалить работника склада";
            this.btnDeleteWareWorkers.UseVisualStyleBackColor = true;
            this.btnDeleteWareWorkers.Click += new System.EventHandler(this.btnDeleteWareWorkers_Click);
            // 
            // AdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 662);
            this.Controls.Add(this.btnDeleteWareWorkers);
            this.Controls.Add(this.btnDeleteCashiers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWarehouseWorkers);
            this.Controls.Add(this.lstCashiers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.dateTimeDateBeginWork);
            this.Controls.Add(this.lblErrorDataBeginWork);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblErrorPatronymic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPatronymic);
            this.Controls.Add(this.rdWarehouseWorker);
            this.Controls.Add(this.rdCashier);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblErrorSurname);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Name = "AdminsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminsForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblErrorSurname;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdWarehouseWorker;
        private System.Windows.Forms.RadioButton rdCashier;
        private System.Windows.Forms.Label lblErrorPatronymic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.DateTimePicker dateTimeDateBeginWork;
        private System.Windows.Forms.Label lblErrorDataBeginWork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblErrorLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstCashiers;
        private System.Windows.Forms.ListBox lstWarehouseWorkers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteCashiers;
        private System.Windows.Forms.Button btnDeleteWareWorkers;
    }
}