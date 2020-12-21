using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicroserviceWebapi.Model
{
    public class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}
        [Key]
        public  Guid Uuid {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public string CreatedAt {get; set;}
        public string UpdatedAt {get; set;}
        public string DeltedAt {get; set;}
    }
}
