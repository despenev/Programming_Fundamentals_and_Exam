using System;
using System.Collections.Generic;
using System.Linq;

namespace Command_Interpreter_SecondTake
{
    class MainClass
    {
       /// <summary>
        /// /////////////////   this is mainmetod
       /// </summary>
       /// <param name="args">The command-line arguments.</param>

        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var command = Console.ReadLine().ToLower();

            while (command!="end")
            {
                var tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

               
                 /////////////////////////// 
                /// 
                /// 
                /// 
                /// 
                /// tova e za reverserange
                if ( tokens[0]=="reverse" && tokens[1]=="from" && tokens[3]=="count")
                {
                    var index = int.Parse(tokens[2]);
                    var count = int.Parse(tokens[4]);
                    if (index<0||index>=tokens.Length||count<0||index+count-1>=tokens.Length)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {
                        input = ReverseFromCount(input, index, count);
                    }
                }

                //
                /////////////
                /// 
                /// 
                /// 
                /// tova e za sortRange
                else if (tokens.Length == 5 && tokens[0] == "sort" && tokens[1] == "from" && tokens[3] == "count")
                {
					var index = int.Parse(tokens[2]);
					var count = int.Parse(tokens[4]);
                    if (index < 0 || index >= tokens.Length || count < 0 || index + count - 1 >= input.Length)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {
                        input = SortFromCount(input, index, count);
                    }
                }


                //////
                /// 
                /// 
                ///  tova e za ROLL LEFT OR RIGHT
                /// 
                /// 
                else if (tokens.Length==3 && (tokens[0]=="rollleft"||tokens[0]=="rollright") && tokens[2]=="times")
                {
                    var direction = tokens[0];
                    var count = int.Parse(tokens[1]);
                    if (count<0)
                    {
						Console.WriteLine("Invalid input parameters.");
						command = Console.ReadLine().ToLower();
						continue;
                    }
                    input = RollLeftOrRightCount(input, count,direction);
                }
                else
                {
					Console.WriteLine("Invalid input parameters.");
					command = Console.ReadLine().ToLower();
					continue;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("[" +string.Join(", ",input) + "]");

        }

        /// <summary>
        /// //                          REVERSE FROM COUNT
        /// </summary>
        /// <returns>The from count.</returns>
        /// <param name="input">Input.</param>
        /// <param name="index">Index.</param>
        /// <param name="count">Count.</param>
		public static string[] ReverseFromCount(string[] input, int index, int count)
		{
			Array.Reverse(input, index, count);
			return input;
		}
        /// <summary>
        /// ///                SORT FROM COUNT
        /// 
        /// 
        /// </summary>
        /// <returns>The from count.</returns>
        /// <param name="input">Input.</param>
        /// <param name="index">Index.</param>
        /// <param name="count">Count.</param>
		public static string[] SortFromCount(string[] input, int index, int count)
		{
			Array.Sort(input, index, count);
			return input;
		}



        /// <summary>
        ///  ///            ROLL LEFT OR RIGHT
        /// </summary>
        /// <returns>The left or right count.</returns>
        /// <param name="input">Input.</param>
        /// <param name="count">Count.</param>
        /// 
        /// <param name="direction">Direction.</param>
        /// 
		public static string[] RollLeftOrRightCount(string[] input, int count, string direction)
		{
			var output = new List<string>();

			if (direction == "rollleft")
			{
				count = -count;
			}

			count = count % input.Length;
			if (count < 0)
			{
				count += input.Length;
			}

			for (int i = input.Length - count; i < input.Length; i++)
			{
				output.Add(input[i]);
			}
			for (int i = 0; i < input.Length - count; i++)
			{
				output.Add(input[i]);
			}

			for (int i = 0; i < input.Length; i++)
			{
				input[i] = output[i];
			}
			return input;

		}

    }
}
