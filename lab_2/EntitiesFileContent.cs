using System.Xml.Serialization;
using lab_2.Entities;

namespace lab_2;

public class EntitiesFileContent
{
    [XmlArray]
    [XmlArrayItem("Bee")]
    public List<Bee>? Bees { get; set; }
    [XmlArray]
    [XmlArrayItem("Beehive")]
    public List<Beehive>? Beehives { get; set; }
    [XmlArray]
    [XmlArrayItem("Apiary")]
    public List<Apiary>? Apiaries { get; set; }
}
