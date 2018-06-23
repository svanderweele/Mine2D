using System;
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
        public static string MapEditorAssetDataPath = "data/map-editor-asset-data";
        public static string ResourcesAssetsPath = "assets/";
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

    public class ObjectType
    {
        private const char DELIMITER = '-';

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

        public string JoinTypes(params string[] types)
        {
            var unorderedTypes = types.ToList();
            var orderedTypes = new List<string>();
            var lowestIndex = int.MaxValue;
            var lowestSelection = "";

            for (var i = 0; i < unorderedTypes.Count; i++)
            {
                var type = unorderedTypes[i];
                
                if(orderedTypes.IndexOf(type) > -1){
                    continue;
                }

                var index = _indexDictionary.IndexOf(type);
                if (index < lowestIndex)
                {
                    lowestIndex = index;
                    lowestSelection = type;
                }

                if (orderedTypes.Count == 0 || i == unorderedTypes.Count - 1)
                {
                    orderedTypes.Add(lowestSelection);
                    lowestIndex = int.MaxValue;
                }
            }


            var stringFormat = string.Join(DELIMITER.ToString(), orderedTypes.ToArray());
            return stringFormat;
        }

        public string[] SplitTypes(string types)
        {
            return types.Split(DELIMITER);
        }

        public bool Matches(string aTypes, string bTypes)
        {
            return aTypes.IndexOf(bTypes) > -1 || bTypes.IndexOf(aTypes) > -1;
        }
    }
}