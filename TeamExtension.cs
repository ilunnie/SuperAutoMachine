using System;

public static class TeamExtension
{
    public static Team GetEnemy(this Team team)
    {
        return team.Round.teamEsquerdo == team ?
            team.Round.teamEsquerdo :
            team.Round.teamDireito;
    }

    public static Piece RandomPiece(this Team team)
    {
        int index;
        while(true) {
            index = Random.Shared.Next();

            if(team.pieces[index] != null)
                break;
        }
        return team.pieces[index];
    }
}