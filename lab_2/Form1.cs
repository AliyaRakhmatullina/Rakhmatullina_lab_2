using System.Text.Json;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1(EntitiesFileContent entitiesFileContent)
        {
            InitializeComponent();
            FillTreeView(entitiesFileContent);
            FillDataGridView(entitiesFileContent);
        }
        
        private void FillDataGridView(EntitiesFileContent entitiesFileContent)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("Id", "Id");
            dataGridView.Columns.Add("EntityType", "EntityType");
            dataGridView.Columns.Add("EntityInfo", "EntityInfo");

            if (entitiesFileContent.Apiaries != null)
            {
                foreach (var apiary in entitiesFileContent.Apiaries)
                {
                    dataGridView.Rows.Add(apiary.Id, "Apiary", $"{JsonSerializer.Serialize(apiary)}");
                }
            }
            if (entitiesFileContent.Beehives != null)
            {
                foreach (var beehive in entitiesFileContent.Beehives)
                {
                    dataGridView.Rows.Add(beehive.Id, "Beehive", $"{JsonSerializer.Serialize(beehive)}");
                }
            }
            if (entitiesFileContent.Bees != null)
            {
                foreach (var bee in entitiesFileContent.Bees)
                {
                    dataGridView.Rows.Add(bee.Id, "Bee", $"{JsonSerializer.Serialize(bee)}");
                }
            }
        }
        private void FillTreeView(EntitiesFileContent entitiesFileContent)
        {
            treeView1.Nodes.Clear();

            var beesNode = new TreeNode("Bees");
            if (entitiesFileContent.Bees != null)
            {
                foreach (var bee in entitiesFileContent.Bees)
                {
                    var beeNode = new TreeNode($"Bee {bee.Id}");

                    beeNode.Nodes.Add(new TreeNode($"Honey: {bee.HoneyMlPerMonth} ml/month"));

                    var sizeNode = new TreeNode("Size");
                    sizeNode.Nodes.Add(new TreeNode($"Length: {bee.Size.LengthMm} mm"));
                    sizeNode.Nodes.Add(new TreeNode($"Width: {bee.Size.WidthMm} mm"));
                    sizeNode.Nodes.Add(new TreeNode($"Wing Length: {bee.Size.WingLengthMm} mm"));

                    beeNode.Nodes.Add(sizeNode);
                    beesNode.Nodes.Add(beeNode);
                }
            }

            var beehivesNode = new TreeNode("Beehives");
            if (entitiesFileContent.Beehives != null)
            {
                foreach (var beehive in entitiesFileContent.Beehives)
                {
                    var beehiveNode = new TreeNode($"Beehive {beehive.Id}");

                    beehiveNode.Nodes.Add(new TreeNode($"Capacity: {beehive.HoneyCapacityMl} ml"));

                    var sizeNode = new TreeNode("Size");
                    sizeNode.Nodes.Add(new TreeNode($"Length: {beehive.Size.LengthMm} mm"));
                    sizeNode.Nodes.Add(new TreeNode($"Width: {beehive.Size.WidthMm} mm"));
                    sizeNode.Nodes.Add(new TreeNode($"Height: {beehive.Size.HeightMm} mm"));

                    beehiveNode.Nodes.Add(sizeNode);
                    beehivesNode.Nodes.Add(beehiveNode);
                }
            }
            
            var apiariesNode = new TreeNode("Apiaries");
            if (entitiesFileContent.Apiaries != null)
            {
                foreach (var apiary in entitiesFileContent.Apiaries)
                {
                    var apiaryNode = new TreeNode($"Apiary {apiary.Id}");

                    apiaryNode.Nodes.Add(new TreeNode($"Beehive Count: {apiary.BeehiveCount}"));
                    apiaryNode.Nodes.Add(new TreeNode($"Grass Height: {apiary.GrassHeightMm} mm"));

                    var sizeNode = new TreeNode("Size");
                    sizeNode.Nodes.Add(new TreeNode($"Length: {apiary.Size.LengthM} m"));
                    sizeNode.Nodes.Add(new TreeNode($"Width: {apiary.Size.WidthM} m"));

                    apiaryNode.Nodes.Add(sizeNode);
                    apiariesNode.Nodes.Add(apiaryNode);
                }
            }

            treeView1.Nodes.Add(beesNode);
            treeView1.Nodes.Add(beehivesNode);
            treeView1.Nodes.Add(apiariesNode);

            treeView1.ExpandAll();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 0)
                return;
            
            var selectedRow = dataGridView.SelectedRows[0];

            var entityId = (int) selectedRow.Cells["Id"].Value;
            var entityType = (string) selectedRow.Cells["EntityType"].Value;
            var entityInfo = (string) selectedRow.Cells["EntityInfo"].Value;
            
            var entityInfoForm = new EntityInfoForm(entityId, entityType, entityInfo);
            entityInfoForm.Show();
        }
    }
}
