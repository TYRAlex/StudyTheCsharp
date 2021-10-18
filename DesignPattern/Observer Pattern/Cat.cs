namespace Observer_Pattern
{
    public class Cat
    {
        public delegate void CatCome();

        public static CatCome CatComing;
    }
}