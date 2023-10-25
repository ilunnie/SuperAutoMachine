using System;
using System.Drawing;
public class FornoIndustrialAGas : Piece
{
    public FornoIndustrialAGas(){
        this.Ataque = 1;
        this.Vida = 3;
        this.Xp = 1;
        this.Tier = 2;
    }
    public override void AllySummonedEffect() { }

    public override void BuyEffect() { }

    public override Piece Clone()
    {
        FornoIndustrialAGas piece = new FornoIndustrialAGas();

        piece.Ataque = this.Ataque;
        piece.Vida = this.Vida;
        piece.Xp = this.Xp;

        return piece;
    }

    public override void FaintEffect() { }

    public override void LevelUpEffect() { }

    public override void SellEffect() { }

    public override void StartBattleEffect() { }

    public override void StartShoppingEffect() 
    {
        this.team.Mercado.Moeda += (1 * this.Nivel);
    }
}