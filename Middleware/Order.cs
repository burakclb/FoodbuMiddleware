using System.Collections.Generic;

namespace Middleware
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<string> Items { get; set; } = new List<string>(); // Initialize with an empty list
        public string Tag { get; set; } = string.Empty; // Initialize with an empty string
    }
}
