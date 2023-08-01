#include <iostream>
using namespace std;
int main() {
	int Deposit;
	double Years;
	double intRate = 0.0;
	double Interest;
	double newBalance;
	cout << "Enter amount of Years" << endl;
	cin >> Years;
	cout << "Enter Deposit amount" << endl;
	cin >> Deposit;
	if (Years >= 5) {
		intRate = .045;
	}
	else if (5 > Years && Years >= 4) {
		intRate = .04;
	}
	else if (4 > Years && Years >= 3) {
		intRate = .035;
	}
	else if (3 > Years && Years >= 2) {
		intRate = .025;
	}
	else if (2 > Years && Years >= 1) {
		intRate = .02;
	}
	else if (1 > Years) {
		intRate = .015;
	}
	Interest = Deposit * intRate * Years;
	newBalance = Deposit + Interest;
	cout << "Original Deposit: " << Deposit << endl;
	cout << "Interest Earned: " << Interest << endl;
	cout << "New Balance: " << newBalance << endl;
}