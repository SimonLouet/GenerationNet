using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generationnet
{
    class Commande
    {

        private int id;
        private string date;
        private string etat;
        private int client;

        public Commande()
        {
        }

        public Commande(int id, string date, string etat, int client)
        {
            this.id = id;
            this.date = date;
            this.etat = etat;
            this.client = client;
            
        }




        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public String getDate()
        {
            return date;
        }

        public void setDate(String date)
        {
            this.date = date;
        }

        public String getEtat()
        {
            return etat;
        }

        public void setEtat(String etat)
        {
            this.etat = etat;
        }

        public int getClient()
        {
            return client;
        }

        public void setClient(int client)
        {
            this.client = client;
        }



    }
}
