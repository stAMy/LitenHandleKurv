using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitenHandleKurv
{
    class Vare
    {

        private String vareNavn;
        private int vareNummer;
        
        private int pris;
        private double prisInclMVA;


        public Vare(String vareNavn, int vareNummer, int pris)
        {
            this.vareNavn = vareNavn;
            this.vareNummer = vareNummer;
            this.pris = pris;
        }

        public Vare()
        {

        }



        public double beregnMVA()
        {
            double mvaSATS = 0.25;
            double mva = Convert.ToDouble(pris) * mvaSATS;

            prisInclMVA = Convert.ToDouble(pris) + mva;
    
            return mva;

        }

        public void skrivUt()
        {

            Console.WriteLine("Navn: " + getVareNavn() + " , Varenummer: " + getVareNummer() + " , Pris: " + getPris() + " , derav MVA: " + beregnMVA() + " , pris å betale: " + getPrisInclMVA());
            Console.ReadLine();

        }
     



        public String getVareNavn()
        {
            return vareNavn;
        }

        public void setVareNavn(String v)
        {
            vareNavn = v;
        }

        public int getVareNummer()
        {
            return vareNummer;
        }

        public void setVareNummer(int v)
        {
            vareNummer = v;
        }



        public int getPris()
        {
            return pris;
        }

        public void setPris(int v)
        {
            pris = v;
        }


        public double getPrisInclMVA()
        {
            return prisInclMVA;
        }


    }
}
