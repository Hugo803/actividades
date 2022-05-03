
namespace PlaneTrial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.start_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.level_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.easy_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.normal_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.hard_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.instructions_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.pause_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.backGround = new System.Windows.Forms.PictureBox();
            this.spaceShip = new System.Windows.Forms.PictureBox();
            this.rocket1 = new System.Windows.Forms.PictureBox();
            this.rocket2 = new System.Windows.Forms.PictureBox();
            this.rocket3 = new System.Windows.Forms.PictureBox();
            this.leftShip = new System.Windows.Forms.PictureBox();
            this.rightShip = new System.Windows.Forms.PictureBox();
            this.darkShip1 = new System.Windows.Forms.PictureBox();
            this.darkShip2 = new System.Windows.Forms.PictureBox();
            this.twoLassers = new System.Windows.Forms.PictureBox();
            this.score_label = new System.Windows.Forms.Label();
            this.attempts_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).BeginInit();
            this.backGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkShip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkShip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoLassers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.start_Button,
            this.level_Button,
            this.instructions_Button,
            this.pause_Button,
            this.exit_Button});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(848, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // start_Button
            // 
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(54, 24);
            this.start_Button.Text = "Start";
            this.start_Button.Click += new System.EventHandler(this.start_ButtonClick);
            // 
            // level_Button
            // 
            this.level_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easy_Button,
            this.normal_Button,
            this.hard_Button});
            this.level_Button.Name = "level_Button";
            this.level_Button.Size = new System.Drawing.Size(57, 24);
            this.level_Button.Text = "Level";
            this.level_Button.Click += new System.EventHandler(this.level_ButtonClick);
            // 
            // easy_Button
            // 
            this.easy_Button.Name = "easy_Button";
            this.easy_Button.Size = new System.Drawing.Size(142, 26);
            this.easy_Button.Text = "Easy";
            this.easy_Button.Click += new System.EventHandler(this.easy_ButtonClick);
            // 
            // normal_Button
            // 
            this.normal_Button.Name = "normal_Button";
            this.normal_Button.Size = new System.Drawing.Size(142, 26);
            this.normal_Button.Text = "Normal";
            this.normal_Button.Click += new System.EventHandler(this.normal_ButtonClick);
            // 
            // hard_Button
            // 
            this.hard_Button.Name = "hard_Button";
            this.hard_Button.Size = new System.Drawing.Size(142, 26);
            this.hard_Button.Text = "Hard";
            this.hard_Button.Click += new System.EventHandler(this.hard_ButtonClick);
            // 
            // instructions_Button
            // 
            this.instructions_Button.Name = "instructions_Button";
            this.instructions_Button.Size = new System.Drawing.Size(98, 24);
            this.instructions_Button.Text = "Instructions";
            this.instructions_Button.Click += new System.EventHandler(this.instructions_ButtonClick);
            // 
            // pause_Button
            // 
            this.pause_Button.Name = "pause_Button";
            this.pause_Button.Size = new System.Drawing.Size(60, 24);
            this.pause_Button.Text = "Pause";
            this.pause_Button.Click += new System.EventHandler(this.pause_ButtonClick);
            // 
            // exit_Button
            // 
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(47, 24);
            this.exit_Button.Text = "Exit";
            this.exit_Button.Click += new System.EventHandler(this.exit_ButtonClick);
            // 
            // backGround
            // 
            this.backGround.BackColor = System.Drawing.Color.Transparent;
            this.backGround.Controls.Add(this.spaceShip);
            this.backGround.Controls.Add(this.rocket1);
            this.backGround.Controls.Add(this.rocket2);
            this.backGround.Controls.Add(this.rocket3);
            this.backGround.Controls.Add(this.leftShip);
            this.backGround.Controls.Add(this.rightShip);
            this.backGround.Controls.Add(this.darkShip1);
            this.backGround.Controls.Add(this.darkShip2);
            this.backGround.Controls.Add(this.twoLassers);
            this.backGround.Image = global::PlaneTrial.Properties.Resources.intro_sky;
            this.backGround.Location = new System.Drawing.Point(12, 31);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(824, 552);
            this.backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backGround.TabIndex = 1;
            this.backGround.TabStop = false;
            // 
            // spaceShip
            // 
            this.spaceShip.BackColor = System.Drawing.Color.Transparent;
            this.spaceShip.Image = global::PlaneTrial.Properties.Resources.Tynker_SpaceShip;
            this.spaceShip.Location = new System.Drawing.Point(369, 399);
            this.spaceShip.Name = "spaceShip";
            this.spaceShip.Size = new System.Drawing.Size(121, 81);
            this.spaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceShip.TabIndex = 2;
            this.spaceShip.TabStop = false;
            this.spaceShip.Visible = false;
            // 
            // rocket1
            // 
            this.rocket1.BackColor = System.Drawing.Color.Transparent;
            this.rocket1.Image = global::PlaneTrial.Properties.Resources.rocket;
            this.rocket1.Location = new System.Drawing.Point(334, -125);
            this.rocket1.Name = "rocket1";
            this.rocket1.Size = new System.Drawing.Size(42, 121);
            this.rocket1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket1.TabIndex = 3;
            this.rocket1.TabStop = false;
            this.rocket1.Visible = false;
            // 
            // rocket2
            // 
            this.rocket2.BackColor = System.Drawing.Color.Transparent;
            this.rocket2.Image = global::PlaneTrial.Properties.Resources.rocket;
            this.rocket2.Location = new System.Drawing.Point(395, -125);
            this.rocket2.Name = "rocket2";
            this.rocket2.Size = new System.Drawing.Size(42, 121);
            this.rocket2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket2.TabIndex = 4;
            this.rocket2.TabStop = false;
            this.rocket2.Visible = false;
            // 
            // rocket3
            // 
            this.rocket3.BackColor = System.Drawing.Color.Transparent;
            this.rocket3.Image = global::PlaneTrial.Properties.Resources.rocket;
            this.rocket3.Location = new System.Drawing.Point(458, -125);
            this.rocket3.Name = "rocket3";
            this.rocket3.Size = new System.Drawing.Size(42, 121);
            this.rocket3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket3.TabIndex = 5;
            this.rocket3.TabStop = false;
            this.rocket3.Visible = false;
            // 
            // leftShip
            // 
            this.leftShip.BackColor = System.Drawing.Color.Transparent;
            this.leftShip.Image = global::PlaneTrial.Properties.Resources.leftShip;
            this.leftShip.Location = new System.Drawing.Point(830, 320);
            this.leftShip.Name = "leftShip";
            this.leftShip.Size = new System.Drawing.Size(87, 90);
            this.leftShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftShip.TabIndex = 6;
            this.leftShip.TabStop = false;
            this.leftShip.Visible = false;
            // 
            // rightShip
            // 
            this.rightShip.BackColor = System.Drawing.Color.Transparent;
            this.rightShip.Image = global::PlaneTrial.Properties.Resources.rightShip;
            this.rightShip.Location = new System.Drawing.Point(-90, 320);
            this.rightShip.Name = "rightShip";
            this.rightShip.Size = new System.Drawing.Size(87, 90);
            this.rightShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightShip.TabIndex = 7;
            this.rightShip.TabStop = false;
            this.rightShip.Visible = false;
            // 
            // darkShip1
            // 
            this.darkShip1.BackColor = System.Drawing.Color.Transparent;
            this.darkShip1.Image = global::PlaneTrial.Properties.Resources.F5S4_SpaceShip;
            this.darkShip1.Location = new System.Drawing.Point(250, 549);
            this.darkShip1.Name = "darkShip1";
            this.darkShip1.Size = new System.Drawing.Size(70, 121);
            this.darkShip1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darkShip1.TabIndex = 8;
            this.darkShip1.TabStop = false;
            this.darkShip1.Visible = false;
            // 
            // darkShip2
            // 
            this.darkShip2.BackColor = System.Drawing.Color.Transparent;
            this.darkShip2.Image = global::PlaneTrial.Properties.Resources.F5S4_SpaceShip;
            this.darkShip2.Location = new System.Drawing.Point(550, 549);
            this.darkShip2.Name = "darkShip2";
            this.darkShip2.Size = new System.Drawing.Size(70, 121);
            this.darkShip2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.darkShip2.TabIndex = 9;
            this.darkShip2.TabStop = false;
            this.darkShip2.Visible = false;
            // 
            // twoLassers
            // 
            this.twoLassers.Image = global::PlaneTrial.Properties.Resources.two_lassers;
            this.twoLassers.Location = new System.Drawing.Point(412, 351);
            this.twoLassers.Name = "twoLassers";
            this.twoLassers.Size = new System.Drawing.Size(36, 48);
            this.twoLassers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoLassers.TabIndex = 10;
            this.twoLassers.TabStop = false;
            this.twoLassers.Visible = false;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.Color.Transparent;
            this.score_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_label.Location = new System.Drawing.Point(699, 82);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(0, 28);
            this.score_label.TabIndex = 3;
            // 
            // attempts_label
            // 
            this.attempts_label.AutoSize = true;
            this.attempts_label.BackColor = System.Drawing.Color.Transparent;
            this.attempts_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.attempts_label.Location = new System.Drawing.Point(699, 50);
            this.attempts_label.Name = "attempts_label";
            this.attempts_label.Size = new System.Drawing.Size(0, 28);
            this.attempts_label.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 35;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 595);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.attempts_label);
            this.Controls.Add(this.backGround);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Plane Trial";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backGround)).EndInit();
            this.backGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rocket3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkShip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkShip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoLassers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem start_Button;
        private System.Windows.Forms.ToolStripMenuItem level_Button;
        private System.Windows.Forms.ToolStripMenuItem instructions_Button;
        private System.Windows.Forms.ToolStripMenuItem pause_Button;
        private System.Windows.Forms.ToolStripMenuItem exit_Button;
        private System.Windows.Forms.ToolStripMenuItem easy_Button;
        private System.Windows.Forms.ToolStripMenuItem normal_Button;
        private System.Windows.Forms.ToolStripMenuItem hard_Button;
        private System.Windows.Forms.PictureBox spaceShip;
        private System.Windows.Forms.PictureBox rocket1;
        private System.Windows.Forms.PictureBox rocket2;
        private System.Windows.Forms.PictureBox rocket3;
        private System.Windows.Forms.PictureBox leftShip;
        private System.Windows.Forms.PictureBox rightShip;
        private System.Windows.Forms.PictureBox darkShip1;
        private System.Windows.Forms.PictureBox darkShip2;
        private System.Windows.Forms.PictureBox twoLassers;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox backGround;
        private System.Windows.Forms.Label attempts_label;
        private System.Windows.Forms.Label score_label;
    }
}

