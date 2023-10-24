using System;
using System.Drawing;
public class RetificaCilindrica : Piece
{
    public RetificaCilindrica(){
        this.Ataque = 2;
        this.Vida = 6;
        this.Xp = 1;
        this.Tier = 3;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        RetificaCilindrica piece = new RetificaCilindrica();

        piece.Ataque = this.Ataque;
        piece.Vida = this.Vida;
        piece.Xp = this.Xp;

        return piece;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect() { }

    public override void SellEffect(Mercado mercado) { }

    public override void StartBattleEffect() { }

    public override void StartShoppingEffect(Mercado mercado) { }
}