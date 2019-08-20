using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    class ComplexNumb
    {
        double real;
        double imag;
        public ComplexNumb(double Real, double Imag)
        {
            real = Real;
            imag = Imag;

        }
        public ComplexNumb(double real) : this(real, 0)
        {
        }
        public override string ToString()
        {
            return (System.String.Format("{0} +{1}i", real, imag));
        }
        static void Main(string[] args)
        {
            ComplexNumb ob1 = new ComplexNumb(3, 5);
            ComplexNumb ob2 = new ComplexNumb(5, 6);
            ComplexNumb ob3 = ob1 * ob2;
            Console.WriteLine( ob3.ToString() );
            Console.ReadKey();
        }
        #region Multiple Complex

        public static ComplexNumb operator *(ComplexNumb A, ComplexNumb B)
        {
            return new ComplexNumb(
                A.real * B.real - A.imag * B.imag,
                A.real * B.imag + A.imag * B.real);
        }

        #endregion
        #region Divide

        public static ComplexNumb operator /(ComplexNumb A, ComplexNumb B)
        {
            ComplexNumb conjugate = new ComplexNumb(B.real, -B.imag);
            B *= conjugate;

            ComplexNumb numerator = A * conjugate;

            return new ComplexNumb(
                numerator.real / B.real,
                numerator.imag / B.real);
        }
        #endregion
    }
}
