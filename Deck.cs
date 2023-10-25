using System.Drawing;

public class Deck
{
    public object Card { get; set; }

    public RectangleF[] Slots { get; private set; } = new RectangleF[5];

    public Deck()
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            Slots[i] = new RectangleF(50 + (250 * i), 50, 200, 200);
        }
    }
}
