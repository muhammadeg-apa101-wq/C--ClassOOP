using System.Drawing;

namespace c__class_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SagirdInformasiya sagird1 = new SagirdInformasiya()
            //{
            //    ad = "Baloglan",
            //    soyad = "Baloglanov",
            //    yas = 20,
            //    cins = "Erkey",
            //    fennler = "Riyaziyyat, Fizika, Kimya",
            //    qiymetler = "2, 0, -1"
            //};
            //sagird1.Melumat();
            //qaqas class
            //MehledeQalanQaqas qaqas1 = new MehledeQalanQaqas("baloglan", 23);
            //Console.WriteLine($"{qaqas1.qaqasinAdi} yaxsi insandi, yasidaki : {qaqas1.qaqasinYasi} , {qaqas1.qaqasinHeyati}");
            //array sorting
            Console.WriteLine("String sort numune:");
            ArraySorting();
            Console.WriteLine("Int sort numune:");
            ArraySortingInt();
            static void ArraySorting()
            {
                string[] words = { "yerpenek", "telefon", "raket", "nietchze felsefesi" };

                Array.Sort(words);

                Console.WriteLine("siraya duzulmus sozler:");

                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }



            }
            static void ArraySortingInt()
            {
                int[] numbers = { 5, 3, 8, 1, 4 };
                Array.Sort(numbers);
                Console.WriteLine("siraya duzulmus ededler:");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
        //sade class
        //class sagirdinformasiya
        //{
        //    public string ad;
        //    public string soyad;
        //    public int yas;
        //    public string cins;
        //    public string fennler;
        //    public string qiymetler;
        //    public void melumat()
        //    {
        //        Console.WriteLine($"ad: {ad}\nsoyad: {soyad}\nyas: {yas}\ncins: {cins}\nfennler: {fennler}\nqiymetler: {qiymetler}");
        //    }
        //}

        //constructor ve this
        class MehledeQalanQaqas
        {
            public string qaqasinAdi;
            public int qaqasinYasi;
            public string qaqasinHeyati;

            public MehledeQalanQaqas()
            {

            }
 


            public MehledeQalanQaqas(string qaqasName, int qaqasAge) :this("xosbext") 
            {
                qaqasinAdi = qaqasName;
                qaqasinYasi = qaqasAge;


            }
            public MehledeQalanQaqas( int qaqasAge)
            {
                qaqasinYasi = qaqasAge;
            }
            public MehledeQalanQaqas(string qaqasinLife)
            {
                qaqasinHeyati = qaqasinLife;
            }
        }




    }
}
