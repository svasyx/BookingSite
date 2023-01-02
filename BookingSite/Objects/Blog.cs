using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite
{
    internal class Blog
    {
        protected Dictionary<string, string> _items { get; set; } = null;

        public Blog()
        {
            _items = new Dictionary<string, string>();
        }

        public Blog(string type_of_item, string content)
        {
            if (!(String.IsNullOrEmpty(type_of_item) && String.IsNullOrEmpty(content)))
            {
                _items = new Dictionary<string, string>();
                _items.Add(type_of_item, content);
            }
        }

        public void SetBlog(string type_of_item, string content)
        {

            if (!(String.IsNullOrEmpty(type_of_item) && String.IsNullOrEmpty(content)))
            {
                _items.Add(type_of_item, content);
            }
        }

        public Dictionary<string, string> GetAllBlog()
        {
            return _items;  
        }
    }
}
