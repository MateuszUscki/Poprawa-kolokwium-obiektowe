using System;
namespace Application
{
    class Elf : Bohater
    {
        private string magia;
        public Elf(string magia_, int hp_, string imie):base(hp_, imie)
        {
            this.magia = magia_;
        }
        public override bool ZadajCios(int cios)
        {
            return true;
        }
    }
}
