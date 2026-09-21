using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp1
{
    public partial class SubjectAdd : Form
    {
        string cs =
            "Server=localhost;Port=3306;Database=school;Uid=root;Pwd=;";

        int studentId;

        public SubjectAdd()
        {
            InitializeComponent();
        }

        public SubjectAdd(string id, string name, string admissionNo)
            : this()
        {
            studentId = Convert.ToInt32(id);

            txtid.Text = id;
            txtStuName.Text = name;
            txtAddNo.Text = admissionNo;

            txtid.ReadOnly = true;
            txtStuName.ReadOnly = true;
            txtAddNo.ReadOnly = true;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    con.Open();
                    string sql = @"SELECT s.id, s.subject_name,EXISTS (SELECT 1 FROM student_subjects ss WHERE ss.subject_id = s.id AND ss.student_id = @studentId) AS saved FROM subjects s ORDER BY s.subject_name";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        lstSubjects.SelectionMode = SelectionMode.MultiSimple;
                        lstSubjects.DisplayMember = "subject_name";
                        lstSubjects.ValueMember = "id";
                        lstSubjects.DataSource = dt;
                        lstSubjects.ClearSelected();
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (Convert.ToInt32(dt.Rows[i]["saved"]) == 1)
                            {
                                lstSubjects.SetSelected(i, true);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot load subjects: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (studentId <= 0)
            {
                MessageBox.Show("Select a student first.");
                return;
            }

            if (lstSubjects.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a subject.");
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(cs))
                {
                    con.Open();

                    using (MySqlTransaction tr = con.BeginTransaction())
                    {
                        string sql = @"INSERT INTO student_subjects(student_id, subject_id, enrolled_on) SELECT @studentId, @subjectId, CURDATE()WHERE NOT EXISTS (SELECT 1 FROM student_subjects WHERE student_id = @studentId AND subject_id = @subjectId)";
                        using (MySqlCommand cmd = new MySqlCommand(sql, con, tr))
                        {
                            cmd.Parameters.AddWithValue("@studentId", studentId);
                            cmd.Parameters.Add("@subjectId", MySqlDbType.Int32);

                            foreach (DataRowView row in lstSubjects.SelectedItems)
                            {
                                cmd.Parameters["@subjectId"].Value = row["id"];
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tr.Commit();
                    }
                }

                MessageBox.Show("Subjects saved successfully.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot save subjects: " + ex.Message);
            }
        }
    }
}