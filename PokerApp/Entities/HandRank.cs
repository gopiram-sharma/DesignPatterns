namespace Entities;

public enum HandRank{
    HighCard, Pair, TwoPair, ThreeOfAKind, Straight,
    Flush, FullHouse, FourOfAKind, StraightFlush, RoyalFlush
}

public static class HandRankExtensions
{
    public static string ToFriendlyString(this HandRank rank)
    {
        return rank switch
        {
            HandRank.HighCard => "High Card",
            HandRank.Pair => "Pair",
            HandRank.TwoPair => "Two Pair",
            HandRank.ThreeOfAKind => "Three of a Kind",
            HandRank.Straight => "Straight",
            HandRank.Flush => "Flush",
            HandRank.FullHouse => "Full House",
            HandRank.FourOfAKind => "Four of a Kind",
            HandRank.StraightFlush => "Straight Flush",
            HandRank.RoyalFlush => "Royal Flush",
            _ => "Unknown"
        };
    }
}