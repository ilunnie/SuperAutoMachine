using System;
using System.Drawing;
public class FuradeiraDeCoordenada : Piece
{
    public FuradeiraDeCoordenada(){
        this.Ataque = 3;
        this.Vida = 5;
        this.Xp = 1;
        this.Tier = 3;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        FuradeiraDeCoordenada piece = new FuradeiraDeCoordenada();

        piece.Ataque = this.Ataque;
        piece.Vida = this.Vida;
        piece.Xp = this.Xp;

        return piece;
    }

    public override void FaintEffect()
    {
        if(this.Vida <= 0)
            return;

        Team enemy = this.team.GetEnemy();
        Piece piece = enemy.RandomPiece();
        piece.RecebeDano(this.Ataque);
    }

    public override void LevelUpEffect() { }

    public override void SellEffect(Mercado mercado) { }

    public override void StartBattleEffect() { }

    public override void StartShoppingEffect(Mercado mercado) { }
}