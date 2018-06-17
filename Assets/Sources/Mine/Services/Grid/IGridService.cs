public interface IGridService
{
    void InitGrid(float width, float height, float tileWidth, float tileHeight);
    void SetGridSize(float width, float height);
    void SetGridPosition(float x, float y);

    void PopulateTile(int tileEID, int objectIED);
    void DePopulateTile(int tileEID);
    int[] GetTileEntities(int tileEID);
}