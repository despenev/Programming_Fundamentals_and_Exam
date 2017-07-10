using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Roli_the_Coder
{
    class MainClass
    {
        class Event
        {
            public int ID { get; set; }
            public string EventName { get; set; }
            public List<string> Participants { get; set; }
        }
        public static void Main(string[] args)
        {
            Regex regexName = new Regex(@"@[a-zA-Z0-9]+([-]{0,1}[']{0,1}[a-zA-Z0-9]+)*");
            Regex regexEvent = new Regex(@"#[a-zA-Z]+");

            var EventsList = new List<Event>();

            while (true)
            {
                var input1 = Console.ReadLine();   //.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input1=="Time for Code")
                    break;
                
                var input = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var Id = int.Parse(input[0]);
				var eventNameMatch = regexEvent.Match(input[1]);
                    
                if (!eventNameMatch.Success)
                    continue;
                
                var eventName = input[1].Remove(0,1);

                if (!EventsList.Any(x => x.ID == Id))
                {
                    var newEvent = new Event
                    {
                        ID = Id,
                        EventName = eventName,
                        Participants = new List<string>()
                    };
                    EventsList.Add(newEvent);
                }

                else if (EventsList.Any(x => x.ID == Id))
                {
                    var index =EventsList.FindIndex(x => x.ID == Id);
                    if (EventsList[index].EventName!=eventName)
                        continue;
                }

                for (int i = 2; i < input.Count; i++)
                {
                    var nameMatch = regexName.Match(input[i]);
                    if (!nameMatch.Success)
                        continue;
                    
                    var name = input[i];

                    var index = EventsList.FindIndex(x=>x.ID==Id);
                    if (EventsList[index].Participants.Contains(name))
                        continue;
                    
					EventsList[index].Participants.Add(name);
                }

            }



            foreach (var Event in EventsList.OrderByDescending(x=>x.Participants.Count).ThenBy(x=>x.EventName))
            {
                Console.WriteLine($"{Event.EventName} - {Event.Participants.Count}");
                foreach (var p in Event.Participants.Distinct().OrderBy(a=>a))
                {
                    Console.WriteLine(p);
                }
            }



        }
    }
}
