public class Round
{
    public Team teamEsquerdo { get; protected set; }
    public Team teamDireito { get; protected set; }

    private Round current = null;
    public void NewRound(Team teamEsquerdo, Team teamDireito)
    {
        this.current = new Round();
        this.current.teamEsquerdo = teamEsquerdo;
        this.current.teamDireito = teamDireito;
        this.current.teamEsquerdo.Round = this;
        this.current.teamDireito.Round = this;
    }

    public Team Start()
    {
        //ToDo aqui que rola a batalha
        return teamDireito;
    } 
}