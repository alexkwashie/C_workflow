using System;
namespace helloworld
{

    class VideoPost: Post
    {
       protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            this.ID = GetNextID();
            this.title = title;
            this.SendUsername = sendByUsername;
            this.isPublic = isPublic;


            //Videourl is member of Videopost but not of Post/Imagepost
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            //return base.ToString()   //default
            return String.Format("{0} - {1} - {2} by {3}", this.ID, this.title, this.VideoURL, this.SendUsername);
        }

    }
}
