using System;

namespace interfaces
{
    // when creating interface you use (I) at the begining i.e. its naming convention

    public interface INotification
    {
        //Members
        void ShowNotice();

        string getDate();

    }


    public class Notifcation: INotification
    {
        private string sender;
        private string message;
        private string Date;


        public Notifcation()
        {
            sender = "Admin";
            message = "Heya, seend you last week";
            Date = "02-12-2019";
        }


        public Notifcation(string mySender, string myMessage, string myDate)
        {
            this.sender = mySender;
            this.message = myMessage;
            this.Date = myDate;
        }

        //members Inherited from the interface method must have (public) at the begining
        public void ShowNotice()
        {
            Console.WriteLine("Message: {0} - was sent by {1} at {2}", message, sender, Date);
        }

        //members Inherited from the interface method must have (public) at the begining
        public string getDate()
        {
            return Date;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Notifcation alfo = new Notifcation("Alfred","Boy how be, I base ooo","13-09-2011");

            alfo.ShowNotice();
            

        }



    }
}
