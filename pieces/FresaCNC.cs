using System;
using System.Drawing;
public class FresaCNC : Piece
{
    public FresaCNC(){
        this.Ataque = 8;
        this.Vida = 4;
        this.Xp = 1;
        this.Tier = 5;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        FresaCNC piece = new FresaCNC();

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