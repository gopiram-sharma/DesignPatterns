using Entities;

string input = "8♥,J♠,T♣,2♦,Q♥ 4♣,K♠,3♥,7♦,6♠";
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(PokerHandComparer.CompareHands(input));