namespace Calculator_WindowsForms
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
			this.value1 = new System.Windows.Forms.Button();
			this.theScreen = new System.Windows.Forms.Label();
			this.value2 = new System.Windows.Forms.Button();
			this.value3 = new System.Windows.Forms.Button();
			this.value4 = new System.Windows.Forms.Button();
			this.value5 = new System.Windows.Forms.Button();
			this.value6 = new System.Windows.Forms.Button();
			this.value7 = new System.Windows.Forms.Button();
			this.value8 = new System.Windows.Forms.Button();
			this.value9 = new System.Windows.Forms.Button();
			this.value0 = new System.Windows.Forms.Button();
			this.valueDesimal = new System.Windows.Forms.Button();
			this.valuePlus = new System.Windows.Forms.Button();
			this.valueMinus = new System.Windows.Forms.Button();
			this.valueMultiply = new System.Windows.Forms.Button();
			this.valueDevide = new System.Windows.Forms.Button();
			this.result = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// value1
			// 
			this.value1.Location = new System.Drawing.Point(111, 202);
			this.value1.Name = "value1";
			this.value1.Size = new System.Drawing.Size(75, 23);
			this.value1.TabIndex = 0;
			this.value1.Text = "1";
			this.value1.UseVisualStyleBackColor = true;
			this.value1.Click += new System.EventHandler(this.button1_Click);
			// 
			// theScreen
			// 
			this.theScreen.AutoSize = true;
			this.theScreen.BackColor = System.Drawing.SystemColors.Control;
			this.theScreen.Location = new System.Drawing.Point(246, 156);
			this.theScreen.Name = "theScreen";
			this.theScreen.Size = new System.Drawing.Size(0, 13);
			this.theScreen.TabIndex = 1;
			this.theScreen.Click += new System.EventHandler(this.label1_Click);
			// 
			// value2
			// 
			this.value2.Location = new System.Drawing.Point(192, 202);
			this.value2.Name = "value2";
			this.value2.Size = new System.Drawing.Size(75, 23);
			this.value2.TabIndex = 2;
			this.value2.Text = "2";
			this.value2.UseVisualStyleBackColor = true;
			this.value2.Click += new System.EventHandler(this.value2_Click);
			// 
			// value3
			// 
			this.value3.Location = new System.Drawing.Point(273, 202);
			this.value3.Name = "value3";
			this.value3.Size = new System.Drawing.Size(75, 23);
			this.value3.TabIndex = 3;
			this.value3.Text = "3";
			this.value3.UseVisualStyleBackColor = true;
			this.value3.Click += new System.EventHandler(this.value3_Click);
			// 
			// value4
			// 
			this.value4.Location = new System.Drawing.Point(111, 232);
			this.value4.Name = "value4";
			this.value4.Size = new System.Drawing.Size(75, 23);
			this.value4.TabIndex = 4;
			this.value4.Text = "4";
			this.value4.UseVisualStyleBackColor = true;
			this.value4.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// value5
			// 
			this.value5.Location = new System.Drawing.Point(193, 232);
			this.value5.Name = "value5";
			this.value5.Size = new System.Drawing.Size(75, 23);
			this.value5.TabIndex = 5;
			this.value5.Text = "5";
			this.value5.UseVisualStyleBackColor = true;
			this.value5.Click += new System.EventHandler(this.value5_Click);
			// 
			// value6
			// 
			this.value6.Location = new System.Drawing.Point(275, 232);
			this.value6.Name = "value6";
			this.value6.Size = new System.Drawing.Size(75, 23);
			this.value6.TabIndex = 6;
			this.value6.Text = "6";
			this.value6.UseVisualStyleBackColor = true;
			this.value6.Click += new System.EventHandler(this.value6_Click);
			// 
			// value7
			// 
			this.value7.Location = new System.Drawing.Point(111, 262);
			this.value7.Name = "value7";
			this.value7.Size = new System.Drawing.Size(75, 23);
			this.value7.TabIndex = 7;
			this.value7.Text = "7";
			this.value7.UseVisualStyleBackColor = true;
			this.value7.Click += new System.EventHandler(this.value7_Click);
			// 
			// value8
			// 
			this.value8.Location = new System.Drawing.Point(193, 262);
			this.value8.Name = "value8";
			this.value8.Size = new System.Drawing.Size(75, 23);
			this.value8.TabIndex = 8;
			this.value8.Text = "8";
			this.value8.UseVisualStyleBackColor = true;
			this.value8.Click += new System.EventHandler(this.value8_Click);
			// 
			// value9
			// 
			this.value9.Location = new System.Drawing.Point(275, 262);
			this.value9.Name = "value9";
			this.value9.Size = new System.Drawing.Size(75, 23);
			this.value9.TabIndex = 9;
			this.value9.Text = "9";
			this.value9.UseVisualStyleBackColor = true;
			this.value9.Click += new System.EventHandler(this.value9_Click);
			// 
			// value0
			// 
			this.value0.Location = new System.Drawing.Point(111, 292);
			this.value0.Name = "value0";
			this.value0.Size = new System.Drawing.Size(156, 23);
			this.value0.TabIndex = 10;
			this.value0.Text = "0";
			this.value0.UseVisualStyleBackColor = true;
			this.value0.Click += new System.EventHandler(this.value0_Click);
			// 
			// valueDesimal
			// 
			this.valueDesimal.Location = new System.Drawing.Point(275, 292);
			this.valueDesimal.Name = "valueDesimal";
			this.valueDesimal.Size = new System.Drawing.Size(75, 23);
			this.valueDesimal.TabIndex = 11;
			this.valueDesimal.Text = ".";
			this.valueDesimal.UseVisualStyleBackColor = true;
			// 
			// valuePlus
			// 
			this.valuePlus.Location = new System.Drawing.Point(355, 202);
			this.valuePlus.Name = "valuePlus";
			this.valuePlus.Size = new System.Drawing.Size(74, 23);
			this.valuePlus.TabIndex = 12;
			this.valuePlus.Text = "+";
			this.valuePlus.UseVisualStyleBackColor = true;
			// 
			// valueMinus
			// 
			this.valueMinus.Location = new System.Drawing.Point(357, 232);
			this.valueMinus.Name = "valueMinus";
			this.valueMinus.Size = new System.Drawing.Size(72, 23);
			this.valueMinus.TabIndex = 13;
			this.valueMinus.Text = "-";
			this.valueMinus.UseVisualStyleBackColor = true;
			// 
			// valueMultiply
			// 
			this.valueMultiply.Location = new System.Drawing.Point(357, 262);
			this.valueMultiply.Name = "valueMultiply";
			this.valueMultiply.Size = new System.Drawing.Size(72, 23);
			this.valueMultiply.TabIndex = 14;
			this.valueMultiply.Text = "x";
			this.valueMultiply.UseVisualStyleBackColor = true;
			// 
			// valueDevide
			// 
			this.valueDevide.Location = new System.Drawing.Point(357, 292);
			this.valueDevide.Name = "valueDevide";
			this.valueDevide.Size = new System.Drawing.Size(75, 23);
			this.valueDevide.TabIndex = 15;
			this.valueDevide.Text = "/";
			this.valueDevide.UseVisualStyleBackColor = true;
			// 
			// result
			// 
			this.result.Location = new System.Drawing.Point(111, 322);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(318, 23);
			this.result.TabIndex = 16;
			this.result.Text = "=";
			this.result.UseVisualStyleBackColor = true;
			this.result.Click += new System.EventHandler(this.result_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.result);
			this.Controls.Add(this.valueDevide);
			this.Controls.Add(this.valueMultiply);
			this.Controls.Add(this.valueMinus);
			this.Controls.Add(this.valuePlus);
			this.Controls.Add(this.valueDesimal);
			this.Controls.Add(this.value0);
			this.Controls.Add(this.value9);
			this.Controls.Add(this.value8);
			this.Controls.Add(this.value7);
			this.Controls.Add(this.value6);
			this.Controls.Add(this.value5);
			this.Controls.Add(this.value4);
			this.Controls.Add(this.value3);
			this.Controls.Add(this.value2);
			this.Controls.Add(this.theScreen);
			this.Controls.Add(this.value1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button value1;
		private System.Windows.Forms.Label theScreen;
		private System.Windows.Forms.Button value2;
		private System.Windows.Forms.Button value3;
		private System.Windows.Forms.Button value4;
		private System.Windows.Forms.Button value5;
		private System.Windows.Forms.Button value6;
		private System.Windows.Forms.Button value7;
		private System.Windows.Forms.Button value8;
		private System.Windows.Forms.Button value9;
		private System.Windows.Forms.Button value0;
		private System.Windows.Forms.Button valueDesimal;
		private System.Windows.Forms.Button valuePlus;
		private System.Windows.Forms.Button valueMinus;
		private System.Windows.Forms.Button valueMultiply;
		private System.Windows.Forms.Button valueDevide;
		private System.Windows.Forms.Button result;
	}
}

