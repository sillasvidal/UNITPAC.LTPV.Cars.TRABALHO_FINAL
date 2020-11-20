using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNITPAC.LTPV.Aplicacao.Interfaces;
using UNITPAC.LTPV.Aplicacao.Notificacoes;
using UNITPAC.LTPV.Aplicacao.Services;
using UNITPAC.LTPV.Infra.Context;
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
            container.Register<LTPVContext>(Lifestyle.Singleton);

            container.Register<INotificador, Notificador>();
            container.Register<ICarroService, CarroService>();

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
