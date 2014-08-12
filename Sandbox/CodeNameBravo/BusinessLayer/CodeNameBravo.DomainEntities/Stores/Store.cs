using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace CodeNameBravo.Domain.Entities.Stores
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

   
    }

}
