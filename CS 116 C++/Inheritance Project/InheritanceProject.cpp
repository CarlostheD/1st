/*Author: Carlos Davalos
Purpose: get area of shapes.
Date: 12/10/2022
hard time trying to compile. couldnt figure program out stumped.
*/

#include <iostream>
#include <string>
using namespace std;

class shape {
public:
	virtual double Area() {

		return 0.0;
	}
	void PrintShape() {
		cout << shapeName << " " << shapeWidth * shapeHeight << endl;
	}
private:
	string shapeName;
	int shapeHeight;
	int shapeWidth;
};
class Rectangle : public shape {
	void SetLength(int newLength) {
		shapeLength = newLength;
	}
	void SetWidth(int newWidth) {
		shapeWidth = newWidth;
	}
	virtual double Area() {
		return shapeLength * shapeWidth;
	}
private:
	int shapeLength;
	int shapeWidth;
};


class Square : public shape {
	void SetSide(int newSide) {
		shapeSide = newSide;
	}
	virtual double Area() {
		return shapeSide * shapeSide;
	}
private:
	int shapeSide;
};



class Circle : public shape {
	void SetRadius(int newRadius) {
		circleRadius = newRadius;
	}
	virtual double Area() {
		return (circleRadius * circleRadius) * 3.14159265358979323846;
	}
private:
	int circleRadius;
};
int main();
const int NUM_SHAPE = 4;
vector<int> numShape(NUM_SHAPE);
numShape.at(0) = Rectangle;
numShape.at(1) = Square;
numShape.at(2) = Circle;
char chosenShape;
cout << "Choose a shape" << endl;
cout << " 0 for Rectangle" << endl;
cout << "1 for Square" << endl;
cout << "2 for Circle" << endl;
cout << "3 to quit" << endl;
cin >> chosenShape;
if (chosenShape == 3) break;
else if (chosenShape == 0)
cout << "Rectangle chosen" << endl;
cout << "Enter Length" << endl;
cin >> shapeLength;
cout << "Enter Width" << endl;
cin >> shapeWidth;
cout << "Area: " << Rectangle:shape virtual double Area();
else if (chosenShape == 1)
cout << "Square chosen" << endl;
cout << "Enter Side" << endl;
cin >> shapeSide;
cout << "Area:" << Square: shape virtual double Area();
else if (chosenShape == 2)
cout << "Circle Chosen" << endl;
cout << "Enter Radius" << endl;
cin >> circleRadius;
cout << "Area:" << Circle: shape virtual double Area();

