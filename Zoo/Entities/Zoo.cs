using System.Collections.Generic;
using Zoo.Entities.Enclosures;

namespace Zoo.Entities
{
    public class Zoo
    {

        private string name;
        private List<Enclosure> enclosures;

        public Zoo(string name)
        {
            this.name = name;
            this.enclosures = new List<Enclosure>();
        }

        public void AddEnclosure(Enclosure enclosure)
        {
            this.enclosures.Add(enclosure);
        }

        public int GetNumberOfEnclosures()
        {
            return enclosures.Count;
        }
    }
}