using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class ArticulosxSucursal
    {

        private int _Cantidad = -1;
        private Sucursal _Sucursal ;
        private Articulo _Articulo;


        public ArticulosxSucursal(int cantidad, Sucursal sucursal, Articulo articulo)
        {
            _Cantidad = cantidad;
            _Sucursal = sucursal;
            _Articulo = articulo;
        }

        public bool IsOk()
        {
            if ( _Sucursal.IsOk() || _Articulo.IsOk() || _Cantidad!=-1 )
            {
                return true;
            }

            return false;
        }


        public new string ToString()
        {

            return "Articulo: " + _Articulo.ToStringSmall() + "\tSucursal: " + _Sucursal.GetName() + "\tCantidad: " + _Cantidad.ToString() ;
        }

        public string[] ToArray()
        {

            string[] tmp = { _Articulo.ToStringSmall(), _Sucursal.GetName(), _Cantidad.ToString()};
            return (tmp);

        }

    }
}
