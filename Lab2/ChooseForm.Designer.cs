namespace Lab2
{
    partial class ChooseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBicycle;
        private System.Windows.Forms.Button btnMushroom;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBicycle = new System.Windows.Forms.Button();
            this.btnMushroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(94, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 31);
            this.lblTitle.Text = "CHOOSE A PROBLEM";
            this.btnBicycle.Location = new System.Drawing.Point(100, 115);
            this.btnBicycle.Name = "btnBicycle";
            this.btnBicycle.Size = new System.Drawing.Size(210, 48);
            this.btnBicycle.Text = "Bicycle";
            this.btnBicycle.UseVisualStyleBackColor = true;
            this.btnBicycle.Click += new System.EventHandler(this.btnBicycle_Click);
            this.btnMushroom.Location = new System.Drawing.Point(100, 185);
            this.btnMushroom.Name = "btnMushroom";
            this.btnMushroom.Size = new System.Drawing.Size(210, 48);
            this.btnMushroom.Text = "Mushroom";
            this.btnMushroom.UseVisualStyleBackColor = true;
            this.btnMushroom.Click += new System.EventHandler(this.btnMushroom_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 290);
            this.Controls.Add(this.btnMushroom);
            this.Controls.Add(this.btnBicycle);
            this.Controls.Add(this.lblTitle);
            this.Name = "ChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 - Choose";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
