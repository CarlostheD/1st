#include <iostream>

using namespace std;

int main()
{
	// First Assignment Problem 2
	/*Carlos Davalos
	CS116
	9/05/2022*/
	// declaring integers
	int quarterAmount;
	int dimeAmount;
	int nickelAmount;
	int quarter = 25;
	int dime = 10;
	int nickel = 5;
	// Input
	cout << "Enter QuarterAmount:" << endl;
	cin >> quarterAmount;
	cout << "Enter dime amount:" << endl;
	cin >> dimeAmount;
	cout << "Enter nickel amount:" << endl;
	cin >> nickelAmount;

	cout << "Total output:" << (quarterAmount * quarter) + (dimeAmount * dime) + (nickelAmount * nickel) << endl;
	return 0;

}