
namespace PlaneTrial
{
    partial class Losser
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
            this.button = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(50, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(149, 30);
            this.label.TabIndex = 0;
            this.label.Text = "You\'ve lost =\'(";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(77, 144);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(94, 29);
            this.button.TabIndex = 1;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score.Location = new System.Drawing.Point(24, 97);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(98, 23);
            this.score.TabIndex = 2;
            this.score.Text = "Your score: ";
            // 
            // Losser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 231);
            this.Controls.Add(this.score);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label);
            this.Name = "Losser";
            this.Text = "Losser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label score;
    }
}