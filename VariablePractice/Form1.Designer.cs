namespace VariablePractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hockeyButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.Button();
            this.carpet = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hockeyButton
            // 
            this.hockeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.Location = new System.Drawing.Point(26, 18);
            this.hockeyButton.Margin = new System.Windows.Forms.Padding(2);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(81, 33);
            this.hockeyButton.TabIndex = 1;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(124, 18);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(287, 257);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "...";
            // 
            // payButton
            // 
            this.payButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(26, 68);
            this.payButton.Margin = new System.Windows.Forms.Padding(2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(81, 33);
            this.payButton.TabIndex = 5;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(26, 132);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(81, 33);
            this.area.TabIndex = 6;
            this.area.Text = "Circumference";
            this.area.UseVisualStyleBackColor = true;
            this.area.Click += new System.EventHandler(this.area_Click);
            // 
            // carpet
            // 
            this.carpet.Location = new System.Drawing.Point(26, 171);
            this.carpet.Name = "carpet";
            this.carpet.Size = new System.Drawing.Size(81, 33);
            this.carpet.TabIndex = 7;
            this.carpet.Text = "Carpet";
            this.carpet.UseVisualStyleBackColor = true;
            this.carpet.Click += new System.EventHandler(this.carpet_Click);
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(26, 225);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(81, 33);
            this.bill.TabIndex = 8;
            this.bill.Text = "Bill";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 302);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.carpet);
            this.Controls.Add(this.area);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hockeyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button payButton;

        private System.Windows.Forms.Button area;
        private System.Windows.Forms.Button carpet;
        private System.Windows.Forms.Button bill;

    }
}

