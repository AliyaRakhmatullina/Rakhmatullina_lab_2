using System.Xml.Serialization;

namespace lab_2.Entities.NestedEntities;

public class BeehiveSize
{
    public int Id { get; set; }
    
    [XmlAttribute]
    public int LengthMm { get; set; }
    [XmlAttribute]
    public int WidthMm { get; set; }
    [XmlAttribute]
    public int HeightMm { get; set; }
}