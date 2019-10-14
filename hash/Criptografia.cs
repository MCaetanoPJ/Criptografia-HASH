using System;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
namespace Cript
{
	public class Criptografia
	{ 
		public static string EncriptarMd5(string input)
		{
			MD5 hashmd5 = MD5.Create();
			byte[] data = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(input));
    		StringBuilder nstring = new StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				nstring.Append(data[i].ToString("x2"));
			}
			
			return nstring.ToString();
		}		
	}
}