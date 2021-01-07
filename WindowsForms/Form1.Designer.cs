
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
			this.ValutaBox = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ValutaBox
			// 
			this.ValutaBox.AllowDrop = true;
			this.ValutaBox.FormattingEnabled = true;
			this.ValutaBox.Location = new System.Drawing.Point(366, 12);
			this.ValutaBox.Name = "ValutaBox";
			this.ValutaBox.Size = new System.Drawing.Size(120, 342);
			this.ValutaBox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(143, 222);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 65);
			this.button1.TabIndex = 1;
			this.button1.Text = "Calculate";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(574, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Koers\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ValutaBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ValutaBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}

