using System.Collections.Generic;

namespace MiniAppBL.Models
{
    public class Component
    {
        public int ComponentId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int ComponentTypeId { get; set; }

        public virtual ComponentType ComponentType { get; set; }
        public virtual ICollection<Storage> Storages { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
