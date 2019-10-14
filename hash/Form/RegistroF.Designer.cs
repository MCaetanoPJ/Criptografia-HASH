namespace hash
{
	partial class Rform
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox registrousuario;
		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TextBox Nome;
		private System.Windows.Forms.Label label3;
		
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
			this.registrousuario = new System.Windows.Forms.TextBox();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.Register = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.Nome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// registrousuario
			// 
			this.registrousuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.registrousuario.Location = new System.Drawing.Point(84, 84);
			this.registrousuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.registrousuario.Name = "registrousuario";
			this.registrousuario.Size = new System.Drawing.Size(155, 26);
			this.registrousuario.TabIndex = 2;
			// 
			// passTxt
			// 
			this.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passTxt.ForeColor = System.Drawing.SystemColors.WindowText;
			this.passTxt.Location = new System.Drawing.Point(84, 141);
			this.passTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.passTxt.Name = "passTxt";
			this.passTxt.Size = new System.Drawing.Size(155, 26);
			this.passTxt.TabIndex = 3;
			this.passTxt.UseSystemPasswordChar = true;
			this.passTxt.TextChanged += new System.EventHandler(this.PassTxtTextChanged);
			// 
			// Register
			// 
			this.Register.BackColor = System.Drawing.Color.SeaGreen;
			this.Register.FlatAppearance.BorderSize = 2;
			this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Register.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Register.ForeColor = System.Drawing.Color.White;
			this.Register.Location = new System.Drawing.Point(93, 207);
			this.Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(135, 42);
			this.Register.TabIndex = 7;
			this.Register.Text = "Criar conta";
			this.Register.UseVisualStyleBackColor = false;
			this.Register.Click += new System.EventHandler(this.RegisterClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 84);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 35);
			this.label1.TabIndex = 8;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 141);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 35);
			this.label2.TabIndex = 9;
			this.label2.Text = "Senha";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(104, 177);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(124, 20);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Mostrar Senha";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// Nome
			// 
			this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Nome.Location = new System.Drawing.Point(84, 31);
			this.Nome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Nome.Name = "Nome";
			this.Nome.Size = new System.Drawing.Size(155, 26);
			this.Nome.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 31);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 35);
			this.label3.TabIndex = 13;
			this.label3.Text = "Nome";
			// 
			// Rform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(280, 280);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Nome);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.passTxt);
			this.Controls.Add(this.registrousuario);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "Rform";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro";
			this.Load += new System.EventHandler(this.RformLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
