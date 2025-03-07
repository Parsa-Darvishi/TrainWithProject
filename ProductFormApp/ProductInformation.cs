using TrainWith.Businesses;
using TrainWith.Entity;

namespace ProductFormApp
{
    public partial class ProductInformation : Form
    {
        ProductBusiness productBusiness = null;
        public ProductInformation()
        {
            InitializeComponent();
            productBusiness = new ProductBusiness();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            Product item = new Product()
            {
                Name = nameTextBox.Text,
                Id = int.Parse(IdTextBox.Text),
                Price = decimal.Parse(priceTextBox.Text),
            };
            productBusiness.Add(item: item);
            Test(y: 2,z: 4);
        }


        public void Test(int y,int z)
        {
            int x = y;
        }
    }
}
