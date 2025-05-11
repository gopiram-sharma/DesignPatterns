namespace Entities;

using System.Collections.Generic;

public class Hand
{
    public List<Card> Cards {get;}
    public HandRank Rank {get; private set;}

    public Hand(string handStr){
        Cards = handStr.Split(',').Select(c => new Card(c.Trim())).ToList();
        Rank = HandEvaluator.Evaluate(Cards);
    }

}