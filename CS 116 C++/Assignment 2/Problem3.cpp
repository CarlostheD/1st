#include <iostream>

using namespace std;

int main()
{
	// Problem 3
	/*Carlos Davalos
	CS 116
	9/05/2022*/
	int time;
	const int acceleration = 32; // Constant declared
	int distance;
	cout << "Input time in seconds:" << endl;
	cin >> time;
	distance = acceleration / 2 * time * time;
	cout << "Distance in feet:" << distance << "ft" << endl;




	return 0;
}