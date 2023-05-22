using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControls
{
    public partial class Form1 : Form
    {
        private TabPage tabPage3;

        public Form1()
        {
            InitializeComponent();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage3)
            {
                tabPage3.BackColor = Color.Green;
            }
            else if(tabControl1.SelectedTab == second_tab)
            {
                second_tab.BackColor = Color.Yellow;
            }
        }
        private void pictureBox3_BackgroundImageChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTeam.Text == "" || txtMember1.Text == "" || txtMember2.Text == "" || txtMember3.Text == "" || txtMember4.Text == "" || txtMember5.Text == "")
            {
                MessageBox.Show("Please enter a player name");
            }
            else
            {
                File.AppendAllLines("Player.txt", new string[] { txtTeam.Text + " Member names: " + txtMember1.Text + " , " + txtMember2.Text + " , " + txtMember3.Text + " , " + txtMember4.Text + " , " + txtMember5.Text + " , " });
                txtTeam.Text = "";
                MessageBox.Show("New player added");
                ShowData();
            }
        }
            void ShowData()
        {
            lstPlayer.Items.Clear();
            foreach (string line in File.ReadLines(@"Player.txt", Encoding.UTF8))
            {
                // process the line
                lstPlayer.Items.Add(line);
            }
            lstPlayer.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Scores scr = new Scores();
            scr.Show();
        }
    }
}
