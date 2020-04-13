using System;
using System.Collections.Generic;

public class Class1
{
	public Class1()
	{
        DateTime now = DateTime.Now;

        public List<Entry> Entries { get; set; } = new List<Entry>();
    Console.WriteLine($"Write a new entry : {now: dd/MM/yy}");
        string text = Console.ReadLine();
    Entry e = new Entry(now, text);
    Entries.Add(e)


	}
}
