using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Reflection;

public class Mercado
{
    private Team team = null;
    public int Moeda { get; set; } = 10;
    public int MaxTier { get; protected set; } = 1;
    public List<Piece> pieces = new();
    public List<Piece> basePieces = new();

    public Mercado(Team team)
        => this.team = team;

    public void Buy(int index, int destiny) {
        if (Moeda < 3)
            throw new InvalidOperationException("Faltou moeda seu pobre kk");

        team.Add(pieces[index], destiny);
        pieces.RemoveAt(index);
    }

    public void Add(Piece piece)
        => this.basePieces.Add(piece);

    public void Refill()
    {
        if (Moeda < 1)
            return;

        Moeda--;
        FreeRefill();
    }

    public void FreeRefill()
    {
        pieces.Clear();
        pieces.Add(getRandomPiece());
        pieces.Add(getRandomPiece());
        pieces.Add(getRandomPiece());
    }

    private Piece getRandomPiece()
    {
        while(true) {
            Random random = new Random();
            int index = random.Next(0, basePieces.Count);
            var piece = this.basePieces[index];

            if(piece.Tier <= MaxTier)
                return piece.Clone();
        }        
    }
}