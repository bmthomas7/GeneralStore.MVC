using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        //foreign key
        public int CustomerId { get; set; }
        //foreign key
        public String ProductId { get; set; }

        public int ItemCount { get; set; }

        public DateTime DateOfTransaction { get; set; }

    }
}