using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            if (cboGills.SelectedIndex == -1 ||
                cboForest.SelectedIndex == -1 ||
                cboRing.SelectedIndex == -1 ||
                cboConvexCup.SelectedIndex == -1)
            {
                MessageBox.Show("Please answer all four questions.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool hasGills = cboGills.Text == "Yes";
            bool growsInForest = cboForest.Text == "Yes";
            bool hasRing = cboRing.Text == "Yes";
            bool hasConvexCup = cboConvexCup.Text == "Yes";

            string mushroom;

            if (hasGills && !growsInForest && hasRing && hasConvexCup)
                mushroom = "Agaric Jaunissant";
            else if (hasGills && growsInForest && hasRing && hasConvexCup)
                mushroom = "Amanite Tue-mouche";
            else if (!hasGills && growsInForest && !hasRing && !hasConvexCup)
                mushroom = "Cepe de Bordeau";
            else if (hasGills && !growsInForest && hasRing && !hasConvexCup)
                mushroom = "Coprin Chevelu";
            else if (hasGills && growsInForest && !hasRing && !hasConvexCup)
                mushroom = "Girolle";
            else if (hasGills && growsInForest && !hasRing && hasConvexCup)
                mushroom = "Pied Bleu";
            else
                mushroom = "No matching mushroom found.";

            MessageBox.Show("Identified Mushroom: " + mushroom,
                "Mushroom Identification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
    }
}
