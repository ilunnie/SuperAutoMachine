using System.Collections.Generic;
using System.Drawing;
using System.IO.Pipes;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

public class GameApp : App
{
    Image moeda = Image.FromFile("Img/moeda.png");
    Image coracao = Image.FromFile("Img/coracao.png");
    private Round round = new();
    private Team player1 = new Player();
    private Team player2 = new Bot();
    private bool player1_shopping = true;

    private RectangleF[] slot_pieces = new RectangleF[5]; 
    private RectangleF[] shop_pieces = new RectangleF[5]; 
    private int teste = 0; //ToDo apagar depois
    public override void OnFrame(bool IsDown, PointF cursor)
    {
        if(!round.Shopping && !round.Battling) {
            player1.Mercado.basePieces = GetBasePieces();
            player2.Mercado.basePieces = GetBasePieces();
            round.NewRound(player1, player2);
        }

        if(round.Shopping) {
            var player = player1_shopping ? player1 : player2;
            DrawImage((Bitmap)moeda, new RectangleF(50, 50, 100, 100));
            DrawText(player.Mercado.Moeda.ToString(), Color.Black, new RectangleF(50, 50, 100, 100));

            DrawImage((Bitmap)coracao, new RectangleF(150, 50, 100, 100));
            DrawText(player.Vidas.ToString(), Color.White, new RectangleF(150, 50, 100, 100)); 

            int index = 0;
            foreach (var piece in player.pieces)
            {
                slot_pieces[index] = DrawLocalShopPiece(piece, index, 200, 250);
                index++;
            }

            index = 0;
            foreach (var piece in player.Mercado.pieces)
            {
                shop_pieces[index] = DrawLocalShopPiece(piece, index, 250, 750);
                index++;
            }

            
            int shop_Index = -1;
            for(var i = 0; i < shop_pieces.Length; i++)
            {
                if(shop_pieces[i].Contains(cursor) && IsDown) 
                    shop_Index = i;
            }
            int slot_Index = -1;
            for(var i = 0; i < slot_pieces.Length; i++)
            {
                if(slot_pieces[i].Contains(cursor) && IsDown)
                    slot_Index = i;
            }

            if(shop_Index >= 0 && slot_Index >= 0)
            {
                player.Mercado.Buy(shop_Index, slot_Index);
            }

            // int slot_Index = 0;
            // foreach (var shop in shop_pieces)
            // {
            //     slot_Index = 0;
            //     foreach (var slot in slot_pieces)
            //     {
            //         if(shop.Contains(cursor) && slot.Contains(cursor) && !IsDown) {
            //             player.Mercado.Buy(shop_Index, slot_Index);
            //         }
            //         slot_Index++;
            //     }
            //     shop_Index++;
            // }
        }

        if(round.Battling) {
            
        }
    }

    private RectangleF DrawLocalShopPiece(Piece piece, int index, int x, int y)
    {
        RectangleF location = new RectangleF(x * (index) + 75, y, 200, 200);
        DrawEmptyPiece(location, false, "");

        RectangleF rect = new RectangleF();
        if(piece != null)
            rect = DrawPiece(location, piece.Ataque, piece.Vida, piece.Xp, piece.Tier, true, piece.GetType().Name);
        return rect;
    }

    private List<Piece> GetBasePieces()
    {
        List<Piece> pieces = new List<Piece>
        {
            new Martelo(),
            new ChaveDeFenda(),
            new Esteira(),
            new FuradeiraDeColuna(),
            new FornoIndustrialAGas(),
            new RetificaPlana(),
            new FuradeiraDeCoordenada(),
            new FornoIndutrialEletrico(),
            new RetificaCilindrica(),
            new Fresa(),
            new Torno(),
            new TornoCNC(),
            new FresaCNC(),
            new CorteAPlasmaCNC()
        };

        return pieces;
    }
}