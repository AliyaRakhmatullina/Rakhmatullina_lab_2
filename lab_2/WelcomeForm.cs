using System.Text.Json;
using System.Xml;
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

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
    }

    private void buttonLoadFromJson_Click(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            var filePath = dialog.FileName;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не существует");
                return;
            }

            var fileText = File.ReadAllText(filePath);
            EntitiesFileContent? entitiesFileContent = JsonSerializer.Deserialize<EntitiesFileContent?>(fileText);
            if (entitiesFileContent == null)
            {
                MessageBox.Show("Содержание файла некорректное");
                return;
            }

            var form1 = new Form1(entitiesFileContent);
            form1.Show();
        }
    }

    private void buttonLoadFromXml_Click(object sender, EventArgs e)
    {
        var dialog = new OpenFileDialog();
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            var filePath = dialog.FileName;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не существует");
                return;
            }
            
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Entities";
            xRoot.IsNullable = true;
            
            using var sr = new StreamReader(filePath);
            using var xmlReader = XmlReader.Create(sr);
            var serializer = new XmlSerializer(typeof(EntitiesFileContent), xRoot);
            
            object? deserializedObject = serializer.Deserialize(xmlReader);
            EntitiesFileContent? entitiesFileContent = (EntitiesFileContent?)deserializedObject;
            if (deserializedObject == null || entitiesFileContent == null)
            {
                MessageBox.Show("Содержание файла некорректное");
                return;
            }
            
            var form1 = new Form1(entitiesFileContent);
            form1.Show();
        }
    }
}