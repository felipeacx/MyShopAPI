using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopAPI.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public string Log { get; set; }
    }
}
