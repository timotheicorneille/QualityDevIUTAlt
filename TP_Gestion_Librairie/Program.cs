using System;

namespace TP_Gestion_Librairie
{
    class Program
    {
        public class Media
        {
            private string titre;
            private int numeroReference;
            private int exemplaireDisponible;

            public virtual void AfficherInfos()
            {
                Console.WriteLine(titre);
                Console.WriteLine(numeroReference);
                Console.WriteLine(exemplaireDisponible);
            }
        }

        public class Livre : Media
        {
            private string auteur;

            public override void AfficherInfos()
            {
                base.AfficherInfos();
                Console.WriteLine(auteur);
            }
        }

        public class DVD : Media
        {
            private int duree;
            public override void AfficherInfos()
            {
                base.AfficherInfos();
                Console.WriteLine(duree);
            }
        }

        public class CD : Media
        {
            private string artiste;
            public override void AfficherInfos()
            {
                base.AfficherInfos();
                Console.WriteLine(artiste);
            }
        }

        public class Librairie
        {
            List<Media> mediaList;

            public Media this[int numeroReference]
            {
                get
                {
                    return "test";
                }
            }
            
   
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
        }
    }
}