using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class Resources
    {
        private static readonly Dictionary<string, Texture2D> textures = new Dictionary<string, Texture2D>();

        private static readonly Dictionary<string, string> resourcesToLoad = new Dictionary<string, string>()
        {
            { "pacman", @"sprites/pac-man/pac-man01" },
            { "block", @"sprites/block" },
            { "map", @"sprites/map04" },
            { "walls_spritesheet", @"sprites/walls_spritesheet" },
            { "FOOD", @"sprites/food" }
        };

        public static void Load(ContentManager content)
        {
            foreach (KeyValuePair<string, string> resData in resourcesToLoad)
            {
                if (resData.Value.Contains("sprites"))
                {
                    textures.Add(resData.Key, content.Load<Texture2D>(resData.Value));
                }
            }
        }

        public static Texture2D GetTexture(string resourceName)
        {
            return textures[resourceName];
        }
    }
}
