namespace BattlefieldCSharp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            teamPlayer = new BattlefieldCSharp.Controls.TeamPanel();
            teamEnemy = new BattlefieldCSharp.Controls.TeamPanel();
            tlpRoot.SuspendLayout();
            SuspendLayout();
            //
            // tlpRoot
            //
            tlpRoot.BackColor = System.Drawing.Color.FromArgb(18, 20, 25);
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            tlpRoot.Controls.Add(teamPlayer, 0, 0);
            tlpRoot.Controls.Add(teamEnemy, 2, 0);
            tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpRoot.Location = new System.Drawing.Point(0, 0);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.Padding = new System.Windows.Forms.Padding(18);
            tlpRoot.RowCount = 1;
            tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpRoot.Size = new System.Drawing.Size(800, 600);
            tlpRoot.TabIndex = 0;
            //
            // teamPlayer
            //
            teamPlayer.AccentColor = System.Drawing.Color.FromArgb(54, 120, 190);
            teamPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            teamPlayer.Name = "teamPlayer";
            teamPlayer.TabIndex = 0;
            teamPlayer.Title = "YOUR TEAM";
            //
            // teamEnemy
            //
            teamEnemy.AccentColor = System.Drawing.Color.FromArgb(190, 72, 72);
            teamEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            teamEnemy.Name = "teamEnemy";
            teamEnemy.TabIndex = 2;
            teamEnemy.Title = "ENEMY TEAM";
            //
            // MainForm
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(18, 20, 25);
            ClientSize = new System.Drawing.Size(1184, 681);
            Controls.Add(tlpRoot);
            Font = new System.Drawing.Font("Segoe UI", 10F);
            ForeColor = System.Drawing.Color.White;
            MinimumSize = new System.Drawing.Size(900, 560);
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Battlefield";
            tlpRoot.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private BattlefieldCSharp.Controls.TeamPanel teamPlayer;
        private BattlefieldCSharp.Controls.TeamPanel teamEnemy;
    }
}
