namespace Entities;

public class PokerHandComparer
{
    public static string CompareHands(string input)
    {
        var parts = input.Split(' ');
        var hand1 = new Hand(parts[0]);
        var hand2 = new Hand(parts[1]);

        string hand1Type = hand1.Rank.ToFriendlyString();
        string hand2Type = hand2.Rank.ToFriendlyString();

        if(hand1.Rank > hand2.Rank)
            return $"Player 1 has {hand1Type}, Player 2 has {hand2Type} -> Player 1 wins!";
        if(hand2.Rank > hand1.Rank)
            return $"Player 1 has {hand1Type}, Player 2 has {hand2Type} -> Player 2 wins!";

        return $"Both players have {hand1Type} -> Tie!";
    }
}