using System;

namespace InheritanceCS
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(String url)
        {
            Console.WriteLine("We added a link to" + url);
        }


    }
}