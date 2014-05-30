using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class that represents a level.
    /// </summary>
    public class Level
    {
        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        [Newtonsoft.Json.JsonProperty(TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto)]
        public BrickZone Map { get; set; }

        /// <summary>
        /// Gets or sets the name of the level.
        /// </summary>
        /// <value>
        /// The name of the level.
        /// </value>
        public string LevelName { get; set; }

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public string Path { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// The JSON settings
        /// </summary>
        public static  JsonSerializerSettings settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All,
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ObjectCreationHandling = ObjectCreationHandling.Replace
            
        };
        /// <summary>
        /// Initializes a new instance of the <see cref="Level"/> class.
        /// </summary>
        public Level()
        {
            this.Path = String.Format("../../../levels/Default/level{0}.json", Directory.GetFiles("../../../levels/Default/").Count() + 1);
            this.Map = null;
            this.Id = 0;
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Level"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Level(int id)
        {
            
            this.Id = id;
            this.Path = String.Format("../../../levels/Default/level{0}.json", Directory.GetFiles("../../../levels/Default/").Count() + 1);
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Level"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="map">The map.</param>
        public Level(int id, BrickZone map ){
            
            this.Map = map;
            this.Id = id;
            this.Path = String.Format("../../../levels/Default/level{0}.json", Directory.GetFiles("../../../levels/Default/").Count() + 1);
        }


        /// <summary>
        /// Loads this instance.
        /// </summary>
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


        /// <summary>
        /// Writes this instance.
        /// </summary>
        public void write()
        {
            
            
            File.WriteAllText(Path, JsonConvert.SerializeObject(this,Formatting.Indented,settings));
           

        }

        /// <summary>
        /// Loads all defaults levels.
        /// </summary>
        /// <returns>the default levels</returns>
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
