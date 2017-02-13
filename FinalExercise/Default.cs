using FinalExercise.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExercise
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            
            DTO.OrderDTO order1 = new DTO.OrderDTO();
            DTO.OrderDTO order2 = new DTO.OrderDTO();
            List<DTO.OrderDTO> orders = new List<DTO.OrderDTO>();
            Domain.OrderManager.CreateOrder1(order1);
            orders = Domain.OrderManager.CreateOrder2(order2);
            dataGridView1.DataSource = orders;
            
        }
    }
}
