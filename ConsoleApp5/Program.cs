using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputUser = GetUserInput();

            Search(inputUser);
        }

        public static void Search(UserInput user)
        {
            int foundatLine = 0;
            int i = 1;
            foreach (var item in user.InputList)
            {
                if (item == user.FindFromList)
                {
                    foundatLine = i;
                    break;
                }
                i++;
            }

            if (foundatLine == 0)
            {
                Console.WriteLine("Nomor " + user.FindFromList + " tidak muncul dalam 5 nomor pertama. ");
            }
            else
            {
                Console.WriteLine("Nomor " + user.FindFromList + "muncul di 5 nomor pertama. ");
            }
        }

        public class UserInput
        {
            public List<int> InputList { get; set; }
            public int FindFromList { get; set; }
        }

        public static UserInput GetUserInput()
        {
            var userInput = new UserInput();
            try
            {
                List<int> inputList = new List<int>();
                int inputcount = 5;

                for (int i = 0; i < inputcount; i++)
                {
                    var input = Convert.ToInt16(GetUserInputDetail("Masukkan nomor"));
                    inputList.Add(input);
                }

                userInput.InputList = inputList;
                userInput.FindFromList = Convert.ToInt16(GetUserInputDetail("Masukkan nomor yang akan dicari"));
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, Press Enter to close the program");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return userInput;
        }

        public static string GetUserInputDetail(string inputName)
        {
            string input = string.Empty;
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine();
                Console.WriteLine(inputName + " is required");
                Console.WriteLine("Enter " + inputName + ": ");
                input = Console.ReadLine();
            }
            return input;
        }
    }


}
