using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startHour;
            int endHour;

            if (!int.TryParse(txtStartTime.Text, out startHour) ||
                !int.TryParse(txtEndTime.Text, out endHour))
            {
                MessageBox.Show("Please enter valid integer hours.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startHour < 0 || startHour > 23)
            {
                MessageBox.Show("Start hour must be between 0 and 23.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (endHour < 1 || endHour > 24)
            {
                MessageBox.Show("End hour must be between 1 and 24.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startHour >= endHour)
            {
                MessageBox.Show("Start hour must be less than end hour.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int totalCost = 0;

            for (int hour = startHour; hour < endHour; hour++)
            {
                if (hour < 7)
                    totalCost += 500;
                else if (hour < 14)
                    totalCost += 1000;
                else if (hour < 19)
                    totalCost += 1500;
                else if (hour < 21)
                    totalCost += 1000;
                else
                    totalCost += 500;
            }

            txtTotal.Text = totalCost.ToString() + " RWF";

            MessageBox.Show("Total Bicycle Rental Cost: " + totalCost + " RWF",
                "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
