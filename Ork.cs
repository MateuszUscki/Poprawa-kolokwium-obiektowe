using System;
namespace Application
{
    class Ork : Bohater
    {
        public int walka;
        public Ork(int walka_, int hp_, string imie):base(hp_, imie)
        {
            this.walka = walka_;
        }

        public override bool ZadajCios(int cios)
        {
            return true;
        }
    }
}
