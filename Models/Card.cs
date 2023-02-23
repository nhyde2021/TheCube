namespace TheCube.Models
{
    public class Card
    {
        public enum SUIT
        {
            CLUBS,
            DIAMONDS,
            HEARTS,
            SPADES
        }

        public enum VALUE
        {
            TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
        }

        public SUIT Myusuit {get; set;}

        public VALUE MyValue { get; set;}
    }
}
