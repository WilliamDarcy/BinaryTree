using System;

namespace BinaryTree
{
    class Personne : IComparable
    {
        public string Nom
        {
            get; set;
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int CompareTo(Personne other)
        {
            return Age.CompareTo(other.Age);
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            var p = obj as Personne;
            if (p != null)
            {
                return Age.CompareTo(p.Age);
            }
            else
            {
                throw new ArgumentException("Pas un personne");
            }
        }

        public override string ToString()
        {
            return "age : " + Age;
        }
    }
}
