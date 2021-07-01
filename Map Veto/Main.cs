using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Map_Veto
{
    public partial class Main : Form
    {
        public int phase = 0;
        public List<MapPool> pools = new List<MapPool>();
        public List<string> maps = new List<string>();
        public List<string> vetoed = new List<string>();
        public List<string> picked = new List<string>();
        public string t1Name;
        public string t2Name;

        public MapPool LoadJson(string fileName)
        {
            MapPool pool = JsonConvert.DeserializeObject<MapPool>(File.ReadAllText(fileName));
            return pool;
        }

        public void Bo1Veto()
        {
            if (phase == 1)
            {
                btnAct.Text = t1Name + " VETO";
            }
            if (phase % 2 == 0)
            {
                btnAct.Text = t2Name + " VETO";
            }
            if (phase % 2 != 0 && phase != 1)
            {
                btnAct.Text = t1Name + " VETO";
            }
            if (phase != 1)
            {
                if (lstMaps.SelectedItem == null)
                {
                    MessageBox.Show("You must select a map.", "Invalid action");
                    return;
                }
                lstVetoed.Items.Add(lstMaps.SelectedItem.ToString());
                maps.Remove(lstMaps.SelectedItem.ToString().Trim());
                lstMaps.Items.Remove(lstMaps.SelectedItem);
            }
            lblRemaining.Text = "Maps Remaining: " + maps.Count;

            if (maps.Count <= 3)
            {
                var random = new Random();
                int randIndex = random.Next(maps.Count);
                string randSelected = maps[randIndex];
                lstPicked.Items.Clear();
                lstPicked.Items.Add(randSelected);
                MessageBox.Show("Map veto has ended.\nSelected map is: " + randSelected, "Veto end", MessageBoxButtons.OK);
                return;
            }
        }

        public Main()
        {
            InitializeComponent();

            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appDir = Path.Combine(appData, "MapVeto");
            Directory.CreateDirectory(appDir); // Will be skipped if directory already exists

            string[] files = Directory.GetFiles(appDir + @"\pools", "*.json");
            foreach (string i in files)
            {
                MapPool poolData = LoadJson(i);
                poolData.filePath = i;
                pools.Add(poolData);
                cmbPools.Items.Add(poolData.name);
            }
        }

        private void btnLoadPools_Click(object sender, EventArgs e)
        {
            MapPool pool = pools.Find(x => x.name == cmbPools.Text.Trim());
            string filePath = pool.filePath;
            foreach (string map in pool.maps)
            {
                maps.Add(map);
                lstMaps.Items.Add(map);
            }

            lblRemaining.Text = "Maps Remaining: " + maps.Count;
        }

        /**
         * 
         * 
         * PHASE CHEATSHEET (TURNS)
         * 0 -> Veto not started
         * 1 -> Team 1 Ban
         * 2 -> Team 2 Ban
         * 3 -> Team 1 Ban (Bo1) / Pick (Bo3)
         * 4 -> Team 2 Ban (Bo1) / Pick (Bo3)
         * 
         * 
         */
        private void btnAct_Click(object sender, EventArgs e)
        {
            phase++;
            t1Name = txtT1.Text;
            t2Name = txtT2.Text;
            txtT1.Enabled = false;
            txtT2.Enabled = false;
            cmbPools.Enabled = false;
            btnLoadPools.Enabled = false;
            cmbStyle.Enabled = false;

            if (cmbStyle.Text.ToLower() == "best of 1")
            {
                Bo1Veto();
            }
            else if (cmbStyle.Text.ToLower() == "best of 3")
            {

            }
            else if (cmbStyle.Text.ToLower() == "best of 5")
            {

            }
            else
            {
                MessageBox.Show("An error has ocurred.", "Error", MessageBoxButtons.OK);
            }
        }
    }

    public class MapPool
    {
        public string filePath { get; set; }
        public string name { get; set; }
        public string[] maps { get; set; }
    }
}
