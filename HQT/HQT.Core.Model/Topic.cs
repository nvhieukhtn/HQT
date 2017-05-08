using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQT.Core.Model
{
    public class Topic:BaseModel
    {
        public string Title { get; set; }
        public string Detail { get; set; }

        public Topic()
        {
            Title = string.Empty;
            Detail = string.Empty;
        }

        public Topic(string title, string detail)
        {
            Title = title;
            Detail = detail;
        }
        public static Topic Default => new Topic();

        public static Topic Test => new Topic("Title test", "The book begins by discussing the installation of the IDE (for both PC and Mac) as well as how to set up your PC so it can be used to develop for iOS. From there, successive chapters cover the user interface, views, view controllers, customisation of controls, animation, events and event handling, getting the most from your app using threading, creating your own settings system, the internal database system and LINQ, sending texts, making calls, taking photos, videos, and audio recordings as well as using the mapping system. The book culminates by showing you how to test your app using testflight and finally how to release your app on the Apple Store. It is an all-encompassing book that leaves nothing out.");
    }
}
