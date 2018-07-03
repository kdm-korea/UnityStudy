using System;

public class Class1 {
    enum Suit { S, D, H, C};

    struct Card {
        public Suit suit;
        public int num;
    }
    static int numPlayers = 5;
    static int cardCount = 5;
    static Card[] card = new Card[52];
    static Card[,] Player = new Card[numPlayers, cardCount];

    static void main(string[] args) {
        PrintCards();

        ShowCard();

        Shuffle();

        Distribute();

        ShowPlayerCard();

        
    }
    private static int CountNum(int n) {
        int cnt = 0;
        for (int idx1 = 0; idx1  < numPlayers; idx1++) {
            for (int idx2= 0; idx2 < cardCount; idx2++) {
                if(Player[n, idx1].num == Player[n, idx2].num) {
                    if(idx1 != idx2) {
                        cnt++;
                    }
                }
            }
        }
    }
    private static int IsOnePair(int i) {
        int c = CountNum(i);
        if (c == 2) Console.WriteLine("OnePair");
        return c;
    }

    private static int IsTwoPair(int i) {
        int c = CountNum(i);
        if (c == 4) Console.WriteLine("TwoPair");
        return c;
    }

    private static int IsTriple(int i) {
        int c = CountNum(i);
        if (c == 6) Console.WriteLine("TwoPair");
        return c;
    }

    private static int IsFullHouse(int i) {
        int c = CountNum(i);
        if (c == 8) Console.WriteLine("TwoPair");
        return c;
    }

    private static int IsFoker(int i) {
        int c = CountNum(i);
        if (c == 12) Console.WriteLine("TwoPair");
        return c;
    }

    private static int IsFlush(int n) {
        for (int i = 1; i < 5; i++) {
            if(Player[n,0].suit != Player[n,i].suit) {
                return 0;
            }
        }
        return 1;
    }

    private static int IsIsStraight(int n) {
        int tmp = 0;
        for (int idx = 0; idx < 5; idx++) {
            for (int idx1 = 0; idx1 < 5; idx1++) {
                if(Player[n, idx] == Player[n, idx1] && idx != idx1) {
                    return 0;
                }else if(Player[n,idx] > Player[n, idx1]) {
                    tmp = Player[n, idx1];
                    Player[n, idx1] = Player[n, idx];
                    Player[n, idx] = tmp;
                }
            }
        }
        if((Player[n, 0]- Player[n, 4] ) == 4) {
            return 1;
        } else {
            return 0;
        }
    }

    private static void PrintCards(int i) {
        for (int idx = 0; idx < card.lengh; idx++) {
            card[idx].suit = (suit) ( idx / 13 );
            card[idx].num = idx % 13 + 1;
        }
    }

    private static void ShowCard() {
        for (int idx = 0; idx < card.lengh; idx++) {
            Console.Write(card[idx].suit + " " + card[idx].num.ToString("00"));
            if (idx % 13 == 12) {
                Console.WriteLine("\n");
            }
            int c1 = IsOnePair(i);
            int c2 = IsTwoPair(i);
            int c3 = IsTriple(i);
           //int c4 = IsStraight(i);
            //int c5 = IsFlush(i);
            int c6 = IsFullHouse(i);
            int c7 = IsFoker(i);
            //int c8 = IsStraghtFlush(i);
        }
    }
    
    private static void Shuffle() {
        Random r = new Random();

        for (int idx = 0; idx < 300; idx++) {
            int r1 = r.Next(card.lengh);
            int r2 = r.Next(card.lengh);

            Card tmp = card[r1];
            card[r1] = card[r2];
            card[r2] = tmp;
        }

    }

    private static void Distribute() {
        int idx = 0;
        for (int peridx = 0; peridx < numPlayers; peridx++) {
            for (int cardidx = 0; cardidx < cardCount; cardidx++) {
                Player[peridx, cardidx] = card[idx++];
            }
        }
    }

    private static void ShowPlayerCard() {
        int idx = 0;
        for (int peridx = 0; peridx < numPlayers; peridx++) {
            for (int cdidx = 0; cdidx < cardCount; cdidx++) {
                Console.Write(Player[peridx, cardCount].num, Player[peridx, cardCount].num+" ");
            }
            Console.Write("\n\n");
        }
    }
}

