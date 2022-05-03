
namespace PlaneTrial
{
    partial class Exit
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
            this.label = new System.Windows.Forms.Label();
            this.yes_button = new System.Windows.Forms.Button();
            this.no_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(91, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(146, 30);
            this.label.TabIndex = 0;
            this.label.Text = "Are you sure?";
            // 
            // yes_button
            // 
            this.yes_button.Location = new System.Drawing.Point(42, 93);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(94, 29);
            this.yes_button.TabIndex = 1;
            this.yes_button.Text = "YES";
            this.yes_button.UseVisualStyleBackColor = true;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // no_button
            // 
            this.no_button.Location = new System.Drawing.Point(169, 93);
            this.no_button.Name = "no_button";
            this.no_button.Size = new System.Drawing.Size(94, 29);
            this.no_button.TabIndex = 2;
            this.no_button.Text = "NO";
            this.no_button.UseVisualStyleBackColor = true;
            this.no_button.Click += new System.EventHandler(this.no_button_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 176);
            this.Controls.Add(this.no_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.label);
            this.Name = "Exit";
            this.Text = "Exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.Button no_button;
    }
}