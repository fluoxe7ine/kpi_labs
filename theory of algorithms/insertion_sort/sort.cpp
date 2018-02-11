#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main() {
  string filename;
  int n;
  int arr[n-1];
  //cin >> filename;

  ifstream fin("input_10.txt"); //ПОМЕНЯЙ ПОТОМ НА filename
  fin >> n;
  cout << n << endl;
  for (int i = 0; i < n; i++) {
    fin >> arr[i];
    cout << arr[i] << endl;
  }
  fin.close();
  return 0;
}
