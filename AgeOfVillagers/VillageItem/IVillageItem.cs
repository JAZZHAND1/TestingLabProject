using System.Drawing;

namespace AgeOfVillagers
{
    interface IVillageItem
    {
        int getHeight();
        int getWidth();
        IShape getItemShape(Point point);
    }
}
