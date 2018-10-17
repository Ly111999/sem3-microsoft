using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string HeadLine { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        private static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();

            items.Add(new NewsItem()
            {
                Id = 1,
                Category = "Financial",
                HeadLine = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Images02/Financial.png"
            });
            items.Add(new NewsItem()
            {
                Id = 2,
                Category = "Financial",
                HeadLine = "Etiam ac felis viverra",
                Subhead = "vulputate nisl ac, aliquet nisi",
                DateLine = "tortor porttitor, eu fermentum ante congue",
                Image = "Assets/Images02/Financial3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 3,
                Category = "Financial",
                HeadLine = "Integer sed turpis erat",
                Subhead = "Set quis hendrerit lorem, quis interdum dolor",
                DateLine = "in viverra meuts facilisis sed",
                Image = "Assets/Images02/Financial4.png"
            }); items.Add(new NewsItem()
            {
                Id = 4,
                Category = "Financial",
                HeadLine = "Proin sem neque",
                Subhead = "aliquet quis ispum tincidunt",
                DateLine = "Integer eleifend",
                Image = "Assets/Images02/Financial5.png"
            }); items.Add(new NewsItem()
            {
                Id = 5,
                Category = "Financial",
                HeadLine = "Mauris bibendum non leo vitae tempor",
                Subhead = "In nisl tortor, eleifend sed ipsum eget",
                DateLine = "Curabitur dictum augue vitae elementum ultrices",
                Image = "Assets/Images02/Food5.png"
            });
            return items;
        }
        
    }
}
