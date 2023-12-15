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
    public partial class Form1 : Form
    {
        public EventHandler<EventArgs> Handler;
    
        List<Product> productList = new List<Product>
            { };
        public Form1()
        {
            Product product1 = new Product("Keyboard", "Led,Mechanical Keyboard", 50.99);
          
            Product product2 = new Product("Mouse", "Gaming Mouse", 34.99);
            
            productList.Add(product1);
            productList.Add(product2);
            Handler = new EventHandler<EventArgs>(UpdateListEvent);
            form2.Handler = this.Handler;
            InitializeComponent();
        }
        string itemName = "";
        private void UpdateListEvent(object sender, EventArgs e)
        {
            nameTxtb.Text = form2.Data.Name;
            descriptionTxtb.Text = form2.Data.Description;
            priceTxtb.Text = form2.Data.Price.ToString();
            itemName = nameTxtb.Text;
            
        }

        Form2 form2 = new Form2();
        private void showListBtn_Click(object sender, EventArgs e)
        {
            form2.List = productList;
            form2.ShowDialog();
         
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var newProduct = new Product(nameTxtb.Text, descriptionTxtb.Text, Convert.ToDouble(priceTxtb.Text));
           
           
            //newProduct.Name = nameTxtb.Text;
            //newProduct.Description = descriptionTxtb.Text;
            //newProduct.Price = Convert.ToDouble(priceTxtb.Text);
            productList.Add(newProduct);
            nameTxtb.Text = "";
            descriptionTxtb.Text = "";
            priceTxtb.Text = "";
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var newProduct = new Product(nameTxtb.Text, descriptionTxtb.Text, Convert.ToDouble(priceTxtb.Text));
            List<Product> copyList = new List<Product>();
            productList.ForEach((item) =>
            {
                if (itemName != item.Name)
                {
                copyList.Add(item);
                }
            });

            productList.Clear();

            copyList.ForEach((item) =>
            {
                productList.Add(item);
            });
            productList.Add(newProduct);
          
        }
    }
}
