namespace Entities;

public class Card{
    public int Value { get; }
    public char Suit { get; }

    public Card(string cardStr){
        Value = "23456789TJQKA".IndexOf(cardStr[0]) + 2;
        Suit = cardStr[1];
    }
}