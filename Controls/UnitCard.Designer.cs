namespace BattlefieldCSharp.Controls
{
    partial class UnitCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlAccent = new Panel();
            lblName = new Label();
            lblRole = new Label();
            lblHealth = new Label();
            pnlHpTrack = new Panel();
            SuspendLayout();
            // 
            // pnlAccent
            // 
            pnlAccent.BackColor = Color.FromArgb(54, 120, 190);
            pnlAccent.Dock = DockStyle.Left;
            pnlAccent.Location = new Point(0, 0);
            pnlAccent.Name = "pnlAccent";
            pnlAccent.Size = new Size(4, 125);
            pnlAccent.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoEllipsis = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 35);
            lblName.Name = "lblName";
            lblName.Size = new Size(162, 24);
            lblName.TabIndex = 1;
            lblName.Text = "Unit";
            // 
            // lblRole
            // 
            lblRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRole.AutoEllipsis = true;
            lblRole.Font = new Font("Segoe UI", 8.5F);
            lblRole.ForeColor = Color.FromArgb(165, 171, 183);
            lblRole.Location = new Point(10, 59);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(162, 18);
            lblRole.TabIndex = 2;
            lblRole.Text = "Role";
            // 
            // lblHealth
            // 
            lblHealth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHealth.Font = new Font("Segoe UI", 8.5F);
            lblHealth.ForeColor = Color.FromArgb(210, 215, 223);
            lblHealth.Location = new Point(76, 97);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(96, 20);
            lblHealth.TabIndex = 3;
            lblHealth.Text = "100 / 100 HP";
            lblHealth.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlHpTrack
            // 
            pnlHpTrack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHpTrack.BackColor = Color.FromArgb(24, 26, 32);
            pnlHpTrack.Location = new Point(10, 80);
            pnlHpTrack.Name = "pnlHpTrack";
            pnlHpTrack.Size = new Size(162, 14);
            pnlHpTrack.TabIndex = 4;
            pnlHpTrack.Paint += pnlHpTrack_Paint;
            pnlHpTrack.Resize += pnlHpTrack_Resize;
            // 
            // UnitCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 42, 51);
            Controls.Add(pnlHpTrack);
            Controls.Add(lblHealth);
            Controls.Add(lblRole);
            Controls.Add(lblName);
            Controls.Add(pnlAccent);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(0, 0, 0, 12);
            Name = "UnitCard";
            Size = new Size(192, 125);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Panel pnlHpTrack;
    }
}
