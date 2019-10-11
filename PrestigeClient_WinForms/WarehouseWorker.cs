using System; 
using System.Windows.Forms;


namespace PrestigeClient_WinForms
{
    public partial class WarehouseWorker : Form
    { 
        public WarehouseWorker()
        {
            InitializeComponent();
        }

        private void WarehouseWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameProd.Text != "" && txtCodeProd.Text != "" && cmbCategories.Text != "" &&
                    txtPrice.Text != "" && cmbManufacturers.Text != "" && txtCompositions.Text != "" &&
                    dateTimeDataManufact.Text != "" && dateTimeBestBefore.Text != "")
                {
                    MessageBox.Show(
                        Program.servicesClient.AddProducts(new PrestigeServiceReference.Products {
                        NameProduct = txtNameProd.Text,
                        CodeProduct = Convert.ToInt32(txtCodeProd.Text),
                        Price = Convert.ToDouble((txtPrice.Text).ToString().Replace('.', ',')),
                        Id_Categories = (int)(cmbCategories.SelectedItem as Label).Tag,
                        Id_Manufacturer = (int)(cmbManufacturers.SelectedItem as Label).Tag,
                        DateOfManufacture = dateTimeDataManufact.Value,
                        BestBefore = dateTimeBestBefore.Value,
                        Composition = txtCompositions.Text
                    }));                     
                    VisibleLabelError(false);
                }
                else
                {
                    VisibleLabelError(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VisibleLabelError(bool flag)
        {
            lblErrorBestBefore.Visible = flag;
            lblErrorCategories.Visible = flag;
            lblErrorCode.Visible = flag;
            lblErrorCompositions.Visible = flag;
            lblErrorDataMan.Visible = flag;
            lblErrorManufacture.Visible = flag;
            lblErrorName.Visible = flag;
            lblErrorPrice.Visible = flag;
            lblInfo.Visible = flag;
        }

        private void WarehouseWorker_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCategories.DisplayMember = "Text"; 
                cmbManufacturers.DisplayMember = "Text";
                cmbCategories.SelectedItem = -1;
                cmbManufacturers.SelectedItem = -1;

                lblWareWork.Text = $"Кладовщик: {Program.Surname_WareWork} {Program.Name_WareWork} {Program.Patronymic_WareWork}";
               
                foreach (var categories in Program.servicesClient.GetCategories())
                {
                    Label label = new Label
                    {
                        Tag = categories.id,
                        Text = categories.Category
                    }; 
                    cmbCategories.Items.Add(label);
                }
                foreach (var manufacrurers in Program.servicesClient.GetManufacturers())
                {
                    Label label = new Label
                    {
                        Tag = manufacrurers.id,
                        Text = manufacrurers.Manufactured
                    };
                    cmbManufacturers.Items.Add(label);
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProductFromDB deleteProductFromDB = new DeleteProductFromDB();
            deleteProductFromDB.ShowDialog();
        }
    }
}
