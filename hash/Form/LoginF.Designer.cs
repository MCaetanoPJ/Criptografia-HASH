/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 29/08/2017
 * Time: 22:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hash
{
	partial class LoginForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox userTxt;
		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Button Login;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Timer timer1;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.userTxt = new System.Windows.Forms.TextBox();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.Login = new System.Windows.Forms.Button();
			this.Register = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// userTxt
			// 
			this.userTxt.Location = new System.Drawing.Point(147, 40);
			this.userTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.userTxt.Name = "userTxt";
			this.userTxt.Size = new System.Drawing.Size(223, 26);
			this.userTxt.TabIndex = 0;
			// 
			// passTxt
			// 
			this.passTxt.Location = new System.Drawing.Point(147, 90);
			this.passTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.passTxt.Name = "passTxt";
			this.passTxt.Size = new System.Drawing.Size(223, 26);
			this.passTxt.TabIndex = 1;
			this.passTxt.UseSystemPasswordChar = true;
			this.passTxt.TextChanged += new System.EventHandler(this.PassTxtTextChanged);
			// 
			// Login
			// 
			this.Login.BackColor = System.Drawing.Color.White;
			this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Login.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
			this.Login.FlatAppearance.BorderSize = 2;
			this.Login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuBar;
			this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Login.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login.ForeColor = System.Drawing.Color.SeaGreen;
			this.Login.Location = new System.Drawing.Point(147, 147);
			this.Login.Margin = new System.Windows.Forms.Padding(1);
			this.Login.Name = "Login";
			this.Login.Size = new System.Drawing.Size(100, 35);
			this.Login.TabIndex = 2;
			this.Login.Text = "Login";
			this.Login.UseCompatibleTextRendering = true;
			this.Login.UseVisualStyleBackColor = false;
			this.Login.Click += new System.EventHandler(this.Button1Click);
			// 
			// Register
			// 
			this.Register.BackColor = System.Drawing.Color.SeaGreen;
			this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Register.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
			this.Register.FlatAppearance.BorderSize = 0;
			this.Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
			this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Register.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Register.ForeColor = System.Drawing.Color.White;
			this.Register.Location = new System.Drawing.Point(270, 147);
			this.Register.Margin = new System.Windows.Forms.Padding(1);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(100, 35);
			this.Register.TabIndex = 3;
			this.Register.Text = "Registrar";
			this.Register.UseCompatibleTextRendering = true;
			this.Register.UseVisualStyleBackColor = false;
			this.Register.Click += new System.EventHandler(this.RegisterClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(83, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 26);
			this.label1.TabIndex = 4;
			this.label1.Text = "Usuário";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(91, 85);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 35);
			this.label2.TabIndex = 5;
			this.label2.Text = "Senha";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(378, 92);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(124, 24);
			this.checkBox1.TabIndex = 17;
			this.checkBox1.Text = "Mostrar Senha";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(512, 219);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.Login);
			this.Controls.Add(this.passTxt);
			this.Controls.Add(this.userTxt);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.TransparencyKey = System.Drawing.Color.PaleVioletRed;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		}
	}