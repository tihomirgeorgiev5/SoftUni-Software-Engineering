

namespace AquaShop.Models.Decorations
{
   
    public class Ornament : Decoration
    {
        //Has 1 comfort and its price is 5.

        private const int OrnamentComfort = 1;
        private const decimal OrnamentPrice = 5;

        public Ornament(int OrnamentComfort) : base(OrnamentComfort,OrnamentPrice)
        {
        }
    }
}
