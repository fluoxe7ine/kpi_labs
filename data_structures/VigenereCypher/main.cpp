#include <iostream>
#include <string>
using namespace std;

string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
string message = "";
string keyword = "";
int counter = 0;

string generatingKey(string msg, string key) {
  for (int i = 0; key.length() < msg.length(); i++) {
    int length = key.length();
    key += key[counter];
    counter++;
    if ((counter + 1) == length) counter = 0;
  }
  return key;
}

string encode(string msg, string key) {
  string result = "";
  int cypherChar;
  for (int i = 0; i < msg.length(); i++) {
    cypherChar = (alphabet.find(msg[i]) + alphabet.find(key[i])) % alphabet.length();
    result += alphabet[cypherChar];
  }
  return result;
}

string decode(string msg, string key) {
  string result = "";
  int decypherChar;
  for (int i = 0; i < msg.length(); i++) {
    decypherChar = (alphabet.find(msg[i]) + alphabet.length() - alphabet.find(key[i])) % alphabet.length();
    result += alphabet[decypherChar];
  }
  return result;
}

 void shift() {
   int size = alphabet.length();
   int temp = alphabet[0];
   for (int i = 0; i < size; i++) {
     alphabet[i] = alphabet[i+1];
     alphabet[size] = temp;
   }
   cout << alphabet << endl;
 }


int main() {
  getline(cin, message);
  getline(cin, keyword);

  keyword = generatingKey(message, keyword);

  string encodeMessage = encode(message, keyword);
  cout << "Encoded message: " << encodeMessage << endl;

  string decodeMessage = decode(encodeMessage, keyword);
  cout << "Decoded message: " << decodeMessage << endl;

  cout << "Matrix: " << endl;
  cout << alphabet << endl;
  for (int i = 1; i < alphabet.length(); i++) {
    shift();
  }

  return 0;
}
