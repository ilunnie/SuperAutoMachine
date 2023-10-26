using System;
using System.Drawing;
public class FuradeiraDeColuna : Piece
{
    public FuradeiraDeColuna(){
        this.Ataque = 3;
        this.Vida = 5;
        this.Xp = 1;
        this.Tier = 2;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        FuradeiraDeColuna piece = new FuradeiraDeColuna();

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