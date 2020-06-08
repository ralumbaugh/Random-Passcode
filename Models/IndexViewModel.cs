using System;

namespace RandomPasscode.Models
{
    public class IndexView
    {
        public int Clicked { get;set; }
        // public string RandomString{ get; set; }
        public IndexView(int numberclicked)
        {
            Clicked = numberclicked;
        }

        public string NewRandom()
        {
            string[] Characters = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","1","2","3","4","5","6","7","8","9","0"};
            string NewRandomString = "";
            for(int i = 1; i<15; i++)
            {
                Random random= new Random();
                NewRandomString += Characters[random.Next(0,62)];
            }
            return NewRandomString;
        }
    }
}