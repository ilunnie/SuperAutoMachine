using System;
using System.Drawing;
public class RetificaPlana : Piece
{
    public RetificaPlana(){
        this.Ataque = 4;
        this.Vida = 2;
        this.Xp = 1;
        this.Tier = 2;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        RetificaPlana piece = new RetificaPlana();

        piece.Ataque = this.Ataque;
        piece.Vida = this.Vida;
        piece.Xp = this.Xp;

        return piece;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect() { }

    public override void SellEffect() { }

    public override void StartBattleEffect() { }

    public override void StartShoppingEffect() { }
}