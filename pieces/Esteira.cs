using System;
using System.Drawing;
public class Esteira : Piece
{
    public Esteira(){
        this.Ataque = 3;
        this.Vida = 1;
        this.Xp = 1;
        this.Tier = 1;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        Esteira piece = new Esteira();

        piece.Ataque = this.Ataque;
        piece.Vida = this.Vida;
        piece.Xp = this.Xp;

        return piece;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect() { }

    public override void SellEffect(Mercado mercado)
    {
        mercado.Moeda += 1;
    }

    public override void StartBattleEffect() { }

    public override void StartShoppingEffect(Mercado mercado) { }
}