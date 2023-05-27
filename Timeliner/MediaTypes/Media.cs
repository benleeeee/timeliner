using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timeliner.MediaTypes
{
    //Base class for all media forms - books, movie, TV etc. 
    internal class Media
    {
        public Media()
        {

        }

        /// <summary>Date & time when the media was first began</summary>
        public DateTime startDateTime { get; set; }
        /// <summary>Date & time when the media was completed</summary>
        public DateTime finishDateTime { get; set; }

        public string name { get; set; }
    }
}
