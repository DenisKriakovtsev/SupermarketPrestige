using System;
using System.Collections;
using System.Windows.Forms;

namespace PrestigeClient_WinForms
{
    public partial class DeleteProductFromDB : Form
    {
        public DeleteProductFromDB()
        {
            InitializeComponent();
        }

        private void DeleteProductFromDB_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDeleteProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDeleteProduct.Columns.Add("idProduct", "Id");
                dataGridViewDeleteProduct.Columns.Add("nameProduct", "Название");
                dataGridViewDeleteProduct.Columns.Add("codeProduct", "Код продукта");
                dataGridViewDeleteProduct.Columns.Add("priceProduct", "Цена");
                dataGridViewDeleteProduct.Columns.Add("manufacturedProduct", "Производитель");
                dataGridViewDeleteProduct.Columns.Add("compositionProduct", "Состояние");

                foreach (var item in Program.servicesClient.ShowAllProduct())
                {
                    ArrayList row = new ArrayList();
                    row.Add(item.id);
                    row.Add(item.NameProduct);
                    row.Add(item.CodeProduct);
                    row.Add(item.Price);

                    foreach (var manufacturers in Program.servicesClient.GetManufacturers())
                    {
                        if (item.Id_Manufacturer == manufacturers.id)
                        {
                            row.Add(manufacturers.Manufactured);
                        }
                    }
                    row.Add(item.Composition);
                    dataGridViewDeleteProduct.Rows.Add(row.ToArray());
                }
                dataGridViewDeleteProduct.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                object idProduct = dataGridViewDeleteProduct.SelectedRows[0].Cells[0].Value;
                if (idProduct != null)
                {
                    MessageBox.Show(Program.servicesClient.DeleteProduct((int)idProduct));
                    dataGridViewDeleteProduct.Rows.Clear();
                    dataGridViewDeleteProduct.Columns.Clear();
                    DeleteProductFromDB_Load(new object(), new EventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
