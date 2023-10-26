using System;
using System.Drawing;
public class Martelo : Piece
{
    public Martelo(){
        this.Ataque = 2;
        this.Vida = 3;
        this.Xp = 1;
        this.Tier = 1;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        Martelo piece = new Martelo();

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