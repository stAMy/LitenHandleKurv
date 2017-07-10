using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace LitenHandleKurv
{
    class Varelager : Vare
    {

        private int antall;
        public ArrayList lager = new ArrayList();
        private double totalPrisen = 0;

        public Varelager(String vareNavn, int vareNummer, int pris) : base(vareNavn, vareNummer, pris)
        {
           antall = 0;

        }

        public Varelager()
        {

        }

        public void leggTil(Vare v)
        {
            lager.Add(v);
            antall++;
        }


        public void visAlleVarer()
        {
            foreach(Vare v in lager)
            {
                v.skrivUt();
            }
        }

       
        public double totalSum()
        {
            foreach (Vare v in lager)
            {
               
                totalPrisen = totalPrisen + v.getPrisInclMVA();
              

            }

            return totalPrisen;
        }


        public void slettVare(int vareNummer)
        {

            foreach (Vare v in lager)
            {
                
                if(v.getVareNummer().Equals(vareNummer))
                {
                    lager.Remove(v);
                    
                    
                    Console.WriteLine("Varenummer " + v.getVareNummer() + " ble slettet");
                    break;
                }

               
            }
            
        }



        public int getAntall()
        {
            return antall;
        }

       

        public void setAntall(int v)
        {
            antall = v;
        }
    }
}
