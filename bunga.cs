using System;

namespace Tugas2
{
    public abstract class bunga
    {
        //encapsulation & data hiding
        private int jmlhkelopak;
        public string nama { get; protected set; }
        //composition
        public Pot PotBunga { get; set; }

        public int totalKelopak
        {
            get { return jmlhkelopak; }
            protected set
            {
                if (value < 0) jmlhkelopak = 0;
                else jmlhkelopak = value;
            }
        }

        //constructor
        public bunga(string nama, int kelopak, Pot pot)
        {
            this.nama = nama;
            this.totalKelopak = kelopak;
            this.PotBunga = pot;
        }

        //polymorphism (overriding)
        public virtual void Deskripsi()
        {
            Console.WriteLine($"Bunga ini adalah : {nama}");
            Console.WriteLine($"Jumlah kelopaknya adalah : {jmlhkelopak}");
            Console.WriteLine($"Ditanam di pot : {PotBunga.bahan}");

        }
    }
}
