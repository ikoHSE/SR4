using System;
using System.Xml;


namespace Triangle {

    /// <summary>
    /// A right angle triangle.
    /// </summary>
    [Serializable]
    public class Triangle: IComparable<Triangle> {

        /// <summary>
        /// A side of the triangle.
        /// </summary>
        public double A {get; set;}
        /// <summary>
        /// A side of the triangle.
        /// </summary>
        public double B {get; set;}

        /// <summary>
        /// A side of the triangle.
        /// </summary>
         public double C {
            get {
                return Math.Sqrt(A*A + B*B);
            }
        }

        /// <summary>
        /// The area of the triangle.
        /// </summary>
        public double S {
            get {
                return A * B / 2;
            }
        }


        public Triangle() {
        }

		public override string ToString() {
            return $"A: {A:f2} \tB: {B:f2} \tC: {C:f2} \tS: {S:f2}";
		}

        int IComparable<Triangle>.CompareTo(Triangle other) {
            return (other.S/other.C).CompareTo(S/C);
        }
	}
}
