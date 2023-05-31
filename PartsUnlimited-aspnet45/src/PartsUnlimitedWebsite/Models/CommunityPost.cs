using System;

namespace PartsUnlimited.Models
{
    // this first change for tp1

    public class CommunityPost
    {
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime DatePosted { get; set; }
        public CommunitySource Source { get; set; }
    }

    public enum CommunitySource
    {
        Facebook,
        Twitter
    }
}