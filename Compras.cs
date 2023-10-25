using System.Drawing;
using System.Windows.Forms;
 
public class Compras : App
{
    Image moeda = Image.FromFile("moeda.png");
    Image coracao = Image.FromFile("coracao.png");
    bool fundiu = false;
    bool clicked = false;

    Deck deck = new Deck();
    Player player = new Player();
    RectangleF card1 = RectangleF.Empty;
    RectangleF card2 = RectangleF.Empty;
    RectangleF card3 = RectangleF.Empty;
    public override void OnFrame(bool isDown, PointF cursor)
    {
        if (card1.Contains(cursor) && card2.Contains(cursor) && !isDown)
            fundiu = true;
 
        if (!fundiu)
        {
            for (int i = 0; i < deck.Slots.Length; i++)
            {
                DrawEmptyPiece(deck.Slots[i], true, "");
            }

            card1 = DrawPiece(new RectangleF(300, 300, 200, 200), 1, 3, 1, 1, true, "CNC");
            card2 = DrawPiece(new RectangleF(550, 300, 200, 200), 2, 4, 2, 1, true, "CNC");
            card3 = DrawPiece(new RectangleF(800, 300, 200, 200), 5, 2, 3, 1, true, "CNC");

            DrawImage((Bitmap)moeda, new RectangleF(1050, 300, 100, 60));
            DrawText(player.Gold.ToString(), Color.Black, new RectangleF(1050, 300, 100, 60));

            DrawImage((Bitmap)coracao, new RectangleF(1050, 500, 100, 100));
            DrawText(player.Hearts.ToString(), Color.White, new RectangleF(1050, 500, 100, 100));
        }
        else
        {
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
        }
 
        if (!clicked)
        {
            clicked = DrawButton(new RectangleF(400, 800, 200, 100), "Iniciar");
            if (clicked)
                MessageBox.Show("Clicou");
        }
    }
}