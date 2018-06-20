namespace svanderweele.Mine.Game.Components.Grid
{
    public static class GridContextExtension
    {
        public static GridEntity CreateGrid(this GridContext context, int rows, int columns, float tileWidth, float tileHeight, TileType[] types)
        {
            var grid = context.CreateEntity();
            grid.AddGridSize(rows, columns);
            grid.AddGridTileSize(tileWidth, tileHeight);
            grid.AddGridTileType(types);
            grid.AddGridTiles(new int[,]{});
            return grid;
        }
    }
}