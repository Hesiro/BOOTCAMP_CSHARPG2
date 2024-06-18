using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEmpresasPOO.Models
{
    internal class Empresa
    {
        private string ruc;
        private string razonSocial;
        private string domicilioFiscal;

        public Empresa(string ruc, string razonSocial, string domicilioFiscal)
        {
            this.ruc = ruc;
            this.razonSocial = razonSocial;
            this.domicilioFiscal = domicilioFiscal;
        }

        public string Ruc { get => ruc; set => ruc = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string DomicilioFiscal { get => domicilioFiscal; set => domicilioFiscal = value; }

        public string Mostrar()
        {
            return $"Ruc: {this.ruc}\nRazón Social: {this.razonSocial}\nDomicilio Fiscal: {this.domicilioFiscal}";
        }
    }
}
