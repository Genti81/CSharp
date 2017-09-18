using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CircusLib
{
    public class Circus
    {
        private string Name;
        private Dictionary<Artist, int> ArtistDictionary = 
            new Dictionary<Artist, int>();

        public Circus(string name)
        {
            this.Name = name;
        }
        
        public void Anställ(Artist artist)
        {
            ArtistDictionary.Add(artist, 0);
        }

        public void ArtistUppträdande(Artist artist)
        {
            ArtistDictionary[artist]++;
        }

        public override string ToString()
        {
            var message = $"Cirkusen {this.Name} har {this.AntalArtister} artister.";
            foreach (var ArtistFöreställningEntry in ArtistDictionary)
            {
                string gånger = "gång";
                if (ArtistFöreställningEntry.Value > 1)
                    gånger += "er";
                message += $" {ArtistFöreställningEntry.Key.Name} har uppträtt {ArtistFöreställningEntry.Value} {gånger}.";
            }
            Debug.WriteLine(message);
            return message;
        }

        public int AntalArtister
        {
            get
            {
                return this.ArtistDictionary.Count;
            }
        }
    }
}
