using System;
using System.Drawing;
public class FornoIndutrialEletrico : Piece
{
    public FornoIndutrialEletrico(){
        this.Ataque = 4;
        this.Vida = 3;
        this.Xp = 1;
        this.Tier = 3;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        FornoIndutrialEletrico piece = new FornoIndutrialEletrico();

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