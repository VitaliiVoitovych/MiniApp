using System.Collections.Generic;

namespace MiniAppBL.Models
{
    public class ComponentType
    {
        public int ComponentTypeId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Component> Components { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
