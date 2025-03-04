using ödev1.absctracts;
using ödev1.absctracts2.cs;


namespace ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            mercedes mercedes = new mercedes();
            Console.WriteLine("MERCEDES;");
            mercedes.ucuyo("");
            mercedes.yüzüyor("");

             
            bmw bmw = new bmw();
            Console.WriteLine("BMW;");
            bmw.gidiyor("");
            bmw.yüzüyor("");
            bmw.ucuyo("");

            porsche porsche = new porsche();
            Console.WriteLine("PORSCHE;");
            porsche.ucuyo("");

            new GenelMudur();
            new Mudur();
            new Programcı();
            new Stajyer();

           // double toplammaas = 0.0;
           // toplammaas += GenelMudur.MaasHesapla();
           // toplammaas += Mudur.MaasHesapla();
           // toplammaas += Programcı.MaasHesapla();
          //  toplammaas += Stajyer.MaasHesapla();
            //Console.WriteLine("toplam maaş:" + toplammaas);


           Mercedes mercedes1 = new Mercedes();
            Porsche porsche1 = new Porsche();
            Bmw bmw1 = new Bmw();

            double yakıt = 0.0;
            yakıt += mercedes1.ArabanızınYakıtı();
            yakıt += porsche1.ArabanızınYakıtı();
            yakıt += bmw1.ArabanızınYakıtı();
            Console.WriteLine("toplam yakıt:" + yakıt);


            GenelMudur gm = new GenelMudur();
            Mudur mudur = new Mudur();
            Programcı programcı = new Programcı();
            Stajyer st = new Stajyer();


            double toplammaas = 0.0;
            toplammaas += gm.maasinizNedir();
            toplammaas += mudur.maasinizNedir();
            toplammaas += programcı.maasinizNedir();
            toplammaas += st.maasinizNedir();
            Console.WriteLine("toplam maaş:" + toplammaas);















        }



    }
}
