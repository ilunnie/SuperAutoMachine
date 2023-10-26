public class Round
{
    public Team teamEsquerdo { get; protected set; }
    public Team teamDireito { get; protected set; }

    public bool Shopping { get; private set; }
    public bool Battling { get; private set; }

    private Round current = null;
    public void NewRound(Team teamEsquerdo, Team teamDireito)
    {
        this.current = new Round();
        this.current.teamEsquerdo = teamEsquerdo;
        this.current.teamDireito = teamDireito;
        this.current.teamEsquerdo.Round = this;
        this.current.teamDireito.Round = this;

        this.Shopping = true;
        this.Battling = false;

        teamEsquerdo.Mercado.FreeRefill();
        teamDireito.Mercado.FreeRefill();
    }
}