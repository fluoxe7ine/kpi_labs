#include <iostream>
#include <ctime>
using namespace std;

struct Node {
  int data;
  Node *next, *prev;
};

Node *head = nullptr;
Node *tail = nullptr;

void addItem(int data); //create new node
void write(); //show list
void del(); //deleting every third node
void clear(); //clear list
void test(int n); //test task for n nodes

int main(int argc, char const *argv[]) {
  test(10);
  test(100);
  test(1000);
  test(10000);
  test(100000);
  test(1000000);
  test(10000000);
  return 0;
}

void addItem(int data) {
  Node *temp = new Node;
  Node *s = new Node;
  temp->data = data;
  temp->next = nullptr;
  if (!head) {
    temp->prev = nullptr;
    head = temp;
    tail = temp;
  } else {
    temp->prev = tail;
    temp->next = nullptr;
    tail->next = temp;
    tail = temp;
  }
}

void clear() {
  if (!head) return;
  for (tail = head; tail; tail = tail-> next) {
    delete tail;
    head = tail->next;
  }
}

void write() {
  tail = head;
  while (tail) {
    cout << tail->data << endl;
    tail = tail->next;
  }
}

void del() {
  Node *prev = new Node;
  Node *curr = new Node;
  tail = head;
  int counter = 0;

  while (tail) {
    if (!tail->next) return;
    counter++;
    if (counter % 3 == 0) {
      prev = tail->prev;
      curr = tail;
      prev->next = tail->next;
      tail->next->prev = prev;
      delete curr;
    }
    tail = tail->next;
  }
}

  void test(int n) {
    clear(); //cleaning list from prev tests
    for (int i = 1; i <= n; i++){ //generating list of indexes
      addItem(i);
    }

    clock_t time;
    time = clock();
    del(); // deleting every third element
    time = (clock() - time);

    int errorCounter = 0;
    for (tail = head; tail; tail = tail->next) { //checking for errors
      if (tail->data % 3 == 0) errorCounter++;
    }
    if (errorCounter > 0) {
      cout << "Test was failed" << endl;
    } else cout << "Test was successfully finished in " << (double)time/CLOCKS_PER_SEC << " seconds" << endl;
  }
