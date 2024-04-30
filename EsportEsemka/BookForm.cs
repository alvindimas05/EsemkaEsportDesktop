using EsportEsemka.databaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportEsemka
{
    public partial class BookForm : Form
    {
        private teamTableAdapter teamTableAdapter;
        public int home_team_id = 1;
        public int away_team_id = 2;
        public BookForm()
        {
            InitializeComponent();
            teamTableAdapter = new teamTableAdapter();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            playerByTeamIdTableAdapter.FillById(databaseDataSetHome.player_by_team_id, home_team_id);
            playerByTeamIdTableAdapter.FillById(databaseDataSetAway.player_by_team_id, away_team_id);

            var homeData = teamTableAdapter.GetDataById(home_team_id)[0];
            labelCompanyHome.Text = homeData.company_name;
            labelTeamHome.Text = homeData.team_name;

            var awayData = teamTableAdapter.GetDataById(away_team_id)[0];
            labelCompanyAway.Text = awayData.company_name;
            labelTeamAway.Text = awayData.team_name;

        }
    }
}
