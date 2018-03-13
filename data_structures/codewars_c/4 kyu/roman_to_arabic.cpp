#include <iostream>
#include <string>

using namespace std;

int decode(char letter)
{
  switch (letter)
  {
    case 'M':
      return 1000;
    case 'D':
      return 500;
    case 'C':
      return 100;
    case 'L':
      return 50;
    case 'X':
      return 10;
    case 'V':
      return 5;
    case 'I':
      return 1;
  }
}

int solution(string roman) {
  int res = 0;
  for (int i = 0; i < roman.length(); ++i)
    if (i < roman.length() - 1 && decode(roman[i]) < decode(roman[i + 1])) {
      res -= decode(roman[i]);
    } else res += decode(roman[i]);

  return res;
}

int main() {
  cout << solution("XXI") << endl;
  return 0;
}
