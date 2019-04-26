using System;

namespace helloworld
{

    // Imagepost derives from post and adds a property (imgURL) and two constructors

    class Imagepost : Post //Allows you to use all code in post class in Inheritance.cs
    {
        public string Imageurl { get; set; }

        public Imagepost() { }

        public Imagepost(string title, bool isPublic, string Imageurl, string sendByUsername)
        {
            //the following properties & GetNextID are inherited from Post
            this.ID = GetNextID();
            this.isPublic = isPublic;
            this.title = title;
            this.SendUsername = sendByUsername;

            //Imageurl is member of Imagepost but not of Post
            this.Imageurl = Imageurl;
        }

        public override string ToString()
        {
            //return base.ToString()   //default
            return String.Format("{0} - {1} - {2} by {3}", this.ID, this.title, this.Imageurl, this.SendUsername);

        }
    }

}