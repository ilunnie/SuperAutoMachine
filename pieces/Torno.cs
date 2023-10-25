using System;
using System.Drawing;
public class Torno : Piece
{
    public Torno(){
        this.Ataque = 5;
        this.Vida = 3;
        this.Xp = 1;
        this.Tier = 4;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        Torno piece = new Torno();

        piece.Ataque = this.Ataque;
        piece.Vida = this.Vida;
        piece.Xp = this.Xp;

        return piece;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect() { }

    public override void SellEffect() { }

    public override void StartBattleEffect() 
    { 
        bool tem_nivel_3 = false;
        foreach (var piece in this.team.pieces)
        {
            if(piece.Nivel == 3)
                tem_nivel_3 = true;
        }

        if (tem_nivel_3) {
            this.Ataque += 2;
            this.Vida += 2;
        }
    }

    public override void StartShoppingEffect() { }
}