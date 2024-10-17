using System;
using System.Collections.Generic;

namespace OrdersMicroservice.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<int> ProductIds { get; set; }
    }
}
