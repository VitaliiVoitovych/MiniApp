using System.Collections.Generic;

namespace MiniAppBL.Models
{
    public class Provider
    {
        public int ProviderId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<Storage> Storages { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
