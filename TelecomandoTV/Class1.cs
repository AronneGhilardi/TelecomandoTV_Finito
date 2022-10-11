using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomandoTV
{
    internal class TV
    {
        private bool stato;
        private string segnale;
        private int volume;
        private int canale;
        private string produttore;
        private string modello;

        //STATO
        public void on()
        {
            setStato(true);
        }
        public void off()
        {
            setStato(false);
        }
        private void setStato(bool newStato)
        {
            stato = newStato;
        }
        public bool getStato()
        {
            return stato;
        }
        public bool invert()
        {
            setStato(!stato);
            return stato;
        }

        //SEGNALE
        public string setSegnale()
        {
            return segnale;
        }
        public void resetSegnale(string v)
        {
            segnale = v;
        }

        //VOLUME
        public void setVolume(int newVolume)
        {
            volume = newVolume;
        }
        public int getVolume()
        {
            return volume;
        }

        //CANALE
        public void setCanale(int newCanale)
        {
            canale = newCanale;
        }
        public int getCanale()
        {
            return canale;
        }

        //PRODUTTORE
        public string setProduttore(string newProduttore)
        {
            produttore = newProduttore;
            return produttore;
        }

        //MODELLO
        public string setModello(string newModello)
        {
            modello = newModello;
            return modello;
        }
    }
}