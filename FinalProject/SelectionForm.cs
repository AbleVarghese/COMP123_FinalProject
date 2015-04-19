using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SelectionForm : Form
    {
        //public Movie[] movies = new Movie[20];
        public List<Movie> movies = new List<Movie>();

        // private instance variables
        int _movieIndex;



        public SelectionForm()
        {
            InitializeComponent();
            InitializeMovieList();
            InitializeMovieSelectionComboBox();
        }


        private void InitializeMovieList()
        {

            movies.Add(new Movie("Cedar Rapids", "Comedy", 1.99));
            movies.Add(new Movie("Company Men", "Drama", 1.99));
            movies.Add(new Movie("Death Race 2", "Action", 2.99));
            movies.Add(new Movie("FootLoose", "New Release", 4.99));
            movies.Add(new Movie("Gnomeo And Juliet", "Comedy", 1.99));
            movies.Add(new Movie("Iam Number Four", "Sci Fi", 1.99));
            movies.Add(new Movie("Just Go With It", "Comedy", 1.99));
            movies.Add(new Movie("No Strings Attached", "Comedy", 1.99));
            movies.Add(new Movie("Real Steel", "New Release", 4.99));
            movies.Add(new Movie("Sanctum", "Action", 2.99));
            movies.Add(new Movie("Season of the Witch", "Sci Fi", 1.99));
            movies.Add(new Movie("The Dilemma", "Comedy", 1.99));
            movies.Add(new Movie("The Eagle", "Action", 2.99));
            movies.Add(new Movie("The Green Hornet", "Action", 2.99));
            movies.Add(new Movie("The Mechanic", "Action", 2.99));
            movies.Add(new Movie("The Other Women", "Action", 2.99));
            movies.Add(new Movie("The Rite", "Horror", 2.99));
            movies.Add(new Movie("The Roommate", "Thriller", 1.99));
            movies.Add(new Movie("The Way Back", "Drama,", 1.99));
            movies.Add(new Movie("Waiting for Forever", "Drama", 1.99));

        }


        private void InitializeMovieSelectionComboBox()
        {
            foreach (var movie in movies)
            {
                MovieSelectionComboBox.Items.Add(movie.Title);

            }
        }

        
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
            this._movieIndex = MovieSelectionComboBox.SelectedIndex;

            movies.Sort();
            MovieTitleTextBox.Text = movies[this._movieIndex].Title;
            MovieCategoryTextBox.Text = movies[this._movieIndex].Category;
            MovieCostTextBox.Text = movies[this._movieIndex].Cost.ToString();
           NextButton.Enabled = true;
           
           //Storing Movie selection, movie category, and movie cost in a array 
            string [] storeMovie={movies[this._movieIndex].Title, movies[this._movieIndex].Category, movies[this._movieIndex].Cost.ToString()};
        

 
        
        }


        private void Nextbutton1_Click(object sender, EventArgs e)
        {
           
            OrderForm orderForm = new OrderForm();
            this.Hide();
            orderForm.Owner = this;
            orderForm.Show();

        }
       
    }
}
