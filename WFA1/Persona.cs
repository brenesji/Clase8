using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA1
{
    class Persona
    {
        private string name;
        private string lastname;

        //constructor
        public Persona()
        {
            name = "";
            lastname = "";
        }

        //constructor con parámetros
        public Persona(string n, string ln)
        {
            name = n;
            lastname = ln;
        }

        //propiedades avanzadas
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        //propiedades básicas
        public void setname(string n)
        {
            name = n;
        }

        public void setlastname(string ln)
        {
            lastname = ln;
        }

        public string getname()
        {
            return name;
        }

        public string getlastname()
        {
            return lastname;
        }

        // destructor
        ~Persona()  
        {

        }

    }

}

