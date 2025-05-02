using System.Xml.Serialization;
using lab_2.Entities.NestedEntities;

namespace lab_2.Entities;

public class Beehive
{
    [XmlAttribute]
    public int Id { get; set; }
    public BeehiveSize Size { get; set; }
    [XmlAttribute]
    public double HoneyCapacityMl { get; set; }
}