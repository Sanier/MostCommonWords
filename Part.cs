using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonWords
{
    public class Part : IEquatable<Part>, IComparable<Part>
    {
        public string Word { get; set; }

        public int Val { get; set; }

        public override string ToString()
        {
            return "Количество повторений: " + Val + "   Слово: " + Word;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        // Default comparer for Part type.
        public int CompareTo(Part comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.Val.CompareTo(comparePart.Val);
        }
        public override int GetHashCode()
        {
            return Val;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.Val.Equals(other.Val));
        }
        // Should also override == and != operators.
    }
}
