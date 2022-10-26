namespace star
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.rowsButton = new System.Windows.Forms.Button();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.TypeComboBox = new System.Windows.Forms.ComboBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// rowsButton
			// 
			this.rowsButton.Location = new System.Drawing.Point(363, 65);
			this.rowsButton.Name = "rowsButton";
			this.rowsButton.Size = new System.Drawing.Size(113, 34);
			this.rowsButton.TabIndex = 0;
			this.rowsButton.Text = "生成";
			this.rowsButton.UseVisualStyleBackColor = true;
			this.rowsButton.Click += new System.EventHandler(this.rowsButton_Click);
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(68, 73);
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(100, 22);
			this.rowsTextBox.TabIndex = 1;
			// 
			// TypeComboBox
			// 
			this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TypeComboBox.FormattingEnabled = true;
			this.TypeComboBox.Items.AddRange(new object[] {
            "靠左",
            "等腰",
            "靠右"});
			this.TypeComboBox.Location = new System.Drawing.Point(218, 73);
			this.TypeComboBox.Name = "TypeComboBox";
			this.TypeComboBox.Size = new System.Drawing.Size(121, 20);
			this.TypeComboBox.TabIndex = 2;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(56, 166);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.resultTextBox.Size = new System.Drawing.Size(462, 254);
			this.resultTextBox.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 450);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.TypeComboBox);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.rowsButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button rowsButton;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.ComboBox TypeComboBox;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}

