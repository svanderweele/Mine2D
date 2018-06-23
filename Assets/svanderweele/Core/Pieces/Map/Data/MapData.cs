using System;

namespace svanderweele.Core.Pieces.Map.Data
{
    public class MapData
    {
        public string Name;
        public DateTime CreationDate;

        public static MapData Default =
            new MapData() {Name = "Playground", CreationDate = DateTime.Today};
    }
}