using Breakout.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CasseBrique.Model
{
    class CustomLevel : Level
    {
        public CustomLevel() : base()
        {
            this.Path = "../../../levels/Customized/level" + Id + ".json";
        }
        public CustomLevel(int id) : base(id)
        {
            this.Path = "../../../levels/Customized/level" + Id + ".json";
        }
        public CustomLevel(int id, BrickZone map) : base(id,map)
        {
            this.Path = "../../../levels/Customized/level" + Id + ".json";
        }


        public static List<Level> loadAllCustom()
        {
            int i = 0;
            string path = "../../../levels/Customized/level" + i + ".json";
            List<Level> toReturn = new List<Level>();
            while (File.Exists(path))
            {
                Level newLevel = new Level();
                string file = File.ReadAllText(path);
                var jsonDe = JsonConvert.DeserializeObject<Level>(file);

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
