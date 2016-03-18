#include <iostream>
#include <conio.h>
using namespace std;
template <class x>

class stack
{
private:
	
	x ray[ 20];
	int top;
public : 

	stack()
	{       
	top==-1;
	}
	template <class x>
		bool stack< x> empty()
		{
		return  ( top==-1);
	
		}
		template <class x>	
		 bool  stack<x> ful()
		{
		 return ( 20-1);
		}
		template <class x>
		void  stack< x> push( int l)
		{
		if (( full))
			cout<<"stack overflow "<<endl;
		else
			top ++;
		total[top]= l
		
		}
		template <class x>
			void stack< x>  pop()
			{
			if(( empty))
				cout<<"underflow"<<endl;
			else 
				return total[ top];
			top--;
			}
			
	void main()
	{
	int  x ,y ;
	cout <<"enter frst value ";
    cin>>x;
	cout <<"enter frst value ";
	cin >>y;
	stack ob1,ob2;
		ob1.push(a);
		ob2.push( b );
		cout <<"push is "<<endl;
	}
}