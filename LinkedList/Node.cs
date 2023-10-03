using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        private int dato;
        private string name;
        private Node? siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Node? Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Node()
        {
            dato = 0;
            name = "";
            siguiente = null;
        }

        public Node(int d)
        {
            this.dato = d;
            name = "";
            siguiente = null;
        }

        public Node(int d, string n, Node? s)
        {
            this.dato = d;
            this.name = n;
            this.siguiente = s;
        }

        public virtual string ToString2()
        {
            return dato.ToString() + " " + name;
        }
    }
}
