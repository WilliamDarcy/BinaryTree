using System;

namespace BinaryTree
{
    class Bt<T> where T : IComparable
    {
        public Node<T> Root { get; set; }
        string _tree;

        public Bt()
        {
            Root = null;
            _tree = null;
        }

        public void Clear()
        {
            Root = null;
        }

        public string AfficherArbre()
        {
            _tree = null;
            Afficher(Root);
            return _tree;
        }

        public void Afficher(Node<T> nodeEnCours)
        {
     

            if (nodeEnCours.Left != null)
            {
                Afficher(nodeEnCours.Left);
            }

            _tree += nodeEnCours.Data.ToString() + " ";

            if (nodeEnCours.Right != null)
            {
                Afficher(nodeEnCours.Right);
            }


        }

        public bool ChercherValeur(T data)
        {
           return Search(Root, data);
        }
        public void AjouterNoeud(Node<T> data)
        {
            Add(Root, data);
        }

        private bool Search(Node<T> nodeEnCours, T data)
        {
            bool result = false;
            if (nodeEnCours == null) return false;
            if (nodeEnCours.Data.CompareTo(data) == 0)
            {               
                return true; 
            }
            else if ( nodeEnCours.Data.CompareTo(data) > 0)
            {
                result = Search(nodeEnCours.Left, data);
            }
            else if (nodeEnCours.Data.CompareTo(data) < 0)
            {
                result = Search(nodeEnCours.Right, data);
            }


            return result;
        }

        public void Add(Node<T> nodeEnCours, Node<T> nouveauNode)
        {
         
            if (nodeEnCours.Data.CompareTo(nouveauNode.Data) == 0)
            {
                throw new Exception();
            }

            if (nodeEnCours.Data.CompareTo(nouveauNode.Data) > 0)
            {
                    if (nodeEnCours.Left == null)
                    {
                    nodeEnCours.Left = nouveauNode;
                    }
                    else
                    {
                        Add(nodeEnCours.Left, nouveauNode);
                    }
            }else
            {
                if (nodeEnCours.Right == null)
                {
                    nodeEnCours.Right = nouveauNode;
                }
                else
                {

                    Add(nodeEnCours.Right, nouveauNode);
                }
            }
        }

        public void Add(Node<T> nouveauNode)
        {
            Node<T> current = Root;
            while (true)
            {
                if (current.Data.CompareTo(nouveauNode.Data) == 0) return;

                if (nouveauNode.Data.CompareTo(current.Data) < 0)
                {
                   
                    if (current.Left == null)
                    {
                        current.Left = nouveauNode;
                        return;
                    }
                    current = current.Left;

                }
                else if (nouveauNode.Data.CompareTo(current.Data) > 0)
                {
                   
                    if (current.Right == null)
                    {
                        current.Right = nouveauNode;
                        return;
                    }
                    current = current.Right;


                }
            }
        }


        }
}
