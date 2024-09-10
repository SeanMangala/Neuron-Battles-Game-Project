using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Sean Mangala
//Date: 2024-04-12
//Purpose: Main menu form
namespace Assignment2Final
{
    public partial class mainMenu : Form
    {
        //Creates an object of Form1 (game screen)
        Form1 gameScreen = new Form1();
        public mainMenu()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameScreen.ShowDialog();
        }

        private void instructionsBtn_Click(object sender, EventArgs e)
        {
            gameScreen.showInstructions();
        }
    }
}
