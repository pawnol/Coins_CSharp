/*
 * Coins
 * Pawelski
 * 12/14/2021
 * This program should calculate the total money a person
 * has when they enter the number of pennies, nickels, dimes,
 * and quarters, but the program is missing code. Add the necessary 
 * code to finish the program.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coins
{
    public partial class CoinsForm : Form
    {
        public CoinsForm()
        {
            InitializeComponent();
        }

        /*
         * This will close the application when the "Exit" button
         * is clicked.
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * This will clear the text boxes and list box.
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            penniesTextBox.Text = "";
            nickelsTextBox.Text = "";
            dimesTextBox.Text = "";
            quartersTextBox.Text = "";
            moneyListBox.Items.Clear();
        }
    }
}
