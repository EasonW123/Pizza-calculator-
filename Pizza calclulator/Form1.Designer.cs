namespace Pizza_calclulator
{
    partial class Form1
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NumberOfToppings = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateButton.Location = new System.Drawing.Point(328, 188);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 37);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.Location = new System.Drawing.Point(267, 334);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(372, 65);
            this.OutPutLabel.TabIndex = 1;
            this.OutPutLabel.Text = "Welcome";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(154, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(168, 58);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Number of Toppings";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(271, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(183, 34);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Rams Pizza Parlour";
            // 
            // NumberOfToppings
            // 
            this.NumberOfToppings.Location = new System.Drawing.Point(328, 109);
            this.NumberOfToppings.Name = "NumberOfToppings";
            this.NumberOfToppings.Size = new System.Drawing.Size(100, 26);
            this.NumberOfToppings.TabIndex = 4;
            this.NumberOfToppings.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberOfToppings);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.OutPutLabel);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label OutPutLabel;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NumberOfToppings;
    }
}

