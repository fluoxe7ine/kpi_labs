#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    string filename;
    int n;
    int arr[n];

    //cin >> filename;
    ifstream fin("input.txt"); //change this to file name later
    fin >> n;
    cout << n << endl;
    for (int i = 0; i < n; i++) {
       fin >> arr[i];
       cout << arr[i];
    }
    fin.close();
    return 0;
}
