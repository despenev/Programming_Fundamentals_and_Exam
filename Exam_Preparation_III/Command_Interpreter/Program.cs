using System;
using System.Linq;
using System.Collections.Generic;


namespace Command_Interpreter
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var inputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			var backupList = new List<String>();
			var secondBackupList = new List<string>();

			var input = Console.ReadLine();
			while (input != "end")
			{
                
                var tokens = input.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                ////
                /// 
                /// 
                /// 
                ///       reverseFromCount
                /// 
                /// 
                try
                {
                    if (tokens[0] == "reverse" &&
                        tokens[1] == "from" &&
                       tokens[3] == "count")
                    {
                        var start = -1;
                        var count = -1;
                        try
                        {
                            start = int.Parse(tokens[2]);
                            count = int.Parse(tokens[4]);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input parameters.");
                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (start < 0 || start >= inputArray.Length || start + count > inputArray.Length || start + count < 0 || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");

                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        for (int i = 0; i < start; i++)
                        {

                            backupList.Add(inputArray[i]);
                        }

                        Array.Reverse(inputArray); ////reversinggg 

                        for (int i = inputArray.Length - (start + count); i < inputArray.Length - start; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }
                        Array.Reverse(inputArray);

                        for (int i = start + count; i < inputArray.Length; i++)
                        {
                            backupList.Add(inputArray[i]);

                        }
                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            inputArray[i] = backupList[i];
                        }
                        backupList = new List<string>();
                        input = Console.ReadLine().ToLower();
                        continue;

                    }
                }
                catch (System.ArgumentOutOfRangeException)
                {
					Console.WriteLine("Invalid input parameters.");
					input = Console.ReadLine().ToLower();
					continue;
                    
                }
                ////
                /// 
                /// 
                ///     SORT FROM COUNT
                /// 
                /// 
                try
                {
                    if (tokens[0] == "sort" &&
                       tokens[1] == "from" &&
                      tokens[3] == "count")
                    {
                        var start = -1;
                        var count = -1;
                        try
                        {
                            start = int.Parse(tokens[2]);
                            count = int.Parse(tokens[4]);
                        }
                        catch
                        {
                            Console.WriteLine("Invalid input parameters.");
                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (start < 0 || start >= inputArray.Length || start + count > inputArray.Length || start + count < 0 || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");

input = Console.ReadLine().ToLower();
                            continue;
                        }
                        for (int i = 0; i < start; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }
                        for (int i = start; i < start + count; i++)
                        {
                            secondBackupList.Add(inputArray[i]);
                        }
                        secondBackupList.Sort();
                        for (int i = 0; i < secondBackupList.Count; i++)
                        {
                            backupList.Add(secondBackupList[i]);
                        }
                        secondBackupList = new List<string>();


                        for (int i = start + count; i < inputArray.Length; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }


                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            inputArray[i] = backupList[i];
                        }
                        backupList = new List<string>();
                        input = Console.ReadLine().ToLower();
                        continue;

                    }
                }
				catch (System.ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid input parameters.");
					input = Console.ReadLine().ToLower();
					continue;

				}
                if (tokens.Count != 3)
                {
                    Console.WriteLine("Invalid input parameters.");
                    input = Console.ReadLine().ToLower();
                    continue;
                }
                ////
                /// 
                /// 
                ///  ROLL LEFT
                /// 
                try
                {
                    if (tokens[0] == "rollleft" && tokens[2] == "times")
                    {
                        var count = -1;

                        try
                        {
                            count = int.Parse(tokens[1]);

                        }
                        catch
                        {
                            Console.WriteLine("Invalid input parameters.");
                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (count >= inputArray.Length)
                        {
                            count = count % inputArray.Length;
                        }
                        for (int i = count; i < inputArray.Length; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }
                        for (int i = 0; i < count; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }
                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            inputArray[i] = backupList[i];
                        }
                        backupList = new List<string>();


                    }
				}
				catch (System.ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid input parameters.");
					input = Console.ReadLine().ToLower();
					continue;

				}
                /////
                /// 
                /// ROLL RIGHT
                /// 
                /// 
                /// 
                ///
                try
                {
                    if (tokens[0] == "rollright" && tokens[2] == "times")
                    {
                        var count = -1;

                        try
                        {
                            count = int.Parse(tokens[1]);

                        }
                        catch
                        {
                            Console.WriteLine("Invalid input parameters.");
                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            input = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (count >= inputArray.Length)
                        {
                            count = count % inputArray.Length;
                        }
                        for (int i = inputArray.Length - count; i < inputArray.Length; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }
                        for (int i = 0; i < inputArray.Length - count; i++)
                        {
                            backupList.Add(inputArray[i]);
                        }
                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            inputArray[i] = backupList[i];
                        }
                        backupList = new List<string>();


                    }
				}
				catch (System.ArgumentOutOfRangeException)
				{
					Console.WriteLine("Invalid input parameters.");
					input = Console.ReadLine().ToLower();
					continue;

				}

                input = Console.ReadLine().ToLower();




			}

			Console.WriteLine("[" + string.Join(", ", inputArray) + "]");

		}
	}
}

