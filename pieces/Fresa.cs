using System;
using System.Drawing;
public class Fresa : Piece
{
    public Fresa(){
        this.Ataque = 4;
        this.Vida = 5;
        this.Xp = 1;
        this.Tier = 4;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        Fresa piece = new Fresa();

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