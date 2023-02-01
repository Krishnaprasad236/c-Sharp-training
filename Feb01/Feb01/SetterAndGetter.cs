using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb01
{
    internal class SetterAndGetter
    {
        string moviename;
        string director;
        private string rating;

        public SetterAndGetter(string moviename, string director,string rating)
        {
            this.moviename = moviename;
            this.director = director;
            this.rating = rating;
        }

        public string Rating
        { 
            
            set 
            { 
                if(value=="good" || value=="bad")
                {
                    rating= value;
                }
                else
                {
                    rating= "not valid ";
                }
            }
            get { return rating; }
        }  
    }
}
