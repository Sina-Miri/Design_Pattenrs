using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Product
{
    public class Product
    {
        public List<string> Parts { get; set; } = new List<string>();

        public void AddPart(string part)
        {
            Parts.Add(part);
        }

        public void ShowParts()
        {
            Parts.ForEach(part => Console.WriteLine(part));
        }
    }
}
