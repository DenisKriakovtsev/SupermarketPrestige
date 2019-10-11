namespace PrestigeClient_WinForms
{
    partial class WarehouseWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseWorker));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblErrorCode = new System.Windows.Forms.Label();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodeProd = new System.Windows.Forms.TextBox();
            this.txtNameProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorCategories = new System.Windows.Forms.Label();
            this.lblErrorPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblErrorDataMan = new System.Windows.Forms.Label();
            this.lblErrorManufacture = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblErrorCompositions = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCompositions = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dateTimeDataManufact = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBestBefore = new System.Windows.Forms.DateTimePicker();
            this.lblErrorBestBefore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWareWork = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.cmbManufacturers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(35, 609);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 44);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(253, 567);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 15);
            this.lblInfo.TabIndex = 49;
            this.lblInfo.Text = "* - Поля обязательные к заполнению";
            this.lblInfo.Visible = false;
            // 
            // lblErrorCode
            // 
            this.lblErrorCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCode.AutoSize = true;
            this.lblErrorCode.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorCode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCode.Location = new System.Drawing.Point(467, 247);
            this.lblErrorCode.Name = "lblErrorCode";
            this.lblErrorCode.Size = new System.Drawing.Size(15, 19);
            this.lblErrorCode.TabIndex = 48;
            this.lblErrorCode.Text = "*";
            this.lblErrorCode.Visible = false;
            // 
            // lblErrorName
            // 
            this.lblErrorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorName.Location = new System.Drawing.Point(467, 207);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(15, 19);
            this.lblErrorName.TabIndex = 47;
            this.lblErrorName.Text = "*";
            this.lblErrorName.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label4.Location = new System.Drawing.Point(27, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Код товара";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label3.Location = new System.Drawing.Point(27, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Название";
            // 
            // txtCodeProd
            // 
            this.txtCodeProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodeProd.BackColor = System.Drawing.Color.White;
            this.txtCodeProd.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtCodeProd.Location = new System.Drawing.Point(217, 247);
            this.txtCodeProd.Name = "txtCodeProd";
            this.txtCodeProd.Size = new System.Drawing.Size(244, 31);
            this.txtCodeProd.TabIndex = 44;
            // 
            // txtNameProd
            // 
            this.txtNameProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameProd.BackColor = System.Drawing.Color.White;
            this.txtNameProd.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtNameProd.Location = new System.Drawing.Point(217, 207);
            this.txtNameProd.Name = "txtNameProd";
            this.txtNameProd.Size = new System.Drawing.Size(244, 31);
            this.txtNameProd.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.25F);
            this.label2.Location = new System.Drawing.Point(120, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 30);
            this.label2.TabIndex = 51;
            this.label2.Text = "Добавление товара в базу";
            // 
            // lblErrorCategories
            // 
            this.lblErrorCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCategories.AutoSize = true;
            this.lblErrorCategories.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorCategories.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCategories.Location = new System.Drawing.Point(467, 326);
            this.lblErrorCategories.Name = "lblErrorCategories";
            this.lblErrorCategories.Size = new System.Drawing.Size(15, 19);
            this.lblErrorCategories.TabIndex = 57;
            this.lblErrorCategories.Text = "*";
            this.lblErrorCategories.Visible = false;
            // 
            // lblErrorPrice
            // 
            this.lblErrorPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorPrice.AutoSize = true;
            this.lblErrorPrice.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrice.Location = new System.Drawing.Point(467, 286);
            this.lblErrorPrice.Name = "lblErrorPrice";
            this.lblErrorPrice.Size = new System.Drawing.Size(15, 19);
            this.lblErrorPrice.TabIndex = 56;
            this.lblErrorPrice.Text = "*";
            this.lblErrorPrice.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label6.Location = new System.Drawing.Point(27, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Категория";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label7.Location = new System.Drawing.Point(27, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 54;
            this.label7.Text = "Цена (грн)";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtPrice.Location = new System.Drawing.Point(217, 286);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(244, 31);
            this.txtPrice.TabIndex = 52;
            // 
            // lblErrorDataMan
            // 
            this.lblErrorDataMan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorDataMan.AutoSize = true;
            this.lblErrorDataMan.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorDataMan.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDataMan.Location = new System.Drawing.Point(467, 405);
            this.lblErrorDataMan.Name = "lblErrorDataMan";
            this.lblErrorDataMan.Size = new System.Drawing.Size(15, 19);
            this.lblErrorDataMan.TabIndex = 63;
            this.lblErrorDataMan.Text = "*";
            this.lblErrorDataMan.Visible = false;
            // 
            // lblErrorManufacture
            // 
            this.lblErrorManufacture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorManufacture.AutoSize = true;
            this.lblErrorManufacture.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorManufacture.ForeColor = System.Drawing.Color.Red;
            this.lblErrorManufacture.Location = new System.Drawing.Point(467, 366);
            this.lblErrorManufacture.Name = "lblErrorManufacture";
            this.lblErrorManufacture.Size = new System.Drawing.Size(15, 19);
            this.lblErrorManufacture.TabIndex = 62;
            this.lblErrorManufacture.Text = "*";
            this.lblErrorManufacture.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label10.Location = new System.Drawing.Point(27, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 24);
            this.label10.TabIndex = 61;
            this.label10.Text = "Дата изготовления";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label11.Location = new System.Drawing.Point(26, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 24);
            this.label11.TabIndex = 60;
            this.label11.Text = "Производитель";
            // 
            // lblErrorCompositions
            // 
            this.lblErrorCompositions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorCompositions.AutoSize = true;
            this.lblErrorCompositions.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorCompositions.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCompositions.Location = new System.Drawing.Point(467, 484);
            this.lblErrorCompositions.Name = "lblErrorCompositions";
            this.lblErrorCompositions.Size = new System.Drawing.Size(15, 19);
            this.lblErrorCompositions.TabIndex = 68;
            this.lblErrorCompositions.Text = "*";
            this.lblErrorCompositions.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label13.Location = new System.Drawing.Point(27, 490);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 24);
            this.label13.TabIndex = 67;
            this.label13.Text = "Состав";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label14.Location = new System.Drawing.Point(27, 451);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 66;
            this.label14.Text = "Употребить до";
            // 
            // txtCompositions
            // 
            this.txtCompositions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCompositions.BackColor = System.Drawing.Color.White;
            this.txtCompositions.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.txtCompositions.Location = new System.Drawing.Point(217, 487);
            this.txtCompositions.Multiline = true;
            this.txtCompositions.Name = "txtCompositions";
            this.txtCompositions.Size = new System.Drawing.Size(244, 77);
            this.txtCompositions.TabIndex = 65;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(349, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 44);
            this.btnExit.TabIndex = 69;
            this.btnExit.Text = "Перезайти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dateTimeDataManufact
            // 
            this.dateTimeDataManufact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeDataManufact.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.dateTimeDataManufact.Location = new System.Drawing.Point(217, 405);
            this.dateTimeDataManufact.Name = "dateTimeDataManufact";
            this.dateTimeDataManufact.Size = new System.Drawing.Size(244, 30);
            this.dateTimeDataManufact.TabIndex = 70;
            // 
            // dateTimeBestBefore
            // 
            this.dateTimeBestBefore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeBestBefore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeBestBefore.Location = new System.Drawing.Point(217, 446);
            this.dateTimeBestBefore.Name = "dateTimeBestBefore";
            this.dateTimeBestBefore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeBestBefore.Size = new System.Drawing.Size(244, 30);
            this.dateTimeBestBefore.TabIndex = 71;
            // 
            // lblErrorBestBefore
            // 
            this.lblErrorBestBefore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorBestBefore.AutoSize = true;
            this.lblErrorBestBefore.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblErrorBestBefore.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBestBefore.Location = new System.Drawing.Point(467, 446);
            this.lblErrorBestBefore.Name = "lblErrorBestBefore";
            this.lblErrorBestBefore.Size = new System.Drawing.Size(15, 19);
            this.lblErrorBestBefore.TabIndex = 72;
            this.lblErrorBestBefore.Text = "*";
            this.lblErrorBestBefore.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(27, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 110);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lblWareWork
            // 
            this.lblWareWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWareWork.AutoSize = true;
            this.lblWareWork.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.lblWareWork.Location = new System.Drawing.Point(59, 109);
            this.lblWareWork.Name = "lblWareWork";
            this.lblWareWork.Size = new System.Drawing.Size(0, 24);
            this.lblWareWork.TabIndex = 74;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(195, 609);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(138, 44);
            this.btnDeleteProduct.TabIndex = 75;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCategories.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(217, 326);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(244, 32);
            this.cmbCategories.TabIndex = 76;
            // 
            // cmbManufacturers
            // 
            this.cmbManufacturers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbManufacturers.DropDownWidth = 400;
            this.cmbManufacturers.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.cmbManufacturers.FormattingEnabled = true;
            this.cmbManufacturers.Location = new System.Drawing.Point(217, 366);
            this.cmbManufacturers.Name = "cmbManufacturers";
            this.cmbManufacturers.Size = new System.Drawing.Size(244, 32);
            this.cmbManufacturers.TabIndex = 77;
            // 
            // WarehouseWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 669);
            this.Controls.Add(this.cmbManufacturers);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.lblWareWork);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErrorBestBefore);
            this.Controls.Add(this.dateTimeBestBefore);
            this.Controls.Add(this.dateTimeDataManufact);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblErrorCompositions);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCompositions);
            this.Controls.Add(this.lblErrorDataMan);
            this.Controls.Add(this.lblErrorManufacture);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblErrorCategories);
            this.Controls.Add(this.lblErrorPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblErrorCode);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodeProd);
            this.Controls.Add(this.txtNameProd);
            this.Controls.Add(this.btnAdd);
            this.Name = "WarehouseWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseWorker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WarehouseWorker_FormClosing);
            this.Load += new System.EventHandler(this.WarehouseWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblErrorCode;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodeProd;
        private System.Windows.Forms.TextBox txtNameProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorCategories;
        private System.Windows.Forms.Label lblErrorPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblErrorDataMan;
        private System.Windows.Forms.Label lblErrorManufacture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblErrorCompositions;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCompositions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dateTimeDataManufact;
        private System.Windows.Forms.DateTimePicker dateTimeBestBefore;
        private System.Windows.Forms.Label lblErrorBestBefore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWareWork;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.ComboBox cmbManufacturers;
    }
}