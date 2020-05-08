using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.IO;
using OfficeOpenXml;

namespace AnimationNamer {
	public partial class Form1 : Form {

		string table_Role = "RoleName";
		string table_Action = "ActionName";

		List<ComboBoxItem> names = new List<ComboBoxItem>();
		List<ComboBoxItem> actions = new List<ComboBoxItem>();

		public Form1() {
			InitializeComponent();

			Panel_Text.Enabled = false;

			ReadExcel(Directory.GetCurrentDirectory() + "/" + table_Role + ".xlsx", names);
			ReadExcel(Directory.GetCurrentDirectory() + "/" + table_Action + ".xlsx", actions);

			foreach (var item in names) {
				ComboBox_Name.Items.Add(item.name);
			}
			foreach (var item in actions) {
				ComboBox_Action.Items.Add(item.name);
			}
		}

		void ReadExcel(string path, List<ComboBoxItem> list) {
			FileInfo file = new FileInfo(path);

			//检测文件是否正在被使用
			try {
				using (FileStream fs = file.Open(FileMode.Open, FileAccess.Read)) {
					fs.Close();
				}
			}
			catch (IOException) {
				string errorText = string.Format("数据表{0}正在被使用，请将其关闭后再打开该软件。", file.Name);

				MessageBox.Show(errorText, "Error花生", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(1);
			}

			ExcelPackage package = new ExcelPackage(file);
			ExcelWorksheets sheets = package.Workbook.Worksheets;

			foreach (var sheet in sheets) {
				int rows = sheet.Dimension.Rows;

				list.Add(new ComboBoxItem("", string.Format("-------- {0} --------", sheet.Name), false));

				for (int row = 2; row < rows; row++) {
					if(sheet.Cells[rows, 1, rows, 2].All(c => c.Value != null)) {
						list.Add(new ComboBoxItem(sheet.GetValue(row, 2).ToString(), sheet.GetValue(row, 1).ToString(), true));
					}
				}
			}
		}

		//选择框变化
		private void ComboBox_Name_SelectedIndexChanged(object sender, EventArgs e) {
			SetText();

			Panel_Text.Enabled = NameText.Text != "";
		}
		private void ComboBox_Action_SelectedIndexChanged(object sender, EventArgs e) {
			SetText();

			Panel_Text.Enabled = NameText.Text != "";
		}

		//设置最终文本
		void SetText() {
			if (ComboBox_Name.SelectedIndex == -1 || ComboBox_Action.SelectedIndex == -1 ||
				!names[ComboBox_Name.SelectedIndex].selectable || !actions[ComboBox_Action.SelectedIndex].selectable) {
				NameText.Text = "";

				return;
			}

			string roleName = "";
			roleName = names[ComboBox_Name.SelectedIndex].id;
			string actionName = "";
			actionName = actions[ComboBox_Action.SelectedIndex].id;

			NameText.Text = string.Format("{0}_{1}", roleName, actionName);
		}

		void comboBox1_DrawItem(object sender, DrawItemEventArgs e) {

			e.DrawBackground();

			if(ComboBox_Name.Items[e.Index].ToString() == "-") {
				e.Graphics.DrawLine(Pens.Red, new Point(e.Bounds.Left, e.Bounds.Bottom - 1),
					new Point(e.Bounds.Right, e.Bounds.Bottom - 1));
			}
			else {
				TextRenderer.DrawText(e.Graphics, ComboBox_Name.Items[e.Index].ToString(),
				ComboBox_Name.Font, e.Bounds, ComboBox_Name.ForeColor, TextFormatFlags.Left);
			}

			e.DrawFocusRectangle();

		}

		//点击复制按钮
		private void Button_Copy_Click(object sender, EventArgs e) {
			if(NameText.Text != "")
				Clipboard.SetText(NameText.Text);
		}
	}

	struct ComboBoxItem {
		public string id;
		public string name;

		public bool selectable;

		public ComboBoxItem(string id, string name, bool selectable) {
			this.id = id;
			this.name = name;
			this.selectable = selectable;
		}
	}
}
