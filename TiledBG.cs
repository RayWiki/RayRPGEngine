using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Rayteam_Advantures.Tiled
{
    class TiledBG
    {
        public static void LoadMaps(String mapname) 
        {
            string jsonString = File.ReadAllText("./assets/data/maps/"+mapname+".tmj");
            TiledMap map = JsonSerializer.Deserialize<TiledMap>(jsonString);
        }
    }
    public class TiledMap
    {
        public int width { get; set; }
        public int height { get; set; }
        public List<TiledLayer> layers { get; set; }
        //public List<TiledTileset> tilesets { get; set; }
    }

    public class TiledLayer
    {
        public string name { get; set; }
        public int[] data { get; set; } // The tile IDs
        public int width { get; set; }
        public int height { get; set; }
    }
}
