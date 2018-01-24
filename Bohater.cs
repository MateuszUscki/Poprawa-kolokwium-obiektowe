using System;
namespace Application
{
    abstract class Bohater
    {
        private string imie;
        private int hp;
        public Bohater(int hp_, string imie)
        {
            this.imie = imie;
            this.hp = hp_;
        }
        abstract public bool ZadajCios(int cios); 
    }
}
