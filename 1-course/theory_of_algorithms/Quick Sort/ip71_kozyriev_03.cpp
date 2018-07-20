#include <iostream>
#include <fstream>
#include <string>
#include <algorithm>
#include <math.h>
#include <vector>
using namespace std;
int firstCount = 0;
int secondCount = 0;
int thirdCount = 0;

int firstPartition (int a[], int p, int r)
{
    int x = a[r];
    int i = (p - 1);

    for (int j = p; j <= r - 1; j++) {
    firstCount++;
        if (a[j] <= x) {
            i++;
            swap(a[i], a[j]);
        }
    }
    swap(a[i + 1], a[r]);
    return (i + 1);
}

void firstQuickSort(int a[], int p, int r)
{
    if (p < r)
    {
        int q = firstPartition(a, p, r);
        firstQuickSort(a, p, q - 1);
        firstQuickSort(a, q + 1, r);
    }
}

int secondPartition (int a[], int p, int r)
{
    int mid = floor((p + r) / 2) + 1;

    int i = p - 1;
    int j = p;
    int x, index;

    if ((a[r] > a[p] && a[r] < a[mid]) || (a[r] < a[p] && a[r] > a[mid])) {
      x = a[r];
      index = r;
    } else if ((a[p] > a[r] && a[p] < a[mid]) || (a[p] < a[r] && a[p] > a[mid])){
      x = a[p];
      index = p;
    } else {
      x = a[mid];
      index = mid;
    }

    swap(a[index], a[r]);

    for (int j = p; j <= r - 1; j++) {
    secondCount++;
        if (a[j] <= x) {
            i++;
            swap(a[i], a[j]);
        }
    }
    swap(a[i + 1], a[r]);
    return (i + 1);

}

void secondQuickSort(int a[], int p, int r)
{
    if (p < r)
    {
        int q = secondPartition(a, p, r);
        secondQuickSort(a, p, q - 1);
        secondQuickSort(a, q + 1, r);
    }
}

void insertion(int *arr, int p, int r) {
  for (int i = p; i <= r; i++) {
    while (arr[i] < arr[i - 1] && i > 0) {
      thirdCount++;
      swap(arr[i], arr[i - 1]);
      i--;
    }
  }
}

void thirdQuickSort(int *arr, int left, int right) {
  if (right - left <= 3) {
    insertion(arr, left, right);
    return;
  }

  int p = arr[left]; int q = arr[left + 1]; int r = arr[right];
  int a = left + 2; int b = left + 2;
  int c = right - 1; int d = right - 1;
  while (b <= c) {
    thirdCount++;
    while (arr[b] < q && b <= c) {
      thirdCount++;
      thirdCount++;
      if (arr[b] < p) {
        swap(arr[a], arr[b]);
        a++;
      }
      b++;
    }
    while (arr[c] > q && b <= c) {
      thirdCount++;
      thirdCount++;
      if (arr[c] > r) {
        swap(arr[c], arr[d]);
        d--;
      }
      c--;
    }
    thirdCount++;
    if (b <= c) {
      thirdCount++;
      if (arr[b] > r) {
        thirdCount++;
        if (arr[c] < p) {
          swap(arr[b], arr[a]);
          swap(arr[a], arr[c]);
          a++;
        } else {
          swap(arr[b], arr[c]);
        }
        swap(arr[c], arr[d]);
        b++; c--; d--;
      } else {
        thirdCount++;
        if (arr[c] < p) {
          swap(arr[b], arr[a]);
          swap(arr[a], arr[c]);
          a++;
        } else {
          swap(arr[b], arr[c]);
        }
        b++; c--;
      }
    }
  }
  thirdCount++;
  a--; b--; c++; d++;
  swap(arr[left + 1], arr[a]);
  swap(arr[a], arr[b]);
  a--;
  swap(arr[left], arr[a]);
  swap(arr[right], arr[d]);
  thirdQuickSort(arr, left, a - 1);
  thirdQuickSort(arr, a + 1, b - 1);
  thirdQuickSort(arr, b + 1, d - 1);
  thirdQuickSort(arr, d + 1, right);
}

int main(int argc, char const *argv[]) {
  string filename;
  ifstream fin("input10.txt");
  ofstream fout("ip71_kozyriev_03_output.txt");

  int n;

  fin >> n;
  int arr[n],first[n],second[n],third[n];

  for (int i = 0; i < n; i++) {
    fin >> arr[i];
    first[i] = arr[i];
    second[i] = arr[i];
    third[i] = arr[i];
  }

  firstQuickSort(first, 0, n-1);
  secondQuickSort(second, 0, n-1);
  thirdQuickSort(third, 0, n-1);

  fout << firstCount << ' ' << secondCount << ' ' << thirdCount << endl;

  return 0;
}
