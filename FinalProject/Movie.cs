using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Movie : IComparable<Movie>
    {
        // PRIVATE INSTANCE VARIABLES #############################################
        private string _title;
        private string _category;
        private double _cost;

        // PUBLIC PROPERTIES ######################################################
        public string Title
        {
            get
            {
                return this._title;
            }
        }
        public string Category
        {
            get
            {
                return this._category;
            }
        }

        public double Cost
        {
            get
            {
                return this._cost;
            }
        }

        // CONSTRUCTOR ###########################################################
        public Movie(string title, string category, double cost)
        {
            //Assign values to instance variables
            this._title = title;
            this._category = category;
            this._cost = cost;
        }


        // PUBLIC METHODS ########################################################
        // Method that compares the title property
        public int CompareTo(Movie compareMovie)
        {

            if (compareMovie == null)
                return 1;

            else
                return this._title.CompareTo(compareMovie._title);
        }
    }
}