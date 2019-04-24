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
    }
}
