using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithTextCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Anuwat Khongchuai ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToLower());
            var index = fullName.IndexOf(' ');
            Console.WriteLine("index of white space: " + index);
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("firstName: '{0}'", firstName);
            Console.WriteLine("lastName: '{0}'", lastName.Trim());
            var names = fullName.Split(' ');
            Console.WriteLine("firstName: '{0}'", names[0]);
            Console.WriteLine("lastName: '{0}'", names[1].Trim());
            fullName = fullName.Replace("Anuwat", "Leo");
            Console.WriteLine("fullName: {0}", fullName);

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }


            if (String.IsNullOrEmpty(""))
            {
                Console.WriteLine("Invalid");
            }

            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "";


            str = "25";

            var strInt = Convert.ToInt32(str);
            Console.WriteLine(strInt);
            Console.WriteLine(strInt+1);

            var a = 250;

            var age = Convert.ToByte(a);
            Console.WriteLine(a);

            float price = 29.95f;

            Console.WriteLine(price.ToString("C"));









            //---------------------------------


            const int maxLength = 20;

            var sentence = "This is really really really really long text";

            if (sentence.Length < maxLength) 
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalChar = 0;
                var summaryWord = new List<string>();

                foreach (var word in words)
                {
                    summaryWord.Add(word);
                    totalChar += word.Length + 1;
                    if (totalChar > maxLength)
                    {
                        break;
                    }
                }

               var sum =  String.Join(" ", summaryWord) + "...";

               Console.WriteLine(sum);

            }





            //=============================
            var builder = new StringBuilder();


            builder.Append('-', 100);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 100);

            builder.Replace('-','+');
            builder.Remove(0, 10);
            builder.Insert(0,new string('-',10));
            Console.WriteLine(builder);



        }

    }
}