using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Data;

namespace RuneTrackerGUI
{
    public partial class RuneTracker : Form
    {

        public RuneTracker() => InitializeComponent();

        private void SearchPlayer_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string username = user.Text;
            string runedata = client.DownloadString("https://apps.runescape.com/runemetrics/profile/profile?user=" + username + "&activities=20");

            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(runedata);

            string pname = dobj["name"].ToString();
            string pskillLvl = dobj["totalskill"].ToString();
            string pcbLvl = dobj["combatlevel"].ToString();

            name.Text = pname;
            skillLvl.Text = pskillLvl;
            cbLvl.Text = pcbLvl;

            activities.Clear();
            foreach (var item in dobj["activities"])
            {
                string pdate = item.date;
                string pdetails = item.details;
                string ptext = item.text;

                int pos = activities.SelectionStart;
                
                activities.AppendText(pdate + Environment.NewLine);
                activities.AppendText(pdetails + Environment.NewLine);
                activities.AppendText(ptext + Environment.NewLine);
                activities.AppendText(Environment.NewLine);

                activities.SelectionStart = pos;

            }
        }

        private void SearchCB_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string username = usernameCB.Text;

            string runedata = client.DownloadString("https://apps.runescape.com/runemetrics/profile/profile?user=" + username + "&activities=20");
            dynamic dobj = JsonConvert.DeserializeObject<dynamic>(runedata);

            foreach (var item in dobj["skillvalues"])
            {
                if (item.id == 0)
                {
                    int attack = item.level;
                    att.Text = attack.ToString();
                }
                else if (item.id == 1)
                {
                    int defence = item.level;
                    def.Text = defence.ToString();
                }
                else if (item.id == 2)
                {
                    int strength = item.level;
                    str.Text = strength.ToString();
                }
                else if (item.id == 3)
                {
                    int constitution = item.level;
                    consti.Text = constitution.ToString();
                }
                else if (item.id == 4)
                {
                    int ranged = item.level;
                    rng.Text = ranged.ToString();
                }
                else if (item.id == 5)
                {
                    int prayer = item.level;
                    pray.Text = prayer.ToString();
                }
                else if (item.id == 6)
                {
                    int magic = item.level;
                    mag.Text = magic.ToString();
                }
                else if (item.id == 23)
                {
                    int summoning = item.level;
                    summ.Text = summoning.ToString();
                }
            }
        }

        private void SubmitCB_Click(object sender, EventArgs e)
        {
            // This will be used several times:
            double attstr = int.Parse(att.Text) + int.Parse(str.Text);
            double magic = int.Parse(mag.Text);
            double ranged = int.Parse(rng.Text);
            double constitution = int.Parse(consti.Text);
            double summoning = int.Parse(summ.Text);
            double prayer = int.Parse(pray.Text);
            double defence = int.Parse(def.Text);

            // Used formula, with every subcalculation being floored:
            // 1/4 * [1.3 * Max(Att+Str, 2*Mag, 2*Rng) + Def + Hp + Pray/2 + Summ/2]
            // The weight of pray/summ for example is 1/8, that of def/hp is 1/4 etc.
            double combatlvl = ((Math.Max(attstr, Math.Max(2 * magic, 2 * ranged)) * 13 / 10) + defence + constitution + Math.Floor(prayer / 2) + Math.Floor(summoning / 2)) / 4;
            double HpDef = Math.Ceiling((1 - (combatlvl % 1)) * 4);
            double PraySumm = Math.Ceiling((1 - (combatlvl % 1)) * 8);
            double AttStr;
            double Mage;
            double Range;

            // Setting what the required prayer and summoning
            double reqPrayer = 0;
            if (prayer % 2 != 0)
            {
                reqPrayer = PraySumm;
            }
            else if (prayer % 2 == 0)
            {
                reqPrayer = PraySumm + 1;
            }

            double reqSummoning = 0;
            if (summoning % 2 != 0)
            {
                reqSummoning = PraySumm;
            }
            else if (summoning % 2 == 0)
            {
                reqSummoning = PraySumm + 1;
            }

            if (attstr >= 2 * magic && attstr >= 2 * ranged)
            {
                AttStr = Math.Ceiling((1 - (combatlvl % 1)) / 0.325);
                Mage = Math.Ceiling(((attstr - (magic * 2)) / 2) + ((1 - (combatlvl % 1)) / 0.65));
                Range = Math.Ceiling(((attstr - (ranged * 2)) / 2) + ((1 - (combatlvl % 1)) / 0.65));
            }
            else
            {
                // calculate att/str levels needed for combat level up:
                // first calculate how many levels to get to make your combat melee-based, then add the amount of levels needed from there.
                AttStr = (Math.Max(ranged, magic) * 2) - attstr + Math.Ceiling((1 - (combatlvl % 1)) / 0.325);

                // store this value in variable Mage first: assume mage-based combat first
                Mage = Math.Ceiling((1 - (combatlvl % 1)) / 0.65);
                if (ranged > magic)
                {
                    // move the calculated value to variable Range: the combat is range-based
                    Range = Mage;
                    // same logic for melee: amount of levels to get mage-based combat PLUS levels to another cb from there
                    Mage = ranged - magic + Range;
                }
                else
                {
                    // same logic again
                    Range = magic - ranged + Mage;
                }
            }

            cbLevelReq.Clear();
            cbLevelReq.AppendText("Your current combat level is " + Math.Floor(combatlvl) + "." + Environment.NewLine);
            cbLevelReq.AppendText("For level " + Math.Floor((combatlvl) + 1) + " you need one of the folowing:" + Environment.NewLine);
            cbLevelReq.AppendText("- " + HpDef + " Constitution or Defence levels" + Environment.NewLine);
            cbLevelReq.AppendText("- " + reqPrayer + " Prayer levels" + Environment.NewLine);
            cbLevelReq.AppendText("- " + reqSummoning + " Summoning levels" + Environment.NewLine);
            cbLevelReq.AppendText("- " + AttStr + " Attack or Strength levels" + Environment.NewLine);
            cbLevelReq.AppendText("- " + Mage + " Magic levels" + Environment.NewLine);
            cbLevelReq.AppendText("- " + Range + " Ranged levels" + Environment.NewLine);
        }

        private void SearchClan_Click(object sender, EventArgs e)
        {
            // "http://services.runescape.com/m=clan-hiscores/members_lite.ws?clanName=" + clanname

            string clanname = clan.Text;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://services.runescape.com/m=clan-hiscores/members_lite.ws?clanName=" + clanname);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream());

            string[] columnname = reader.ReadLine().Split(',');
            DataTable dt = new DataTable();

            foreach (string c in columnname)
            {
                dt.Columns.Add(c);
            }
            string newline;
            while ((newline = reader.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            reader.Close();
            csvTable.DataSource = dt;
        }
    }
}
