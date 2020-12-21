using System;

namespace fractions
{
    class Fraction
    {
        public int denominateur;
        public int numerateur;
        public Fraction(int _denominateur, int _numerateur)
        {
            denominateur = _denominateur;
            numerateur = _numerateur;
        }
        public Fraction(int _numerateur) 
        {
            denominateur = 0;
            numerateur = _numerateur;
        }
        public override string ToString()
        {
            return denominateur + "/" + numerateur;
        }
        public void oppose(int _denominateur, int numerateur)
        {
            _denominateur = _denominateur * -1;
        }
        public void inverse() 
        {
            int temp = denominateur;
            denominateur = numerateur;
            numerateur = temp;
        }
        public bool superieurA(Fraction fraction2)
        {
            if(this.denominateur / this.numerateur < fraction2.denominateur / fraction2.numerateur)
            {
                return false;
            }
            else
            {
                return true; 
            }
        }
      
        public bool egalA(Fraction fraction1,Fraction fraction2)
        {
            if (fraction1==fraction2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool reduire()
        {
            //Trouver le PGCD

            //Diviser le dénominateur et le numérateur par le pgcd
        }
        public void plus(Fraction fraction2)
        {
            //Trouver le PGCD 

            //changer le numerateur 
            
            //additionner les denominateurs

        }
        public void moins(Fraction fraction2)
        {
            //Trouver le PGCD 

            //changer le numerateur 

            //soustraire les denominateurs

        }
        public void divise(Fraction fraction2)
        {
            double resfrac1 = this.denominateur / this.numerateur;
            double resfrac2 = fraction2.denominateur / fraction2.numerateur;
            double resultat = resfrac1 / resfrac2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(8,9);
            Fraction f2 = new Fraction(7,3);
        }

    }
}
