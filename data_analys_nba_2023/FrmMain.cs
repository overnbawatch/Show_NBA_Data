using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static data_analys_nba_2023.GlobalValariables;

namespace data_analys_nba_2023
{
    public partial class FrmMain : Form
    {
        string[] list_seasons;
        string[] list_leagues;

        public FrmMain()
        {
            InitializeComponent();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            string[] list_item = { "seasons", "leagues", "teams", "players", "games", "gameDetails", "standings", "statistics" };
            Cmb_Item_1.Items.Clear();
            Cmb_Item_1.DataSource = list_item;
            Cmb_Item_1.Text = Cmb_Item_1.Items[0].ToString();

            string file_name = String.Format(dir_json, list_item[0]);
            if (File.Exists(file_name))
            {
                using (FileStream txt_json = File.OpenRead(file_name))
                {
                    Root_Seasons root_s = JsonSerializer.Deserialize<Root_Seasons>(txt_json);
                    list_seasons = new string[root_s.api.seasons.Count];
                    foreach (var season in root_s.api.seasons.Select((v, i) => new { Value = v, Index = i }))
                    {
                        list_seasons[season.Index] = season.Value;
                    }
                }
            }

            file_name = String.Format(dir_json, list_item[1]);
            if (File.Exists(file_name))
            {
                using (FileStream txt_json = File.OpenRead(file_name))
                {
                    Root_Leagues root_s = JsonSerializer.Deserialize<Root_Leagues>(txt_json);
                    list_leagues = new string[root_s.api.leagues.Count];
                    foreach (var league in root_s.api.leagues.Select((v, i) => new { Value = v, Index = i }))
                    {
                        list_leagues[league.Index] = league.Value;
                    }
                }
            }
            Cmb_SeasonYear.DataSource = list_seasons;

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            GetApi api = new GetApi();
            #region Get data of seasons
            string sub_uri = Cmb_Item_1.Text;
            if (Cmb_Item_2.Enabled) sub_uri += "/" + Cmb_Item_2.Text;
            if (Cmb_Item_3.Enabled) sub_uri += "/" + Cmb_Item_3.Text;

            string file_name =String.Format(dir_json, sub_uri.Replace("/", "_"));
            if (File.Exists(file_name))
            {
                DialogResult result = MessageBox.Show("すでに" + sub_uri + "にファイルが存在します。\r\n上書きしますか？",
                    "ファイル上書き確認", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    api.Get_Api_Method_Async(sub_uri);
                    Make_File(file_name, "add");
                }
            }
            else
            {
                api.Get_Api_Method_Async(sub_uri);
                Make_File(file_name, "create");
            }
            #endregion
        }

        private void Cmb_Item_1_TextChanged(object sender, EventArgs e)
        {
            Cmb_Item_2.Text = string.Empty;
            Cmb_Item_3.Text = string.Empty;
            Cmb_Item_2.Items.Clear();
            Cmb_Item_3.Items.Clear();
            if(Cmb_Item_1.Text == "seasons")
            {
                Cmb_Item_2.Enabled = false;
                Cmb_Item_3.Enabled = false;
            }
            else if (Cmb_Item_1.Text == "leagues")
            {
                Cmb_Item_2.Enabled = false;
                Cmb_Item_3.Enabled = false;

            }
            else if (Cmb_Item_1.Text == "teams")
            {
                Cmb_Item_2.Enabled = true;
                Cmb_Item_3.Enabled = false;

            }
            else if (Cmb_Item_1.Text == "players")
            {
                Cmb_Item_2.Enabled = true;
                Cmb_Item_3.Enabled = false;

            }
            else if (Cmb_Item_1.Text == "games")
            {
                Cmb_Item_2.Enabled = true;
                Cmb_Item_3.Enabled = true;

            }
            else if (Cmb_Item_1.Text == "gameDetails")
            {
                Cmb_Item_2.Enabled = false;
                Cmb_Item_3.Enabled = false;

            }
            else if (Cmb_Item_1.Text == "standings")
            {
                Cmb_Item_2.Enabled = true;
                Cmb_Item_3.Enabled = true;
                Cmb_Item_2.DataSource = list_leagues;
                Cmb_Item_3.DataSource = list_seasons;

            }
            else if (Cmb_Item_1.Text == "statistics")
            {
                Cmb_Item_2.Enabled = true;
                Cmb_Item_3.Enabled = true;

            }
        }

        private void Make_File(string file_name, string state)
        {
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            using (StreamWriter writer = new StreamWriter(file_name, false, sjisEnc))
            {
                writer.WriteLine(json_body);
            }

            if (state == "add")
            {
                MessageBox.Show("ファイルを上書きしました。", "ファイル上書き確認", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("ファイルを作成しました。", "ファイル作成確認", MessageBoxButtons.OK);
            }
        }

        private void Btn_Show_Data_Click(object sender, EventArgs e)
        {
            string file_name = String.Format(dir_json, "games_gameId_" + Txt_Gameid.Text);
            if (File.Exists(file_name))
            {
                using (FileStream txt_json = File.OpenRead(file_name))
                {
                    Root_Gama root = JsonSerializer.Deserialize<Root_Gama>(txt_json);
                    foreach (var game in root.api.games)
                    {
                        #region vteam data
                        // vteam name
                        Lbl_Vteam_Name.Text = game.vTeam.fullName;

                        // vteam logo
                        string url = game.vTeam.logo.ToString();
                        using (WebClient webClient = new WebClient())
                        using (Stream stream = webClient.OpenRead(url))
                        {
                            Bitmap bitmap = new Bitmap(stream);
                            Pcb_Vteam.Image = bitmap;
                        }

                        // vteam score
                        lbl_Vteam_Score.Text = game.vTeam.score.points;
                        #endregion

                        #region hteam data
                        // hteam name
                        Lbl_Hteam_Name.Text = game.hTeam.fullName;

                        // hteam logo
                        url = game.hTeam.logo.ToString();
                        using (WebClient webClient = new WebClient())
                        using (Stream stream = webClient.OpenRead(url))
                        {
                            Bitmap bitmap = new Bitmap(stream);
                            Pcb_Hteam.Image = bitmap;
                        }

                        // hteam score
                        lbl_Hteam_Score.Text = game.hTeam.score.points;
                        #endregion

                    }


                }
            }
        }

        private void Btn_Show_Games_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            DataTable table = new DataTable("Table");
            string file_name = String.Format(dir_json, "games_seasonYear_" + Cmb_SeasonYear.Text);
            if (File.Exists(file_name))
            {
                using (FileStream txt_json = File.OpenRead(file_name))
                {
                    Root_Gama root = JsonSerializer.Deserialize<Root_Gama>(txt_json);
                    table.Columns.Add("gameId");
                    table.Columns.Add("league");
                    table.Columns.Add("startTime");
                    table.Columns.Add("statusGame");
                    table.Columns.Add("vteam nickName");
                    table.Columns.Add("hteam nickName");
                    //arena
                    //city
                    //country
                    foreach (var game in root.api.games)
                    {
                        table.Rows.Add(
                            game.gameId,
                            game.league,
                            game.startTimeUTC,
                            game.statusGame,
                            game.vTeam.nickName,
                            game.hTeam.nickName);
                    }
                    dataGridView1.DataSource = table;
                }
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Change_Game_Data();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Change_Game_Data();
        }

        private void Change_Game_Data()
        {
            string file_name = String.Format(dir_json, "games_seasonYear_" + Cmb_SeasonYear.Text);
            if (File.Exists(file_name) && dataGridView1.Rows.Count > 1)
            {
                using (FileStream txt_json = File.OpenRead(file_name))
                {
                    Root_Gama root = JsonSerializer.Deserialize<Root_Gama>(txt_json);
                    //arena
                    //city
                    //country
                    string gameid = String.Empty;
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        gameid = dataGridView1.Rows[item.Index].Cells[0].Value.ToString();
                    }

                    foreach (var game in root.api.games)
                    {
                        if (game.gameId == gameid)
                        {
                            #region vteam data
                            // vteam name
                            Lbl_Vteam_Name.Text = game.vTeam.fullName;

                            // vteam logo
                            string url = game.vTeam.logo.ToString();
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.Headers.Add("User-Agent: Other");
                                using (Stream stream = webClient.OpenRead(url))
                                {
                                    Bitmap bitmap = new Bitmap(stream);
                                    Pcb_Vteam.Image = bitmap;
                                }
                            }

                            // vteam score
                            lbl_Vteam_Score.Text = game.vTeam.score.points;
                            #endregion

                            #region hteam data
                            // hteam name
                            Lbl_Hteam_Name.Text = game.hTeam.fullName;

                            // hteam logo
                            url = game.hTeam.logo.ToString();
                            using (WebClient webClient = new WebClient())
                            {
                                webClient.Headers.Add("User-Agent: Other");
                                using (Stream stream = webClient.OpenRead(url))
                                {
                                    Bitmap bitmap = new Bitmap(stream);
                                    Pcb_Hteam.Image = bitmap;
                                }
                            }

                            // hteam score
                            lbl_Hteam_Score.Text = game.hTeam.score.points;
                            #endregion
                            break;
                        }
                    }
                }
            }
        }
    }
}
