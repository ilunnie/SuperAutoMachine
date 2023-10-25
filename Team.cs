using System;
using System.Collections.Generic;

public abstract class Team
{
    public int Vidas { get; private set; } = 5;
    public string Name { get; set; }
    public Round Round = new();
    public Piece[] pieces = new Piece[5];
    public Mercado Mercado { get; private set; }

    public Team() {
        this.Mercado = new Mercado(this);
    }

    public void Add(Piece piece, int index)
    {
        if(pieces[index] != null)
            throw new InvalidOperationException(
                "ocupado kk"
            );

        for(int i = 0; i < 5; i++)
        {
            if(pieces[i] is null)
                continue;
            pieces[i].AllySummonedEffect();
        }
        pieces[index] = piece;
        pieces[index].BuyEffect();
    }

    public void Sell(int index)
    {
        if(pieces[index] is null)
            throw new InvalidOperationException(
                "index vazio"
            );

        for (int i = 0; i < 5; i++)
        {
            if(pieces[i] is null)
                continue;
            pieces[i].SellEffect();
        }

        pieces[index] = null;
    }
}