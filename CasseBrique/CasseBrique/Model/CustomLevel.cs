using Breakout.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CasseBrique.Model
{
    class CustomLevel : Level
    {
        public static int IdInstance = 0;
        public CustomLevel() : base()
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
        }
        public CustomLevel(int id) : base(id)
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
        }
        public CustomLevel(int id, BrickZone map) : base(id,map)
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
        }

        public CustomLevel(string levelName, BrickZone map)
            : base()
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
            
            
            this.LevelName = levelName;
        }
        public static List<Level> loadAllCustom()
        {
            int i = 1;
            string path = "../../../levels/Customized/level" + i + ".json";
            
            List<Level> toReturn = new List<Level>();
            while (File.Exists(path))
            {
                Level newLevel = new Level();
                string file = File.ReadAllText(path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file, settings);


                newLevel.LevelName = jsonDe.LevelName;
                newLevel.Map = jsonDe.Map;
                i++;
                path = "../../../levels/Customized/level" + i + ".json";
                toReturn.Add(newLevel);
            }
            return toReturn;
        }
    }
}
