using System;
using System.Text;

namespace AnimalExample
{
    abstract class Тварина
    {
        protected string назва;
        protected string вид;
        protected string місцеІснування;

        public Тварина(string назва, string вид, string місцеІснування)
        {
            this.назва = назва;
            this.вид = вид;
            this.місцеІснування = місцеІснування;
        }

        public abstract void ВивестиІнформацію();
    }

    class Ссавець : Тварина
    {
        protected string харчування;

        public Ссавець(string назва, string вид, string місцеІснування, string харчування)
            : base(назва, вид, місцеІснування)
        {
            this.харчування = харчування;
        }

        public override void ВивестиІнформацію()
        {
            Console.WriteLine($"Тварина: {назва}");
            Console.WriteLine($"Вид: {вид}");
            Console.WriteLine($"Місце існування: {місцеІснування}");
            Console.WriteLine($"Харчування: {харчування}");
        }
    }

    class Риба : Тварина
    {
        protected string водойма;

        public Риба(string назва, string вид, string місцеІснування, string водойма)
            : base(назва, вид, місцеІснування)
        {
            this.водойма = водойма;
        }

        public override void ВивестиІнформацію()
        {
            Console.WriteLine($"Тварина: {назва}");
            Console.WriteLine($"Вид: {вид}");
            Console.WriteLine($"Місце існування: {місцеІснування}");
            Console.WriteLine($"Водойма: {водойма}");
        }
    }

    class Птах : Тварина
    {
        protected bool дикий;
        protected bool мігруючий;

        public Птах(string назва, string вид, string місцеІснування, bool дикий, bool мігруючий)
            : base(назва, вид, місцеІснування)
        {
            this.дикий = дикий;
            this.мігруючий = мігруючий;
        }

        public override void ВивестиІнформацію()
        {
            Console.WriteLine($"Тварина: {назва}");
            Console.WriteLine($"Вид: {вид}");
            Console.WriteLine($"Місце існування: {місцеІснування}");
            Console.WriteLine($"Дикий: {(дикий ? "так" : "ні")}");
            Console.WriteLine($"Мігруючий: {(мігруючий ? "так" : "ні")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Тварина[] тварини = new Тварина[3];

            тварини[0] = new Ссавець("Кіт", "Ссавець", "Квартира, вулиця", "Хижак");
            тварини[1] = new Риба("Лосось", "Риба", "Річка", "Прісноводна");
            тварини[2] = new Птах("Горобець", "Птах", "Парк", false, false);

            foreach (var тварина in тварини)
            {
                тварина.ВивестиІнформацію();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
