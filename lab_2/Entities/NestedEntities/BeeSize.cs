using System.Xml.Serialization;

namespace lab_2.Entities.NestedEntities;

public class BeeSize
{
    public int Id { get; set; }
    
    [XmlAttribute]
    public int LengthMm { get; set; }
    [XmlAttribute]
    public int WidthMm { get; set; }
    [XmlAttribute]
    public int WingLengthMm{ get; set; }
}