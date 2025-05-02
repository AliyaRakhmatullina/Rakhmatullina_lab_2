using System.Xml.Serialization;

namespace lab_2.Entities.NestedEntities;

public class ApiarySize
{
    public int Id { get; set; }
    
    [XmlAttribute]
    public int LengthM { get; set; }
    [XmlAttribute]
    public int WidthM { get; set; }
        
}