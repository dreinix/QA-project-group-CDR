using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAproject.Utility
{
    public class Item
    {
        private int _id;
        private string _name;
        private int _count;
        private string _provider;

        public Item(int id, string name, int count, string provider)
        {
            _id = id;
            _name = name;
            _count = count;
            _provider = provider;
        }

        public int ID
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int Count
        {
            get { return _count; }
        }
        public string Provider
        {
            get { return _provider; }
        }
    }
}
