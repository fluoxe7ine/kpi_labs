#include <stdio.h>

int solution(int number) {
		int sum = 0;
    for (int i = 1; i < number; i++) {
      if (((i % 3) == 0) || ((i % 5) == 0)) sum += i;
    }
    return sum;
}

int main(int argc, char const *argv[]) {
  printf("%d\n", solution(10));
  return 0;
}
