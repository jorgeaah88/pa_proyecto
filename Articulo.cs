using System;

namespace Proyecto1 {
    //Objeto de tipo Articulo
    public class Articulo {
        //Atributos del objeto 
        private int _Id = -1;
        private string _Marca = "";
        private string _Descripcion = "";
        private bool _Activo = false;
        private Categoria _CategoriaArticulo;
       
        public Articulo(int id, string descripcion, Categoria categoriaarticulo, string marca, bool activo) {

            _Id = id;
            _Marca = marca;
            _CategoriaArticulo = categoriaarticulo;
            _Activo = activo;
            _Descripcion = descripcion;

        }


        public bool IsOk() {
            if (_Id==-1 || _Marca.Equals("") || _Descripcion.Equals("") || !_CategoriaArticulo.IsOk() || !_Activo) {
                return false;
            }

            return true;
        }

        public string Status()
        {
            if (_Activo)
            {
                return "Activo";
            }

            return "Inactivo";
        }

        new public string ToString() {

            return ">Id: " + _Id.ToString() + "\t>Marca: " + _Marca + "\t>Descripcion :  " + _Descripcion + "\t>Categoria: " + _CategoriaArticulo.GetDesc() + "\t>Estado: " + Status();
        }

        public string ToStringSmall()
        {
            return ">Id: " + _Id.ToString() + "\t>Marca: " + _Marca;
        }

            public string[] ToArray() {
            string[] tmp = { _Id.ToString(), _Marca, _Descripcion, _CategoriaArticulo.GetDesc(), Status() };
            return (tmp);

        }

    }

}
