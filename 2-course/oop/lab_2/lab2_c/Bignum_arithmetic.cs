using System;
using System.Collections.Generic;
namespace lab2_c
{
    class Bignum_arithmetic
    {
        public string bignum;
        public Bignum_arithmetic(string number) {
            bignum = number;
       }

        private static List<int> convertToBigNum(Bignum_arithmetic ba1) {
            char[] raw_bignum = ba1.bignum.ToCharArray();
            List<int> bignum = new List<int>();

            for (int i = 0; i < raw_bignum.Length; i++) {
                if (raw_bignum[i] == '-') continue;
                int buff = (int)Char.GetNumericValue(raw_bignum[i]);
                bignum.Add(buff);
            }

            return bignum;
        }

        private static void equalizeBigNumsAndResult (List<int> bignum1, List<int> bignum2, List<int>result) {
            while (bignum1.Count != bignum2.Count) {
                if (bignum1.Count < bignum2.Count) bignum1.Insert(0,0);
                else bignum2.Insert(0,0);
            }
        }

        private static List<int> Add(List <int> bignum1, List <int> bignum2) {
            List<int> result = new List<int>();
            for (int i = 0; i <= bignum1.Count; i++) {
                result.Insert(0,0);
            }
            for (int i = bignum1.Count - 1; i >= 0; i--) {
                int newNumber = bignum1[i] + bignum2[i] + result[i+1];
                if (newNumber >= 10) {
                    result[i+1] = newNumber % 10;
                    result[i] = newNumber / 10;
                } else result[i+1] = newNumber;
            }
            if (result[0] == 0) result.RemoveAt(0);            
            return result;
        }

        private static List<int> Substract(List <int> bignum1, List <int> bignum2) {
            List<int> result = new List<int>();
            for (int i = bignum1.Count - 1; i >= 0; i--) {
                int newNumber = bignum1[i] - bignum2[i];
                if (newNumber < 0) {
                    result.Insert(0,10 + newNumber);
                    bignum1[i-1]--;
                } else result.Insert(0, newNumber);
            }
            if (result[0] == 0) result.RemoveAt(0);            
            return result;
        }

        private static List<int> getMax (List<int> ba1, List<int> ba2) {
            for (int i = 0; i < ba1.Count; i++) {
                if (ba1[i] == ba2[i]) continue;
                if (ba1[i] > ba2[i]) return ba1;
                else return ba2;
            }
            return ba1;
        }
        public static Bignum_arithmetic operator +(Bignum_arithmetic ba1, Bignum_arithmetic ba2) {
            // -ba1 + -ba2 = -(ba1 + ba2)
            // -ba1 + ba2 = (ba2 - ba1)
            // ba1 + -ba2 = (ba1 - ba2)
            // ba1 + ba2 = ba1 + ba2
            List<int> bignum1 = convertToBigNum(ba1);
            List<int> bignum2 = convertToBigNum(ba2);
            List<int> result = new List<int>();
            equalizeBigNumsAndResult(bignum1, bignum2, result);
          
            if (ba1.bignum[0] == '-' && ba2.bignum[0] == '-') { 
                result = Add(bignum1, bignum2); 
                return new Bignum_arithmetic($"-{String.Join("", result)}"); 
            } else if (ba1.bignum[0] != '-' && ba2.bignum[0] != '-') {
                result = Add(bignum1, bignum2); 
                return new Bignum_arithmetic($"{String.Join("", result)}"); 
            } else if (ba1.bignum[0] == '-' && ba2.bignum[0] != '-') {
                if (bignum1 == getMax(bignum1, bignum2)) {
                    result = Substract(bignum1, bignum2); 
                    return new Bignum_arithmetic($"-{String.Join("", result)}"); 
                } else {
                    result = Substract(bignum2, bignum1); 
                    return new Bignum_arithmetic($"{String.Join("", result)}"); 
                }
            } else if (ba1.bignum[0] != '-' && ba2.bignum[0] == '-') {
                 if (bignum1 == getMax(bignum1, bignum2)) {
                    result = Substract(bignum1, bignum2); 
                    return new Bignum_arithmetic($"{String.Join("", result)}"); 
                } else {
                    result = Substract(bignum2, bignum1); 
                    return new Bignum_arithmetic($"-{String.Join("", result)}"); 
                }
            }

            return new Bignum_arithmetic(String.Join("", result));
       }

    }
}
