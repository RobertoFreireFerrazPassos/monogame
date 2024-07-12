using Microsoft.Xna.Framework;
using System;

namespace PriestVsDemons;

internal class Sprite
{
    public Rectangle Source;

    public Sprite(int number)
    {
        (int x, int y) = ConvertNumberToXY(number);
        Source = new Rectangle(x*40, y*40, 40, 40);
    }

    private (int x, int y) ConvertNumberToXY(int number)
    {
        if (number < 1 || number > 39)
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 39.");

        int rows = 3;
        int columns = 13;

        int x = (number - 1) % columns;
        int y = (number - 1) / columns;

        return (x, y);
    }
}
