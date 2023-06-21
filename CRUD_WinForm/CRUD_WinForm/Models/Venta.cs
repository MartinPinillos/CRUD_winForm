using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_WinForm.Models
{
    public class Venta
    {
        //Modelo
        public int id { get; set; }
        public string comentarios { get; set; }


        //Constructor
        public Venta()
        {
            id = 0;
            comentarios = string.Empty;
        }
    }
}
