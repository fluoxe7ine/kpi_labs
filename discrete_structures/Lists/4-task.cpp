#include<iostream>
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

BstNode* FindMin(BstNode* root){
	while(root->left != NULL) root = root->left;
	return root;
}

BstNode* Insert(BstNode* root,int data) {
	if(root == NULL) {
		root = GetNewNode(data);
	}
	else if(data <= root->data) {
		root->left = Insert(root->left,data);
	}
	else {
		root->right = Insert(root->right,data);
	}
	return root;
}

BstNode* DeleteNode(BstNode* root, int data){
  if(root == NULL) return root;
	else if(data < root->data) root->left = DeleteNode(root->left,data);
	else if (data > root->data) root->right = DeleteNode(root->right,data);

	else {
		// no child
		if(root->left == NULL && root->right == NULL) {
			delete root;
			root = NULL;
		}
		//one child
		else if(root->left == NULL) {
			BstNode* temp = root;
			root = root->right;
			delete temp;
		}
		else if(root->right == NULL) {
			BstNode* temp = root;
			root = root->left;
			delete temp;
		}
		// two children
		else {
			BstNode* temp = FindMin(root->right);
			root->data = temp->data;
			root->right = DeleteNode(root->right,temp->data);
		}
	}
	return root;
}

//printing out the binary tree
void PrintOut(BstNode* root) {
  if(root == NULL) {
    return ;
  };
  PrintOut(root->left);
  cout << root->data << ' ';
  PrintOut(root->right);
}

bool Search(BstNode* root, int data) {
	if(root == NULL) {
		return false;
	}
	else if(root->data == data) {
		return true;
	}
	else if(data <= root->data) {
		return Search(root->left,data);
	}
	else {
		return Search(root->right,data);
	}
}

int main() {
  srand(time(NULL));
	BstNode* root = NULL;
  int choice;
  cout << "Press 1 for manual input or 2 for random input: ";
  cin >> choice;

  if (choice == 1) {
    for (int i = 0; i < 15; i++){
      int nodeData;
      cin >> nodeData;
      root = Insert(root, nodeData);
    }
  } else if (choice == 2) {
    for (int i = 0; i < 15; i++){
      int nodeData;
      nodeData = (rand() % 199) - 99;
      root = Insert(root, nodeData);
    }
  };

  PrintOut(root);
  cout << endl;

  int n;
  cout << "Enter N: ";
  cin >> n;

  for (int i = -99; i < n; i++){
    while(Search(root, i) == true) {
      root = DeleteNode(root, i);
      int nodeData;
      nodeData = (rand() % (n+1)) + n;
      root = Insert(root, nodeData);
    }
  }
  
  PrintOut(root);
}
