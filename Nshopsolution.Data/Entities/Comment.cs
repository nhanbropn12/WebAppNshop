using System;
using System.Collections.Generic;
using System.Text;

namespace Nshopsolution.Data.Entities
{
    public class Comment
    {
        public int Idcomment { set; get; }
        public int Iduser { set; get; }
        public int feedback { set; get; }
        public DateTime Datecreate { set; get; }
        public string Image { set; get; }
        public string Contentfeedback { set; get; }
        public Account Account { get; set; }


    }
}

