using FGC_validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidationsTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            Charity charity = new Charity();

            using (CharitySelection f = new CharitySelection())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    charity = f.DataItem;
                }
            }
        }

        private void button2_Click(Object sender, EventArgs e)
        {
            Chest chest = new Chest();

            using (ChestSelection f = new ChestSelection())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    chest = f.DataItem;
                }
            }
        }

        private void button3_Click(Object sender, EventArgs e)
        {
            Lodge lodge = new Lodge();

            using (LodgeSelection f = new LodgeSelection())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    lodge = f.DataItem;
                }
            }
        }

        private void button4_Click(Object sender, EventArgs e)
        {
            Member member = new Member();

            using (MemberSelection f = new MemberSelection())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    member = f.DataItem;
                }
            }
        }

        private void button5_Click(Object sender, EventArgs e)
        {
            try
            {
                // Provider=OraOLEDB.Oracle;Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;
                using (System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;"))
                {
                    connection.Open();

                    MessageBox.Show("Connected successfully.");

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed with error: {ex.Message}");
            }
        }
    }
}

