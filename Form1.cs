using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;


namespace RiotChampionProfiler
{
    public partial class Form1 : Form
    {
        List<string> mostFrequent = new List<string>();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear Lists
            
            sum1champs.Items.Clear();
            sum2champs.Items.Clear();
            sum3champs.Items.Clear();
            sum4champs.Items.Clear();
            sum5champs.Items.Clear();


            var riotApi = RiotApi.NewInstance(riotApiKeyField.Text);
            if (riotApi != null)
            {
                //Get Summoner information
                StatusLabel.Text = "Getting Summoner info from Riot API (1/5)";
                GetSummonerData(riotApi, summoner1name.Text, sum1champs);
                ProgressBar.Value = 20;

                StatusLabel.Text = "Getting Summoner info from Riot API (2/5)";
                GetSummonerData(riotApi, summoner2name.Text, sum2champs);
                ProgressBar.Value = 40;

                StatusLabel.Text = "Getting Summoner info from Riot API (3/5)";
                GetSummonerData(riotApi, summoner3name.Text, sum3champs);
                ProgressBar.Value = 60;

                StatusLabel.Text = "Getting Summoner info from Riot API (4/5)";
                GetSummonerData(riotApi, summoner4name.Text, sum4champs);
                ProgressBar.Value = 80;

                StatusLabel.Text = "Getting Summoner info from Riot API (5/5)";
                GetSummonerData(riotApi, summoner5name.Text, sum5champs);
                ProgressBar.Value = 100;
                ProgressBar.Value = 0;
                StatusLabel.Text = "Fetch complete";

                var groupsWithCounts = from s in mostFrequent
                                       group s by s into g
                                       select new
                                       {
                                           Item = g.Key,
                                           Count = g.Count()
                                       };

                var groupsSorted = groupsWithCounts.OrderByDescending(g => g.Count);
                AdviceText.Text = "You should ban " + groupsSorted.First().Item + ".";
            }
            else
            {
                MessageBox.Show("Invalid Riot API Key");
            }
        }

        private void summoner1name_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void PrintBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sum1champs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sum2champs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sum3champs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sum4champs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sum5champs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        //Get and populate data
        public void GetSummonerData(RiotApi riotApi, string summonerName, ListBox summonerData)
        {
            var summoner = riotApi.SummonerV4.GetBySummonerName(MingweiSamuel.Camille.Enums.Region.NA, summonerName);
            if (summoner != null)
            {
                var masteries = riotApi.ChampionMasteryV4.GetAllChampionMasteries(MingweiSamuel.Camille.Enums.Region.NA, summoner.Id);

                for (var i = 0; i < masteries.Length; i++)
                {
                    if (i == 9)
                    {
                        break;
                    }
                    var mastery = masteries[i];
                    // Get champion for this mastery.
                    var champ = (Champion)mastery.ChampionId;
                    summonerData.Items.Add((i+1).ToString() + " | " + champ.Name() + " (" + mastery.ChampionPoints.ToString() + " | " + mastery.ChampionLevel.ToString() + ")");
                    mostFrequent.Add(champ.Name());
                }
            }
            else
            {
                MessageBox.Show("The Summoner Name " + summonerName + "could not be found.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void riotApiKeyField_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
