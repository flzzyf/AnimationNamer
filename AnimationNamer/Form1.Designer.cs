namespace AnimationNamer {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.ComboBox_Name = new System.Windows.Forms.ComboBox();
			this.ComboBox_Action = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NameText = new System.Windows.Forms.TextBox();
			this.Button_Copy = new System.Windows.Forms.Button();
			this.Panel_Option = new System.Windows.Forms.Panel();
			this.Panel_Text = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.Panel_Option.SuspendLayout();
			this.Panel_Text.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "1.选择角色名称";
			// 
			// ComboBox_Name
			// 
			this.ComboBox_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_Name.Font = new System.Drawing.Font("黑体", 12F);
			this.ComboBox_Name.FormattingEnabled = true;
			this.ComboBox_Name.Location = new System.Drawing.Point(17, 50);
			this.ComboBox_Name.Name = "ComboBox_Name";
			this.ComboBox_Name.Size = new System.Drawing.Size(186, 24);
			this.ComboBox_Name.TabIndex = 4;
			this.ComboBox_Name.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Name_SelectedIndexChanged);
			// 
			// ComboBox_Action
			// 
			this.ComboBox_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_Action.Font = new System.Drawing.Font("黑体", 12F);
			this.ComboBox_Action.FormattingEnabled = true;
			this.ComboBox_Action.Location = new System.Drawing.Point(17, 128);
			this.ComboBox_Action.Name = "ComboBox_Action";
			this.ComboBox_Action.Size = new System.Drawing.Size(266, 24);
			this.ComboBox_Action.TabIndex = 6;
			this.ComboBox_Action.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Action_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "2.选择动作名称";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(113, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "自动生成的动画名称";
			// 
			// NameText
			// 
			this.NameText.Font = new System.Drawing.Font("宋体", 16F);
			this.NameText.Location = new System.Drawing.Point(37, 52);
			this.NameText.Name = "NameText";
			this.NameText.Size = new System.Drawing.Size(246, 32);
			this.NameText.TabIndex = 9;
			// 
			// Button_Copy
			// 
			this.Button_Copy.Location = new System.Drawing.Point(83, 118);
			this.Button_Copy.Name = "Button_Copy";
			this.Button_Copy.Size = new System.Drawing.Size(168, 45);
			this.Button_Copy.TabIndex = 10;
			this.Button_Copy.Text = "点击复制该文本";
			this.Button_Copy.UseVisualStyleBackColor = true;
			this.Button_Copy.Click += new System.EventHandler(this.Button_Copy_Click);
			// 
			// Panel_Option
			// 
			this.Panel_Option.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel_Option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel_Option.Controls.Add(this.label4);
			this.Panel_Option.Controls.Add(this.ComboBox_Action);
			this.Panel_Option.Controls.Add(this.label1);
			this.Panel_Option.Controls.Add(this.ComboBox_Name);
			this.Panel_Option.Controls.Add(this.label2);
			this.Panel_Option.Location = new System.Drawing.Point(32, 53);
			this.Panel_Option.Name = "Panel_Option";
			this.Panel_Option.Size = new System.Drawing.Size(301, 197);
			this.Panel_Option.TabIndex = 11;
			// 
			// Panel_Text
			// 
			this.Panel_Text.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Panel_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel_Text.Controls.Add(this.Button_Copy);
			this.Panel_Text.Controls.Add(this.label3);
			this.Panel_Text.Controls.Add(this.NameText);
			this.Panel_Text.Location = new System.Drawing.Point(361, 53);
			this.Panel_Text.Name = "Panel_Text";
			this.Panel_Text.Size = new System.Drawing.Size(315, 197);
			this.Panel_Text.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(275, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "（如果Ase文件包含多个动作，以第一个动作命名）";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 320);
			this.Controls.Add(this.Panel_Text);
			this.Controls.Add(this.Panel_Option);
			this.Name = "Form1";
			this.Text = "动画名称生成器";
			this.Panel_Option.ResumeLayout(false);
			this.Panel_Option.PerformLayout();
			this.Panel_Text.ResumeLayout(false);
			this.Panel_Text.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ComboBox_Name;
		private System.Windows.Forms.ComboBox ComboBox_Action;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NameText;
		private System.Windows.Forms.Button Button_Copy;
		private System.Windows.Forms.Panel Panel_Option;
		private System.Windows.Forms.Panel Panel_Text;
		private System.Windows.Forms.Label label4;
	}
}

