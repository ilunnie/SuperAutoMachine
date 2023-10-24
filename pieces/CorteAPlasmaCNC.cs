using System;
using System.Drawing;
public class CorteAPlasmaCNC : Piece
{
    public CorteAPlasmaCNC(){
        this.Ataque = 6;
        this.Vida = 8;
        this.Xp = 1;
        this.Tier = 6;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        CorteAPlasmaCNC piece = new CorteAPlasmaCNC();

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