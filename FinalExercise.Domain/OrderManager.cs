using FinalExercise.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExercise.Domain
{
    public class OrderManager
    {
        public static List<DTO.OrderDTO> CreateOrder1(DTO.OrderDTO order)
        {
            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.SizeType.Medium;
            order.Crust = DTO.Enums.CrustType.Regular;
            order.Sausage = true;
            order.Pepperoni = false;
            order.Onions = true;
            order.GreenPeppers = false;
            order.Name = "Jack";
            order.Address = "123 Fake St";
            order.Zip = "94865";
            order.Phone = "555-666-7777";
            order.TotalCost = 5M;
            order.PaymentType = DTO.Enums.PaymentType.Cash;
            order.Completed = false;
            return Persistence.OrderRepository.CreateOrder(order);
        }

        public static List<DTO.OrderDTO> CreateOrder2(DTO.OrderDTO order)
        {
            order.OrderId = Guid.NewGuid();
            order.Size = DTO.Enums.SizeType.Large;
            order.Crust = DTO.Enums.CrustType.Thick;
            order.Sausage = true;
            order.Pepperoni = true;
            order.Onions = true;
            order.GreenPeppers = false;
            order.Name = "Bill";
            order.Address = "345 Fake St";
            order.Zip = "38247";
            order.Phone = "555-666-3333";
            order.TotalCost = 10M;
            order.PaymentType = DTO.Enums.PaymentType.Credit;
            order.Completed = false;
            return OrderRepository.CreateOrder(order);
        }
    }
}
