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
    public partial class NPCDisposition : Form
    {
        public string systemFolder;
        public NPCDisposition()
        {
            InitializeComponent();
        }

        private void HelpLoveInterest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The name you put in here has no concieved purpose.  If you wish to not add anything, please set it as null.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpRelation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The proper format for this section is <NPC Name>'<Relation>'.  An example is Caroline'mom'.  This will randomly have your NPC tell something about any relation within the field.  Leave blank if no relations.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NPCDisposition_Load(object sender, EventArgs e)
        {
            systemFolder = NewProject.projectNamePass;
           /* string validSpawn = "Common Data/ValidLocations.txt";
            string parse = File.ReadAllText(validSpawn);
            var loadSpawn = new Dictionary<string, string>(parse);*/

        }
    }
}
