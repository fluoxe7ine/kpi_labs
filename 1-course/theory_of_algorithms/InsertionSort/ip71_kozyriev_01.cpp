#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;

string filename;
int n, buffer;
vector <int> mainArr;
vector <int> even;
vector <int> odd;
void dataRead();
void evenSort();
void oddSort();
void makeMainArr();
void dataWrite();

int main()
{
    cin >> filename;
    dataRead();
    evenSort();
    oddSort();
    makeMainArr();
    dataWrite();
    return 0;
}

void dataRead() {
  ifstream fin(filename);
  if (!fin.is_open()) cout << "Error while opening file" << endl;
  fin >> n;
  for (int i = 0; i < n; i++) {
    fin >> buffer;
    if ((buffer % 2) == 0) {
      even.push_back(buffer);
    } else odd.push_back(buffer);
  }
  fin.close();
}

void evenSort() {
  for (int i = 1; i < even.size(); i++) {
    int temp = even[i];
    int j = i - 1;
    for (j; even[j] > even[j + 1] && j>=0; j--) {
      even[j+1] = even[j];
      even[j] = temp;
    }
  }
}

void oddSort() {
  for (int i = 1; i < odd.size(); i++) {
    int temp = odd[i];
    int j = i - 1;
    for (j; odd[j] < odd[j + 1] && j>=0; j--) {
      odd[j+1] = odd[j];
      odd[j] = temp;
    }
  }
}

void makeMainArr() {
  for (int i = 0; i < even.size(); i++) {
    mainArr.push_back(even[i]);
  }
  for (int i = 0; i < odd.size(); i++) {
    mainArr.push_back(odd[i]);
  }
}

void dataWrite() {
  ofstream fout("ip71_kozyriev_01_output.txt");
  for (int i = 0; i < mainArr.size(); i++) {
    fout << mainArr[i] << endl;
  }
  fout.close();
}
