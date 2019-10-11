namespace PrestigeClient_WinForms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblCashier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelAllProduct = new System.Windows.Forms.Panel();
            this.dataGridViewAllProduct = new System.Windows.Forms.DataGridView();
            this.panelWishList = new System.Windows.Forms.Panel();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnDelCart = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelAllProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProduct)).BeginInit();
            this.panelWishList.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblCashier);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(869, 36);
            this.panelHeader.TabIndex = 0;
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.lblCashier.Location = new System.Drawing.Point(10, 9);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(0, 19);
            this.lblCashier.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(373, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все товары";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 9.25F);
            this.lblDate.Location = new System.Drawing.Point(690, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 18);
            this.lblDate.TabIndex = 1;
            // 
            // panelAllProduct
            // 
            this.panelAllProduct.Controls.Add(this.dataGridViewAllProduct);
            this.panelAllProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAllProduct.Location = new System.Drawing.Point(0, 36);
            this.panelAllProduct.Name = "panelAllProduct";
            this.panelAllProduct.Size = new System.Drawing.Size(869, 288);
            this.panelAllProduct.TabIndex = 1;
            // 
            // dataGridViewAllProduct
            // 
            this.dataGridViewAllProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAllProduct.Name = "dataGridViewAllProduct";
            this.dataGridViewAllProduct.ReadOnly = true;
            this.dataGridViewAllProduct.Size = new System.Drawing.Size(869, 288);
            this.dataGridViewAllProduct.TabIndex = 0;
            // 
            // panelWishList
            // 
            this.panelWishList.Controls.Add(this.lstCart);
            this.panelWishList.Controls.Add(this.label2);
            this.panelWishList.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWishList.Location = new System.Drawing.Point(0, 324);
            this.panelWishList.Name = "panelWishList";
            this.panelWishList.Size = new System.Drawing.Size(459, 316);
            this.panelWishList.TabIndex = 2;
            // 
            // lstCart
            // 
            this.lstCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstCart.Font = new System.Drawing.Font("Comic Sans MS", 12.25F);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 23;
            this.lstCart.Location = new System.Drawing.Point(3, 42);
            this.lstCart.Name = "lstCart";
            this.lstCart.ScrollAlwaysVisible = true;
            this.lstCart.Size = new System.Drawing.Size(453, 257);
            this.lstCart.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(177, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Корзина";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.BackColor = System.Drawing.Color.White;
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.btnAddToCart.Location = new System.Drawing.Point(35, 43);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(162, 43);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Добавить в корзину";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelivery.BackColor = System.Drawing.Color.White;
            this.btnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelivery.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.btnDelivery.Location = new System.Drawing.Point(35, 109);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(162, 43);
            this.btnDelivery.TabIndex = 4;
            this.btnDelivery.Text = "Оформить заказ";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.btnExit.Location = new System.Drawing.Point(129, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(162, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelp.BackColor = System.Drawing.Color.White;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.btnHelp.Location = new System.Drawing.Point(220, 178);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(162, 43);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnFind);
            this.panelButton.Controls.Add(this.btnRestart);
            this.panelButton.Controls.Add(this.btnDelCart);
            this.panelButton.Controls.Add(this.btnHelp);
            this.panelButton.Controls.Add(this.btnExit);
            this.panelButton.Controls.Add(this.btnAddToCart);
            this.panelButton.Controls.Add(this.btnDelivery);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButton.Location = new System.Drawing.Point(465, 324);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(404, 316);
            this.panelButton.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(220, 109);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(162, 43);
            this.btnFind.TabIndex = 62;
            this.btnFind.Text = "Искать продажи";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.BackColor = System.Drawing.Color.White;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.btnRestart.Location = new System.Drawing.Point(35, 178);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(162, 43);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Перезайти";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnDelCart
            // 
            this.btnDelCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelCart.BackColor = System.Drawing.Color.White;
            this.btnDelCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelCart.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.btnDelCart.Location = new System.Drawing.Point(220, 43);
            this.btnDelCart.Name = "btnDelCart";
            this.btnDelCart.Size = new System.Drawing.Size(162, 43);
            this.btnDelCart.TabIndex = 7;
            this.btnDelCart.Text = "Удалить из корзины";
            this.btnDelCart.UseVisualStyleBackColor = false;
            this.btnDelCart.Click += new System.EventHandler(this.btnDelCart_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(869, 640);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelWishList);
            this.Controls.Add(this.panelAllProduct);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Супермаркет \"Престиж\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelAllProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllProduct)).EndInit();
            this.panelWishList.ResumeLayout(false);
            this.panelWishList.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelAllProduct;
        private System.Windows.Forms.Panel panelWishList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dataGridViewAllProduct;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Button btnDelCart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnFind;
    }
}

