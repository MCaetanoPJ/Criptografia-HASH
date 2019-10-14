using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace hash
{
	public partial class Rform : Form
	{
		public Rform()
		{
			InitializeComponent();
		}
		void RegisterClick(object sender, EventArgs e)
		{
			string rusuario = registrousuario.Text;
			if(registrousuario.Text.Length <4 || passTxt.Text.Length <5)
			{
				MessageBox.Show("Usuário ou senha muito curto");
			}
			else if (Nome.Text.Length <2 )
			{
				MessageBox.Show ("Digite um nome válido");
			}
			else if(!Directory.Exists("data\\"+rusuario))
			{
				Directory.CreateDirectory("data\\"+rusuario);
				
				var sw= new StreamWriter("data\\"+rusuario+"\\data.ls");
				string encriptnome= Cript.Criptografia.EncriptarMd5(Nome.Text);
				string encriptusuario= Cript.Criptografia.EncriptarMd5(registrousuario.Text);
				string encriptsenha=Cript.Criptografia.EncriptarMd5(passTxt.Text);
				sw.WriteLine(encriptnome);
				sw.WriteLine(encriptusuario);
				sw.WriteLine(encriptsenha);
				sw.Close();
				
				MessageBox.Show("Registro completo");
				this.Close();
				
			}
			
			else
			{
				MessageBox.Show("Usuário "+rusuario+ " já existe");
				
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
		
		void RformLoad(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
	}
}
