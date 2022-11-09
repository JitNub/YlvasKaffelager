using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YlvasKaffelager.DataModels
{
    public class Order
    {
        public int Id { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        public string Email { get; set; }
        public string Brand { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
    }
}