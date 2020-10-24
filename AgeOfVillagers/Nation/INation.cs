using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        string nationName { get; set; }
        Color getTerrainColor();
        IShape getItemShape(Point point, String itemType);
    }
}
