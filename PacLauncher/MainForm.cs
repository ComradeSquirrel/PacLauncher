using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacLauncher.Compatability;
using PacLauncher.Compatability.Platform;

namespace PacLauncher {
	public partial class MainForm:Form {
		private List<Package> _packages = new List<Package>();

		public MainForm() {
			InitializeComponent();
		}

		private void spaceButton3_Click(object sender,EventArgs e) {
			Console.WriteLine("This wasn't implemented, due to time constraints (and lack of using the actual database)... Sorry");
			throw new NotImplementedException();
		}

		private void spaceButton6_Click(object sender,EventArgs e) {
		}

		private void spaceButton7_Click(object sender,EventArgs e) {
			string fileName = fileNameInput.Text;
			string filePath = filePathInput.Text;
			string launchArgs = launchArgsInput.Text;
			if(fileNameInput.Text!=null&&fileNameInput.Text!=null) {
				MultiPlatform.Instance.Launch(filePath,fileName);
			}
		}

		private void spaceButton5_Click(object sender,EventArgs e) {
			Application.Exit();
		}

		private void spaceButton1_Click(object sender,EventArgs e) {
			addToConfig();
		}

		private void spaceButton8_Click(object sender,EventArgs e) {
			addToConfig();
		}
		private void addToConfig() {
			_packages.Add(new Package() {
				FileName=fileNameInput.Text,
				FilePath=filePathInput.Text,
				LaunchArgs=launchArgsInput.Text
			});
		}
	}
}
