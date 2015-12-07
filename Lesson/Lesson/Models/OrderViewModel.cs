using System;
using System.ComponentModel;

namespace Lesson.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        [DisplayName("Order Date")]
        public DateTime? OrderDate { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
    }
}