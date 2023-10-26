using System;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;

public abstract class Piece
{
    public Team? team { get; set; }
    public bool Vivo { get; protected set; } = true;
    public int Tier { get; protected set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Xp { get; set; }
    public Bitmap? Image { get; protected set;}
    public int Nivel =>
        Xp switch
        {
            < 3 => 1,
            < 6 => 2,
            _ => 3
        };

    public void Atacar(Piece piece) {
        this.RecebeDano(piece.Ataque);
        piece.RecebeDano(this.Ataque);
    }

    public void RecebeDano(int damage) {
        this.Vida -= damage;
        if(this.Vida <= 0)
            this.Vivo = false;
    }

    public void Fundir(Piece piece) {
        if(this.GetType() != piece.GetType())
            throw new InvalidOperationException(
                "deu lgtv+"
            );

        if(this.Nivel == 3 || piece.Nivel == 3)
            throw new InvalidOperationException(
                "obesidade"
            );

        int oldNivel = this.Nivel;

        this.Vida = this.Vida > piece.Vida ?
                    this.Vida + 1 : piece.Vida + 1;

        this.Ataque = this.Ataque > piece.Ataque ?
                    this.Ataque + 1 : piece.Ataque + 1;

        this.Xp += piece.Xp;
        if (this.Xp > 6)
            this.Xp = 6;

        if(this.Nivel > oldNivel)
            LevelUpEffect();
    }

    public abstract void FaintEffect();
    public abstract void SellEffect();
    public abstract void BuyEffect();
    public abstract void LevelUpEffect();
    public abstract void StartBattleEffect();
    public abstract void AllySummonedEffect();
    public abstract void StartShoppingEffect();
    public abstract Piece Clone();
}