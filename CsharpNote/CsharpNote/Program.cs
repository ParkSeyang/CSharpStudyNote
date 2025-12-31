
namespace CsharpNote
{
    internal class Program
    {
        public delegate void Animal();

        public static Animal animals;


        public static void Dog()
        {
            Console.WriteLine("강아지입니다.");
            Console.WriteLine("강아지는 짖습니다. 멍!멍!멍!멍!");
        }
        public static void Cat()
        {
            Console.WriteLine("고양이 입니다.");
            Console.WriteLine("고양이는 웁니다. 야옹~ 야옹~");
        }
        public static void Monkey()
        {
            Console.WriteLine("원숭이 입니다.");
            Console.WriteLine("원숭이는 이렇게 포효합니다. 우끼끼! 우끼끼!");

        }


        static void Main(string[] args)
        {
            animals += Dog;
            animals += Cat;
            animals += Monkey;

            animals();
        }
    }
}
