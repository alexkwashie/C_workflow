using System;

namespace helloworld
{
    class Post

    {
        private static int CurrentPostId;

        //*Properties
        protected int ID{ get; set; } //Protected means, it can only be used byt this class & any deriving class
        protected string title { get; set; }
        protected bool isPublic { get; set; }
        protected string SendUsername { get; set; }

        // Default constructor. If a derived class does not invoke a base-
        // class constructor explicitly, the default constructor is called implicity

        public Post()
        {
            ID = 0;
            title = "My First Post";
            isPublic = true;
            SendUsername = "Al Pacino";

        }


        //Instant constructor that has three paramenters
        // eg. Creating a Post
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.isPublic = isPublic;
            this.title = title;
            this.SendUsername = sendByUsername;

        }

        protected int GetNextID()
        {
            return ++CurrentPostId; //Means increment & assign to the number 
        }


        //Editing a post
        public void Update(string title, bool isPublic)
        {
            this.title = title;
            this.isPublic = isPublic;
        }


        /*Virtual method override of the ToString method that is inherited
       from System.Object*/
        // i. e. Convert values from methods to string
        public override string ToString()
        {
            //return base.ToString()   //default
            return String.Format("{0} - {1}- by {2}", this.ID, this.title, this.SendUsername);
        }

       

        //Now Craete a new Class called "ImagePost"


    }
}
