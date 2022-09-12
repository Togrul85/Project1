using System;
using System.Collections.Generic;
using System.Text;

namespace Project0
{
    class Pizza
    {
        private static int _id;
        public int Id { get; set; }
        public string  Name { get; set; }

        public Pizza()
        {
            _id++;
            Id = _id;
        }


    }



}
