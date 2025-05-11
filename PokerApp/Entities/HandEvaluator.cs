namespace Entities;

public static class HandEvaluator
{
    public static HandRank Evaluate(List<Card> cards)
    {
        bool isFlush = cards.All(c => c.Suit == cards[0].Suit);
        var ordered = cards.Select(c => c.Value).OrderBy(v => v).ToList();
        bool isStraight = ordered.Zip(ordered.Skip(1), (a, b) => b - a)
            .All(diff => diff == 1);

        var groups = cards.GroupBy(c => c.Value)
            .OrderByDescending(g => g.Count())
            .ThenByDescending(g => g.Key).ToList();
        int[] counts = groups.Select(g => g.Count()).ToArray();

        if(isFlush && isStraight && ordered.Last() == 14) return HandRank.RoyalFlush;
        if(isFlush && isStraight) return HandRank.StraightFlush;
        if(counts.SequenceEqual(new[] {4,1})) return HandRank.FourOfAKind;
        if(counts.SequenceEqual(new[] {3,2})) return HandRank.ThreeOfAKind;
        if(isFlush) return HandRank.Flush;
        if(isStraight) return HandRank.Straight;
        if(counts.SequenceEqual(new[] {3,1,1})) return HandRank.ThreeOfAKind;
        if(counts.SequenceEqual(new[] {2,2,1})) return HandRank.TwoPair;
        if(counts.SequenceEqual(new[] {2,1,1,1})) return HandRank.Pair;

        return HandRank.HighCard;
    }
}