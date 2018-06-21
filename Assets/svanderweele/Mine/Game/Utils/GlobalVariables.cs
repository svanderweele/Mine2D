using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Assertions;

namespace svanderweele.Mine.Game.Utils
{
    public static class GlobalVariables
    {
        public const string ACTION_HIDE_ACTOR = "ACTION_HIDE_ACTOR";

        public static ObjectType ObjectType = new ObjectType();

        public enum Layer
        {
            Background = 0,
            Foreground = 1,
        }
    }



    public enum KeyId
    {
        W,
        A,
        S,
        D,
        Space,
        None,
        Escape
    }

    public enum TileType
    {
        Tile,
        Object,
        Wire,
        Debug
    }
    
    
    public class ObjectType
    {
        private List<string> _indexDictionary;

        public const string OBJECT_CATEGORY_TILE = "OBJECT_CATEGORY_TILE";
        public const string OBJECT_CATEGORY_DEBUG = "OBJECT_CATEGORY_DEBUG";

        public ObjectType()
        {
            _indexDictionary = new List<string>();

            IndexCategory(OBJECT_CATEGORY_DEBUG);
            IndexCategory(OBJECT_CATEGORY_TILE);
        }

        private void IndexCategory(string category)
        {
            Assert.IsFalse(_indexDictionary.IndexOf(category) > -1, "Category already indexed " + category);
            _indexDictionary.Add(category);
        }

        public string GetType(string[] types)
        {
            var unorderedTypes = types.ToList();
            var orderedTypes = new List<string>();
            var lowestIndex = int.MaxValue;
            var lowestSelection = "";

            for (var i = 0; i < unorderedTypes.Count; i++)
            {
                var type = unorderedTypes[i];
                var index = _indexDictionary.IndexOf(type);
                if (index < lowestIndex)
                {
                    lowestIndex = index;
                    lowestSelection = type;
                }

                if (orderedTypes.Count == 0 || i == unorderedTypes.Count - 1)
                {
                    orderedTypes.Add(lowestSelection);
                    unorderedTypes.RemoveAt(i);
                    lowestIndex = int.MaxValue;
                }
            }

            var stringFormat = "";

            foreach (var orderedType in orderedTypes)
            {
                stringFormat += orderedType;
            }

            return stringFormat;
        }
    }
}