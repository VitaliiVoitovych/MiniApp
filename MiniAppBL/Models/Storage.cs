namespace MiniAppBL.Models
{
    public class Storage
    {
        public int StorageId { get; set; }

        public int ComponentId { get; set; }
        public virtual Component Component { get; set; }

        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }

        public int Count { get; set; }

    }
}
