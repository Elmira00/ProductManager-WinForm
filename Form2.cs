using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager_WinForm
{
    public partial class Form2 : Form
    {
        public EventHandler<EventArgs> Handler { get; set; }
        private List<Product> list;

        public List<Product> List
        {
            get { return list; }
            set { list = value; SetListBox(value); }
        }
        private Product data;

        public Product Data
        {
            get { return data; }
            set { data = value; }
        }

        private void SetListBox(List<Product> value)
        {
            productListbox.Items.Clear();
            foreach (var item in value)
            {
                productListbox.Items.Add(item.ToString());
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void productListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = (productListbox.SelectedItem as string).Split('-');
            string name = list[0];
            string description = list[1];
            double price = Convert.ToDouble(list[2]);
            Product product = new Product(name,description,price);
            Data = product;
            Handler.Invoke(sender, e);
        }
    }
}
