using System;

namespace Tugas2
{
    public abstract class bunga
    {
        //encapsulation
        private int jmlhkelopak;
        public string nama { get; protected set; }

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
        public bunga(string nama, int kelopak)
        {
            this.nama = nama;
            this.jmlhkelopak = kelopak;
        }

        //polymorphism (overriding)
        public virtual void Deskripsi()
        {
            Console.WriteLine($"Bunga ini adalah : {nama}");
            Console.WriteLine($"Jumlah kelopaknya adalah : {jmlhkelopak}");
            
        }
    }
}
