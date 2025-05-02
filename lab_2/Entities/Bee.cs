using System.Xml.Serialization;
using lab_2.Entities.NestedEntities;

namespace lab_2.Entities
{
    public class Bee
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public double HoneyMlPerMonth { get; set; }
        [XmlElement]
        public BeeSize Size { get; set; }
    }
}
