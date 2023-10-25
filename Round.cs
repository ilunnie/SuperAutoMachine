public class Round
{
    protected Team teamEsquerdo { get; set; }
    protected Team teamDireito { get; set; }

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