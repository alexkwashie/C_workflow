// CHALLENGE add a deriving Class "VideoPost" with a property VideoURL, Length. 

// create the required constructors to create a VideoPost
// adjust the ToString() method accordingly
// create an instance of VideoPost and use the ToString method on it.


// More advanced - use Timer and a Callback method here (google it :))
// create fields as required
// add member methods "Play" which should write the current duration of the video
// and "Stop" which should stop the "timer" and write "stopped at {0}s" onto the console.
// Play the video after creating the instance and stop it, when the user presses any key

using System;
using System.Threading;

namespace helloworld
{

    class VideoPost: Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;

        Timer timer;


        //Properties
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
            return String.Format("{0} - {1} - {2}, {4} by {3}", this.ID, this.title, this.Length, this.VideoURL,this.SendUsername);
        }

        public void play()
        {
            if (!isPlaying)
            {
                isPublic = true;
                Console.WriteLine("Playing...");
                timer = new Timer(TimerCallback, null, 1, 1000);
            }

        }

        //to be called by only this object: make it private
        //The timer method allows you to run a block of code over a set period eg. 1000 (every 1sec)
        private void TimerCallback(object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                stop();
            }
        }



        public void stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;

                //stop timer
                timer.Dispose();
            }
                
        }




    }
}
