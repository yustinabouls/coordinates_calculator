/* Name: Yustina Bouls
   Date: January 18
   Name of the program: OOP-2200-06
   Description: That's a program that calculates and displays distance between two coordinates (x and y) */
   
   
#include <iostream>
#include <iomanip>
#include <cmath>
using namespace std;

int main()
{
	 // DECLARATIONS
 int x2,x1,y2,y1; 
 double d; //d=distance
 
 
 cout<<"Find the distance between the two coordinates:"<<endl; //here it's asking to input the first coordinate in the form of x y 
 cout<<"-------------------------------------------------" <<endl;
 
 
 cout<<"Enter the value of x1 (first coordinate) :";
 cin>> x1;

 cout<<"Enter the value of y1 (first coordinate) :";
 cin>> y1;
 
 cout<<"Enter the value of x2 (second coordinate) :";
 cin>> x2;
 
 cout<<"Enter the value of y2 (second coordinate) :";
 cin>> y2;
 
 
 cout<<"________________________________"<<endl;
  
 cout<< "The two coordinates you inputed: (" << x1<< ", "<< y1<< ") and ("<< x2<< ", "<< y2<< ")" <<endl;
 
 cout<<"the distance between the two coordinates:" <<d;
  return d=sqrt(pow (x2 - x1, 2) + pow (y2 - y1, 2)); 
  
} 
 
 

 
	
