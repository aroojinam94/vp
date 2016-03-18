#include<iostream>
#include <conio.h>
using namespace std;

class smallobj
{
private:
	int somedata;
public:
	void setdata(int d)
	{	
		somedata = d ; 
	}
	void showdata()
	{
          cout<<"data is"<<somedata<<endl;  
	}
};
void main ( )
{
smallobj s1,s2;
s1.setdata(0);
s2.setdata(440);
s1.showdata( );
s2.showdata( );
getch( );  }
