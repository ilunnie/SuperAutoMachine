public class DeckBuilder
{
    // Piece card = new Piece();
    private Deck deck = null;

    public DeckBuilder chooseDeck(Deck deck)
    {
        this.deck = deck;
        return this;
    }
    public DeckBuilder AddSlot1(object card)
    {
        deck.Card = card;

        return this;
    }
    public void AddSlot2()
    {

    }
    public void AddSlot3()
    {

    }
    public void AddSlot4()
    {

    }
    public void AddSlot5()
    {

    }
    public void Build() { }
}