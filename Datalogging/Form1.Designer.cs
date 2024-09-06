namespace Datalogging
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
			this.btnGetData1 = new System.Windows.Forms.Button();
			this.txtTemperature = new System.Windows.Forms.TextBox();
			this.txtTemperature2 = new System.Windows.Forms.TextBox();
			this.txtTemperature3 = new System.Windows.Forms.TextBox();
			this.cboSensorType1 = new System.Windows.Forms.ComboBox();
			this.cboSensorType2 = new System.Windows.Forms.ComboBox();
			this.cboSensorType3 = new System.Windows.Forms.ComboBox();
			this.btnAddSensor1 = new System.Windows.Forms.Button();
			this.btnAddSensor2 = new System.Windows.Forms.Button();
			this.btnAddSensor3 = new System.Windows.Forms.Button();
			this.btnGetData2 = new System.Windows.Forms.Button();
			this.btnGetData3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGetData1
			// 
			this.btnGetData1.Location = new System.Drawing.Point(351, 74);
			this.btnGetData1.Margin = new System.Windows.Forms.Padding(2);
			this.btnGetData1.Name = "btnGetData1";
			this.btnGetData1.Size = new System.Drawing.Size(82, 34);
			this.btnGetData1.TabIndex = 0;
			this.btnGetData1.Text = "btnGetData";
			this.btnGetData1.UseVisualStyleBackColor = true;
			this.btnGetData1.Click += new System.EventHandler(this.btnGetData1_Click);
			// 
			// txtTemperature
			// 
			this.txtTemperature.Location = new System.Drawing.Point(66, 82);
			this.txtTemperature.Margin = new System.Windows.Forms.Padding(2);
			this.txtTemperature.Name = "txtTemperature";
			this.txtTemperature.Size = new System.Drawing.Size(56, 20);
			this.txtTemperature.TabIndex = 1;
			// 
			// txtTemperature2
			// 
			this.txtTemperature2.Location = new System.Drawing.Point(66, 118);
			this.txtTemperature2.Margin = new System.Windows.Forms.Padding(2);
			this.txtTemperature2.Name = "txtTemperature2";
			this.txtTemperature2.Size = new System.Drawing.Size(56, 20);
			this.txtTemperature2.TabIndex = 2;
			// 
			// txtTemperature3
			// 
			this.txtTemperature3.Location = new System.Drawing.Point(66, 158);
			this.txtTemperature3.Margin = new System.Windows.Forms.Padding(2);
			this.txtTemperature3.Name = "txtTemperature3";
			this.txtTemperature3.Size = new System.Drawing.Size(56, 20);
			this.txtTemperature3.TabIndex = 3;
			// 
			// cboSensorType1
			// 
			this.cboSensorType1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cboSensorType1.FormattingEnabled = true;
			this.cboSensorType1.Items.AddRange(new object[] {
            "-",
            "Temperatur",
            "Sim Temperatur"});
			this.cboSensorType1.Location = new System.Drawing.Point(139, 81);
			this.cboSensorType1.Name = "cboSensorType1";
			this.cboSensorType1.Size = new System.Drawing.Size(121, 21);
			this.cboSensorType1.TabIndex = 4;
			this.cboSensorType1.Text = "Temperatur";
			// 
			// cboSensorType2
			// 
			this.cboSensorType2.FormattingEnabled = true;
			this.cboSensorType2.Items.AddRange(new object[] {
            "-",
            "Temperatur",
            "Sim Temperatur"});
			this.cboSensorType2.Location = new System.Drawing.Point(139, 118);
			this.cboSensorType2.Name = "cboSensorType2";
			this.cboSensorType2.Size = new System.Drawing.Size(121, 21);
			this.cboSensorType2.TabIndex = 6;
			this.cboSensorType2.Text = "-";
			// 
			// cboSensorType3
			// 
			this.cboSensorType3.FormattingEnabled = true;
			this.cboSensorType3.Items.AddRange(new object[] {
            "-",
            "Temperatur",
            "Sim Temperatur"});
			this.cboSensorType3.Location = new System.Drawing.Point(139, 157);
			this.cboSensorType3.Name = "cboSensorType3";
			this.cboSensorType3.Size = new System.Drawing.Size(121, 21);
			this.cboSensorType3.TabIndex = 7;
			this.cboSensorType3.Text = "-";
			// 
			// btnAddSensor1
			// 
			this.btnAddSensor1.Location = new System.Drawing.Point(265, 74);
			this.btnAddSensor1.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddSensor1.Name = "btnAddSensor1";
			this.btnAddSensor1.Size = new System.Drawing.Size(82, 34);
			this.btnAddSensor1.TabIndex = 5;
			this.btnAddSensor1.Text = "AddSensor";
			this.btnAddSensor1.UseVisualStyleBackColor = true;
			this.btnAddSensor1.Click += new System.EventHandler(this.btnAddSensor1_Click);
			// 
			// btnAddSensor2
			// 
			this.btnAddSensor2.Location = new System.Drawing.Point(265, 112);
			this.btnAddSensor2.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddSensor2.Name = "btnAddSensor2";
			this.btnAddSensor2.Size = new System.Drawing.Size(82, 34);
			this.btnAddSensor2.TabIndex = 8;
			this.btnAddSensor2.Text = "AddSensor";
			this.btnAddSensor2.UseVisualStyleBackColor = true;
			this.btnAddSensor2.Click += new System.EventHandler(this.btnAddSensor2_Click);
			// 
			// btnAddSensor3
			// 
			this.btnAddSensor3.Location = new System.Drawing.Point(265, 149);
			this.btnAddSensor3.Margin = new System.Windows.Forms.Padding(2);
			this.btnAddSensor3.Name = "btnAddSensor3";
			this.btnAddSensor3.Size = new System.Drawing.Size(82, 34);
			this.btnAddSensor3.TabIndex = 9;
			this.btnAddSensor3.Text = "AddSensor";
			this.btnAddSensor3.UseVisualStyleBackColor = true;
			this.btnAddSensor3.Click += new System.EventHandler(this.btnAddSensor3_Click);
			// 
			// btnGetData2
			// 
			this.btnGetData2.Location = new System.Drawing.Point(351, 112);
			this.btnGetData2.Margin = new System.Windows.Forms.Padding(2);
			this.btnGetData2.Name = "btnGetData2";
			this.btnGetData2.Size = new System.Drawing.Size(82, 34);
			this.btnGetData2.TabIndex = 10;
			this.btnGetData2.Text = "btnGetData";
			this.btnGetData2.UseVisualStyleBackColor = true;
			this.btnGetData2.Click += new System.EventHandler(this.btnGetData2_Click);
			// 
			// btnGetData3
			// 
			this.btnGetData3.Location = new System.Drawing.Point(351, 150);
			this.btnGetData3.Margin = new System.Windows.Forms.Padding(2);
			this.btnGetData3.Name = "btnGetData3";
			this.btnGetData3.Size = new System.Drawing.Size(82, 34);
			this.btnGetData3.TabIndex = 11;
			this.btnGetData3.Text = "btnGetData";
			this.btnGetData3.UseVisualStyleBackColor = true;
			this.btnGetData3.Click += new System.EventHandler(this.btnGetData3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Temperatur";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(136, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Sensor type";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 244);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGetData3);
			this.Controls.Add(this.btnGetData2);
			this.Controls.Add(this.btnAddSensor3);
			this.Controls.Add(this.btnAddSensor2);
			this.Controls.Add(this.cboSensorType3);
			this.Controls.Add(this.cboSensorType2);
			this.Controls.Add(this.btnAddSensor1);
			this.Controls.Add(this.cboSensorType1);
			this.Controls.Add(this.txtTemperature3);
			this.Controls.Add(this.txtTemperature2);
			this.Controls.Add(this.txtTemperature);
			this.Controls.Add(this.btnGetData1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetData1;
		private System.Windows.Forms.TextBox txtTemperature;
		private System.Windows.Forms.TextBox txtTemperature2;
		private System.Windows.Forms.TextBox txtTemperature3;
		private System.Windows.Forms.ComboBox cboSensorType1;
		private System.Windows.Forms.ComboBox cboSensorType2;
		private System.Windows.Forms.ComboBox cboSensorType3;
		private System.Windows.Forms.Button btnAddSensor1;
		private System.Windows.Forms.Button btnAddSensor2;
		private System.Windows.Forms.Button btnAddSensor3;
		private System.Windows.Forms.Button btnGetData2;
		private System.Windows.Forms.Button btnGetData3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

