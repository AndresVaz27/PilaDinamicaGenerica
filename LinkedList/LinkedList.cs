using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList : Node
    {
        private Node? cima;
        private int NodeCount = 0;

        public string[] ToArray()
        {
            string[] result = new string[Count()];
            var index = 0;
            var node = cima;
            while (node != null)
            {
                result[index] = node.Dato.ToString();
                node = node.Siguiente;
            }
            return result;
        }
        public Node? Head
        {
            get { return cima; }
            set { cima = value; }
        }

        public LinkedList()
        {
            cima = null;
        }

        public void Push(int Dato)
        {
            //if (NodeCount == 1000)
            //    MessageBox.Show("LinkedList llena!");   
            //    return;
            Node nuevoNodo = new Node(Dato);
            nuevoNodo.Siguiente = cima;
            cima = nuevoNodo;
            NodeCount++;    
        }

        public string Pop()
        {
            if (cima == null)
            {
                MessageBox.Show("No existen datos para mostrar.");            
            }

            var valor = cima.Dato;
            cima = cima.Siguiente;
            return valor.ToString();
            NodeCount--;
        }

        public string Peek()
        {
            if (cima == null)
            {
                MessageBox.Show("El stack está vacío.");
                return "";
            }
            return cima.Dato.ToString();
        }

        public bool IsEmpty()
        {
            return cima == null;
        }

        public int Count()
        {
            int c = 0;
            Node? h = cima;
            while (h != null)
            {
                c++;
                h = h.Siguiente;
            }
            return c;
        }
        public override string ToString()
        {
            Node c = cima;
            string r = "";
            while (c != null)
            {
                 r += c.Dato + " ";
                c = c.Siguiente;            
            }
            return r;
        }
        public override string ToString2()
        {
            //recorer para concatenar los datas de los nodes de la lista
            Node? h = cima;
            string r = "";
            while (h != null)
            {
                r += h.ToString2() + Name + " ";
                
                h = h.Siguiente;
            }
            return r;
            
        }
    }
}
