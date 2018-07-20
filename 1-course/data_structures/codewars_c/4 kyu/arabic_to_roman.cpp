#include <iostream>
#include <string>
using namespace std;

string solution (int number) {
  string result = "";
  int temp_value;

  //1000
  temp_value = number / 1000;
  number -= temp_value * 1000;
  for (int i = 0; i < temp_value; i++) {
    result.append("M");
  }

  string hundreds[9] = {"C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC","CM"};

  //hundreds
  temp_value = number / 100;
  if (temp_value > 0) result.append(hundreds[temp_value - 1]);
  number -= temp_value * 100;

  //decades
  temp_value = number / 10;
  string decades[9] = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
  if (temp_value > 0) result.append(decades[temp_value - 1]);
  number -= temp_value * 10;

  //numbers
  temp_value = number;
  string numbers[9] = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
  if (temp_value > 0) result.append(numbers[temp_value - 1]);

  return result;
}

int main(int argc, char const *argv[]) {
  cout << solution(52) << endl;
  cout << solution(3052) << endl;
  cout << solution(752) << endl;
  cout << solution(652) << endl;
  cout << solution(552) << endl;
  cout << solution(452) << endl;
  cout << solution(352) << endl;
  cout << solution(252) << endl;
  cout << solution(152) << endl;
  return 0;
}
