using Breakout.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Breakout.Model
{
    /// <summary>
    /// This is a class that represents a custom level.
    /// </summary>
    public class CustomLevel : Level
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLevel"/> class.
        /// </summary>
        public CustomLevel() : base()
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLevel"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public CustomLevel(int id) : base(id)
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLevel"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="map">The map.</param>
        public CustomLevel(int id, BrickZone map) : base(id,map)
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLevel"/> class.
        /// </summary>
        /// <param name="levelName">Name of the level.</param>
        /// <param name="map">The map.</param>
        public CustomLevel(string levelName, BrickZone map)
            : base()
        {
            this.Path = String.Format("../../../levels/Customized/level{0}.json", Directory.GetFiles("../../../levels/Customized/").Count() + 1);
            
            
            this.LevelName = levelName;
        }
        /// <summary>
        /// Loads all custom.
        /// </summary>
        /// <returns>a list a custom levels</returns>
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
