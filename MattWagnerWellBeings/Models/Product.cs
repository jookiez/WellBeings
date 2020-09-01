using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MattWagnerWellBeings.Models
{
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public string Type { get; }
        public string Description { get; }

        public Product (int id, string name, string type, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Description = description;
        }
    }
}
