using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TournamentMgr_Deidre;

namespace DeidreDevelopingWindowsApplication
{
    public partial class teamFrm : Form
    {
        string connectionString = "Data Source = INSTRUCTORIT; Initial Catalog = TournamentManager; Persist Security Info=True;User ID = ProfileUser; Password=ProfileUser2019";
        private string user = "Deidre";
        public teamFrm()
        {
            InitializeComponent();
        }

        private void TeamFrm_Load(object sender, EventArgs e)
        {
            LoadTeams();

        }

        private void LoadTeams()
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = connectionString;

            try
            {
                myConnection.Open();
                string query = "Select * from Teams order by TeamId desc";
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = query;

                DataTable teams = new DataTable();

                teams.Columns.Add(new DataColumn("TeamId"));
                teams.Columns.Add(new DataColumn("TeamName"));
                teams.Columns.Add(new DataColumn("CoachName"));
                teams.Columns.Add(new DataColumn("DirectorName"));
                teams.Columns.Add(new DataColumn("AddressLine1"));
                teams.Columns.Add(new DataColumn("AddressLine2"));
                teams.Columns.Add(new DataColumn("PostCode"));
                teams.Columns.Add(new DataColumn("City"));
                teams.Columns.Add(new DataColumn("ContactNumber"));
                teams.Columns.Add(new DataColumn("EmailAddress"));
                teams.Columns.Add(new DataColumn("CreatedBy"));

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    DataRow team = teams.NewRow();
                    team["TeamId"] = myReader["TeamId"];
                    team["TeamName"] = myReader["TeamName"];
                    team["CoachName"] = myReader["CoachName"];
                    team["DirectorName"] = myReader["DirectorName"];
                    team["AddressLine1"] = myReader["AddressLine1"];
                    team["AddressLine2"] = myReader["AddressLine2"];
                    team["PostCode"] = myReader["PostCode"];
                    team["City"] = myReader["City"];
                    team["ContactNumber"] = myReader["ContactNumber"];
                    team["EmailAddress"] = myReader["EmailAddress"];
                    team["CreatedBy"] = myReader["CreatedBy"];
                    teams.Rows.Add(team);
                }

                teamsGridView.DataSource = teams;
                teamsGridView.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                myConnection.Close();
            }
        }

        private void InsertUpdateBtn_Click(object sender, EventArgs e)
        {
            string msgValidation = getMsgValidations();

            if (msgValidation == string.Empty)
            {
                DataRowView teamRow;
                try
                {
                    teamRow = (DataRowView)teamsGridView.SelectedRows[0].DataBoundItem;
                    int id = Convert.ToInt32(teamRow.Row[0]);
                    string userName = teamRow.Row[10].ToString();
                    UpdateTeam(id, userName);
                }
                catch
                {
                    InsertTeam();
                }

                LoadTeams();
            }
            else
            {
                MessageBox.Show("The next fields are mandatory: " + msgValidation);
            }


        }

        private string getMsgValidations()
        {
            string msg = string.Empty;
            if (teamNameTxt.Text == string.Empty)
            {
                msg += " Team Name ";
            }
            if (coachNameTxt.Text == string.Empty)
            {
                msg += " Coach Name ";
            }
            if (directorNameTxt.Text == string.Empty)
            {
                msg += " Director Name ";
            }
            if (addressLine1Txt.Text == string.Empty)
            {
                msg += " Address line 1 ";
            }
            if (postCodeTxt.Text == string.Empty)
            {
                msg += " Post Code ";
            }
            if (cityTxt.Text == string.Empty)
            {
                msg += " City ";
            }
            if (contactNumberTxt.Text == string.Empty)
            {
                msg += " Contact Number ";
            }
            if (emailAddressTxt.Text == string.Empty)
            {
                msg += " Email Address ";
            }

            return msg;
        }

        private void UpdateTeam(int id, string userName)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            Team team = new Team()
            {
                TeamName = teamNameTxt.Text,
                CoachName = coachNameTxt.Text,
                DirectorName = directorNameTxt.Text,
                AddressLine1 = addressLine1Txt.Text,
                AddressLine2 = addressLine2Txt.Text,
                PostCode = postCodeTxt.Text,
                City = cityTxt.Text,
                ContactNumber = contactNumberTxt.Text,
                EmailAddress = emailAddressTxt.Text,
                CreatedBy = userName,
            };

            string qry = @"UPDATE [dbo].[Teams]
   SET [TeamName] = '{0}'
      ,[CoachName] = '{1}'
      ,[DirectorName] = '{2}'
      ,[AddressLine1] = '{3}'
      ,[AddressLine2] = '{4}'
      ,[PostCode] = '{5}'
      ,[City] = '{6}'
      ,[ContactNumber] = '{7}'
      ,[EmailAddress] = '{8}'
      ,[CreatedBy] = '{9}'
 WHERE TeamId = '{10}'";

            string command = string.Format(
                qry, team.TeamName,
                team.CoachName,
                team.DirectorName,
                team.AddressLine1,
                team.AddressLine2,
                team.PostCode,
                team.City,
                team.ContactNumber,
                team.EmailAddress,
                team.CreatedBy,
                id
                );

            SqlCommand cmd = new SqlCommand(command, cn);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void InsertTeam()
        {
            SqlConnection cn = new SqlConnection(connectionString);
            string now = DateTime.Now.ToString("yyyy /M/dd hh:mm:ss");

            Team team = new Team()
            {
                TeamName = teamNameTxt.Text,
                CoachName = coachNameTxt.Text,
                DirectorName = directorNameTxt.Text,
                AddressLine1 = addressLine1Txt.Text,
                AddressLine2 = addressLine2Txt.Text,
                PostCode = postCodeTxt.Text,
                City = cityTxt.Text,
                ContactNumber = contactNumberTxt.Text,
                EmailAddress = emailAddressTxt.Text,
                CreatedBy = user
            };

            string qry = @"INSERT INTO [dbo].[Teams]
           ([TeamName]
           ,[CoachName]
           ,[DirectorName]
           ,[AddressLine1]
           ,[AddressLine2]
           ,[PostCode]
           ,[City]
           ,[ContactNumber]
           ,[EmailAddress]
           ,[CreatedBy])
     VALUES
           ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')";

            string command = string.Format(
                qry, team.TeamName,
                team.CoachName,
                team.DirectorName,
                team.AddressLine1,
                team.AddressLine2,
                team.PostCode,
                team.City,
                team.ContactNumber,
                team.EmailAddress,
                team.CreatedBy
                );

            SqlCommand cmd = new SqlCommand(command, cn);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void TeamsGridView_SelectionChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("jojo");
        }

        private void TeamsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView incidenceRow = (DataRowView)teamsGridView.SelectedRows[0].DataBoundItem;
            Team team = new Team()
            {
                TeamId = Convert.ToInt32(incidenceRow.Row[0]),
                TeamName = incidenceRow.Row[1].ToString(),
                CoachName = incidenceRow.Row[2].ToString(),
                DirectorName = incidenceRow.Row[3].ToString(),
                AddressLine1 = incidenceRow.Row[4].ToString(),
                AddressLine2 = incidenceRow.Row[5].ToString(),
                PostCode = incidenceRow.Row[6].ToString(),
                City = incidenceRow.Row[7].ToString(),
                ContactNumber = incidenceRow.Row[8].ToString(),
                EmailAddress = incidenceRow.Row[9].ToString(),
                CreatedBy = incidenceRow.Row[10].ToString(),
            };

            teamNameTxt.Text = team.TeamName;
            coachNameTxt.Text = team.CoachName;
            directorNameTxt.Text = team.DirectorName;
            addressLine1Txt.Text = team.AddressLine1;
            addressLine2Txt.Text = team.AddressLine2;
            postCodeTxt.Text = team.PostCode;
            cityTxt.Text = team.City;
            contactNumberTxt.Text = team.ContactNumber;
            emailAddressTxt.Text = team.EmailAddress;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            teamNameTxt.Text = "";
            coachNameTxt.Text = "";
            directorNameTxt.Text = "";
            addressLine1Txt.Text = "";
            addressLine2Txt.Text = "";
            postCodeTxt.Text = "";
            cityTxt.Text = "";
            contactNumberTxt.Text = "";
            emailAddressTxt.Text = "";
            teamsGridView.ClearSelection();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (teamsGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                    "Confirm Delete!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DataRowView itemToDelete = (DataRowView)teamsGridView.SelectedRows[0].DataBoundItem;
                int idToDelete = Convert.ToInt32(itemToDelete.Row[0]);

                SqlConnection myConnection = new SqlConnection();
                myConnection.ConnectionString = connectionString;
                try
                {
                    string query = "DELETE FROM Teams WHERE TeamId = {0}";
                    query = String.Format(query,
                        idToDelete);
                    myConnection.Open();

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = myConnection;
                    sqlCommand.CommandText = query;
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (myConnection.State == ConnectionState.Open)
                    {
                        myConnection.Close();
                    }


                }

                LoadTeams();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeamNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostCodeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
