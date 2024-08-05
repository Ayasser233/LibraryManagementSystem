using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask
{
    internal class Book
    {
        private string _Title;
        private string _Author;
        private int _NumberOfCopies;
        public string Title 
        {
            get{return _Title; }
            set{ _Title = value;}
        }
        public string Author 
        {
            get{ return _Author; }
            set{ _Author = value;}
        }
        public int NumberOfCopies 
        {
            get{return _NumberOfCopies; } 
            set{ _NumberOfCopies = value;}
        }
    }
}
