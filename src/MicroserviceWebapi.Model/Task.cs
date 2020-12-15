using System;

namespace MicroserviceWebapi.Model
{
    public class Task
    {
        public string Id {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public string CreatedAt {get; set;}
        public string UpdatedAt {get; set;}
        public string DeltedAt {get; set;}
    }
}
