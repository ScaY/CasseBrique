using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Breakout.Model
{
    public class Level
    {
        public BrickZone Map { get; set; }

        public string LevelName { get; set; }

        public string Path { get; set; }
        public int Id { get; set; }

        public Level()
        {
            this.Path = "../../../levels/Default/level" + Id + ".json";
            this.Map = null;
            this.Id = 0;
            
        }
        public Level(int id)
        {
            
            this.Id = id;
            this.Path = "../../../levels/Default/level" + Id + ".json";
            
        }
        public Level(int id, BrickZone map ){
            
            this.Map = map;
            this.Id = id;
            this.Path = "../../../levels/Default/level" + Id + ".json";
        }
        

        public void load()
        {
            

            if (File.Exists(Path))
            {
                string file = File.ReadAllText(Path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file);

                this.LevelName = jsonDe.LevelName;
                this.Map = jsonDe.Map;
            }
        }


        public void write()
        {
            
            
            File.WriteAllText(Path, JsonConvert.SerializeObject(this));

        }

        public static List<Level> loadAllDefault()
        {
            int i=0;
            string path = "../../../levels/Default/level" + i + ".json";
            List<Level> toReturn = new List<Level>();
            while (File.Exists(path))
            {
                Level newLevel = new Level();
                string file = File.ReadAllText(path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file);

                newLevel.LevelName = jsonDe.LevelName;
                newLevel.Map = jsonDe.Map;
                i++;
                path = "../../../levels/Default/level" + i + ".json";
                toReturn.Add(newLevel);
            }
            return toReturn;
        }


        
    }
}
