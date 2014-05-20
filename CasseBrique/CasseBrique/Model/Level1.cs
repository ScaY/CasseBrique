using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace CasseBrique.Model
{
    class Level1
    {
        private BrickZone map;
        private int id;
        private string levelName;

        public BrickZone Map
        {
            get { return map; }
            set { map = value; }
        }

        public string LevelName
        {
            get { return levelName; }
            set { levelName = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Level1()
        {
            Map = null;
            id = 0;
        }
        public Level1(int id)
        {
            this.Id = id;
            load(id);
        }
        public Level1(int id, BrickZone map)
        {
            this.Map = map;
            this.Id = id;
        }


        public void load(int id)
        {
            string path = "../../../levels/level" + id + ".json";
            if (File.Exists(path))
            {
                string file = File.ReadAllText(path);
                var jsonDe = JsonConvert.DeserializeObject<Level1>(file);

                this.LevelName = jsonDe.LevelName;
                this.Map = jsonDe.Map;
            }
        }


        public void write()
        {
            string path = "../../../levels/level" + Id + ".json";

            File.WriteAllText(path, JsonConvert.SerializeObject(this));

        }

    }
}
