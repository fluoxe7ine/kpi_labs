#include <stdlib.h>
#include <stdio.h>

int count_zeros_n_double_fact(int n)
{
		int res = 0;
		int i = 0;
		if ((n % 2) != 0) return res; else
 		{
			n /= 2;
			while (n > 0) {
				n /= 5;
				res += n;
			}
		}
  return res;
}

int main(int argc, char const *argv[]) {
	printf("%d\n", count_zeros_n_double_fact(8));
	return 0;
}
