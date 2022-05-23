using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace w13_Kei
{
    public partial class form_Player : Form
    {
        public form_Player()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public string sqlQuery1;
        public string sqlQuery2;
        public string cekTim="";
        public int urutan = 0;

        DataTable dtPlayer = new DataTable();
        DataTable dtNation = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtNumber = new DataTable();
        private void form_Player_Load(object sender, EventArgs e)
        {
            sqlQuery = "select player_id, player_name, birthdate, nation, team_name, team_number from player p, team t, nationality n where p.nationality_id =  n.nationality_id and p.team_id = t.team_id";
            sqlQuery1 = "select nation as 'Nations', nationality_id as 'ID Nation' from nationality";
            sqlCommand = new MySqlCommand(sqlQuery1, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNation);

            sqlQuery2 = "select team_name as 'Nama tim', team_id as 'ID Team' from team";
            sqlCommand = new MySqlCommand(sqlQuery2, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            tb_PlayerId.Text = dtPlayer.Rows[urutan]["player_id"].ToString();
            tb_PlayerName.Text = dtPlayer.Rows[urutan]["player_name"].ToString();
            dtp_Birth.Text = dtPlayer.Rows[urutan]["birthdate"].ToString();
            cb_Nation.Text = dtPlayer.Rows[urutan]["nation"].ToString();
            cb_Team.Text = dtPlayer.Rows[urutan]["team_name"].ToString();
            nup_TeamNumber.Value = Convert.ToInt16(dtPlayer.Rows[urutan]["team_number"]);

            cb_Nation.DataSource = dtNation;
            cb_Nation.DisplayMember = "Nations";
            cb_Nation.ValueMember = "ID Nation";

            cb_Team.DataSource = dtTeam;
            cb_Team.DisplayMember = "Nama Tim";
            cb_Team.ValueMember = "ID Team";
            cekTim = cb_Team.SelectedValue.ToString();
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            if (urutan == 0)
            {
                MessageBox.Show("Data sudah paling awal");
            }
            urutan = 0;
            tb_PlayerId.Text = dtPlayer.Rows[urutan]["player_id"].ToString();
            tb_PlayerName.Text = dtPlayer.Rows[urutan]["player_name"].ToString();
            dtp_Birth.Text = dtPlayer.Rows[urutan]["birthdate"].ToString();
            cb_Nation.Text = dtPlayer.Rows[urutan]["nation"].ToString();
            cb_Team.Text = dtPlayer.Rows[urutan]["team_name"].ToString();
            nup_TeamNumber.Value = Convert.ToInt16(dtPlayer.Rows[urutan]["team_number"]);
            cekTim = cb_Team.SelectedValue.ToString();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            if (urutan == 858)
            {
                MessageBox.Show("Data sudah paling akhir");
            }
            urutan = 858;
            tb_PlayerId.Text = dtPlayer.Rows[urutan]["player_id"].ToString();
            tb_PlayerName.Text = dtPlayer.Rows[urutan]["player_name"].ToString();
            dtp_Birth.Text = dtPlayer.Rows[urutan]["birthdate"].ToString();
            cb_Nation.Text = dtPlayer.Rows[urutan]["nation"].ToString();
            cb_Team.Text = dtPlayer.Rows[urutan]["team_name"].ToString();
            nup_TeamNumber.Value = Convert.ToInt16(dtPlayer.Rows[urutan]["team_number"]);
            cekTim = cb_Team.SelectedValue.ToString();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (urutan == 0)
            {
                MessageBox.Show("Data sudah paling awal");
            }
            else
            {
                urutan = urutan - 1;
                tb_PlayerId.Text = dtPlayer.Rows[urutan]["player_id"].ToString();
                tb_PlayerName.Text = dtPlayer.Rows[urutan]["player_name"].ToString();
                dtp_Birth.Text = dtPlayer.Rows[urutan]["birthdate"].ToString();
                cb_Nation.Text = dtPlayer.Rows[urutan]["nation"].ToString();
                cb_Team.Text = dtPlayer.Rows[urutan]["team_name"].ToString();
                nup_TeamNumber.Value = Convert.ToInt16(dtPlayer.Rows[urutan]["team_number"]);
                cekTim = cb_Team.SelectedValue.ToString();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (urutan == 858)
            {
                MessageBox.Show("Data sudah paling akhir");
            }
            else
            {
                urutan = urutan + 1;
                tb_PlayerId.Text = dtPlayer.Rows[urutan]["player_id"].ToString();
                tb_PlayerName.Text = dtPlayer.Rows[urutan]["player_name"].ToString();
                dtp_Birth.Text = dtPlayer.Rows[urutan]["birthdate"].ToString();
                cb_Nation.Text = dtPlayer.Rows[urutan]["nation"].ToString();
                cb_Team.Text = dtPlayer.Rows[urutan]["team_name"].ToString();
                nup_TeamNumber.Value = Convert.ToInt16(dtPlayer.Rows[urutan]["team_number"]);
                cekTim = cb_Team.SelectedValue.ToString();
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (lb_Available.Text == "Not Available")
            {     
                MessageBox.Show("Sudah ada Team Number");
            }
            else
            {
                sqlQuery = "update player set player_name = '" + tb_PlayerName.Text + "', birthdate = '" + dtp_Birth.Value.ToString("yyyyMMdd") + "', nationality_id = '" + cb_Nation.SelectedValue.ToString() + "', team_id = '" + cb_Team.SelectedValue.ToString() + "', team_number = '" + nup_TeamNumber.Value.ToString() + "' where player_id = '" + tb_PlayerId.Text + "'";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data sudah di update");
                sqlConnect.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nup_TeamNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string timID = cekTim;
                sqlQuery = "select p.player_name as `Name`, p.team_number as `Number` from team t, player p where p.team_id = t.team_id and t.team_id = '"+timID+"' having p.team_number = "+nup_TeamNumber.Value.ToString()+"";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtNumber);
                if (dtNumber.Rows.Count == 0)
                {
                    lb_Available.Text = "Available";
                }
                else
                {
                    lb_Available.Text = "Not Available";
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Salah");
            }
        }
    }
}
