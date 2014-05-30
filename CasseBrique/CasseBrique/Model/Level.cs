using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Breakout.Model
{
    public class Level
    {
        public BrickZone Map { get; set; }

        public string LevelName { get; set; }

        public string Path { get; set; }
        public int Id { get; set; }

        public static JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All,
            ConstructorHandling = ConstructorHandling.Default,
            ObjectCreationHandling = ObjectCreationHandling.Auto
        };

        public Level()
        {
           // this.Path = String.Format("../../../levels/Default/level{0}.json", Directory.GetFiles("../../../levels/Default/").Count() + 1);
            this.Map = null;
            this.Id = 0;
            
        }
        public Level(int id)
        {
            
            this.Id = id;
           // this.Path = String.Format("../../../levels/Default/level{0}.json", Directory.GetFiles("../../../levels/Default/").Count() + 1);
            
        }
        public Level(int id, BrickZone map ){
            
            this.Map = map;
            this.Id = id;
          // this.Path = String.Format("../../../levels/Default/level{0}.json", Directory.GetFiles("../../../levels/Default/").Count() + 1);
        }
        

        public void load()
        {
            /*
            if (File.Exists(Path))
            {
                string file = File.ReadAllText(Path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file);

                this.LevelName = jsonDe.LevelName;
                this.Map = jsonDe.Map;
            }*/
        }


        public void write()
        {
            
            
            File.WriteAllText(Path, JsonConvert.SerializeObject(this,Formatting.Indented,settings));
           

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
                var jsonDe = JsonConvert.DeserializeObject<Level>(file, settings);

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
