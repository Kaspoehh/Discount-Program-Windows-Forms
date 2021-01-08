
namespace WindowsForms
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
			this.ToValutaBox = new System.Windows.Forms.ListBox();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.FromValutaBox = new System.Windows.Forms.ListBox();
			this.From = new System.Windows.Forms.Label();
			this.To = new System.Windows.Forms.Label();
			this.Amount = new System.Windows.Forms.TextBox();
			this.Total = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Error = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ToValutaBox
			// 
			this.ToValutaBox.AllowDrop = true;
			this.ToValutaBox.FormattingEnabled = true;
			this.ToValutaBox.Location = new System.Drawing.Point(218, 56);
			this.ToValutaBox.Name = "ToValutaBox";
			this.ToValutaBox.Size = new System.Drawing.Size(120, 342);
			this.ToValutaBox.TabIndex = 0;
			// 
			// CalculateButton
			// 
			this.CalculateButton.Location = new System.Drawing.Point(560, 149);
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.Size = new System.Drawing.Size(75, 23);
			this.CalculateButton.TabIndex = 3;
			this.CalculateButton.Text = "Calculate";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// FromValutaBox
			// 
			this.FromValutaBox.AllowDrop = true;
			this.FromValutaBox.FormattingEnabled = true;
			this.FromValutaBox.Location = new System.Drawing.Point(41, 56);
			this.FromValutaBox.Name = "FromValutaBox";
			this.FromValutaBox.Size = new System.Drawing.Size(120, 342);
			this.FromValutaBox.TabIndex = 4;
			this.FromValutaBox.SelectedIndexChanged += new System.EventHandler(this.FromValutaBox_SelectedIndexChanged);
			// 
			// From
			// 
			this.From.AutoSize = true;
			this.From.Location = new System.Drawing.Point(83, 27);
			this.From.Name = "From";
			this.From.Size = new System.Drawing.Size(30, 13);
			this.From.TabIndex = 5;
			this.From.Text = "From";
			this.From.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// To
			// 
			this.To.AutoSize = true;
			this.To.Location = new System.Drawing.Point(262, 27);
			this.To.Name = "To";
			this.To.Size = new System.Drawing.Size(20, 13);
			this.To.TabIndex = 6;
			this.To.Text = "To";
			this.To.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Amount
			// 
			this.Amount.Location = new System.Drawing.Point(419, 151);
			this.Amount.Name = "Amount";
			this.Amount.Size = new System.Drawing.Size(100, 20);
			this.Amount.TabIndex = 7;
			this.Amount.Text = "Amount";
			// 
			// Total
			// 
			this.Total.AutoSize = true;
			this.Total.Location = new System.Drawing.Point(358, 191);
			this.Total.Name = "Total";
			this.Total.Size = new System.Drawing.Size(19, 13);
			this.Total.TabIndex = 8;
			this.Total.Text = "10";
			this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(358, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Amount:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Error
			// 
			this.Error.AutoSize = true;
			this.Error.BackColor = System.Drawing.Color.White;
			this.Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Error.ForeColor = System.Drawing.Color.Black;
			this.Error.Location = new System.Drawing.Point(248, 416);
			this.Error.Name = "Error";
			this.Error.Size = new System.Drawing.Size(93, 29);
			this.Error.TabIndex = 0;
			this.Error.Text = "ERROR!!";
			this.Error.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Error.UseCompatibleTextRendering = true;
			this.Error.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Error);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Total);
			this.Controls.Add(this.Amount);
			this.Controls.Add(this.To);
			this.Controls.Add(this.FromValutaBox);
			this.Controls.Add(this.From);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.ToValutaBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ToValutaBox;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.ListBox FromValutaBox;
		private System.Windows.Forms.Label From;
		private System.Windows.Forms.Label To;
		private System.Windows.Forms.TextBox Amount;
		private System.Windows.Forms.Label Total;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Error;
	}
}

