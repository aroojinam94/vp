#include<iostream>
#include<conio.h>
#include<cstdlib>
using namespace std;
class LinkL
{
public:
	struct node
	{
		int data;
		node *fwrd;
	};
	node *Rhead;
	node *Fhead;
	node *Bhead;
    node *Rtail;
	node *Ftail;		
	node *Btail;
public:
	LinkL()
	{
		Rhead=NULL;
		Fhead=NULL;
		Bhead=NULL;
		Rtail=NULL;
		Ftail=NULL;
		Btail=NULL;
	}

	void addF(int x)
	{
		node *temp=new node;
		temp->data=x;
		temp->fwrd=NULL;
		if(Fhead==NULL)
		{
			Fhead=temp;
			Ftail=temp;
		}
		else
		{
			Ftail->fwrd=temp;
			Ftail=temp;
		}
	}
	void delR(int num)
	{
		node *temp;
		node *temp2;
		temp=Rhead;
		if(Rhead->data==num)
		{
			Rhead=Rhead->fwrd;
			free(temp);
		}
		else
		{
			while(temp->fwrd->data!=num)
			{
				temp=temp->fwrd;
			}
			temp2=temp->fwrd;
			temp->fwrd=temp2->fwrd;
			free(temp2);
		}
	}

	void delF()
	{
		node *temp;
		node *temp1;
		temp=Fhead;
		Fhead=Fhead->fwrd;
		free(temp);
	}
	void addFAg(int num)
	{
		node *temp=new node;
		node *temp1=Rhead;
		node *temp2=Fhead;
		if(temp1->data==num)
		{
			temp->data=Rhead->data;
			temp->fwrd=NULL;
		}
		else 
		{
			while(temp1->data!=num)
			{
			temp1=temp1->fwrd;
			}
			temp->data=temp1->data;
			temp->fwrd=NULL;

		}
		if(Fhead==NULL)
		{
			Fhead=temp;
			Ftail=temp;
		}
		else
		{
			while(temp2->fwrd!=NULL)
			{
				temp2=temp2->fwrd;
			}
			temp2->fwrd=temp;
		}
	}
	void addB(int num)
	{
		node *temp=new node;
		node *temp1=Rhead;
		node *temp2=Bhead;
		if(temp1->data==num)
		{
			temp->data=Rhead->data;
			temp->fwrd=NULL;
		}
		else 
		{
			while(temp1->data!=num)
			{
			temp1=temp1->fwrd;
			}
			temp->data=temp1->data;
			temp->fwrd=NULL;

		}
		if(Bhead==NULL)
		{
			Bhead=temp;
			Btail=temp;
		}
		else
		{
			while(temp2->fwrd!=NULL)
			{
				temp2=temp2->fwrd;
			}
			temp2->fwrd=temp;
		}
	}
	
	void addR()
	{
		node *temp=new node;
		temp->data=Fhead->data;
		temp->fwrd=NULL;
		if(Rhead==NULL)
		{
			Rhead=temp;
			Rtail=temp;
		}
		else
		{
			Rtail->fwrd=temp;
			Rtail=temp;
		}
	}
	void displayF()
	{
		node *temp;
		temp=Fhead;
		if(temp==NULL)
		{
			cout<<"Empty";
			cout<<endl;
		}
		else 
		{
			cout<<endl;	 
			while(temp!=NULL)
			{
		      cout<<"Free_List = "<<temp->data;
		      cout<<endl;
		      temp=temp->fwrd;
			}
			cout<<endl;
		}
	}
	void displayR()
	{
		node *temp;
		temp=Rhead;
		if(temp==NULL)
		{
			cout<<"Empty\n";
			cout<<endl;
		}
		else 
		{
			while(temp!=NULL)
			{
		      cout<<"Ready_List = "<<temp->data;
		      cout<<endl;
		      temp=temp->fwrd;
			}
			cout<<endl;
		}
	}
	void displayB()
	{
		node *temp;
		temp=Bhead;
		if(temp==NULL)
		{
			cout<<"Empty\n";
			cout<<endl;
		}
		else 
		{
			while(temp!=NULL)
			{
		      cout<<"Block_List = "<<temp->data;
		      cout<<endl;
		      temp=temp->fwrd;
			}
			cout<<endl;
		}
	}
};
void main()
{

	LinkL l;
	int num;
	char choi;
	
	l.addF(1);
	l.addF(2);
	l.addF(3);
	l.addF(4);
	l.addF(5);
	l.addF(6);
	l.addF(7);
	l.addF(8);
	l.addF(9);
	l.addF(10);
	do
	{
	cout<<"1)Create Process\n";
	cout<<"2)Kill\n";
	cout<<"3)Process To Wait\n";
	cout<<"Enter Choice = ";
	cin>>num;
	switch(num)
	{
	case 1:
		{
			l.addR();
			l.delF();
			break;
		}
	case 2:
		{
			int x;
			cout<<"Enter Value To Kill ";
			cin>>x;
			l.addFAg(x);
	        l.delR(x);
			break;
		}
	case 3:
		{
			int x;
			cout<<"Enter Value To Wait ";
			cin>>x;
			l.addB(x);
			l.delR(x);
			break;
		}

	}
	l.displayF();
	l.displayR();
	l.displayB();
	cout<<"\nDo Yo Want To Continue ? = ";
	cin>>choi;
	system("cls");
	}
	while(choi=='y'||choi=='Y');
	getch();
}


