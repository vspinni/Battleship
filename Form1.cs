using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Battleship2
{
    public partial class Form1 : Form
    {
        int p1spaces = 17;
        int p2spaces = 17;
        int turn_count = 0;
        int p1hits = 0;
        int p2hits = 0;
        bool isPlayer1 = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p1play.Hide();
            p2play.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = true;
            p2ships.Visible = false;
            p1play.Visible = false;
            p2play.Visible = false;
        }

        private void about_Click(object sender, EventArgs e)
        {

        }
        private void p1shipnext_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = false;
            p2ships.Visible = true;
            p1play.Visible = false;
            p2play.Visible = false;
        }
        private void p2shipnext_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = false;
            p2ships.Visible = false;
            p1play.Visible = true;
            p2play.Visible = false;
        }

        /*private void p1shipback_Click(object sender, EventArgs e)
        {
            start.Visible = true;
            p1ships.Visible = false;
            p2ships.Visible = false;
            p1play.Visible = false;
            p2play.Visible = false;
            start.BringToFront();
            start.Show();

        }*/

        private void p2shipback_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = true;
            p2ships.Visible = false;
            p1play.Visible = false;
            p2play.Visible = false;
        }

        private void p1playnext_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = false;
            p2ships.Visible = false;
            p1play.Visible = false;
            p2play.Visible = true;

        }
        private void p2playback_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = false;
            p2ships.Visible = false;
            p1play.Visible = true;
            p2play.Visible = false;

        }

        private void p1playback_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            p1ships.Visible = false;
            p2ships.Visible = true;
            p1play.Visible = false;
            p2play.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcome_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void creationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create by Shravan, Jon, Jacob, and Dani for CS302");
        }

        private void place_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "X";
            b.Enabled = false;
        }
        private void place1_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "X";
            b.Enabled = false;
            if (p1spaces > 0)
                p1spaces--;
            if (p1spaces == 0)
            {
                MessageBox.Show("Player 1 has placed all their ships!");
                S1A1.Enabled = false;
                S1A2.Enabled = false;
                S1A3.Enabled = false;
                S1A4.Enabled = false;
                S1A5.Enabled = false;
                S1A6.Enabled = false;
                S1A7.Enabled = false;
                S1A8.Enabled = false;
                S1A9.Enabled = false;
                S1A10.Enabled = false;
                S1B1.Enabled = false;
                S1B2.Enabled = false;
                S1B3.Enabled = false;
                S1B4.Enabled = false;
                S1B5.Enabled = false;
                S1B6.Enabled = false;
                S1B7.Enabled = false;
                S1B8.Enabled = false;
                S1B9.Enabled = false;
                S1B10.Enabled = false;
                S1C1.Enabled = false;
                S1C2.Enabled = false;
                S1C3.Enabled = false;
                S1C4.Enabled = false;
                S1C5.Enabled = false;
                S1C6.Enabled = false;
                S1C7.Enabled = false;
                S1C8.Enabled = false;
                S1C9.Enabled = false;
                S1C10.Enabled = false;
                S1D1.Enabled = false;
                S1D2.Enabled = false;
                S1D3.Enabled = false;
                S1D4.Enabled = false;
                S1D5.Enabled = false;
                S1D6.Enabled = false;
                S1D7.Enabled = false;
                S1D8.Enabled = false;
                S1D9.Enabled = false;
                S1D10.Enabled = false;
                S1E1.Enabled = false;
                S1E1.Enabled = false;
                S1E2.Enabled = false;
                S1E3.Enabled = false;
                S1E4.Enabled = false;
                S1E5.Enabled = false;
                S1E6.Enabled = false;
                S1E7.Enabled = false;
                S1E8.Enabled = false;
                S1E9.Enabled = false;
                S1E10.Enabled = false;
                S1F1.Enabled = false;
                S1F2.Enabled = false;
                S1F3.Enabled = false;
                S1F4.Enabled = false;
                S1F5.Enabled = false;
                S1F6.Enabled = false;
                S1F7.Enabled = false;
                S1F8.Enabled = false;
                S1F9.Enabled = false;
                S1F10.Enabled = false;
                S1G1.Enabled = false;
                S1G2.Enabled = false;
                S1G3.Enabled = false;
                S1G4.Enabled = false;
                S1G5.Enabled = false;
                S1G6.Enabled = false;
                S1G7.Enabled = false;
                S1G8.Enabled = false;
                S1G9.Enabled = false;
                S1G10.Enabled = false;
                S1G1.Enabled = false;
                S1H1.Enabled = false;
                S1H2.Enabled = false;
                S1H3.Enabled = false;
                S1H4.Enabled = false;
                S1H5.Enabled = false;
                S1H6.Enabled = false;
                S1H7.Enabled = false;
                S1H8.Enabled = false;
                S1H9.Enabled = false;
                S1H10.Enabled = false;
                S1I1.Enabled = false;
                S1I2.Enabled = false;
                S1I3.Enabled = false;
                S1I4.Enabled = false;
                S1I5.Enabled = false;
                S1I6.Enabled = false;
                S1I7.Enabled = false;
                S1I8.Enabled = false;
                S1I9.Enabled = false;
                S1I10.Enabled = false;
                S1J1.Enabled = false;
                S1J2.Enabled = false;
                S1J3.Enabled = false;
                S1J4.Enabled = false;
                S1J5.Enabled = false;
                S1J6.Enabled = false;
                S1J7.Enabled = false;
                S1J8.Enabled = false;
                S1J9.Enabled = false;
                S1J10.Enabled = false;
            }
        }

        private void place2_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "X";
            b.Enabled = false;
            if (p2spaces > 0)
                p2spaces--;
            if (p2spaces == 0)
            {
                MessageBox.Show("Player 2 has placed all their ships!");
                S2A1.Enabled = false;
                S2A2.Enabled = false;
                S2A3.Enabled = false;
                S2A4.Enabled = false;
                S2A5.Enabled = false;
                S2A6.Enabled = false;
                S2A7.Enabled = false;
                S2A8.Enabled = false;
                S2A9.Enabled = false;
                S2A10.Enabled = false;
                S2B1.Enabled = false;
                S2B2.Enabled = false;
                S2B3.Enabled = false;
                S2B4.Enabled = false;
                S2B5.Enabled = false;
                S2B6.Enabled = false;
                S2B7.Enabled = false;
                S2B8.Enabled = false;
                S2B9.Enabled = false;
                S2B10.Enabled = false;
                S2C1.Enabled = false;
                S2C2.Enabled = false;
                S2C3.Enabled = false;
                S2C4.Enabled = false;
                S2C5.Enabled = false;
                S2C6.Enabled = false;
                S2C7.Enabled = false;
                S2C8.Enabled = false;
                S2C9.Enabled = false;
                S2C10.Enabled = false;
                S2D1.Enabled = false;
                S2D2.Enabled = false;
                S2D3.Enabled = false;
                S2D4.Enabled = false;
                S2D5.Enabled = false;
                S2D6.Enabled = false;
                S2D7.Enabled = false;
                S2D8.Enabled = false;
                S2D9.Enabled = false;
                S2D10.Enabled = false;
                S2E1.Enabled = false;
                S2E1.Enabled = false;
                S2E2.Enabled = false;
                S2E3.Enabled = false;
                S2E4.Enabled = false;
                S2E5.Enabled = false;
                S2E6.Enabled = false;
                S2E7.Enabled = false;
                S2E8.Enabled = false;
                S2E9.Enabled = false;
                S2E10.Enabled = false;
                S2F1.Enabled = false;
                S2F2.Enabled = false;
                S2F3.Enabled = false;
                S2F4.Enabled = false;
                S2F5.Enabled = false;
                S2F6.Enabled = false;
                S2F7.Enabled = false;
                S2F8.Enabled = false;
                S2F9.Enabled = false;
                S2F10.Enabled = false;
                S2G1.Enabled = false;
                S2G2.Enabled = false;
                S2G3.Enabled = false;
                S2G4.Enabled = false;
                S2G5.Enabled = false;
                S2G6.Enabled = false;
                S2G7.Enabled = false;
                S2G8.Enabled = false;
                S2G9.Enabled = false;
                S2G10.Enabled = false;
                S2G1.Enabled = false;
                S2H1.Enabled = false;
                S2H2.Enabled = false;
                S2H3.Enabled = false;
                S2H4.Enabled = false;
                S2H5.Enabled = false;
                S2H6.Enabled = false;
                S2H7.Enabled = false;
                S2H8.Enabled = false;
                S2H9.Enabled = false;
                S2H10.Enabled = false;
                S2I1.Enabled = false;
                S2I2.Enabled = false;
                S2I3.Enabled = false;
                S2I4.Enabled = false;
                S2I5.Enabled = false;
                S2I6.Enabled = false;
                S2I7.Enabled = false;
                S2I8.Enabled = false;
                S2I9.Enabled = false;
                S2I10.Enabled = false;
                S2J1.Enabled = false;
                S2J2.Enabled = false;
                S2J3.Enabled = false;
                S2J4.Enabled = false;
                S2J5.Enabled = false;
                S2J6.Enabled = false;
                S2J7.Enabled = false;
                S2J8.Enabled = false;
                S2J9.Enabled = false;
                S2J10.Enabled = false;
            }
        }

        private void P1A1_Click(object sender, EventArgs e)
        {
            //Checks for a hit or miss in respective cell on other grid.
            Button b = (Button)sender;
            if (S2A1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A2_Click(object sender, EventArgs e)
        {
            //Checks for a hit or miss in respective cell on other grid.
            Button b = (Button)sender;
            if (S2A2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";

            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A3_Click(object sender, EventArgs e)
        {
            //Checks for a hit or miss in respective cell on other grid.
            Button b = (Button)sender;
            if (S2A3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";

            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1A10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2A10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1B10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2B10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void P1C2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1C10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2C10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1D10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2D10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1E10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2E10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1F10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2F10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1G10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2G10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1H10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2H10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I9.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1I10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2I10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J1.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J2.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J3.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J4.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J5.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J6.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J7.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J8.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P1J10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S2J10.Text == "X")
            {
                b.Text = "H";
                p1hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p1hits == 17)
            {
                MessageBox.Show("Player 1 Wins!");
            }
            else
            {
                p1play.Visible = false;
                p2play.Visible = true;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2A10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1A10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2B10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1B10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2C10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1C10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2D10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1D10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2E10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1E10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2F10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1F10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2G10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1G10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2H10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1H10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2I10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1I10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J1.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J2.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J3.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J4.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J5.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J6.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J7.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J8.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J9.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void P2J10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (S1J10.Text == "X")
            {
                b.Text = "H";
                p2hits++;
            }
            else
                b.Text = "M";
            //Increment Turn count.
            turn_count++;

            //Checking for a winner. Otherwise changing turn.
            if (p2hits == 17)
            {
                MessageBox.Show("Player 2 Wins!");
            }
            else
            {
                p1play.Visible = true;
                p2play.Visible = false;
            }

            //Disabling the button just pressed.
            b.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Resetting Variables.
            p1spaces = 17;
            p2spaces = 17;
            turn_count = 0;
            p1hits = 0;
            p2hits = 0;
            isPlayer1 = true;


            S1A1.Enabled = true;
            S1A2.Enabled = true;
            S1A3.Enabled = true;
            S1A4.Enabled = true;
            S1A5.Enabled = true;
            S1A6.Enabled = true;
            S1A7.Enabled = true;
            S1A8.Enabled = true;
            S1A9.Enabled = true;
            S1A10.Enabled = true;
            S1B1.Enabled = true;
            S1B2.Enabled = true;
            S1B3.Enabled = true;
            S1B4.Enabled = true;
            S1B5.Enabled = true;
            S1B6.Enabled = true;
            S1B7.Enabled = true;
            S1B8.Enabled = true;
            S1B9.Enabled = true;
            S1B10.Enabled = true;
            S1C1.Enabled = true;
            S1C2.Enabled = true;
            S1C3.Enabled = true;
            S1C4.Enabled = true;
            S1C5.Enabled = true;
            S1C6.Enabled = true;
            S1C7.Enabled = true;
            S1C8.Enabled = true;
            S1C9.Enabled = true;
            S1C10.Enabled = true;
            S1D1.Enabled = true;
            S1D2.Enabled = true;
            S1D3.Enabled = true;
            S1D4.Enabled = true;
            S1D5.Enabled = true;
            S1D6.Enabled = true;
            S1D7.Enabled = true;
            S1D8.Enabled = true;
            S1D9.Enabled = true;
            S1D10.Enabled = true;
            S1E1.Enabled = true;
            S1E2.Enabled = true;
            S1E3.Enabled = true;
            S1E4.Enabled = true;
            S1E5.Enabled = true;
            S1E6.Enabled = true;
            S1E7.Enabled = true;
            S1E8.Enabled = true;
            S1E9.Enabled = true;
            S1E10.Enabled = true;
            S1F1.Enabled = true;
            S1F2.Enabled = true;
            S1F3.Enabled = true;
            S1F4.Enabled = true;
            S1F5.Enabled = true;
            S1F6.Enabled = true;
            S1F7.Enabled = true;
            S1F8.Enabled = true;
            S1F9.Enabled = true;
            S1F10.Enabled = true;
            S1G1.Enabled = true;
            S1G2.Enabled = true;
            S1G3.Enabled = true;
            S1G4.Enabled = true;
            S1G5.Enabled = true;
            S1G6.Enabled = true;
            S1G7.Enabled = true;
            S1G8.Enabled = true;
            S1G9.Enabled = true;
            S1G10.Enabled = true;
            S1H1.Enabled = true;
            S1H2.Enabled = true;
            S1H3.Enabled = true;
            S1H4.Enabled = true;
            S1H5.Enabled = true;
            S1H6.Enabled = true;
            S1H7.Enabled = true;
            S1H8.Enabled = true;
            S1H9.Enabled = true;
            S1H10.Enabled = true;
            S1I1.Enabled = true;
            S1I2.Enabled = true;
            S1I3.Enabled = true;
            S1I4.Enabled = true;
            S1I5.Enabled = true;
            S1I6.Enabled = true;
            S1I7.Enabled = true;
            S1I8.Enabled = true;
            S1I9.Enabled = true;
            S1I10.Enabled = true;
            S1J1.Enabled = true;
            S1J2.Enabled = true;
            S1J3.Enabled = true;
            S1J4.Enabled = true;
            S1J5.Enabled = true;
            S1J6.Enabled = true;
            S1J7.Enabled = true;
            S1J8.Enabled = true;
            S1J9.Enabled = true;
            S1J10.Enabled = true;

            S2A1.Enabled = true;
            S2A2.Enabled = true;
            S2A3.Enabled = true;
            S2A4.Enabled = true;
            S2A5.Enabled = true;
            S2A6.Enabled = true;
            S2A7.Enabled = true;
            S2A8.Enabled = true;
            S2A9.Enabled = true;
            S2A10.Enabled = true;
            S2B1.Enabled = true;
            S2B2.Enabled = true;
            S2B3.Enabled = true;
            S2B4.Enabled = true;
            S2B5.Enabled = true;
            S2B6.Enabled = true;
            S2B7.Enabled = true;
            S2B8.Enabled = true;
            S2B9.Enabled = true;
            S2B10.Enabled = true;
            S2C1.Enabled = true;
            S2C2.Enabled = true;
            S2C3.Enabled = true;
            S2C4.Enabled = true;
            S2C5.Enabled = true;
            S2C6.Enabled = true;
            S2C7.Enabled = true;
            S2C8.Enabled = true;
            S2C9.Enabled = true;
            S2C10.Enabled = true;
            S2D1.Enabled = true;
            S2D2.Enabled = true;
            S2D3.Enabled = true;
            S2D4.Enabled = true;
            S2D5.Enabled = true;
            S2D6.Enabled = true;
            S2D7.Enabled = true;
            S2D8.Enabled = true;
            S2D9.Enabled = true;
            S2D10.Enabled = true;
            S2E1.Enabled = true;
            S2E2.Enabled = true;
            S2E3.Enabled = true;
            S2E4.Enabled = true;
            S2E5.Enabled = true;
            S2E6.Enabled = true;
            S2E7.Enabled = true;
            S2E8.Enabled = true;
            S2E9.Enabled = true;
            S2E10.Enabled = true;
            S2F1.Enabled = true;
            S2F2.Enabled = true;
            S2F3.Enabled = true;
            S2F4.Enabled = true;
            S2F5.Enabled = true;
            S2F6.Enabled = true;
            S2F7.Enabled = true;
            S2F8.Enabled = true;
            S2F9.Enabled = true;
            S2F10.Enabled = true;
            S2G1.Enabled = true;
            S2G2.Enabled = true;
            S2G3.Enabled = true;
            S2G4.Enabled = true;
            S2G5.Enabled = true;
            S2G6.Enabled = true;
            S2G7.Enabled = true;
            S2G8.Enabled = true;
            S2G9.Enabled = true;
            S2G10.Enabled = true;
            S2H1.Enabled = true;
            S2H2.Enabled = true;
            S2H3.Enabled = true;
            S2H4.Enabled = true;
            S2H5.Enabled = true;
            S2H6.Enabled = true;
            S2H7.Enabled = true;
            S2H8.Enabled = true;
            S2H9.Enabled = true;
            S2H10.Enabled = true;
            S2I1.Enabled = true;
            S2I2.Enabled = true;
            S2I3.Enabled = true;
            S2I4.Enabled = true;
            S2I5.Enabled = true;
            S2I6.Enabled = true;
            S2I7.Enabled = true;
            S2I8.Enabled = true;
            S2I9.Enabled = true;
            S2I10.Enabled = true;
            S2J1.Enabled = true;
            S2J2.Enabled = true;
            S2J3.Enabled = true;
            S2J4.Enabled = true;
            S2J5.Enabled = true;
            S2J6.Enabled = true;
            S2J7.Enabled = true;
            S2J8.Enabled = true;
            S2J9.Enabled = true;
            S2J10.Enabled = true;

            P1A1.Enabled = true;
            P1A2.Enabled = true;
            P1A3.Enabled = true;
            P1A4.Enabled = true;
            P1A5.Enabled = true;
            P1A6.Enabled = true;
            P1A7.Enabled = true;
            P1A8.Enabled = true;
            P1A9.Enabled = true;
            P1A10.Enabled = true;
            P1B1.Enabled = true;
            P1B2.Enabled = true;
            P1B3.Enabled = true;
            P1B4.Enabled = true;
            P1B5.Enabled = true;
            P1B6.Enabled = true;
            P1B7.Enabled = true;
            P1B8.Enabled = true;
            P1B9.Enabled = true;
            P1B10.Enabled = true;
            P1C1.Enabled = true;
            P1C2.Enabled = true;
            P1C3.Enabled = true;
            P1C4.Enabled = true;
            P1C5.Enabled = true;
            P1C6.Enabled = true;
            P1C7.Enabled = true;
            P1C8.Enabled = true;
            P1C9.Enabled = true;
            P1C10.Enabled = true;
            P1D1.Enabled = true;
            P1D2.Enabled = true;
            P1D3.Enabled = true;
            P1D4.Enabled = true;
            P1D5.Enabled = true;
            P1D6.Enabled = true;
            P1D7.Enabled = true;
            P1D8.Enabled = true;
            P1D9.Enabled = true;
            P1D10.Enabled = true;
            P1E1.Enabled = true;
            P1E2.Enabled = true;
            P1E3.Enabled = true;
            P1E4.Enabled = true;
            P1E5.Enabled = true;
            P1E6.Enabled = true;
            P1E7.Enabled = true;
            P1E8.Enabled = true;
            P1E9.Enabled = true;
            P1E10.Enabled = true;
            P1F1.Enabled = true;
            P1F2.Enabled = true;
            P1F3.Enabled = true;
            P1F4.Enabled = true;
            P1F5.Enabled = true;
            P1F6.Enabled = true;
            P1F7.Enabled = true;
            P1F8.Enabled = true;
            P1F9.Enabled = true;
            P1F10.Enabled = true;
            P1G1.Enabled = true;
            P1G2.Enabled = true;
            P1G3.Enabled = true;
            P1G4.Enabled = true;
            P1G5.Enabled = true;
            P1G6.Enabled = true;
            P1G7.Enabled = true;
            P1G8.Enabled = true;
            P1G9.Enabled = true;
            P1G10.Enabled = true;
            P1H1.Enabled = true;
            P1H2.Enabled = true;
            P1H3.Enabled = true;
            P1H4.Enabled = true;
            P1H5.Enabled = true;
            P1H6.Enabled = true;
            P1H7.Enabled = true;
            P1H8.Enabled = true;
            P1H9.Enabled = true;
            P1H10.Enabled = true;
            P1I1.Enabled = true;
            P1I2.Enabled = true;
            P1I3.Enabled = true;
            P1I4.Enabled = true;
            P1I5.Enabled = true;
            P1I6.Enabled = true;
            P1I7.Enabled = true;
            P1I8.Enabled = true;
            P1I9.Enabled = true;
            P1I10.Enabled = true;
            P1J1.Enabled = true;
            P1J2.Enabled = true;
            P1J3.Enabled = true;
            P1J4.Enabled = true;
            P1J5.Enabled = true;
            P1J6.Enabled = true;
            P1J7.Enabled = true;
            P1J8.Enabled = true;
            P1J9.Enabled = true;
            P1J10.Enabled = true;

            P2A1.Enabled = true;
            P2A2.Enabled = true;
            P2A3.Enabled = true;
            P2A4.Enabled = true;
            P2A5.Enabled = true;
            P2A6.Enabled = true;
            P2A7.Enabled = true;
            P2A8.Enabled = true;
            P2A9.Enabled = true;
            P2A10.Enabled = true;
            P2B1.Enabled = true;
            P2B2.Enabled = true;
            P2B3.Enabled = true;
            P2B4.Enabled = true;
            P2B5.Enabled = true;
            P2B6.Enabled = true;
            P2B7.Enabled = true;
            P2B8.Enabled = true;
            P2B9.Enabled = true;
            P2B10.Enabled = true;
            P2C1.Enabled = true;
            P2C2.Enabled = true;
            P2C3.Enabled = true;
            P2C4.Enabled = true;
            P2C5.Enabled = true;
            P2C6.Enabled = true;
            P2C7.Enabled = true;
            P2C8.Enabled = true;
            P2C9.Enabled = true;
            P2C10.Enabled = true;
            P2D1.Enabled = true;
            P2D2.Enabled = true;
            P2D3.Enabled = true;
            P2D4.Enabled = true;
            P2D5.Enabled = true;
            P2D6.Enabled = true;
            P2D7.Enabled = true;
            P2D8.Enabled = true;
            P2D9.Enabled = true;
            P2D10.Enabled = true;
            P2E1.Enabled = true;
            P2E2.Enabled = true;
            P2E3.Enabled = true;
            P2E4.Enabled = true;
            P2E5.Enabled = true;
            P2E6.Enabled = true;
            P2E7.Enabled = true;
            P2E8.Enabled = true;
            P2E9.Enabled = true;
            P2E10.Enabled = true;
            P2F1.Enabled = true;
            S2F2.Enabled = true;
            P2F3.Enabled = true;
            P2F4.Enabled = true;
            P2F5.Enabled = true;
            P2F6.Enabled = true;
            P2F7.Enabled = true;
            P2F8.Enabled = true;
            P2F9.Enabled = true;
            P2F10.Enabled = true;
            P2G1.Enabled = true;
            P2G2.Enabled = true;
            P2G3.Enabled = true;
            P2G4.Enabled = true;
            P2G5.Enabled = true;
            P2G6.Enabled = true;
            P2G7.Enabled = true;
            P2G8.Enabled = true;
            P2G9.Enabled = true;
            P2G10.Enabled = true;
            P2H1.Enabled = true;
            P2H2.Enabled = true;
            P2H3.Enabled = true;
            P2H4.Enabled = true;
            P2H5.Enabled = true;
            P2H6.Enabled = true;
            P2H7.Enabled = true;
            P2H8.Enabled = true;
            P2H9.Enabled = true;
            P2H10.Enabled = true;
            P2I1.Enabled = true;
            P2I2.Enabled = true;
            P2I3.Enabled = true;
            P2I4.Enabled = true;
            P2I5.Enabled = true;
            P2I6.Enabled = true;
            P2I7.Enabled = true;
            P2I8.Enabled = true;
            P2I9.Enabled = true;
            P2I10.Enabled = true;
            P2J1.Enabled = true;
            P2J2.Enabled = true;
            P2J3.Enabled = true;
            P2J4.Enabled = true;
            P2J5.Enabled = true;
            P2J6.Enabled = true;
            P2J7.Enabled = true;
            P2J8.Enabled = true;
            P2J9.Enabled = true;
            P2J10.Enabled = true;

            S1A1.Text = "";
            S1A2.Text = "";
            S1A3.Text = "";
            S1A4.Text = "";
            S1A5.Text = "";
            S1A6.Text = "";
            S1A7.Text = "";
            S1A8.Text = "";
            S1A9.Text = "";
            S1A10.Text = "";
            S1B1.Text = "";
            S1B2.Text = "";
            S1B3.Text = "";
            S1B4.Text = "";
            S1B5.Text = "";
            S1B6.Text = "";
            S1B7.Text = "";
            S1B8.Text = "";
            S1B9.Text = "";
            S1B10.Text = "";
            S1C1.Text = "";
            S1C2.Text = "";
            S1C3.Text = "";
            S1C4.Text = "";
            S1C5.Text = "";
            S1C6.Text = "";
            S1C7.Text = "";
            S1C8.Text = "";
            S1C9.Text = "";
            S1C10.Text = "";
            S1D1.Text = "";
            S1D2.Text = "";
            S1D3.Text = "";
            S1D4.Text = "";
            S1D5.Text = "";
            S1D6.Text = "";
            S1D7.Text = "";
            S1D8.Text = "";
            S1D9.Text = "";
            S1D10.Text = "";
            S1E1.Text = "";
            S1E2.Text = "";
            S1E3.Text = "";
            S1E4.Text = "";
            S1E5.Text = "";
            S1E6.Text = "";
            S1E7.Text = "";
            S1E8.Text = "";
            S1E9.Text = "";
            S1E10.Text = "";
            S1F1.Text = "";
            S1F2.Text = "";
            S1F3.Text = "";
            S1F4.Text = "";
            S1F5.Text = "";
            S1F6.Text = "";
            S1F7.Text = "";
            S1F8.Text = "";
            S1F9.Text = "";
            S1F10.Text = "";
            S1G1.Text = "";
            S1G2.Text = "";
            S1G3.Text = "";
            S1G4.Text = "";
            S1G5.Text = "";
            S1G6.Text = "";
            S1G7.Text = "";
            S1G8.Text = "";
            S1G9.Text = "";
            S1G10.Text = "";
            S1H1.Text = "";
            S1H2.Text = "";
            S1H3.Text = "";
            S1H4.Text = "";
            S1H5.Text = "";
            S1H6.Text = "";
            S1H7.Text = "";
            S1H8.Text = "";
            S1H9.Text = "";
            S1H10.Text = "";
            S1I1.Text = "";
            S1I2.Text = "";
            S1I3.Text = "";
            S1I4.Text = "";
            S1I5.Text = "";
            S1I6.Text = "";
            S1I7.Text = "";
            S1I8.Text = "";
            S1I9.Text = "";
            S1I10.Text = "";
            S1J1.Text = "";
            S1J2.Text = "";
            S1J3.Text = "";
            S1J4.Text = "";
            S1J5.Text = "";
            S1J6.Text = "";
            S1J7.Text = "";
            S1J8.Text = "";
            S1J9.Text = "";
            S1J10.Text = "";

            S2A1.Text = "";
            S2A2.Text = "";
            S2A3.Text = "";
            S2A4.Text = "";
            S2A5.Text = "";
            S2A6.Text = "";
            S2A7.Text = "";
            S2A8.Text = "";
            S2A9.Text = "";
            S2A10.Text = "";
            S2B1.Text = "";
            S2B2.Text = "";
            S2B3.Text = "";
            S2B4.Text = "";
            S2B5.Text = "";
            S2B6.Text = "";
            S2B7.Text = "";
            S2B8.Text = "";
            S2B9.Text = "";
            S2B10.Text = "";
            S2C1.Text = "";
            S2C2.Text = "";
            S2C3.Text = "";
            S2C4.Text = "";
            S2C5.Text = "";
            S2C6.Text = "";
            S2C7.Text = "";
            S2C8.Text = "";
            S2C9.Text = "";
            S2C10.Text = "";
            S2D1.Text = "";
            S2D2.Text = "";
            S2D3.Text = "";
            S2D4.Text = "";
            S2D5.Text = "";
            S2D6.Text = "";
            S2D7.Text = "";
            S2D8.Text = "";
            S2D9.Text = "";
            S2D10.Text = "";
            S2E1.Text = "";
            S2E2.Text = "";
            S2E3.Text = "";
            S2E4.Text = "";
            S2E5.Text = "";
            S2E6.Text = "";
            S2E7.Text = "";
            S2E8.Text = "";
            S2E9.Text = "";
            S2E10.Text = "";
            S2F1.Text = "";
            S2F2.Text = "";
            S2F3.Text = "";
            S2F4.Text = "";
            S2F5.Text = "";
            S2F6.Text = "";
            S2F7.Text = "";
            S2F8.Text = "";
            S2F9.Text = "";
            S2F10.Text = "";
            S2G1.Text = "";
            S2G2.Text = "";
            S2G3.Text = "";
            S2G4.Text = "";
            S2G5.Text = "";
            S2G6.Text = "";
            S2G7.Text = "";
            S2G8.Text = "";
            S2G9.Text = "";
            S2G10.Text = "";
            S2H1.Text = "";
            S2H2.Text = "";
            S2H3.Text = "";
            S2H4.Text = "";
            S2H5.Text = "";
            S2H6.Text = "";
            S2H7.Text = "";
            S2H8.Text = "";
            S2H9.Text = "";
            S2H10.Text = "";
            S2I1.Text = "";
            S2I2.Text = "";
            S2I3.Text = "";
            S2I4.Text = "";
            S2I5.Text = "";
            S2I6.Text = "";
            S2I7.Text = "";
            S2I8.Text = "";
            S2I9.Text = "";
            S2I10.Text = "";
            S2J1.Text = "";
            S2J2.Text = "";
            S2J3.Text = "";
            S2J4.Text = "";
            S2J5.Text = "";
            S2J6.Text = "";
            S2J7.Text = "";
            S2J8.Text = "";
            S2J9.Text = "";
            S2J10.Text = "";

            P1A1.Text = "";
            P1A2.Text = "";
            P1A3.Text = "";
            P1A4.Text = "";
            P1A5.Text = "";
            P1A6.Text = "";
            P1A7.Text = "";
            P1A8.Text = "";
            P1A9.Text = "";
            P1A10.Text = "";
            P1B1.Text = "";
            P1B2.Text = "";
            P1B3.Text = "";
            P1B4.Text = "";
            P1B5.Text = "";
            P1B6.Text = "";
            P1B7.Text = "";
            P1B8.Text = "";
            P1B9.Text = "";
            P1B10.Text = "";
            P1C1.Text = "";
            P1C2.Text = "";
            P1C3.Text = "";
            P1C4.Text = "";
            P1C5.Text = "";
            P1C6.Text = "";
            P1C7.Text = "";
            P1C8.Text = "";
            P1C9.Text = "";
            P1C10.Text = "";
            P1D1.Text = "";
            P1D2.Text = "";
            P1D3.Text = "";
            P1D4.Text = "";
            P1D5.Text = "";
            P1D6.Text = "";
            P1D7.Text = "";
            P1D8.Text = "";
            P1D9.Text = "";
            P1D10.Text = "";
            P1E1.Text = "";
            P1E2.Text = "";
            P1E3.Text = "";
            P1E4.Text = "";
            P1E5.Text = "";
            P1E6.Text = "";
            P1E7.Text = "";
            P1E8.Text = "";
            P1E9.Text = "";
            P1E10.Text = "";
            P1F1.Text = "";
            P1F2.Text = "";
            P1F3.Text = "";
            P1F4.Text = "";
            P1F5.Text = "";
            P1F6.Text = "";
            P1F7.Text = "";
            P1F8.Text = "";
            P1F9.Text = "";
            P1F10.Text = "";
            P1G1.Text = "";
            P1G2.Text = "";
            P1G3.Text = "";
            P1G4.Text = "";
            P1G5.Text = "";
            P1G6.Text = "";
            P1G7.Text = "";
            P1G8.Text = "";
            P1G9.Text = "";
            P1G10.Text = "";
            P1H1.Text = "";
            P1H2.Text = "";
            P1H3.Text = "";
            P1H4.Text = "";
            P1H5.Text = "";
            P1H6.Text = "";
            P1H7.Text = "";
            P1H8.Text = "";
            P1H9.Text = "";
            P1H10.Text = "";
            P1I1.Text = "";
            P1I2.Text = "";
            P1I3.Text = "";
            P1I4.Text = "";
            P1I5.Text = "";
            P1I6.Text = "";
            P1I7.Text = "";
            P1I8.Text = "";
            P1I9.Text = "";
            P1I10.Text = "";
            P1J1.Text = "";
            P1J2.Text = "";
            P1J3.Text = "";
            P1J4.Text = "";
            P1J5.Text = "";
            P1J6.Text = "";
            P1J7.Text = "";
            P1J8.Text = "";
            P1J9.Text = "";
            P1J10.Text = "";

            P2A1.Text = "";
            P2A2.Text = "";
            P2A3.Text = "";
            P2A4.Text = "";
            P2A5.Text = "";
            P2A6.Text = "";
            P2A7.Text = "";
            P2A8.Text = "";
            P2A9.Text = "";
            P2A10.Text = "";
            P2B1.Text = "";
            P2B2.Text = "";
            P2B3.Text = "";
            P2B4.Text = "";
            P2B5.Text = "";
            P2B6.Text = "";
            P2B7.Text = "";
            P2B8.Text = "";
            P2B9.Text = "";
            P2B10.Text = "";
            P2C1.Text = "";
            P2C2.Text = "";
            P2C3.Text = "";
            P2C4.Text = "";
            P2C5.Text = "";
            P2C6.Text = "";
            P2C7.Text = "";
            P2C8.Text = "";
            P2C9.Text = "";
            P2C10.Text = "";
            P2D1.Text = "";
            P2D2.Text = "";
            P2D3.Text = "";
            P2D4.Text = "";
            P2D5.Text = "";
            P2D6.Text = "";
            P2D7.Text = "";
            P2D8.Text = "";
            P2D9.Text = "";
            P2D10.Text = "";
            P2E1.Text = "";
            P2E2.Text = "";
            P2E3.Text = "";
            P2E4.Text = "";
            P2E5.Text = "";
            P2E6.Text = "";
            P2E7.Text = "";
            P2E8.Text = "";
            P2E9.Text = "";
            P2E10.Text = "";
            P2F1.Text = "";
            P2F2.Text = "";
            P2F3.Text = "";
            P2F4.Text = "";
            P2F5.Text = "";
            P2F6.Text = "";
            P2F7.Text = "";
            P2F8.Text = "";
            P2F9.Text = "";
            P2F10.Text = "";
            P2G1.Text = "";
            P2G2.Text = "";
            P2G3.Text = "";
            P2G4.Text = "";
            P2G5.Text = "";
            P2G6.Text = "";
            P2G7.Text = "";
            P2G8.Text = "";
            P2G9.Text = "";
            P2G10.Text = "";
            P2H1.Text = "";
            P2H2.Text = "";
            P2H3.Text = "";
            P2H4.Text = "";
            P2H5.Text = "";
            P2H6.Text = "";
            P2H7.Text = "";
            P2H8.Text = "";
            P2H9.Text = "";
            P2H10.Text = "";
            P2I1.Text = "";
            P2I2.Text = "";
            P2I3.Text = "";
            P2I4.Text = "";
            P2I5.Text = "";
            P2I6.Text = "";
            P2I7.Text = "";
            P2I8.Text = "";
            P2I9.Text = "";
            P2I10.Text = "";
            P2J1.Text = "";
            P2J2.Text = "";
            P2J3.Text = "";
            P2J4.Text = "";
            P2J5.Text = "";
            P2J6.Text = "";
            P2J7.Text = "";
            P2J8.Text = "";
            P2J9.Text = "";
            P2J10.Text = "";

        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Text box of the rules.
            MessageBox.Show("How to Play Battleship:\n1. Each player gets 5 ships to place of lengths: " +
                "2,3,3,4 and 5.\n2. The ships cannot be placed immediately next to each other. Ship " +
                "placement is marked with an X." +"\n3. Afterward they take turns attempting to hit each" +
                " others ships. A hit is marked as H and a miss as M." + "\n4. The one who sinks all of the" +
                " opponent's ships first wins.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
