using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Bt<int> bt = new Bt<int>();
            bt.Root = new Node<int>(90);
            bt.Root.Left = new Node<int>(40);
            bt.Root.Right = new Node<int>(130);
            bt.Root.Left.Left = new Node<int>(25);
            bt.Root.Left.Right = new Node<int>(60);
            bt.Root.Right.Left = new Node<int>(100);
            bt.Root.Right.Right = new Node<int>(250);

           Console.WriteLine(bt.AfficherArbre());
            if (bt.ChercherValeur(28)) Console.WriteLine("OK");

            Node<int> n = new Node<int>(35);
            Node<int> n1 = new Node<int>(108);
            bt.AjouterNoeud(n);
            bt.Add(n1);
            Console.WriteLine(bt.AfficherArbre());


            Console.WriteLine("*******************************************************************");
            Bt<Personne> bt1 = new Bt<Personne>();
            var b1 = new Node<Personne>(new Personne { Age = 23, Nom = "Durant" });
            var b2 = new Node<Personne>(new Personne { Age = 66, Nom = "Martin" });
            var b3 = new Node<Personne>(new Personne { Age = 88, Nom = "Kole" });

            bt1.Root = b1;
            bt1.AjouterNoeud(b2);
            bt1.AjouterNoeud(b3);

            Console.WriteLine(bt1.AfficherArbre());

            Console.ReadLine();
        }
    }
}
