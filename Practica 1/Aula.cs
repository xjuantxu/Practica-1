using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Aula
    {
        #region variables
        private int id;
        private string nombre;
        private List<Ordenador> listapc;
        private DateTime fechamod;
        #endregion
        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public List<Ordenador> Listapc
        {
            get { return listapc; }
            set { listapc = value; }
        }
        public DateTime FechaMod
        {
            get { return fechamod; }
            set { fechamod = value; }
        }
        #endregion
        #region constructor
        public Aula() { } //Constructor por defecto
        public Aula(int i, string n, DateTime f)
        {
            i = Id;
            n = Nombre;
            listapc = new List<Ordenador>();
            f = FechaMod;

        }
        #endregion
        #region metodos
        #endregion
    }
}
