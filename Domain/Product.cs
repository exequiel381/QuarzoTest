using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        private int _nIdProduct;
        private string _cNombProduct;
        private decimal _cPrecioProd;
        private string _nNomCateg;
        public int IdProduct { get { return _nIdProduct; } set { _nIdProduct = value; } }
        public string NombProduct { get { return _cNombProduct; } set { _cNombProduct = value; } }
        public decimal PrecioProd { get { return _cPrecioProd; } set { _cPrecioProd = value; } }
        public string Category { get { return _nNomCateg; } set { _nNomCateg = value; } }
    }
}
