using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards__project_s_form
{
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
        }

        //ShowCard method to accept a string that names selected card, displays that card
        private void ShowCard(string card) // variable parameter is string named card
        {
            switch (card) //  if card is equal to " ", show cards corresponding to that string
            {
                case "Ace of Spades":
                    ShowAceSpades(); //Calling ShowAceSpades method
                    break;
                case "10 of Hearts":
                    ShowTenHearts(); // calling ShowTenHearts method
                    break;
                case "King of Clubs":
                    ShowKingClubs(); // calling ShowKingClubs method
                    break;
            }
        }

        private void ShowAceSpades() // ShowAceSpades method to only show spades card
        {
            aceSpadesPictureBox.Visible = true; //spades card is visible
            tenHeartsPictureBox.Visible = false; // invisible for the others
            kingClubsPictureBox.Visible = false;
        }

        private void ShowTenHearts() // ShowTenHearts method to only show heart card
        {
            tenHeartsPictureBox.Visible = true; // heart card visible
            aceSpadesPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        private void ShowKingClubs() // ShowKingClubs method to only show king card
        {
            kingClubsPictureBox.Visible = true; // king card visible
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
        }

        private void showCardButton_Click(object sender, EventArgs e) // event handler method to display selected card in ListBox
        {
            if (cardListBox.SelectedIndex != -1)
            {
                ShowCard(cardListBox.SelectedItem.ToString()); // calling ShowCard method           
            }
            else
            {
                MessageBox.Show("Please select a card from the list box."); // if user doesn't choose string from ListBox
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
