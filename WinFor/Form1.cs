using Business.Abstract;
using Business.Concrete.NewFolder;
using Business.DependencyReselvors;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            productService=(IProductService)InstanceFactory<IProductService>.GetManagerInstance();
        }
        IProductService productService;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = productService.GetAll();
        }


    }
}
