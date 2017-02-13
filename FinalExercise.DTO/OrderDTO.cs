using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.DTO
{
    public class OrderDTO
    {
        [Key]
        public Guid OrderId { get; set; }
        public Enums.SizeType Size { get; set; }
        public Enums.CrustType Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public Enums.PaymentType PaymentType { get; set; }
        public bool Completed { get; set; }

    }
}
