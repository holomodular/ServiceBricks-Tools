using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportApp.Model
{
    public class Microservice
    {
        public string Name { get; set; } = @"Example Microservice";
        public string Description { get; set; } = @"This is an example microservice built using the ServiceBricks foundation.";
        public string ModuleName { get; set; } = @"Example";
        public List<MicroserviceModel> Models { get; set; } = new List<MicroserviceModel>();
    }

    public class MicroserviceModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MicroserviceModelProperty> Properties { get; set; } = new List<MicroserviceModelProperty>();
    }

    public class MicroserviceModelProperty
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DotNetType { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}