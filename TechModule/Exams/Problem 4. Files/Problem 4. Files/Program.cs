using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[int.Parse(Console.ReadLine().Trim())];

            List<InputData> datas = new List<InputData>();

            for (int i = 0; i < inputs.Length; i++)
            {
                string command = Console.ReadLine().Trim();

                var data = new InputData
                {
                    RootPath = GetRootFilePath(command),
                    FileName = GetFileName(command),
                    FileExtension = GetFileExtension(command),
                    FileSize = GetFileSize(command)
                };

                datas.Add(data);
            }


            string rootFolder = GetRootFolder(Console.ReadLine().Trim());

            for (int i = 0; i < datas.Count; i++)
            {
                var data = datas[i];

                if (string.Compare(data.RootPath, rootFolder, StringComparison.Ordinal) != 0)
                {
                    datas.RemoveAt(i);
                }

            }


            datas = datas.OrderBy(d => d.FileSize).OrderBy(d => d.FileName).ToList();

            for (int i = 0; i < datas.Count; i++)
            {
                var data = datas[i];
                Console.WriteLine($"{data.FileName}.{data.FileExtension} - {data.FileSize} KB");
            }



            Console.ReadKey();
        }


        private static string GetRootFilePath(string command)
        {
            string[] parts = command.Split('\\');
            string result = string.Join("\\", parts, 0, parts.Length - 1);
            return result;
        }

        private static string GetFileName(string command)
        {
            string[] parts = command.Split('\\');

            parts = parts[parts.Length - 1].Split('.');

            return parts[0];
        }

        private static string GetFileExtension(string command)
        {
            string[] parts = command.Split('\\');

            parts = parts[parts.Length - 1].Split('.');

            parts = parts[parts.Length - 1].Split(';');

            return parts[0];
        }

        private static int GetFileSize(string command)
        {
            string[] parts = command.Split('\\');

            parts = parts[parts.Length - 1].Split('.');

            parts = parts[parts.Length - 1].Split(';');

            return int.Parse(parts[1]);
        }

        private static string GetRootFolder(string command)
        {
            return command.Split(' ')[2];
        }


        private struct InputData
        {
            public string RootPath;
            public string FileName, FileExtension;
            public int FileSize;
        }
    }
}
