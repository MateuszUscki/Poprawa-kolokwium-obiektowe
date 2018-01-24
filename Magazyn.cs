using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks; 
namespace Application
{
    class Magazyn : IMagazyn
    {         
        private string zamowienie;
        public Magazyn(string zamowienie_){
            this.zamowienie = zamowienie_;
        }         public int Przyjmij(string things) {
            return 1;         }         public bool Wydaj(int cos) {
            return true;         }
    }
}
