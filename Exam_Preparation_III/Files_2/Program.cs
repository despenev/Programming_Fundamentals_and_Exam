using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Files_2
{
    class MainClass
    {
        class File
        {
            public string Root { get; set; }
            public string FileName { get; set; }
            public long FileSize { get; set; }
            public string Ext { get; set; }
        }
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var filesList = new List<File>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var lastSemicolumn = input.LastIndexOf(';');
                var fileSize = long.Parse(input.Substring(lastSemicolumn + 1));
                var firstSlash= input.IndexOf('\\');
                var root = input.Substring(0, firstSlash);
                var lastSlash = input.LastIndexOf('\\');
                input = input.Substring(0, lastSemicolumn);

                var fileName = input.Substring(lastSlash + 1);
                var ext = fileName.Substring(fileName.LastIndexOf('.')+1);

                if (filesList.Any(x => x.Root == root && x.FileName == fileName))
                {
                    var match = filesList.FirstOrDefault(x => x.Root == root && x.FileName == fileName);
                    match.FileSize = fileSize;
                }
                else
                {
                    var file = new File()
                    {
                        FileSize = fileSize,
                        Root = root,
                        FileName = fileName,
                        Ext = ext
                    };
                    filesList.Add(file);
                }

            }

            var extAndLocation = Regex.Split(Console.ReadLine(), @"\s+in\s+").ToArray();
            var wandedExt = extAndLocation[0];
            var wantedRoot = extAndLocation[1];

            if (filesList.Where(r => r.Root == wantedRoot).Where(e => e.Ext == wandedExt).OrderByDescending(x => x.FileSize).ThenBy(x => x.FileName).ToList().Count!=0)
            {

				foreach (var file in filesList.Where(r => r.Root == wantedRoot).Where(e => e.Ext == wandedExt).OrderByDescending(x => x.FileSize).ThenBy(x => x.FileName))
				{
					Console.WriteLine($"{file.FileName} - {file.FileSize} KB");
				}
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
