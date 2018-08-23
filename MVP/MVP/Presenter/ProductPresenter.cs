using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public class ProductPresenter : IProductPresenter
    {
        private IProductView view = null;
        public ProductPresenter(IProductView v) {
            this.view = v;
        }

        public void ShowProductName()
        {
            view.ShowName("MAC电脑");
        }
    }
}
