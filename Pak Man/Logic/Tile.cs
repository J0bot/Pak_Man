namespace Pak_Man
{
    public enum Tile
    {
        EMPTY,
        FOOD,
        WALL_BOTTOM,    //(FF,0,0)
        WALL_TOP,       //(0,FF,0)
        WALL_RIGHT,     //(0,FF,FF)
        WALL_LEFT,      //(0,0,FF)
        CORNER_TOP_LEFT,            //(FF,FF,0)
        CORNER_TOP_RIGHT,           //(FF,100,FF)
        CORNER_BOTTOM_LEFT,         //(100,0,0)
        CORNER_BOTTOM_RIGHT,        //(0,100,0)
        INNER_CORNER_BOTTOM_LEFT,   //(0,0,100)
        INNER_CORNER_BOTTOM_RIGHT,  //(100,0,100)
        INNER_CORNER_TOP_RIGHT,     //(100,100,0)
        INNER_CORNER_TOP_LEFT,      //(0,100,100)


    }
}
