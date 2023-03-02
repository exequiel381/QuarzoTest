using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Category
    {
        private int _nIdCategori;
        private string _cNombCateg;
        private bool _cEsActiva;
        public int IdCategori { get { return _nIdCategori; } set { _nIdCategori = value; } }
        public string NombCateg { get { return _cNombCateg; } set { _cNombCateg = value; } }
        public bool EsActiva { get { return _cEsActiva; } set { _cEsActiva = value; } }
    }
}
