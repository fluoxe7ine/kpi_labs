#include <iostream>
#include <fstream>
#include <cstdlib>
#include <string>
using namespace std;

int merge(int* arr, int low, int mid, int high){
  int leftLength = mid - low + 1;
  int rightLength = high - mid;
  int left[leftLength + 1];
  int right[rightLength + 1];
  int i = 0;
  int j = 0;
  int inversions = 0;
  for (i = 0; i < leftLength; i++){
    left[i] = arr[i + low];
  }
  left[leftLength] = 2147483647; //same like inf

  for (i = 0; i < rightLength; i++){
    right[i] = arr[mid + i + 1];
  }
  right[rightLength] = 2147483647;

  i = 0;
  j = 0;

  //creating sort array
  for (int k = low; k <= high; k++){
    if (left[i] < right[j]) {
      arr[k] = left[i];
      i++;
    }
    else {
      arr[k] = right[j];
      inversions += leftLength - i;
      j++;
    }
  }
  return inversions;
}

int mergeSort(int* arr, int low, int high){
  int inversions = 0;
  if (low < high) {
    int mid = (low + high) / 2;
    inversions = mergeSort(arr, low, mid);
    inversions += mergeSort(arr, mid + 1, high);
    inversions += merge(arr, low, mid, high);
    return inversions;
  }
  else return 0;
}

void createArray(int len, int* first_arr, int* second_arr, int *result){
  for (int i = 0; i < len; i++){
    result[first_arr[i] - 1] = second_arr[i];
  }
}

int main(int argc, char* argv[]){
  int x = atoi(argv[1]);
  string filename;
  cin >> filename;
  ifstream fin(filename);
  ofstream fout("ip71_kozyriev_02_output.txt");
  int u, m, n;
  int *result = new int(m);
  fin >> u >> m;

  int outputData[u - 1][2]; // output data
  int matrix[u][m];

  //reading data
  for (int i = 0; i < u; i++){
    fin >> n;
    for (int j = 0; j < m; j++){
      fin >> matrix[i][j];
    }
  }
  int j = 0;
  for (int i = 0; i < u; i++){
    if (i != (x - 1)){
      createArray(m, matrix[x - 1], matrix[i], result);
      outputData[j][0] = i + 1;
      outputData[j][1] = mergeSort(result, 0, m - 1);
      j++;
    }
  }

  fout << x << endl;

  for (int i = 0; i < u - 1; i++){
    for (int j = 0; j < u - 1; j++){
        if (outputData[i][1] < outputData[j][1]){
          swap(outputData[i],outputData[j]);
          }
        }
      }

  for (int i = 0; i < u - 1; i++){
    for (int j = 0; j < 2; j++){
        fout << outputData[i][j] << " ";
      }
      fout << endl;
    }
}
