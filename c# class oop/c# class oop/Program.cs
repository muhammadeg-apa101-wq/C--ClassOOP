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
            MehledeQalanQaqas qaqas1 = new MehledeQalanQaqas("baloglan", 23);
            Console.WriteLine($"{qaqas1.qaqasinAdi} yaxsi insandi, yasidaki : {qaqas1.qaqasinYasi} , {qaqas1.qaqasinHeyati}");
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
