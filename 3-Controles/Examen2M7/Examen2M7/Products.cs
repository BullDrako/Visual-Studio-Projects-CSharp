using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Examen2M7
{
    class Products
    {
        private static Products instance = null;

        private ArrayList products = null;
        private Product select = null;
        private String name = "";

        protected Products()
        {
            products = new ArrayList();
        }

        public static Products getInstance()
        {
            if (instance == null)
            {
                instance = new Products();
            }
            return instance;
        }


        public Product Select
        {
            get { return select; }
            set { select = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        internal void borrarProduct(Product select)
        {
            products.Remove(select);
        }

        public Product buscarProductIndexOf(int i)
        {
            return (Product)this.products[i];

        }

        public int contarProductos()
        {
            return products.Count;
        }

    }
}
