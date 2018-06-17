using Entitas;

[Game]
public class GridComponent : IComponent
{
    public int Columns;
    public int Rows;
    public int TileWidth;
    public int TileHeight;
    public bool ShouldRefresh;
}