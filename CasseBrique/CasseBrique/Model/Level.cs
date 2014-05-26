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

        public int Id { get; set; }

        public Level()
        {
            this.Map = null;
            this.Id = 0;
        }
        public Level(int id)
        {
            this.Id = id;
            load(id);
        }
        public Level(int id, BrickZone map ){
            this.Map = map;
            this.Id = id;
        }
        

        public void load(int id)
        {
            string path = "../../../levels/level"+id+".json";
            if (File.Exists(path))
            {
                string file = File.ReadAllText(path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file);

                this.LevelName = jsonDe.LevelName;
                this.Map = jsonDe.Map;
            }
        }


        public void write()
        {
            string path = "../../../levels/level" + Id + ".json";
            
            File.WriteAllText(path, JsonConvert.SerializeObject(this));

        }

        public static List<Level> loadAll()
        {
            int i=0;
            string path = "../../../levels/level" + i + ".json";
            List<Level> toReturn = new List<Level>();
            while (File.Exists(path))
            {
                Level newLevel = new Level();
                string file = File.ReadAllText(path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file);

                newLevel.LevelName = jsonDe.LevelName;
                newLevel.Map = jsonDe.Map;
                i++;
                path = "../../../levels/level" + i + ".json";
                toReturn.Add(newLevel);
            }
            return toReturn;
        }
    }
}
