using System;
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    public partial class AdminsForm : Form
    { 
        public AdminsForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Autorization autor = new Autorization();
                autor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminsForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblAdmin.Text = $"Администратор: {Program.Surname_Admin} {Program.Name_Admin}";
                lstCashiers.DisplayMember = "Text";
                lstWarehouseWorkers.DisplayMember = "Text";
                lstCashiers.Items?.Clear();
                lstWarehouseWorkers.Items?.Clear();
                foreach (var cashiers in Program.servicesClient.GetCashiers())
                {

                    Label label = new Label
                    {
                        Tag = cashiers.id,
                        Text = cashiers.Surname + " " + cashiers.Name + " " + cashiers.Patronymic + " Принят(а) " + cashiers.DateBeginWork.ToShortDateString()
                    };
                    lstCashiers.Items.Add(label);
                }
                foreach (var warehouseWorkers in Program.servicesClient.GetWarehouseWorkers())
                {
                    Label label = new Label
                    {
                        Tag = warehouseWorkers.id,
                        Text = warehouseWorkers.Surname + " " + warehouseWorkers.Name + " " + warehouseWorkers.Patronymic + " Принят(а) " + warehouseWorkers.DateBeginWork.ToShortDateString()
                    };
                    lstWarehouseWorkers.Items.Add(label);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtPatronymic.Text != "" && txtSurname.Text != "" &&
                    dateTimeDateBeginWork.Text != "" && txtPassword.Text != "" && txtLogin.Text != "")
                {
                    if (rdCashier.Checked)
                    {
                        MessageBox.Show(Program.servicesClient.AddCashiers(new PrestigeServiceReference.Posts
                        {
                            Login = txtLogin.Text,
                            Password = txtPassword.Text,
                            TypePost = "cashier"
                        }, new PrestigeServiceReference.Cashiers
                        {
                            Name = txtName.Text,
                            Surname = txtSurname.Text,
                            Patronymic = txtPatronymic.Text,
                            DateBeginWork = dateTimeDateBeginWork.Value
                        }));
                        ClearTextBox();
                        AdminsForm_Load(new object(), new EventArgs());
                    }

                    if (rdWarehouseWorker.Checked)
                    {
                        MessageBox.Show(Program.servicesClient.AddWarehouseWorkers(new PrestigeServiceReference.Posts
                        {
                            Login = txtLogin.Text,
                            Password = txtPassword.Text,
                            TypePost = "warehouse worker"
                        }, new PrestigeServiceReference.WarehouseWorkers
                        {
                            Name = txtName.Text,
                            Surname = txtSurname.Text,
                            Patronymic = txtPatronymic.Text,
                            DateBeginWork = dateTimeDateBeginWork.Value
                        }));
                        ClearTextBox();
                        AdminsForm_Load(new object(), new EventArgs());
                    }
                    VisibleErrorLabel(false);
                }
                else
                {
                    VisibleErrorLabel(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void VisibleErrorLabel(bool flag)
        {
            lblErrorName.Visible = flag;
            lblErrorPatronymic.Visible = flag;
            lblErrorSurname.Visible = flag;
            lblInfo.Visible = flag;
            lblErrorDataBeginWork.Visible = flag;
            lblErrorLogin.Visible = flag;
            lblErrorPassword.Visible = flag;
        }

        private void ClearTextBox()
        {
            txtLogin.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            txtPatronymic.Text = "";
            txtSurname.Text = "";
            dateTimeDateBeginWork.Value = DateTime.Now.Date;
        }

        private void btnDeleteCashiers_Click(object sender, EventArgs e)
        {
            if (lstCashiers.SelectedItem != null)
            {
                MessageBox.Show(Program.servicesClient.DeleteCashiers((int)(lstCashiers.SelectedItem as Label).Tag));
                AdminsForm_Load(new object(), new EventArgs());
            }
        }

        private void btnDeleteWareWorkers_Click(object sender, EventArgs e)
        {
            if (lstWarehouseWorkers.SelectedItem != null)
            {
                MessageBox.Show(Program.servicesClient.DeleteWarehouseWork((int)(lstWarehouseWorkers.SelectedItem as Label).Tag));
                AdminsForm_Load(new object(), new EventArgs());
            }
        }
    }
}
