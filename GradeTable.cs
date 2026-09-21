using MySqlConnector;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using WinFormsApp1.DAL;

namespace WinFormsApp1
{
    public partial class GradeTable : Form
    {
        string connString =
            ConfigurationManager.ConnectionStrings["MyDbConnection"]
            ?.ConnectionString ?? string.Empty;

        public GradeTable()
        {
            InitializeComponent();
        }

        private async Task LoadGrade()
        {
            GradeDAL gradeDAL = new GradeDAL();

            DataTable dt =await gradeDAL.GetAll();

            dgvAllGrades.DataSource = dt;
        }

        private string GetSelectedId()
        {
            if (dgvAllGrades.CurrentRow == null ||
                dgvAllGrades.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a grade.");
                return string.Empty;
            }

            string id = Convert.ToString(
                dgvAllGrades.CurrentRow.Cells["id"].Value);

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Selected grade has no ID.");
                return string.Empty;
            }

            return id;
        }

        private void ShowGrade()
        {
            string id = GetSelectedId();

            if (string.IsNullOrWhiteSpace(id))
            {
                return;
            }

            using (frmShowGrade frm = new frmShowGrade(id))
            {
                frm.ShowDialog();
            }
        }

        private void EditGrade()
        {
            string id = GetSelectedId();

            if (string.IsNullOrWhiteSpace(id))
            {
                return;
            }

            using (frmEditGrade frm = new frmEditGrade(id))
            {
                frm.ShowDialog();
            }

            LoadGrade();
        }

        private async void DeleteGrade()
        {
            string id = GetSelectedId();

            if (string.IsNullOrWhiteSpace(id))
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this grade?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                GradeDAL gradeDAL = new GradeDAL();

                bool deleted = await gradeDAL.DeleteAsync(id);

                if (deleted)
                {
                    MessageBox.Show("Grade deleted successfully.");

                    LoadGrade();
                }
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(connString))
            {
                MessageBox.Show("MyDbConnection is missing in App.config.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    MessageBox.Show("Connection successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllGrades_Click(object sender, EventArgs e)
        {
            try
            {
                LoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                ShowGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                EditGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                DeleteGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmCreateGrade frm = new frmCreateGrade())
                {
                    frm.ShowDialog();
                }

                LoadGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}