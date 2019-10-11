namespace PrestigeClient_WinForms
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCart = new System.Windows.Forms.Panel();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.lblSumm = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPatronimyc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowCheck = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtNumberCard = new System.Windows.Forms.TextBox();
            this.rdCards = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatronimyc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(589, 33);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(219, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваша корзина";
            // 
            // panelCart
            // 
            this.panelCart.Controls.Add(this.dataGridViewCart);
            this.panelCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCart.Location = new System.Drawing.Point(0, 33);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(589, 189);
            this.panelCart.TabIndex = 1;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCart.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(589, 189);
            this.dataGridViewCart.TabIndex = 0;
            // 
            // lblSumm
            // 
            this.lblSumm.AutoSize = true;
            this.lblSumm.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSumm.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.lblSumm.Location = new System.Drawing.Point(589, 0);
            this.lblSumm.Name = "lblSumm";
            this.lblSumm.Size = new System.Drawing.Size(0, 29);
            this.lblSumm.TabIndex = 17;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.Controls.Add(this.lblInfo);
            this.panelMain.Controls.Add(this.lblPayment);
            this.panelMain.Controls.Add(this.lblPatronimyc);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.lblSurname);
            this.panelMain.Controls.Add(this.lblSumm);
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Controls.Add(this.btnShowCheck);
            this.panelMain.Controls.Add(this.btnBuy);
            this.panelMain.Controls.Add(this.txtNumberCard);
            this.panelMain.Controls.Add(this.rdCards);
            this.panelMain.Controls.Add(this.rdCash);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.txtPatronimyc);
            this.panelMain.Controls.Add(this.txtName);
            this.panelMain.Controls.Add(this.txtSurname);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 222);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(589, 423);
            this.panelMain.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(433, 316);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(130, 30);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "* - Поля обязательные\r\n к заполнению";
            this.lblInfo.Visible = false;
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(377, 251);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(15, 19);
            this.lblPayment.TabIndex = 21;
            this.lblPayment.Text = "*";
            this.lblPayment.Visible = false;
            // 
            // lblPatronimyc
            // 
            this.lblPatronimyc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatronimyc.AutoSize = true;
            this.lblPatronimyc.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblPatronimyc.ForeColor = System.Drawing.Color.Red;
            this.lblPatronimyc.Location = new System.Drawing.Point(377, 196);
            this.lblPatronimyc.Name = "lblPatronimyc";
            this.lblPatronimyc.Size = new System.Drawing.Size(15, 19);
            this.lblPatronimyc.TabIndex = 20;
            this.lblPatronimyc.Text = "*";
            this.lblPatronimyc.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(377, 156);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(15, 19);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "*";
            this.lblName.Visible = false;
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblSurname.ForeColor = System.Drawing.Color.Red;
            this.lblSurname.Location = new System.Drawing.Point(377, 116);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(15, 19);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "*";
            this.lblSurname.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(436, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 53);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Выйти в главное меню";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowCheck
            // 
            this.btnShowCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowCheck.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCheck.Location = new System.Drawing.Point(436, 124);
            this.btnShowCheck.Name = "btnShowCheck";
            this.btnShowCheck.Size = new System.Drawing.Size(128, 50);
            this.btnShowCheck.TabIndex = 15;
            this.btnShowCheck.Text = "Посмотреть чек";
            this.btnShowCheck.UseVisualStyleBackColor = true;
            this.btnShowCheck.Click += new System.EventHandler(this.btnShowCheck_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuy.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(208, 335);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(138, 44);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "Купить!";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtNumberCard
            // 
            this.txtNumberCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNumberCard.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtNumberCard.Location = new System.Drawing.Point(189, 287);
            this.txtNumberCard.Name = "txtNumberCard";
            this.txtNumberCard.Size = new System.Drawing.Size(182, 31);
            this.txtNumberCard.TabIndex = 13;
            // 
            // rdCards
            // 
            this.rdCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdCards.AutoSize = true;
            this.rdCards.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdCards.Location = new System.Drawing.Point(298, 250);
            this.rdCards.Name = "rdCards";
            this.rdCards.Size = new System.Drawing.Size(70, 22);
            this.rdCards.TabIndex = 12;
            this.rdCards.TabStop = true;
            this.rdCards.Text = "Картой";
            this.rdCards.UseVisualStyleBackColor = true;
            this.rdCards.CheckedChanged += new System.EventHandler(this.rdCards_CheckedChanged);
            // 
            // rdCash
            // 
            this.rdCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdCash.AutoSize = true;
            this.rdCash.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdCash.Location = new System.Drawing.Point(189, 250);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(101, 22);
            this.rdCash.TabIndex = 11;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Наличными";
            this.rdCash.UseVisualStyleBackColor = true;
            this.rdCash.CheckedChanged += new System.EventHandler(this.rdCash_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label6.Location = new System.Drawing.Point(35, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Способ оплаты";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label5.Location = new System.Drawing.Point(35, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(35, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // txtPatronimyc
            // 
            this.txtPatronimyc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatronimyc.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtPatronimyc.Location = new System.Drawing.Point(189, 196);
            this.txtPatronimyc.Name = "txtPatronimyc";
            this.txtPatronimyc.Size = new System.Drawing.Size(182, 31);
            this.txtPatronimyc.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtName.Location = new System.Drawing.Point(189, 156);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 31);
            this.txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtSurname.Location = new System.Drawing.Point(189, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 31);
            this.txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.label2.Location = new System.Drawing.Point(127, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Заполните данные";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 645);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowCheck;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtNumberCard;
        private System.Windows.Forms.RadioButton rdCards;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatronimyc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewCart;
        public System.Windows.Forms.Label lblSumm;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPatronimyc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
    }
}