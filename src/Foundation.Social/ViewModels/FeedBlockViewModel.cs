using Foundation.Social.Models.Blocks;
using System.Collections.Generic;

namespace Foundation.Social.ViewModels
{
    public class FeedBlockViewModel
    {
        public FeedBlockViewModel(FeedBlock block)
        {
            Heading = block.Heading;
            ShowHeading = block.ShowHeading;
            FeedDisplayMax = block.FeedDisplayMax;
            FeedTitle = block.FeedTitle;
            Feed = new List<CommunityFeedItemViewModel>();
        }

        public string Heading { get; set; }

        public bool ShowHeading { get; set; }

        public int FeedDisplayMax { get; set; }

        public string FeedTitle { get; set; }

        public IEnumerable<CommunityFeedItemViewModel> Feed { get; set; }

        public List<MessageViewModel> Messages { get; set; }
    }
}