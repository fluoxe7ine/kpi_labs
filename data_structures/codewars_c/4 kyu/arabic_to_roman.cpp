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

  //hundreds
  temp_value = number / 100;
  switch (temp_value) {
    case 9: {
      result.append("CM");
      break;
    }
    case 6:
    case 7:
    case 8: {
      result.append("D");
      for (int i = 0; i < temp_value - 5; i++) {
        result.append("C");
      }
      break;
    }
    case 5: {
      result.append("D");
      break;
    }
    case 4: {
      result.append("CD");
      break;
    }
    case 1:
    case 2:
    case 3: {
      for (int i = 0; i < temp_value; i++) {
        result.append("C");
      }
      break;
    }
  }
  number -= temp_value * 100;

  //decades
  temp_value = number / 10;
  switch (temp_value) {
    case 9: {
      result.append("XC");
      break;
    }
    case 6:
    case 7:
    case 8: {
      result.append("L");
      for (int i = 0; i < temp_value - 5; i++) {
        result.append("X");
      }
      break;
    }
    case 5: {
      result.append("L");
      break;
    }
    case 4: {
      result.append("XL");
      break;
    }
    case 1:
    case 2:
    case 3: {
      for (int i = 0; i < temp_value; i++) {
        result.append("X");
      }
      break;
    }
  }
  number -= temp_value * 10;

  //decades
  temp_value = number;
  switch (temp_value) {
    case 9: {
      result.append("IX");
      break;
    }
    case 6:
    case 7:
    case 8: {
      result.append("V");
      for (int i = 0; i < temp_value - 5; i++) {
        result.append("I");
      }
      break;
    }
    case 5: {
      result.append("V");
      break;
    }
    case 4: {
      result.append("IV");
      break;
    }
    case 1:
    case 2:
    case 3: {
      for (int i = 0; i < temp_value; i++) {
        result.append("I");
      }
      break;
    }
  }
  return result;
}

int main(int argc, char const *argv[]) {
  cout << solution(952) << endl;
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
