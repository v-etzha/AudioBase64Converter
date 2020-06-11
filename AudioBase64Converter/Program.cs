using System;
using System.IO;

namespace AudioBase64Converter
{
	class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"C:\Users\Ethan\Desktop\AudioSource\test.webm";
			try
			{
				using (FileStream fsRead = new FileStream(filePath, FileMode.Open))
				{
					int fsLen = (int)fsRead.Length;
					byte[] heByte = new byte[fsLen];
					int r = fsRead.Read(heByte, 0, heByte.Length);
					string base64Str = Convert.ToBase64String(heByte);


					//FileStream fileStream = File.OpenRead(filePath);
					//byte[] fileByte = new byte[fileStream.Length];
					//string base64Str = Convert.ToBase64String(fileByte);
					//int r = fileStream.Read(fileByte, 0, (int)fileStream.Length);					
					File.WriteAllText(@"C:\Users\Ethan\Desktop\AudioSource\testwebmbase64.txt", base64Str);
				}
			}
			catch (IOException e)
			{
				throw e;
			}
		}
	}
}
