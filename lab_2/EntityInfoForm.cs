using System.Text;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

namespace lab_2;

public partial class EntityInfoForm : Form
{
    public EntityInfoForm(int entityId, string entityType, string entityInfo)
    {
        InitializeComponent();
        
        var mainDbContext = new MainDbContext();
        mainDbContext.Database.EnsureCreated();

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Выбранная сущность:");
        sb.AppendLine(entityInfo);
        sb.AppendLine();
        if (entityType == "Bee")
        {
            var beehiveIds = mainDbContext.BeeBeehives.Where(bb => bb.BeeId == entityId).Select(bb => bb.BeehiveId).ToList();
            if (beehiveIds.Count > 0)
            {
                var beehives = mainDbContext.Beehives.Where(b => beehiveIds.Contains(b.Id)).Include(b => b.Size).ToList();
                sb.AppendLine("Эта сущности принадлежат ульи:");
                foreach (var b in beehives)
                {
                    sb.AppendLine(JsonSerializer.Serialize(b));
                }
            }
            else
            {
                sb.AppendLine("Эта сущность не имеет ульев");
            }
        }
        else if (entityType == "Beehive")
        {
            var apiaryIds = mainDbContext.BeehivesApiaries.Where(ba => ba.BeehiveId == entityId).Select(ba => ba.ApiaryId).ToList();
            if (apiaryIds.Count > 0)
            {
                var apiaries = mainDbContext.Apiaries.Where(a => apiaryIds.Contains(a.Id)).Include(a => a.Size).ToList();
                sb.AppendLine("Эта сущности принадлежат пасеки:");
                foreach (var a in apiaries)
                {
                    sb.AppendLine(JsonSerializer.Serialize(a));
                }
            }
            else
            {
                sb.AppendLine("Эта сущность не имеет пасек");
            }
        }
        else if (entityType == "Apiary")
        {
            var beehiveIds = mainDbContext.BeehivesApiaries.Where(ba => ba.ApiaryId == entityId).Select(ba => ba.BeehiveId).ToList();
            if (beehiveIds.Count > 0)
            {
                var beehives = mainDbContext.Beehives.Where(b => beehiveIds.Contains(b.Id)).Include(b => b.Size).ToList();
                sb.AppendLine("Эта сущности принадлежат ульи:");
                foreach (var b in beehives)
                {
                    sb.AppendLine(JsonSerializer.Serialize(b));
                }
            }
            else
            {
                sb.AppendLine("Эта сущность не имеет ульев");
            }
        }
        
        richTextBox1.AppendText(sb.ToString());
    }
}