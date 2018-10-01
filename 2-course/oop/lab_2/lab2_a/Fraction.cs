using System;

namespace lab2_a
{
    class Fraction : ICloneable
    {
        public string fract_value;
        public Fraction(string value) {
            this.fract_value = value;
        }

        public static implicit operator Fraction (int val) => (new Fraction($"{val}/1"));
        
        public static Fraction operator *(Fraction f1, Fraction f2) {
            string result = "";
            int m1 = Int32.Parse(f1.fract_value.Split('/')[0]);
            int m2 = Int32.Parse(f2.fract_value.Split('/')[0]);
            int n1 = Int32.Parse(f1.fract_value.Split('/')[1]);
            int n2 = Int32.Parse(f2.fract_value.Split('/')[1]);
            result += $"{makeOptimize(m1*m2, n1*n2)}";
            return new Fraction(result);
        }

        public static Fraction operator /(Fraction f1, Fraction f2) {
            string result = "";
            int m1 = Int32.Parse(f1.fract_value.Split('/')[0]);
            int m2 = Int32.Parse(f2.fract_value.Split('/')[0]);
            int n1 = Int32.Parse(f1.fract_value.Split('/')[1]);
            int n2 = Int32.Parse(f2.fract_value.Split('/')[1]);
            result = $"{makeOptimize(m1*n2, m2*n1)}";
            return new Fraction(result);
        }

        public static Fraction operator +(Fraction f1, Fraction f2) {
            int m1 = Int32.Parse(f1.fract_value.Split('/')[0]);
            int m2 = Int32.Parse(f2.fract_value.Split('/')[0]);
            int n1 = Int32.Parse(f1.fract_value.Split('/')[1]);
            int n2 = Int32.Parse(f2.fract_value.Split('/')[1]);

            int new_n = n1 < n2 ? n1: n2;
            int new_m = 1;

            for (int i = new_n; i <= n1*n2; i++) {
                if (i % n1 == 0 && i % n2 == 0) {
                    new_m = m1 * (i / n1) + m2 * (i / n2);
                    return new Fraction($"{makeOptimize(new_m, i)}");
                }
            }

            return 0;
        }

          public static Fraction operator -(Fraction f1, Fraction f2) {
            int m1 = Int32.Parse(f1.fract_value.Split('/')[0]);
            int m2 = Int32.Parse(f2.fract_value.Split('/')[0]);
            int n1 = Int32.Parse(f1.fract_value.Split('/')[1]);
            int n2 = Int32.Parse(f2.fract_value.Split('/')[1]);

            int new_n = n1 < n2 ? n1: n2;
            int new_m = 1;

            for (int i = new_n; i <= n1*n2; i++) {
                if (i % n1 == 0 && i % n2 == 0) {
                    new_m = m1 * (i / n1) - m2 * (i / n2);
                    return new Fraction($"{makeOptimize(new_m, i)}");
                }
            }

            return 0;
        }

        private static string makeOptimize(int m, int n) {
            string sign = "";
            if (m < 0 && n < 0) {
                m = Math.Abs(m);
                n = Math.Abs(n);
                sign = "+";
            } else if (m > 0 && n < 0) {
                n = Math.Abs(n);
                sign = "-";
            }
            int max = Math.Abs(m) > Math.Abs(n) ? Math.Abs(m) : Math.Abs(n);
            for (int i = max; i >= 2; i--) {
                if (m % i == 0 && n % i == 0) {
                    return $"{sign}{m / i}/{n / i}";
                }
            }
            return $"{sign}{m}/{n}";
        }
        public static bool operator ==(Fraction f1, Fraction f2) => (f1.fract_value == f2.fract_value);
        public static bool operator !=(Fraction f1, Fraction f2) => (f1.fract_value != f2.fract_value);

        public object Clone() {
            return new Fraction(this.fract_value);
        }
    }
}
