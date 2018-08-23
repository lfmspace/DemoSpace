using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class ProductView : Form,IProductView
    {
        private IProductPresenter presenter = null;
        public ProductView()
        {
            InitializeComponent();
        }

        public void ShowName(string name)
        {
            this.tb_Name.Text=name;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            presenter = new ProductPresenter(this);
            presenter.ShowProductName();
        }
    }
}
