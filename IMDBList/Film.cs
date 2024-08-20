using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBList
{
    internal class Film
    {
        private string? name ; // Null olma durumunda hata vermemesi için optional tanımlıyoruz. name field
        private double imdbPoint; // Film nesnesi için imdbPoint tanımlıyoruz. imdbPoint field
        public string Name // Name property
        {
            get
            {
                return name!;
            }
            set
            {
                name = value ;
            }
        }
        public double ImdbPoint // ImdbPoint property
        {
            get
            {
                return imdbPoint;
            }

            set
            {
                imdbPoint = value;
            }
        }       

    }
}
