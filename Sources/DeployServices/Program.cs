using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeployServices
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("ok");
            string TestString = "This is a <Test String>.";
            string EncodedString = System.Web.HttpUtility.UrlDecode("Text=\"%40(Server >'%25(Name)'):");
        }
    }
}
