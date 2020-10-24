using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        List<INation> nationlist = new List<INation>();
        INation nation;
        Village village = null;
        Graphics g;
        public Pen p; 
        string villageName = null;

        public VillageWindow()
        {
            InitializeComponent();
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {
            nation = (INation)NationlistBox.SelectedItem;
            villageName = null;
      
            g = drawing_space.CreateGraphics();
            p = new Pen(Color.Black);

            nationlist.Add(new BangladeshiFarmers());
            nationlist.Add(new ArabBedouin());
            nationlist.Add(new EgyptianKings());    
            nationlist.Add(new InuitHunters());

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nationlist;
            NationlistBox.DataSource = nationlist;
            NationlistBox.DisplayMember = "nationName";
        }

        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
            if (village != null)
            {
                Point point = new Point(e.X, e.Y);
                if (tree_btn.Checked)
                {
                    village.AddTree(g, p, point);
                }
                else if (House_btn.Checked)
                {
                    village.AddHouse(g, p, point);
                }
                else if (water_btn.Checked)
                {
                    village.AddWaterResource(g, p, point);
                }
            }
        }

        private void Village_name_textBox_TextChanged(object sender, EventArgs e)
        {
            villageName = Village_name_textBox.Text;
            
            if (villageName.Length != 0  &  village != null)
            {
                village.SetVillageName(villageName);
            }
            else if (villageName.Length == 0)
            {
                if(village != null)
                    Village_name_textBox.Text = villageName = village.GetVillageName();
                else
                    villageName = null;

                MessageBox.Show(" Villge name cannot be empty ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                 
        }

        private void NationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = (INation)NationlistBox.SelectedItem;
            if(village!= null)
            {
                village.ChangeVillageNation(nation);
                village.initiate(g, p);
            }
        }

        private void new_village_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (villageName != null)
                {
                    village = new Village(villageName, nation);
                    village.initiate(g, p);
                }
                else
                    MessageBox.Show("Valid village name required to create new village ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void save_village_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (village != null)
                {
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        VillageState state = village.CreateState();
                        string jsonString = JsonConvert.SerializeObject(state, Formatting.Indented);
                        File.WriteAllText(saveFileDialog.FileName, jsonString);
                        saveFileDialog.Dispose();
                    }
                }
                else
                    MessageBox.Show("No village to save. Create new village first ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured! File not saved\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void open_village_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.Trim() != string.Empty)
                    {
                        string jsonString = File.ReadAllText(openFileDialog.FileName);
                        VillageState state = JsonConvert.DeserializeObject<VillageState>(jsonString);
                        if (village == null)
                            village = new Village("", nation);
                        village.SetState(state);
                        village.initiate(g, p);
                        villageName = Village_name_textBox.Text = village.GetVillageName();
                        openFileDialog.Dispose();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured while opening file\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
