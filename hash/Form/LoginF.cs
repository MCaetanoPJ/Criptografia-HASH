using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Drawing;

namespace hash
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}
		
		public static string User, Pass =" ";
		void RegisterClick(object sender, EventArgs e)
		{
			Rform rf= new Rform();
			rf.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			
			if(userTxt.Text.Length < 3||passTxt.Text.Length < 5)
			{
				MessageBox.Show("Usuário ou senha inválido ou muito curto");
			}
			else
			{
				User= userTxt.Text;
				Pass= passTxt.Text;
				if(!Directory.Exists("data\\"+User))
					MessageBox.Show(string.Format("Usuário {0} não existe", User));
				else
				{
					var sr = new StreamReader("data\\" + User + "\\data.ls");
					string encriptnome=sr.ReadLine();
					string encriptusuario=sr.ReadLine();
					string encriptsenha=sr.ReadLine();
					sr.Close();
					string encriptusuarior=Cript.Criptografia.EncriptarMd5(User);
					string encriptsenhar=Cript.Criptografia.EncriptarMd5(Pass);
					if(encriptusuarior == encriptusuario && encriptsenhar == encriptsenha)
					{
						this.Hide();
						EncriptF ef= new EncriptF();
						ef.Show();
					}
					else
					{
						MessageBox.Show("Usuário ou senha incorreto");
					}
				}
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			 if (checkBox1.Checked == true)
            {
                passTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passTxt.UseSystemPasswordChar = true;
            }
		}
		
		void PassTxtTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
