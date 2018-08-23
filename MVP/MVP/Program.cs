using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var pv = new ProductView();
    //        var p = new ProductPresenter(pv);
    //        var name=p.ShowProductName();
    //        Console.WriteLine(name);
    //        Console.ReadKey();
    //    }
    //}
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductView());
        }
    }
}
