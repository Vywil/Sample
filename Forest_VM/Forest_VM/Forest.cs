using System;
namespace Forest_VM
{
    class Forest
    {
        public string name;
        private string biome;
        private string forestlayer;
        public int age;

        public string Biome
        {
            get { return biome; }
            set
            {
                if (value == "Tropical" ||
                    value == "Temperate" ||
                    value == "Boreal" ||
                    value == "Desert" ||
                    value == "Tundra" ||
                    value == "Taiga" ||
                    value == "Grassland" ||
                    value == "Savanna"

                    )
                {
                    biome = value + " it's a correct answer!";
                }
                else
                {
                    biome = value +  " it's not a type of biome.";
                }

            }
        }
        public string Forestlayer
        {
            get { return forestlayer; }
            set
            {
                if(
                    value == "Emergent" ||
                    value == "Canopy" ||
                    value == "Understory"||
                    value == "Forest Floor"
                    )
                {
                    forestlayer = value + " it's a correct answer!";
                }
                else
                {
                    forestlayer = value + " it's not a forest layer type.";
                }
            }

        }
    }
}

