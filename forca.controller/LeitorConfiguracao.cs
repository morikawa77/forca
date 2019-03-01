using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca.Controller
{
    class LeitorConfiguracao
    {
        public string LerConexao()
        {
            string resultado = "";

            //Ler string de Configuraçao
            resultado = ConfigurationManager.ConnectionStrings
                ["forca.Properties.Settings.Conexao"].ConnectionString;
            return resultado;
        }
    }
}
