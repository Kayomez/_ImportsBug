using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace MyWebsite.Shared.PageMakeup
{
    public class Navigation
    {
        public string Title { get; set; }
        public string UrlTitle { get; set; }
        public string[] Directory { get; set; } = new string[0];
        public string UrlFull
        {
            get
            {
                string ret = "/";
                foreach (var item in Directory) ret += $"{item}/";
                return $"{ret}/{UrlTitle}";
            }
        }
        public Navigation(string title, string urlTitle)
        {
            this.Title = title;
            this.UrlTitle = UrlTitle;
        }
        
        public Navigation(string title, string urlTitle, string[] directory) : this(title,urlTitle)
        {
            this.Directory = directory;
        }
        public static Navigation[] GetAll
        {
            get
            {
                return new Navigation[]
                {
                     new Navigation("Home", "home"),
                     new Navigation("About", "About")
                };
            }
        }
    }
}
