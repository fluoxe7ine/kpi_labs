#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <ctype.h>

char findMissingLetter(char array[], int arrayLength)
{
	int counter = 0;
	int index = ("%d",array[0]);
	for (int j = 0; j < arrayLength; j++){
			if (("%d", array[j]) != index) return ("%c",index);
			index++;
	}
}

int main(int argc, char const *argv[]) {

	char arr1[] = { 'a','b','c','d','f' };
  char arr2[] = { 'O','Q','R','S' };

	printf("%c\n", findMissingLetter(arr1, 5));
	return 0;
}
