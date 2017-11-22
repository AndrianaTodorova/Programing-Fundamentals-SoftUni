using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWithSimona
{
    class ExampleClass
    {
        private string name { get; set; }
        private int age { get; set; }
        private string town { get; set; }
        public Dictionary<int, string> music { get; set; }

        public ExampleClass(String inputName, int inputAge)
        {
            name = inputName;
            age = inputAge;
            music = new Dictionary<int, string>();
        }

        public List<String> getSongs()
        {
            List<string> songs = new List<string>();
            foreach(string song in music.Values)
            {
                string current = string.Join(", ",song);
                songs.Add(current);
            }
            return songs;
        }

        public string greeting()
        {
            return string.Concat("Hello, ", this.name);
        }
    }
}
