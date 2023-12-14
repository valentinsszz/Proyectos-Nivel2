using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;
        // constructor
            
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        //propiedad
        public void setEdad(int e){
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }

        // metodos

       public string saludar()
        {
            return "Hol soy ... " + nombre;
        }

    

}
}
