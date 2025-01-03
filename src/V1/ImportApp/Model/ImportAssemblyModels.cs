using Mono.Cecil;

namespace ImportApp.Model
{
    public class ImportAssemblyConfig
    {
        public string Filename { get; set; }
        public List<TypeDefinition> TypeDefinitions { get; set; } = new List<TypeDefinition>();
        public List<ImportObject> ImportObjects { get; set; } = new List<ImportObject>();
        public string Name { get; set; }
        public string Description { get; set; }
        public string Module { get; set; }
        public bool AssumeFirstPropIsPk { get; set; }
    }

    public class ImportObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ModelName { get; set; }
        public List<ImportProperty> Properties { get; set; } = new List<ImportProperty>();
    }

    public class ImportProperty
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DotNetType { get; set; }
        public bool IsPrimaryKey { get; set; }
    }
}