using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMST4.Store.Shoes.Models.Entites
{
    public class Color
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedBy { get; set; }
    }
}