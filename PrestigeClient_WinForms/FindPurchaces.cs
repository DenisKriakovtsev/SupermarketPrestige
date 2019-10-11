using System;
using System.Collections;
using System.Data; 
using System.Linq; 
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    public partial class FindPurchaces : Form
    { 
        public FindPurchaces()
        {
            InitializeComponent();
        }

        private void FindPurchaces_Load(object sender, EventArgs e)
        {
            dataGridViewSearchPurchaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSearchPurchaces.Columns.Add("nameProduct", "Название");
            dataGridViewSearchPurchaces.Columns.Add("totalSumm", "Сумма(Общая)");
            dataGridViewSearchPurchaces.Columns.Add("fioClient", "ФИО Покупателя");
            dataGridViewSearchPurchaces.Columns.Add("fioCashier", "ФИО Продавца");
            dataGridViewSearchPurchaces.Columns.Add("fioManufactured", "Производитель");
            dataGridViewSearchPurchaces.Columns.Add("fioQuantity", "Общее кол-во купленых товаров");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewSearchPurchaces.Rows.Clear();
                lblNotFind.Visible = true;
               
                foreach (var item in Program.servicesClient.GetChecks().Where
                    (p => p.DatePurchase == dateTimeDateBeginWork.Value.Date))
                {
                    foreach (var manufacturers in Program.servicesClient.GetManufacturers())
                    {
                        if (Program.servicesClient.ShowAllProduct().Any(p => p.Id_Manufacturer == manufacturers.id && p.id == item.id_product))
                        {
                            lblNotFind.Visible = false;
                            ArrayList row = new ArrayList();
                            row.Add(item.Products.NameProduct);
                            row.Add(item.TotalSumm);
                            row.Add(item.Clients.FIO);
                            row.Add(item.Cashiers.Surname + " " + item.Cashiers.Name + " " + item.Cashiers.Patronymic);
                            row.Add(manufacturers.Manufactured);
                            row.Add(item.Quantity);
                            dataGridViewSearchPurchaces.Rows.Add(row.ToArray());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
