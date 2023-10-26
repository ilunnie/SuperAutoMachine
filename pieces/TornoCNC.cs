using System;
using System.Drawing;
public class TornoCNC : Piece
{
    public TornoCNC(){
        this.Ataque = 5;
        this.Vida = 8;
        this.Xp = 1;
        this.Tier = 5;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        TornoCNC piece = new TornoCNC();

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