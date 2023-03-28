using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDeploy
{
    [Table("Test1")]
    public sealed class Test1
    {
        [Key]
        public int Id { get; set; }
    }
}
