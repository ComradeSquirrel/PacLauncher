using System.Linq;
namespace PacLauncher {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			hopeForm=new ReaLTaiizor.Forms.HopeForm();
			spaceButton5=new ReaLTaiizor.Controls.SpaceButton();
			spaceButton4=new ReaLTaiizor.Controls.SpaceButton();
			spaceButton2=new ReaLTaiizor.Controls.SpaceButton();
			spaceButton1=new ReaLTaiizor.Controls.SpaceButton();
			spaceButton3=new ReaLTaiizor.Controls.SpaceButton();
			splitContainer1=new System.Windows.Forms.SplitContainer();
			flowLayoutPanel1=new System.Windows.Forms.FlowLayoutPanel();
			tableLayoutPanel1=new System.Windows.Forms.TableLayoutPanel();
			panel2=new System.Windows.Forms.Panel();
			progressIndicator1=new ReaLTaiizor.Controls.ProgressIndicator();
			spaceButton7=new ReaLTaiizor.Controls.SpaceButton();
			fileNameInput=new ReaLTaiizor.Controls.ForeverTextBox();
			thunderLabel4=new ReaLTaiizor.Controls.ThunderLabel();
			launchArgsInput=new ReaLTaiizor.Controls.ForeverTextBox();
			thunderLabel3=new ReaLTaiizor.Controls.ThunderLabel();
			filePathInput=new ReaLTaiizor.Controls.ForeverTextBox();
			thunderLabel2=new ReaLTaiizor.Controls.ThunderLabel();
			tableLayoutPanel2=new System.Windows.Forms.TableLayoutPanel();
			panel3=new System.Windows.Forms.Panel();
			spaceButton8=new ReaLTaiizor.Controls.SpaceButton();
			panel1=new System.Windows.Forms.Panel();
			thunderLabel1=new ReaLTaiizor.Controls.ThunderLabel();
			foreverComboBox1=new ReaLTaiizor.Controls.ForeverComboBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			panel2.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			panel3.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// hopeForm
			// 
			hopeForm.ControlBoxColorH=System.Drawing.Color.FromArgb(228,231,237);
			hopeForm.ControlBoxColorHC=System.Drawing.Color.FromArgb(245,108,108);
			hopeForm.ControlBoxColorN=System.Drawing.Color.White;
			hopeForm.Dock=System.Windows.Forms.DockStyle.Top;
			hopeForm.Font=new System.Drawing.Font("Segoe UI",12F);
			hopeForm.ForeColor=System.Drawing.Color.FromArgb(242,246,252);
			hopeForm.Image=null;
			hopeForm.Location=new System.Drawing.Point(0,0);
			hopeForm.Name="hopeForm";
			hopeForm.Size=new System.Drawing.Size(869,40);
			hopeForm.TabIndex=0;
			hopeForm.Text="PacLauncher";
			hopeForm.ThemeColor=System.Drawing.Color.FromArgb(40,56,72);
			// 
			// spaceButton5
			// 
			spaceButton5.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton5.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton5.Image=null;
			spaceButton5.Location=new System.Drawing.Point(3,347);
			spaceButton5.Name="spaceButton5";
			spaceButton5.NoRounding=false;
			spaceButton5.Size=new System.Drawing.Size(80,80);
			spaceButton5.TabIndex=4;
			spaceButton5.Text="Exit";
			spaceButton5.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton5.Transparent=false;
			spaceButton5.Click+=spaceButton5_Click;
			// 
			// spaceButton4
			// 
			spaceButton4.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton4.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton4.Image=null;
			spaceButton4.Location=new System.Drawing.Point(3,261);
			spaceButton4.Name="spaceButton4";
			spaceButton4.NoRounding=false;
			spaceButton4.Size=new System.Drawing.Size(80,80);
			spaceButton4.TabIndex=3;
			spaceButton4.Text="Remove";
			spaceButton4.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton4.Transparent=false;
			// 
			// spaceButton2
			// 
			spaceButton2.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton2.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton2.Image=null;
			spaceButton2.Location=new System.Drawing.Point(3,175);
			spaceButton2.Name="spaceButton2";
			spaceButton2.NoRounding=false;
			spaceButton2.Size=new System.Drawing.Size(80,80);
			spaceButton2.TabIndex=1;
			spaceButton2.Text="Modify";
			spaceButton2.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton2.Transparent=false;
			// 
			// spaceButton1
			// 
			spaceButton1.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton1.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton1.Image=null;
			spaceButton1.Location=new System.Drawing.Point(3,89);
			spaceButton1.Name="spaceButton1";
			spaceButton1.NoRounding=false;
			spaceButton1.Size=new System.Drawing.Size(80,80);
			spaceButton1.TabIndex=0;
			spaceButton1.Text="Add";
			spaceButton1.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton1.Transparent=false;
			spaceButton1.Click+=spaceButton1_Click;
			// 
			// spaceButton3
			// 
			spaceButton3.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton3.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton3.Image=null;
			spaceButton3.Location=new System.Drawing.Point(3,3);
			spaceButton3.Name="spaceButton3";
			spaceButton3.NoRounding=false;
			spaceButton3.Size=new System.Drawing.Size(80,80);
			spaceButton3.TabIndex=2;
			spaceButton3.Text="Reload";
			spaceButton3.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton3.Transparent=false;
			spaceButton3.Click+=spaceButton3_Click;
			// 
			// splitContainer1
			// 
			splitContainer1.BackColor=System.Drawing.Color.FromArgb(58,58,69);
			splitContainer1.Dock=System.Windows.Forms.DockStyle.Fill;
			splitContainer1.Location=new System.Drawing.Point(0,40);
			splitContainer1.Name="splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
			splitContainer1.Size=new System.Drawing.Size(869,433);
			splitContainer1.SplitterDistance=86;
			splitContainer1.TabIndex=2;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor=System.Drawing.Color.FromArgb(58,58,69);
			flowLayoutPanel1.Controls.Add(spaceButton3);
			flowLayoutPanel1.Controls.Add(spaceButton1);
			flowLayoutPanel1.Controls.Add(spaceButton2);
			flowLayoutPanel1.Controls.Add(spaceButton4);
			flowLayoutPanel1.Controls.Add(spaceButton5);
			flowLayoutPanel1.Dock=System.Windows.Forms.DockStyle.Fill;
			flowLayoutPanel1.Location=new System.Drawing.Point(0,0);
			flowLayoutPanel1.Name="flowLayoutPanel1";
			flowLayoutPanel1.Size=new System.Drawing.Size(86,433);
			flowLayoutPanel1.TabIndex=0;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount=1;
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,100F));
			tableLayoutPanel1.Controls.Add(panel2,0,1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2,0,0);
			tableLayoutPanel1.Dock=System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel1.Location=new System.Drawing.Point(0,0);
			tableLayoutPanel1.Name="tableLayoutPanel1";
			tableLayoutPanel1.RowCount=2;
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,66.6666641F));
			tableLayoutPanel1.Size=new System.Drawing.Size(779,433);
			tableLayoutPanel1.TabIndex=0;
			// 
			// panel2
			// 
			panel2.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
			panel2.Controls.Add(progressIndicator1);
			panel2.Controls.Add(spaceButton7);
			panel2.Controls.Add(fileNameInput);
			panel2.Controls.Add(thunderLabel4);
			panel2.Controls.Add(launchArgsInput);
			panel2.Controls.Add(thunderLabel3);
			panel2.Controls.Add(filePathInput);
			panel2.Controls.Add(thunderLabel2);
			panel2.Dock=System.Windows.Forms.DockStyle.Fill;
			panel2.Location=new System.Drawing.Point(3,147);
			panel2.Name="panel2";
			panel2.Size=new System.Drawing.Size(773,283);
			panel2.TabIndex=4;
			// 
			// progressIndicator1
			// 
			progressIndicator1.Location=new System.Drawing.Point(290,-17);
			progressIndicator1.MinimumSize=new System.Drawing.Size(50,50);
			progressIndicator1.Name="progressIndicator1";
			progressIndicator1.P_AnimationColor=System.Drawing.Color.DimGray;
			progressIndicator1.P_AnimationSpeed=100;
			progressIndicator1.P_BaseColor=System.Drawing.Color.DarkGray;
			progressIndicator1.Size=new System.Drawing.Size(120,120);
			progressIndicator1.TabIndex=8;
			progressIndicator1.Text="progressIndicator1";
			progressIndicator1.Visible=false;
			// 
			// spaceButton7
			// 
			spaceButton7.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton7.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton7.Image=null;
			spaceButton7.Location=new System.Drawing.Point(469,171);
			spaceButton7.Name="spaceButton7";
			spaceButton7.NoRounding=false;
			spaceButton7.Size=new System.Drawing.Size(180,60);
			spaceButton7.TabIndex=7;
			spaceButton7.Text="Launch!!!";
			spaceButton7.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton7.Transparent=false;
			spaceButton7.Click+=spaceButton7_Click;
			// 
			// fileNameInput
			// 
			fileNameInput.BackColor=System.Drawing.Color.Transparent;
			fileNameInput.BaseColor=System.Drawing.Color.FromArgb(45,47,49);
			fileNameInput.BorderColor=System.Drawing.Color.FromArgb(35,168,109);
			fileNameInput.FocusOnHover=false;
			fileNameInput.ForeColor=System.Drawing.Color.FromArgb(192,192,192);
			fileNameInput.Location=new System.Drawing.Point(469,65);
			fileNameInput.MaxLength=32767;
			fileNameInput.Multiline=false;
			fileNameInput.Name="fileNameInput";
			fileNameInput.ReadOnly=false;
			fileNameInput.Size=new System.Drawing.Size(182,38);
			fileNameInput.TabIndex=6;
			fileNameInput.TextAlign=System.Windows.Forms.HorizontalAlignment.Left;
			fileNameInput.UseSystemPasswordChar=false;
			// 
			// thunderLabel4
			// 
			thunderLabel4.BackColor=System.Drawing.Color.Transparent;
			thunderLabel4.ForeColor=System.Drawing.Color.WhiteSmoke;
			thunderLabel4.Location=new System.Drawing.Point(509,3);
			thunderLabel4.Name="thunderLabel4";
			thunderLabel4.Size=new System.Drawing.Size(100,77);
			thunderLabel4.TabIndex=5;
			thunderLabel4.Text="File Name";
			// 
			// launchArgsInput
			// 
			launchArgsInput.BackColor=System.Drawing.Color.Transparent;
			launchArgsInput.BaseColor=System.Drawing.Color.FromArgb(45,47,49);
			launchArgsInput.BorderColor=System.Drawing.Color.FromArgb(35,168,109);
			launchArgsInput.FocusOnHover=false;
			launchArgsInput.ForeColor=System.Drawing.Color.FromArgb(192,192,192);
			launchArgsInput.Location=new System.Drawing.Point(56,193);
			launchArgsInput.MaxLength=32767;
			launchArgsInput.Multiline=false;
			launchArgsInput.Name="launchArgsInput";
			launchArgsInput.ReadOnly=false;
			launchArgsInput.Size=new System.Drawing.Size(182,38);
			launchArgsInput.TabIndex=4;
			launchArgsInput.TextAlign=System.Windows.Forms.HorizontalAlignment.Left;
			launchArgsInput.UseSystemPasswordChar=false;
			// 
			// thunderLabel3
			// 
			thunderLabel3.BackColor=System.Drawing.Color.Transparent;
			thunderLabel3.ForeColor=System.Drawing.Color.WhiteSmoke;
			thunderLabel3.Location=new System.Drawing.Point(97,110);
			thunderLabel3.Name="thunderLabel3";
			thunderLabel3.Size=new System.Drawing.Size(100,77);
			thunderLabel3.TabIndex=3;
			thunderLabel3.Text="Launch Args";
			// 
			// filePathInput
			// 
			filePathInput.BackColor=System.Drawing.Color.Transparent;
			filePathInput.BaseColor=System.Drawing.Color.FromArgb(45,47,49);
			filePathInput.BorderColor=System.Drawing.Color.FromArgb(35,168,109);
			filePathInput.FocusOnHover=false;
			filePathInput.ForeColor=System.Drawing.Color.FromArgb(192,192,192);
			filePathInput.Location=new System.Drawing.Point(56,65);
			filePathInput.MaxLength=32767;
			filePathInput.Multiline=false;
			filePathInput.Name="filePathInput";
			filePathInput.ReadOnly=false;
			filePathInput.Size=new System.Drawing.Size(182,38);
			filePathInput.TabIndex=2;
			filePathInput.TextAlign=System.Windows.Forms.HorizontalAlignment.Left;
			filePathInput.UseSystemPasswordChar=false;
			// 
			// thunderLabel2
			// 
			thunderLabel2.BackColor=System.Drawing.Color.Transparent;
			thunderLabel2.ForeColor=System.Drawing.Color.WhiteSmoke;
			thunderLabel2.Location=new System.Drawing.Point(97,3);
			thunderLabel2.Name="thunderLabel2";
			thunderLabel2.Size=new System.Drawing.Size(100,77);
			thunderLabel2.TabIndex=1;
			thunderLabel2.Text="File Path";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount=2;
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,37.5F));
			tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,62.5F));
			tableLayoutPanel2.Controls.Add(panel3,1,0);
			tableLayoutPanel2.Controls.Add(panel1,0,0);
			tableLayoutPanel2.Dock=System.Windows.Forms.DockStyle.Fill;
			tableLayoutPanel2.Location=new System.Drawing.Point(3,3);
			tableLayoutPanel2.Name="tableLayoutPanel2";
			tableLayoutPanel2.RowCount=1;
			tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent,100F));
			tableLayoutPanel2.Size=new System.Drawing.Size(773,138);
			tableLayoutPanel2.TabIndex=0;
			// 
			// panel3
			// 
			panel3.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
			panel3.Controls.Add(spaceButton8);
			panel3.Location=new System.Drawing.Point(292,3);
			panel3.Name="panel3";
			panel3.Size=new System.Drawing.Size(478,132);
			panel3.TabIndex=4;
			// 
			// spaceButton8
			// 
			spaceButton8.Customization="Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
			spaceButton8.Font=new System.Drawing.Font("Verdana",8F);
			spaceButton8.Image=null;
			spaceButton8.Location=new System.Drawing.Point(177,50);
			spaceButton8.Name="spaceButton8";
			spaceButton8.NoRounding=false;
			spaceButton8.Size=new System.Drawing.Size(180,60);
			spaceButton8.TabIndex=9;
			spaceButton8.Text="Add to config";
			spaceButton8.TextAlignment=System.Windows.Forms.HorizontalAlignment.Center;
			spaceButton8.Transparent=false;
			spaceButton8.Click+=spaceButton8_Click;
			// 
			// panel1
			// 
			panel1.BorderStyle=System.Windows.Forms.BorderStyle.FixedSingle;
			panel1.Controls.Add(thunderLabel1);
			panel1.Controls.Add(foreverComboBox1);
			panel1.Location=new System.Drawing.Point(3,3);
			panel1.Name="panel1";
			panel1.Size=new System.Drawing.Size(282,132);
			panel1.TabIndex=2;
			// 
			// thunderLabel1
			// 
			thunderLabel1.BackColor=System.Drawing.Color.Transparent;
			thunderLabel1.ForeColor=System.Drawing.Color.WhiteSmoke;
			thunderLabel1.Location=new System.Drawing.Point(82,3);
			thunderLabel1.Name="thunderLabel1";
			thunderLabel1.Size=new System.Drawing.Size(112,77);
			thunderLabel1.TabIndex=1;
			thunderLabel1.Text="Configured Packages";
			// 
			// foreverComboBox1
			// 
			foreverComboBox1.BaseColor=System.Drawing.Color.FromArgb(25,27,29);
			foreverComboBox1.BGColor=System.Drawing.Color.FromArgb(45,47,49);
			foreverComboBox1.DrawMode=System.Windows.Forms.DrawMode.OwnerDrawFixed;
			foreverComboBox1.DropDownStyle=System.Windows.Forms.ComboBoxStyle.DropDownList;
			foreverComboBox1.Font=new System.Drawing.Font("Segoe UI",8F);
			foreverComboBox1.ForeColor=System.Drawing.Color.White;
			foreverComboBox1.FormattingEnabled=true;
			foreverComboBox1.HoverColor=System.Drawing.Color.FromArgb(35,168,109);
			foreverComboBox1.HoverFontColor=System.Drawing.Color.White;
			foreverComboBox1.ItemHeight=18;
			foreverComboBox1.Items.AddRange((from x in _packages.ToArray() select x.FileName).ToArray());
			foreverComboBox1.Location=new System.Drawing.Point(53,86);
			foreverComboBox1.Name="foreverComboBox1";
			foreverComboBox1.Size=new System.Drawing.Size(182,24);
			foreverComboBox1.TabIndex=3;
			// 
			// MainForm
			// 
			AutoScaleDimensions=new System.Drawing.SizeF(10F,25F);
			AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			ClientSize=new System.Drawing.Size(869,473);
			Controls.Add(splitContainer1);
			Controls.Add(hopeForm);
			FormBorderStyle=System.Windows.Forms.FormBorderStyle.None;
			MaximumSize=new System.Drawing.Size(1920,1128);
			MinimumSize=new System.Drawing.Size(190,40);
			Name="MainForm";
			StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
			Text="MainForm";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private ReaLTaiizor.Forms.HopeForm hopeForm;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private ReaLTaiizor.Controls.SpaceButton spaceButton3;
		private ReaLTaiizor.Controls.SpaceButton spaceButton1;
		private ReaLTaiizor.Controls.SpaceButton spaceButton2;
		private ReaLTaiizor.Controls.SpaceButton spaceButton4;
		private ReaLTaiizor.Controls.SpaceButton spaceButton5;
		private System.Windows.Forms.Panel panel1;
		private ReaLTaiizor.Controls.ThunderLabel thunderLabel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel2;
		private ReaLTaiizor.Controls.ForeverTextBox filePathInput;
		private ReaLTaiizor.Controls.ThunderLabel thunderLabel2;
		private ReaLTaiizor.Controls.ForeverComboBox foreverComboBox1;
		private ReaLTaiizor.Controls.SpaceButton spaceButton7;
		private ReaLTaiizor.Controls.ForeverTextBox fileNameInput;
		private ReaLTaiizor.Controls.ThunderLabel thunderLabel4;
		private ReaLTaiizor.Controls.ForeverTextBox launchArgsInput;
		private ReaLTaiizor.Controls.ThunderLabel thunderLabel3;
		private ReaLTaiizor.Controls.ProgressIndicator progressIndicator1;
		private System.Windows.Forms.Panel panel3;
		private ReaLTaiizor.Controls.SpaceButton spaceButton8;
	}
}