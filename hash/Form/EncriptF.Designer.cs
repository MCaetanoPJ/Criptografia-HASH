/*
 * Created by SharpDevelop.
 * User: hp
 * Date: 19/10/2017
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace hash
{
	partial class EncriptF
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox userTxt;
		private System.Windows.Forms.TextBox passTxt;
		private System.Windows.Forms.Button voltar;
	
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.userTxt = new System.Windows.Forms.TextBox();
			this.passTxt = new System.Windows.Forms.TextBox();
			this.voltar = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaGreen;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(164, 200);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 42);
			this.button1.TabIndex = 0;
			this.button1.Text = "Encriptar";
			this.button1.UseCompatibleTextRendering = true;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(138, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuário";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(138, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Senha";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// userTxt
			// 
			this.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.userTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userTxt.Location = new System.Drawing.Point(78, 89);
			this.userTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.userTxt.Name = "userTxt";
			this.userTxt.ReadOnly = true;
			this.userTxt.Size = new System.Drawing.Size(292, 26);
			this.userTxt.TabIndex = 1;
			this.userTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.userTxt.TextChanged += new System.EventHandler(this.UserTxtTextChanged);
			// 
			// passTxt
			// 
			this.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.passTxt.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passTxt.Location = new System.Drawing.Point(78, 158);
			this.passTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.passTxt.Name = "passTxt";
			this.passTxt.ReadOnly = true;
			this.passTxt.Size = new System.Drawing.Size(292, 26);
			this.passTxt.TabIndex = 2;
			this.passTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// voltar
			// 
			this.voltar.BackColor = System.Drawing.Color.WhiteSmoke;
			this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.voltar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
			this.voltar.FlatAppearance.BorderSize = 0;
			this.voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.voltar.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.voltar.ForeColor = System.Drawing.Color.SeaGreen;
			this.voltar.Location = new System.Drawing.Point(377, 15);
			this.voltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.voltar.Name = "voltar";
			this.voltar.Size = new System.Drawing.Size(76, 32);
			this.voltar.TabIndex = 6;
			this.voltar.Text = "Voltar";
			this.voltar.UseCompatibleTextRendering = true;
			this.voltar.UseVisualStyleBackColor = false;
			this.voltar.Click += new System.EventHandler(this.VoltarClick);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(78, 306);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(292, 41);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(138, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(176, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Mensagem";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.SeaGreen;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(164, 367);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(127, 42);
			this.button3.TabIndex = 9;
			this.button3.Text = "Encriptar";
			this.button3.UseCompatibleTextRendering = true;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// EncriptF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(449, 462);
			this.ControlBox = false;
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.voltar);
			this.Controls.Add(this.passTxt);
			this.Controls.Add(this.userTxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.MaximizeBox = false;
			this.Name = "EncriptF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Criptografia";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
	}
}