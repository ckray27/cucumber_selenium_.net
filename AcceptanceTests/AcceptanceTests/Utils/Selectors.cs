using System;

namespace AcceptanceTests.Utils
{
    public class Selectors
    {

        public static string ElementLocator(string link)
        {
            var webElement = "";
            switch (link)
            {
                case "First Name":
                    webElement = "firstname";
                    break;
                case "Last Name":
                    webElement = "lastname";
                    break;
                case "Price":
                    webElement = "totalprice";
                    break;
                case "Deposit Dropdown":
                    webElement = "depositpaid";
                    break;
                case "Check-in":
                    webElement = "checkin";
                    break;
                case "Check-out":
                    webElement = "checkout";
                    break;
                case "Save":
                    webElement = "/html/body/div[1]/div[3]/div/div[7]/input";
                    break;
                case "Delete":
                    webElement = "/html/body/div[1]/div[2]/div[2]/div[7]/input";
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
            return webElement;
        }

        public static string LinksUrlSearch(string page)
        {
            var elementUrl = "";
            switch (page)
            {
                case "hotel booking":
                    elementUrl = "http://hotel-test.equalexperts.io/";
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
            return elementUrl;
        }

    }
}
