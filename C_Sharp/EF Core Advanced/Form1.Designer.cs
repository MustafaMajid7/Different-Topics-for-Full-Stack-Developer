namespace EF_Core_Advanced
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
			button1 = new Button();
			dataGridView1 = new DataGridView();
			TXT_addr = new TextBox();
			TXT_name = new TextBox();
			NUD_age = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)NUD_age).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(328, 368);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 0;
			button1.Text = "Add";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(683, 163);
			dataGridView1.TabIndex = 1;
			// 
			// TXT_addr
			// 
			TXT_addr.Location = new Point(104, 300);
			TXT_addr.Name = "TXT_addr";
			TXT_addr.Size = new Size(100, 23);
			TXT_addr.TabIndex = 2;
			// 
			// TXT_name
			// 
			TXT_name.Location = new Point(287, 300);
			TXT_name.Name = "TXT_name";
			TXT_name.Size = new Size(100, 23);
			TXT_name.TabIndex = 2;
			// 
			// NUD_age
			// 
			NUD_age.Location = new Point(567, 308);
			NUD_age.Name = "NUD_age";
			NUD_age.Size = new Size(120, 23);
			NUD_age.TabIndex = 3;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(506, 310);
			label1.Name = "label1";
			label1.Size = new Size(26, 15);
			label1.TabIndex = 4;
			label1.Text = "age";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(243, 303);
			label2.Name = "label2";
			label2.Size = new Size(37, 15);
			label2.TabIndex = 4;
			label2.Text = "name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(51, 303);
			label3.Name = "label3";
			label3.Size = new Size(47, 15);
			label3.TabIndex = 4;
			label3.Text = "address";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(NUD_age);
			Controls.Add(TXT_name);
			Controls.Add(TXT_addr);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)NUD_age).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private DataGridView dataGridView1;
		private TextBox TXT_addr;
		private TextBox TXT_name;
		private NumericUpDown NUD_age;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}