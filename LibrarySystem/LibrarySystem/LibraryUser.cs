using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser : User
    {
        public LibraryCard Card {  get; set; }

        public LibraryUser(string name , LibraryCard card) 
        {
            Card = card;
            Name = name;

        }
    }
}
