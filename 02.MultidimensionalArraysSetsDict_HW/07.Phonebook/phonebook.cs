using System;
using System.Collections.Generic;
using System.Linq;

    class phonebook
    {
        static void Main()
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            string[] contactInfo;
            

            while (input != "search")
            {
                contactInfo = input.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = contactInfo[0];
                string phoneNumber = contactInfo[1];

                if(!phonebook.ContainsKey(name))
                {
                    List<string> phoneNumbers = new List<string>();
                    phoneNumbers.Add(phoneNumber);
                    phonebook.Add(name, phoneNumbers);
                }
                else
                {
                    if (!phonebook[name].Contains(phoneNumber))
                    {
                        phonebook[name].Add(phoneNumber);
                    }
                }            
                input = Console.ReadLine();
            }

            while (true)
            {
                string searchFor = Console.ReadLine();

                if (phonebook.ContainsKey(searchFor))
                {
                    Console.WriteLine("{0} --> {1}", searchFor, String.Join(", ", phonebook[searchFor] ));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", searchFor);
                }
            }
            

        }
    }

