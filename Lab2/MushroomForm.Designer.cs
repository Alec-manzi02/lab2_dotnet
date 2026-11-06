namespace Lab2
{
    partial class MushroomForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGills;
        private System.Windows.Forms.Label lblForest;
        private System.Windows.Forms.Label lblRing;
        private System.Windows.Forms.Label lblConvexCup;
        private System.Windows.Forms.ComboBox cboGills;
        private System.Windows.Forms.ComboBox cboForest;
        private System.Windows.Forms.ComboBox cboRing;
        private System.Windows.Forms.ComboBox cboConvexCup;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGills = new System.Windows.Forms.Label();
            this.lblForest = new System.Windows.Forms.Label();
            this.lblRing = new System.Windows.Forms.Label();
            this.lblConvexCup = new System.Windows.Forms.Label();
            this.cboGills = new System.Windows.Forms.ComboBox();
            this.cboForest = new System.Windows.Forms.ComboBox();
            this.cboRing = new System.Windows.Forms.ComboBox();
            this.cboConvexCup = new System.Windows.Forms.ComboBox();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(94, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(236, 30);
            this.lblTitle.Text = "MUSHROOM IDENTIFIER";
            this.lblGills.AutoSize = true;
            this.lblGills.Location = new System.Drawing.Point(35, 91);
            this.lblGills.Name = "lblGills";
            this.lblGills.Size = new System.Drawing.Size(111, 15);
            this.lblGills.Text = "Does it have gills?";
            this.lblForest.AutoSize = true;
            this.lblForest.Location = new System.Drawing.Point(35, 139);
            this.lblForest.Name = "lblForest";
            this.lblForest.Size = new System.Drawing.Size(141, 15);
            this.lblForest.Text = "Does it grow in a forest?";
            this.lblRing.AutoSize = true;
            this.lblRing.Location = new System.Drawing.Point(35, 187);
            this.lblRing.Name = "lblRing";
            this.lblRing.Size = new System.Drawing.Size(108, 15);
            this.lblRing.Text = "Does it have a ring?";
            this.lblConvexCup.AutoSize = true;
            this.lblConvexCup.Location = new System.Drawing.Point(35, 235);
            this.lblConvexCup.Name = "lblConvexCup";
            this.lblConvexCup.Size = new System.Drawing.Size(139, 15);
            this.lblConvexCup.Text = "Does it have a convex cup?";
            this.cboGills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGills.FormattingEnabled = true;
            this.cboGills.Items.AddRange(new object[] { "Yes", "No" });
            this.cboGills.Location = new System.Drawing.Point(225, 87);
            this.cboGills.Name = "cboGills";
            this.cboGills.Size = new System.Drawing.Size(145, 23);
            this.cboForest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboForest.FormattingEnabled = true;
            this.cboForest.Items.AddRange(new object[] { "Yes", "No" });
            this.cboForest.Location = new System.Drawing.Point(225, 135);
            this.cboForest.Name = "cboForest";
            this.cboForest.Size = new System.Drawing.Size(145, 23);
            this.cboRing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRing.FormattingEnabled = true;
            this.cboRing.Items.AddRange(new object[] { "Yes", "No" });
            this.cboRing.Location = new System.Drawing.Point(225, 183);
            this.cboRing.Name = "cboRing";
            this.cboRing.Size = new System.Drawing.Size(145, 23);
            this.cboConvexCup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvexCup.FormattingEnabled = true;
            this.cboConvexCup.Items.AddRange(new object[] { "Yes", "No" });
            this.cboConvexCup.Location = new System.Drawing.Point(225, 231);
            this.cboConvexCup.Name = "cboConvexCup";
            this.cboConvexCup.Size = new System.Drawing.Size(145, 23);
            this.btnIdentify.Location = new System.Drawing.Point(125, 282);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(145, 35);
            this.btnIdentify.Text = "Identify Mushroom";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            this.btnBack.Location = new System.Drawing.Point(35, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 35);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnLogout.Location = new System.Drawing.Point(220, 345);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 35);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 410);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.cboConvexCup);
            this.Controls.Add(this.cboRing);
            this.Controls.Add(this.cboForest);
            this.Controls.Add(this.cboGills);
            this.Controls.Add(this.lblConvexCup);
            this.Controls.Add(this.lblRing);
            this.Controls.Add(this.lblForest);
            this.Controls.Add(this.lblGills);
            this.Controls.Add(this.lblTitle);
            this.Name = "MushroomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 - Mushroom";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
