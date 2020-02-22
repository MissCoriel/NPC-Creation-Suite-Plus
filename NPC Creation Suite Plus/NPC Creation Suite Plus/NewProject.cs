using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NPC_Creation_Suite_Plus
{
    public partial class NewProject : Form
    {
        public static string projectNamePass;

        public NewProject()
        {
            InitializeComponent();
        }

        private void NewNPC_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"NPC/[CP]{projectName.Text}"))
            {
                MessageBox.Show("This Project already exists.  Please load from Save.", "Directory Exists!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets/img");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets/Disposition");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets/Gift Taste");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets/Dialogue");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets/Animation");
                Directory.CreateDirectory($"NPC/[CP]{projectName.Text}/assets/Schedule");
                Directory.CreateDirectory("Save Data");

                SaveModel saveData = new SaveModel
                {
                    project = $"{projectName.Text}"
                };
                string path = Path.Combine($"Save Data", $"{projectName.Text}_Save.json");
                File.WriteAllText(path, JsonConvert.SerializeObject(saveData, Formatting.Indented));
                MessageBox.Show("Project Created Sucessfully!", $"{projectName.Text} Created!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                NPCDisposition frRemA = new NPCDisposition();
                NewProject.projectNamePass = this.projectName.Text;
                frRemA.ShowDialog();


            }
            
        }
    }
}
