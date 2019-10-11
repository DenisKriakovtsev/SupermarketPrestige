using System;
using System.Linq;
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    public partial class Autorization : Form
    {     
        public Autorization()
        {
            InitializeComponent();
            rdWarehouseWorker.Enabled = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            #region Error Visible
            if (txtLogin.Text == "")
            {
                lblLogin.Visible = true;
            }
            else
            {
                lblLogin.Visible = false;
            }
            if (txtPassword.Text == "")
            {
                lblPassword.Visible = true;
            }
            else
            {
                lblPassword.Visible = false;
            }
            #endregion
            try
            {
                if (txtLogin.Text != "" && txtPassword.Text != "")
                {
                    // Кассир авторизация
                    if (rdCashier.Checked && Program.servicesClient.Autorizations(txtLogin.Text, txtPassword.Text, "cashier"))
                    {
                        int id_cashiers = Program.servicesClient.GetPosts().FirstOrDefault(p => p.Login == txtLogin.Text &&
                     p.Password == txtPassword.Text && p.TypePost == "cashier").id;

                        Program.Id_Cashier = Program.servicesClient.GetCashiers().FirstOrDefault
                            (p => p.id_post == id_cashiers).id;
                        Program.Name_Cashier = Program.servicesClient.GetCashiers().FirstOrDefault
                            (p => p.id_post == id_cashiers).Name;
                        Program.Patronymic_Cashier = Program.servicesClient.GetCashiers().FirstOrDefault
                            (p => p.id_post == id_cashiers).Patronymic;
                        Program.Surname_Cashier = Program.servicesClient.GetCashiers().FirstOrDefault
                            (p => p.id_post == id_cashiers).Surname;

                        DialogResult = DialogResult.OK;
                        lblError.Visible = false;

                        this.Hide();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                    else
                    {
                        lblError.Visible = true;
                    }
                    // Работник склада авторизация
                    if (rdWarehouseWorker.Checked && Program.servicesClient.Autorizations(txtLogin.Text, txtPassword.Text, "warehouse worker"))
                    {
                        int id_warwork = Program.servicesClient.GetPosts().FirstOrDefault(p => p.Login == txtLogin.Text &&
                        p.Password == txtPassword.Text && p.TypePost == "warehouse worker").id;

                        Program.Id_WareWork = Program.servicesClient.GetWarehouseWorkers().FirstOrDefault
                            (p => p.id_post == id_warwork).id;
                        Program.Name_WareWork = Program.servicesClient.GetWarehouseWorkers().FirstOrDefault
                            (p => p.id_post == id_warwork).Name;
                        Program.Patronymic_WareWork = Program.servicesClient.GetWarehouseWorkers().FirstOrDefault
                            (p => p.id_post == id_warwork).Patronymic;
                        Program.Surname_WareWork = Program.servicesClient.GetWarehouseWorkers().FirstOrDefault
                            (p => p.id_post == id_warwork).Surname;
                        Program.DateBeginWork_WareWork = Program.servicesClient.GetWarehouseWorkers().FirstOrDefault
                            (p => p.id_post == id_warwork).DateBeginWork;

                        DialogResult = DialogResult.OK;
                        lblError.Visible = false;

                        this.Hide();
                        WarehouseWorker warework = new WarehouseWorker();
                        warework.ShowDialog();
                    }
                    else
                    {
                        lblError.Visible = true;
                    }
                    // Администратор авторизация
                    if (rbAdmin.Checked && Program.servicesClient.Autorizations(txtLogin.Text, txtPassword.Text, "admin"))
                    {
                        int id_admin = Program.servicesClient.GetPosts().FirstOrDefault(p => p.Login == txtLogin.Text &&
                         p.Password == txtPassword.Text && p.TypePost == "admin").id;

                        Program.Id_Admin = Program.servicesClient.GetAdmins().FirstOrDefault
                           (p => p.id_post == id_admin).id;
                        Program.Name_Admin = Program.servicesClient.GetAdmins().FirstOrDefault
                            (p => p.id_post == id_admin).Name;
                        Program.Surname_Admin = Program.servicesClient.GetAdmins().FirstOrDefault
                            (p => p.id_post == id_admin).Surname;

                        DialogResult = DialogResult.OK;
                        lblError.Visible = false;
                        this.Hide();
                        AdminsForm adminss = new AdminsForm();
                        adminss.ShowDialog();
                    }
                    else
                    {
                        lblError.Visible = true;
                    }
                    lblInfo.Visible = false;
                }          
                else
                {
                    lblError.Visible = true;
                    lblInfo.Visible = true;
                }
            }
            catch
            {
                lblError.Visible = true;
            }
        }
    }
}
