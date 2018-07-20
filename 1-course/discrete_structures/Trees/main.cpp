#include <iostream>
using namespace std;

struct BstNode {
  int data;
  BstNode* left;
  BstNode* right;
};

BstNode* GetNewNode(int data) {
  BstNode* newNode = new BstNode();
  newNode->data = data;
  newNode->left = newNode->right = NULL;
  return newNode;
}

BstNode* Insert(BstNode* root, int data){
  if (root == NULL) {
    root = GetNewNode(data);
  }
  else if (data <= root->data) {
    root->left = Insert(root->left, data);
  }
  else {
    root->right = Insert(root->right, data);
  }
  return root;
}

int FindMin (BstNode* root){
  int min = root->data;
  while (root->left != NULL) root = root->left;
  min = root->data;
  return min;
}

int FindMax (BstNode* root){
  int max = root->data;
  while (root->right != NULL) root = root->right;
  max = root->data;
  return max;
}

void PrintOut(BstNode* root) {
  if(root == NULL) {
    return ;
  };
  PrintOut(root->left);
  cout << root->data << ' ';
  PrintOut(root->right);
}

void print_Tree(BstNode* root,int level)
{
    if(root){
        print_Tree(root->right,level + 1);
        for (int i = 0;i < level;i++){
            cout << "        ";
        }
        cout << root->data << " " << endl;
        print_Tree(root->left,level + 1);
    }
}

int main(int argc, char const *argv[]) {
  srand(time(NULL));
  BstNode* root = NULL;

  //generating tree
  for (int i = 0; i < 15; i++) {
    int nodeData;
    nodeData = (rand() % 199) - 99;
    root = Insert(root, nodeData);
  }

  PrintOut(root);
  cout << endl;
  int min = FindMin(root);
  int max = FindMax(root);
  cout << "min: " << min << endl;
  cout << "max: " << max << endl;
  root = Insert(root, min);
  root = Insert(root, max);
  PrintOut(root);
  cout << endl;
  print_Tree(root,0);

  return 0;
}
