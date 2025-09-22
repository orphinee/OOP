using System;

namespace Tugas2
{
    public class Mawar : bunga //inheritance
    {
        public bool MemilikiDuri { get; set; }

        public Mawar(string nama, int kelopak, Pot pot, bool berduri) : base(nama, kelopak, pot)
        {
            this.MemilikiDuri = berduri;
        }

        //polymorphism (overriding)
        public override void Deskripsi()
        {
            base.Deskripsi();
            Console.WriteLine($"Memiliki duri : {MemilikiDuri}");
        }

        //polymorphism(overloading)
        public void Siram()
        {
            Console.WriteLine($"Mawar {nama} disiram dengan air biasa.");
        }
        public void Siram(string pupuk)
        {
            Console.WriteLine($"Mawar {nama} disiram dengan air dan pupuk {pupuk}.");
        }

    }
}
