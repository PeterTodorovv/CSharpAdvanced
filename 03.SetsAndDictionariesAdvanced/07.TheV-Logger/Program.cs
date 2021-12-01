using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();
            string input = Console.ReadLine();

            while(input != "Statistics")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                string action = splitted[1];

                switch (action)
                {
                    case "joined ":
                        vloggers.Add(new Vlogger(name));
                        break;
                    case "followed":
                        string name2 = splitted[2];
                        if (name == name2)
                            break;
                        Vlogger vloger1 = vloggers.Where(v => v.Name == name).FirstOrDefault();
                        vloger1.StartFollowing(name2);
                        Vlogger vloger2 = vloggers.Where(v => v.Name == name2).FirstOrDefault();
                        vloger2.GetsFolloed(name);
                        break;
                }   
                input = Console.ReadLine();
            }

            int count = 0;

            foreach(Vlogger vlogger in vloggers)
            {
                count++;
                Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Follows.Count} followin");
            }
        }

        public class Vlogger
        {
            public string Name { get; }
            public SortedSet<string> Followers { get;}
            public HashSet<string> Follows { get;}
            public Vlogger(string name)
            {
                this.Name = name;
                this.Followers = new SortedSet<string>();
                this.Follows = new HashSet<string>();
            }

            public void StartFollowing(string name)
            {
                Follows.Add(name);
            }

            public void GetsFolloed(string name)
            {
                Followers.Add(name);
            }


        }
    }
}
