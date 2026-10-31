namespace BattlefieldCSharp.Controls
{
    partial class TeamPanel
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
            lblTitle = new Label();
            flpUnits = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(54, 120, 190);
            lblTitle.Location = new Point(14, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(179, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TEAM";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpUnits
            // 
            flpUnits.AutoScroll = true;
            flpUnits.BackColor = Color.FromArgb(27, 30, 37);
            flpUnits.Dock = DockStyle.Fill;
            flpUnits.FlowDirection = FlowDirection.TopDown;
            flpUnits.Location = new Point(14, 56);
            flpUnits.Name = "flpUnits";
            flpUnits.Padding = new Padding(0, 8, 4, 0);
            flpUnits.Size = new Size(179, 430);
            flpUnits.TabIndex = 1;
            flpUnits.WrapContents = false;
            flpUnits.Resize += flpUnits_Resize;
            // 
            // TeamPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 30, 37);
            Controls.Add(flpUnits);
            Controls.Add(lblTitle);
            ForeColor = Color.White;
            Margin = new Padding(8, 0, 8, 0);
            Name = "TeamPanel";
            Padding = new Padding(14);
            Size = new Size(207, 500);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpUnits;
    }
}
