using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MediaLibrary
{
    public class MediaLibrary
    {
        public static void Main(string[] args)
        {
            String action = "";
            while(!action.ToUpper().Equals("QUIT"))
            {
                Console.WriteLine("What would you like to do?");
                action = Console.ReadLine();
            }
        }
    }
}
