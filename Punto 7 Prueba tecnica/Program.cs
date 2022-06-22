using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static List<Item> listainicial = new List<Item>()
            {
                new Item { IdItem= "1",   Titulo="Administración", IdItemPadre=null },
                new Item { IdItem= "2",   Titulo="Gestion", IdItemPadre=null },
                new Item { IdItem= "3",   Titulo="Clientes",    IdItemPadre="1" },
                new Item { IdItem= "4",   Titulo="Productos",   IdItemPadre="1" },
                new Item { IdItem= "5",   Titulo="Editar Productos",    IdItemPadre="4" },
                new Item { IdItem= "6",   Titulo="Inventario",  IdItemPadre="4" },
                new Item { IdItem= "7",   Titulo="Despacho de Pedidos", IdItemPadre="2" },

            };
        static void Main(string[] args)
        {
            recursive(listainicial.Where(i => i.IdItemPadre == null).ToList(),"");
        }

        public static void recursive(List<Item> nodos,string tab)
        {
            foreach (Item item in nodos)
            {
                Console.WriteLine(tab+item.Titulo);
                List<Item> hijos = listainicial.Where(i => i.IdItemPadre == item.IdItem).ToList();
                if (hijos.Count != 0)
                {
                    recursive(hijos, tab + "\t");
                }
            }
        }


    }
}
