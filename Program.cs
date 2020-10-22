using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Infra.Interfaces;
using UNITPAC.LTPV.Infra.Repositories;

namespace UNITPAC.LTPV.Cars
{
    static class Program
    {
        public static Container container;

        public static void Bootstrap()
        {
            container = new Container();

            container.Register<ICarsRepository, CarsRepository>();

            container.Verify();
        }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(new FrmPrincipal());
        }
    }
}
