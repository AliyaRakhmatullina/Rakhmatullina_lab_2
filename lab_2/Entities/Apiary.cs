using System.Xml.Serialization;
using lab_2.Entities.NestedEntities;

namespace lab_2.Entities;

public class Apiary
{
    [XmlAttribute]
    public int Id { get; set; }
    [XmlElement]
    public ApiarySize Size { get; set; } 
    [XmlAttribute]
    public int BeehiveCount { get; set; }
    [XmlAttribute]
    public double GrassHeightMm { get; set; }
}