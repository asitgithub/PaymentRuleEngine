using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentRuleEngine
{
    public class VideoLearningHandler : IVideoLearning
    {
        private readonly VideoTypes _videoType;

        public VideoLearningHandler(VideoTypes videoType)
        {
            _videoType = videoType;
        }

        public void AddFreeFirstAidVideo()
        {
            Console.WriteLine("First Aid video added to packing slip!");
        }

        public void MakePayment()
        {
            if (_videoType == VideoTypes.LearningToSki)
            {
                Console.WriteLine("Payment was made successfully for Learning to Ski video");
                AddFreeFirstAidVideo();
            }
            else
            {
                Console.WriteLine("Payment was made successfully for the video");
            }
        }
    }
}
