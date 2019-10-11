using System;
using System.Windows.Forms;
using System.Collections;
namespace PrestigeClient_WinForms
{
    public partial class Main : Form
    {
        Order order = new Order();
        Autorization autorization = new Autorization(); 
        public Main()
        {
            InitializeComponent();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                var idProduct = dataGridViewAllProduct.SelectedRows[0].Cells[0].Value;
                var nameProduct = dataGridViewAllProduct.SelectedRows[0].Cells[1].Value;
                var priceProduct = dataGridViewAllProduct.SelectedRows[0].Cells[3].Value;
                lstCart.Items.Add(nameProduct + ",\tЦена - " + priceProduct.ToString() + " (грн)" +
                    "\t[ID=" + idProduct + "]");
                if (lstCart.Items.Count != 0)
                {
                    btnDelivery.Enabled = true;
                    btnDelCart.Enabled = true;
                    AddElementToGridOrder();
                }
            }
            catch { }
        }
        void AddElementToGridOrder()
        {
            ArrayList row = new ArrayList();
            // ID
            row.Add(lstCart.Items[lstCart.Items.Count - 1].ToString().Substring
                (lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf('=') + 1,
                lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf(']') -
                lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf('=') - 1));
            //Name
            row.Add(lstCart.Items[lstCart.Items.Count - 1].ToString().Substring
                (0, lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf(',')));
            //Price
            row.Add(lstCart.Items[lstCart.Items.Count - 1].ToString().Substring
               (lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf('-') + 2,
               lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf('(') -
               lstCart.Items[lstCart.Items.Count - 1].ToString().IndexOf('-') - 2
               ).TrimEnd(' '));

            order.dataGridViewCart.Rows.Add(row.ToArray());
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для того что бы добавить товар в Корзину, необходимо выделить нужную строку и кликнуть на кнопку 'Добавить в корзину'");                      
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        private void btnDelivery_Click(object sender, EventArgs e)
        {
            order.ShowDialog();
        }
        private void btnDelCart_Click(object sender, EventArgs e)
        { 
            order.dataGridViewCart.Rows.RemoveAt(lstCart.SelectedIndex);
            lstCart.Items.Remove(lstCart.SelectedItem);

            if (lstCart.Items.Count == 0)
            {
                btnDelivery.Enabled = false;
                btnDelCart.Enabled = false;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization autor = new Autorization();
            autor.ShowDialog();
        }         
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                InitilizationDataGrid(); // заполняем грид продуктами
                timer.Start(); // запускаем таймер с текущим временем
                //datagridview - order  
                order.dataGridViewCart.Columns.Add("idProduct", "Id");
                order.dataGridViewCart.Columns.Add("nameProduct", "Name");
                order.dataGridViewCart.Columns.Add("priceProduct", "Price");
                btnDelCart.Enabled = false;
                btnDelivery.Enabled = false;
                lblCashier.Text = $"Кассир: {Program.Surname_Cashier} {Program.Name_Cashier} {Program.Patronymic_Cashier}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InitilizationDataGrid()
        {
            dataGridViewAllProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewAllProduct.Columns.Add("idProduct", "Id");
            dataGridViewAllProduct.Columns.Add("nameProduct", "Название");
            dataGridViewAllProduct.Columns.Add("codeProduct", "Код продукта");
            dataGridViewAllProduct.Columns.Add("priceProduct", "Цена");
            dataGridViewAllProduct.Columns.Add("categoriesProduct", "Категория");
            dataGridViewAllProduct.Columns.Add("manufacturedProduct", "Производитель");
            dataGridViewAllProduct.Columns.Add("dateManuf", "Дата производства");
            dataGridViewAllProduct.Columns.Add("bestBefore", "Употребить до");
            dataGridViewAllProduct.Columns.Add("compositionProduct", "Состояние");

            foreach (var item in Program.servicesClient.ShowAllProduct())
            {
                ArrayList row = new ArrayList();
                row.Add(item.id);
                row.Add(item.NameProduct);
                row.Add(item.CodeProduct);
                row.Add(item.Price);
                foreach (var categories in Program.servicesClient.GetCategories())
                {
                    foreach (var manufacturers in Program.servicesClient.GetManufacturers())
                    {
                        if (item.Id_Categories == categories.id && item.Id_Manufacturer == manufacturers.id)
                        { 
                            row.Add(categories.Category);
                            row.Add(manufacturers.Manufactured);
                        }
                    }
                }
                row.Add(item.DateOfManufacture);
                row.Add(item.BestBefore);
                row.Add(item.Composition);
                dataGridViewAllProduct.Rows.Add(row.ToArray());
            }
            dataGridViewAllProduct.Columns[0].Visible = false; //скрываем колонки
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            FindPurchaces findP = new FindPurchaces();
            findP.ShowDialog();
        }
    }
}