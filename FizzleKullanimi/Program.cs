using System;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace FizzleKullanimi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var web = new HtmlWeb();

            var document =  web.Load("https://www.teknosa.com/iphone-12-c-100001001013");

            var productItems = document.DocumentNode.QuerySelectorAll("div.product-item");

            foreach (var productItem in productItems)
            {
                
                Console.WriteLine(productItem.Attributes["data-product-url"].Value);
            }
        }
    }
}