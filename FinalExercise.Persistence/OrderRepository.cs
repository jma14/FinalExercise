using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.Entity.Core;
using System.Data.SqlClient;

namespace FinalExercise.Persistence
{
    public class OrderRepository
    {
        public static List<DTO.OrderDTO> CreateOrder(DTO.OrderDTO order)
        {
            MyContext context = new MyContext();
            using (context)
            {
                context.Orders.Add(order);
                context.SaveChanges();
                return context.Orders.ToList();
                //context.Orders.ToList();
            }
        }
    }
}
