using System;
using System.Drawing;
using System.Windows.Forms;

namespace hash
{
	public partial class EncriptF : Form
	{
		public EncriptF()
		{
			InitializeComponent();
			userTxt.Text=LoginForm.User;
			passTxt.Text=LoginForm.Pass;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			userTxt.Text = Cript.Criptografia.EncriptarMd5(LoginForm.User);
			passTxt.Text =Cript.Criptografia.EncriptarMd5(LoginForm.Pass);
		}
		void VoltarClick(object sender, EventArgs e)
		{
			this.Close();
			LoginForm lf= new LoginForm();
			lf.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length == 0)
			{
				MessageBox.Show ("Digite sua mensagem");
			}
			else
			{
			    textBox1.Text = Cript.Criptografia.EncriptarMd5(textBox1.Text);
			}
		
		}
		
		
		void UserTxtTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
