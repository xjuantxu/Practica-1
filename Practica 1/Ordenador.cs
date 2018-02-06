using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    public class Ordenador
    {
        #region variables
        private int id;
        private int aula;
        private string procesador;
        private int ram;
        private int vram;
        private int hdd;
        private string aplicaciones;
        #endregion
        #region propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        public string Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram = value; }
        }

        public int Vram
        {
            get { return vram; }
            set { vram = value; }
        }
        public int Hdd
        {
            get { return hdd; }
            set { hdd = value; }
        }
        public string Aplicaciones
        {
            get { return aplicaciones; }
            set { aplicaciones = value; }
        }
        #endregion
        #region constructor
        public Ordenador(){} //constructor por defecto
        public Ordenador(int i, int a, string p, int r, int v, int h, string ap) //constructor que toma los var
        {
            i = Id;
            a = Aula;
            p = Procesador;
            r = Ram;
            v = Vram;
            h = Hdd;
            ap = Aplicaciones;
        }
        #endregion
    }
}
