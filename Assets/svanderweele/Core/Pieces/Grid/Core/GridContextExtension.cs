﻿using svanderweele.Core.Pieces.Grid.Core.Components;

namespace svanderweele.Core.Pieces.Grid.Core
{
    public static class GridContextExtension
    {
        public static GridEntity CreateGrid(this GridContext context, int rows, int columns, float tileWidth,
            float tileHeight, string type)
        {
            var grid = context.CreateEntity();
            grid.isGrid = true;
            grid.isNewGrid = true;
            grid.AddGridSize(rows, columns);
            grid.AddGridTileSize(tileWidth, tileHeight);
            grid.AddGridTileType(type);
            grid.AddGridTiles(new TileEntities[,] { });
            grid.isGridChanged = true;
            return grid;
        }
    }
}