using System.Collections.Generic;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
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
    private RectangleF[] shop_pieces = new RectangleF[3]; 
    private int?[] toBuy = new int?[2];
    private int?[] toTransfer = new int?[2];
    public override void OnFrame(bool IsDown, PointF cursor)
    {
        if(!round.Shopping && !round.Battling) {
            player1.Mercado.basePieces = GetBasePieces();
            player2.Mercado.basePieces = GetBasePieces();
            round.NewRound(player1, player2);
        }

        if(round.Shopping) {
            ShoppingFrame(IsDown, cursor);
        }

        if(round.Battling) {
            
        }
    }
    private bool reseting = false;
    private void ShoppingFrame(bool IsDown, PointF cursor)
    {
        var player = player1_shopping ? player1 : player2;

        if(!IsDown && toBuy.All(x => x.HasValue)) {
            player.Mercado.Buy(toBuy[0].Value, toBuy[1].Value);
        }
        shop_pieces = new RectangleF[player.Mercado.pieces.Count()];
        toBuy = new int?[2];

        if(!IsDown && toTransfer.All(x => x.HasValue)) {
            player.Sort(toTransfer[0].Value, toTransfer[1].Value);
        }
        toTransfer = new int?[2];

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

        int shop_Index = 0;
        foreach (var shop in shop_pieces)
        {
            int slot_Index = 0;
            foreach (var slot in slot_pieces)
            {
                if(shop.Contains(cursor) && slot.Contains(cursor)) {
                    toBuy[0] = shop_Index;
                    toBuy[1] = slot_Index;
                }
                slot_Index++;
            }
            shop_Index++;
        }

        index = 0;
        int slot_index = 0;
        foreach (var pieces in slot_pieces)
        {
            if (pieces.Contains(cursor))
                if(slot_index == 0) {
                    toTransfer[0] = index;
                    slot_index++;
                }
                else
                    toTransfer[1] = index;
            index++;
        }
    
        bool refill = DrawButton(new RectangleF(800, 850, 200, 100), "ReFill");
        if(refill && !reseting)
        {
            player.Mercado.Refill();
            reseting = true;
        }
        if(!IsDown)
            reseting = false;
    }

    private RectangleF DrawLocalShopPiece(Piece piece, int index, int x, int y)
    {
        RectangleF location = new RectangleF(x * (index) + 75, y, 200, 200);
        location = DrawEmptyPiece(location, false, "");
        
        if(piece != null)
            location = DrawPiece(location, piece.Ataque, piece.Vida, piece.Xp, piece.Tier, true, piece.GetType().Name);

        return location;
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