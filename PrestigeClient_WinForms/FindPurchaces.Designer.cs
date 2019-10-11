namespace PrestigeClient_WinForms
{
    partial class FindPurchaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindPurchaces));
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeDateBeginWork = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridViewSearchPurchaces = new System.Windows.Forms.DataGridView();
            this.lblNotFind = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPurchaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.label8.Location = new System.Drawing.Point(298, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 29);
            this.label8.TabIndex = 126;
            this.label8.Text = "Поиск продаж по дате ";
            // 
            // dateTimeDateBeginWork
            // 
            this.dateTimeDateBeginWork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimeDateBeginWork.Font = new System.Drawing.Font("Comic Sans MS", 12.75F);
            this.dateTimeDateBeginWork.Location = new System.Drawing.Point(296, 161);
            this.dateTimeDateBeginWork.Name = "dateTimeDateBeginWork";
            this.dateTimeDateBeginWork.Size = new System.Drawing.Size(244, 31);
            this.dateTimeDateBeginWork.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.label10.Location = new System.Drawing.Point(119, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 24);
            this.label10.TabIndex = 124;
            this.label10.Text = "Выберите дату";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFind.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFind.Location = new System.Drawing.Point(590, 158);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(138, 36);
            this.btnFind.TabIndex = 121;
            this.btnFind.Text = "Найти";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dataGridViewSearchPurchaces);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 243);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(832, 364);
            this.panelMain.TabIndex = 127;
            // 
            // dataGridViewSearchPurchaces
            // 
            this.dataGridViewSearchPurchaces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSearchPurchaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchPurchaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchPurchaces.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearchPurchaces.Name = "dataGridViewSearchPurchaces";
            this.dataGridViewSearchPurchaces.Size = new System.Drawing.Size(832, 364);
            this.dataGridViewSearchPurchaces.TabIndex = 0;
            // 
            // lblNotFind
            // 
            this.lblNotFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNotFind.AutoSize = true;
            this.lblNotFind.Font = new System.Drawing.Font("Comic Sans MS", 13.25F);
            this.lblNotFind.Location = new System.Drawing.Point(258, 212);
            this.lblNotFind.Name = "lblNotFind";
            this.lblNotFind.Size = new System.Drawing.Size(338, 24);
            this.lblNotFind.TabIndex = 128;
            this.lblNotFind.Text = "По указанной дате ничего не найдено";
            this.lblNotFind.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(215, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 102);
            this.pictureBox1.TabIndex = 129;
            this.pictureBox1.TabStop = false;
            // 
            // FindPurchaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNotFind);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimeDateBeginWork);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnFind);
            this.MaximumSize = new System.Drawing.Size(848, 646);
            this.MinimumSize = new System.Drawing.Size(848, 646);
            this.Name = "FindPurchaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindPurchaces";
            this.Load += new System.EventHandler(this.FindPurchaces_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchPurchaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeDateBeginWork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridViewSearchPurchaces;
        private System.Windows.Forms.Label lblNotFind;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}