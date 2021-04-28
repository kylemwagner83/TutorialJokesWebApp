using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialJokesWebApp.Models
{
    public class Joke
    {
        private int _Id;
        private string _JokeQuestion;
        private string _JokeAnswer;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string JokeQuestion
        {
            get { return _JokeQuestion; }
            set { _JokeQuestion = value; }
        }

        public string JokeAnswer
        {
            get { return _JokeAnswer; }
            set { _JokeAnswer = value; }
        }

        public Joke()
        {
            
        }

    }
}
