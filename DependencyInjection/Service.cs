using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;

namespace DependencyInjection
{
    // Just a wrapper for the Service List Element to has it's own name and not <ArrayOfService>
    [XmlType(TypeName = nameof(Services))]
    public class Services : List<Service>
    {}

    public class Service
    {
        // [XmlAttribute] needs to be specified it is an Attribute -> <Service DisplayName="Example"/>, 
        // Else it would be an element -> 
        // <Service>
        //      <DisplayName>Example</DisplayName>
        //  <Service>
        [XmlAttribute]
        public string DisplayName { get; set; }
        [XmlAttribute]
        public string Id { get; set; }
        [XmlAttribute]
        public string Namespace { get; set; }

        // For caching last instance
        [XmlIgnore]
        private Module _instance;

        // Just a convenient way to get the instance
        // Properties in C# are like getter and setter methods, but you don't have to write parenthese
        [XmlIgnore]
        public Module Instance
        {
            get
            {
                if (_instance == null)
                {
                    // Get current assembly(this is the prefered method)
                    // Get all types in assembly
                    // And return the first Type which BaseType is Module and which namespace with id equals FullName of Type.
                    Type instanceType = typeof(Service).Assembly.GetTypes().First(type => type.BaseType == typeof(Module) && type.FullName == Namespace + "." + Id);
                    _instance = (Module)Activator.CreateInstance(instanceType);

                    // Example what you can do to initialize Basic Module
                    _instance.Name = DisplayName;
                }

                return _instance;

            }
        }
    }
}
