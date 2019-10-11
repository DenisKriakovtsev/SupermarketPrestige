using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    public partial class Order : Form
    {        
        public Order()
        {
            InitializeComponent();
            rdCash.Enabled = true;
            txtNumberCard.Enabled = false;
        }
        private void Order_Load(object sender, EventArgs e)
        {
            lblSumm.Text = "Итого к оплате: " + SummRowGrid() + " грн";
            dataGridViewCart.Columns[0].Visible = false; //скрываем колонки
            btnShowCheck.Enabled = false;
        }
        private double SummRowGrid()
        {
            double summ = 0;
            for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
            {
                // ?? "0" - проверяем если вещественное число то добавляем Replace()
                //cell[2] - Так как первая колонка id скрыта
                summ += Convert.ToDouble((dataGridViewCart.Rows[i].Cells[2].Value ?? "0").ToString().Replace('.', ','));
            }
            return summ;
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            #region Visible Error
            if (txtSurname.Text == "")
            {
                lblSurname.Visible = true;
            }
            else
            {
                lblSurname.Visible = false;
            }
            if (txtName.Text == "")
            {
                lblName.Visible = true;
            }
            else
            {
                lblName.Visible = false;
            }
            if (txtPatronimyc.Text == "")
            {
                lblPatronimyc.Visible = true;
            }
            else
            {
                lblPatronimyc.Visible = false;
            }
            if (rdCards.Checked == false && rdCash.Checked == false)
            {
                lblPayment.Visible = true;
            }
            else
            {
                lblPayment.Visible = false;
            }
            #endregion
            try
            {
                if (txtName.Text != "" && txtSurname.Text != "" && txtPatronimyc.Text != "" &&
                    (rdCards.Checked && txtNumberCard.Text != "" || rdCash.Checked))
                {
                    lblInfo.Visible = false;

                    Program.servicesClient.AddClients(
                        new PrestigeServiceReference.Clients
                        {
                            FIO = txtSurname.Text + " " + txtName.Text + " " + txtPatronimyc.Text,
                            NumberCard = rdCards.Checked ? Convert.ToInt32(txtNumberCard.Text) : Convert.ToInt32(null),
                            Cash = rdCash.Checked ? true : false
                        });

                    for (int i = 0; i < dataGridViewCart.Rows.Count - 1; i++)
                    {
                        Program.servicesClient.AddToChecks(new PrestigeServiceReference.Checks
                        {
                            id_cashier = Program.Id_Cashier,
                            id_product = Convert.ToInt32(dataGridViewCart.Rows[i].Cells[0].Value),
                            DatePurchase = DateTime.Now.Date,
                            TotalSumm = Convert.ToDecimal(SummRowGrid()),
                            Info = "Куплено!",
                            Quantity = dataGridViewCart.Rows.Count - 1
                        });
                    }

                    MessageBox.Show("Куплено!");
                    btnShowCheck.Enabled = true;
                }
                else
                {
                    btnShowCheck.Enabled = true;
                    lblInfo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowCheck_Click(object sender, EventArgs e)
        {
            string last_client_Fio = (from p in Program.servicesClient.GetClients() select p.FIO).ToList().Last();
            CheckForm checks = new CheckForm();

            for (int i = 0; i < dataGridViewCart.Rows.Count - 1; i++)
            {
                checks.lstProd.Items.Add(dataGridViewCart.Rows[i].Cells[1].Value);
                checks.lblPurchaces.Text = $"\nПродавец: {Program.Name_Cashier + " " + Program.Surname_Cashier}\n" +
              $"Покупатель: {last_client_Fio}\n" +
              $"Когда: {DateTime.Now.Date}\n" +
              $"Итого к оплате: {SummRowGrid()} грн";

            }
            checks.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            txtNumberCard.Enabled = false;
        }
        private void rdCards_CheckedChanged(object sender, EventArgs e)
        {
            txtNumberCard.Enabled = true;
        }
    }
}
