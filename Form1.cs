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

            var riotApi = RiotApi.NewInstance("RGAPI-05e979b0-de94-4bcf-b8bf-5e88bc7af374");

            //Get Summoner information
            GetSummonerData(riotApi, summoner1name.Text, sum1champs);
            GetSummonerData(riotApi, summoner2name.Text, sum2champs);
            GetSummonerData(riotApi, summoner3name.Text, sum3champs);
            GetSummonerData(riotApi, summoner4name.Text, sum4champs);
            GetSummonerData(riotApi, summoner5name.Text, sum5champs);

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
                    summonerData.Items.Add(champ.Name() + " | " + mastery.ChampionPoints.ToString() + " | " + mastery.ChampionLevel.ToString());
                }
            }
            else
            {
                MessageBox.Show("The Summoner Name " + summonerName + "could not be found.");
            }
        }
    }
}
