using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAproject.Utility
{
    class Provider
    {
        private int _Id;
        private string _name;
        private string _direction;
        private string _company;

        public Provider(int id, string name, string direction, string company)
        {
            _Id = id;
            _name = name;
            _direction = direction;
            _company = company;
        }
        public int ID
        {
            get { return _Id; }
        }
        public string Name
        {
            get { return _name; }
        }
        public string Direction
        {
            get { return _direction; }
        } 
        public string Company
        {
            get { return _company; }
        }
    }
}
