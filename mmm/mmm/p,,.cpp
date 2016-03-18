#include<iostream>
#include<conio.h>

using namespace std;

struct PCB
{
	int ID;
	PCB *Forward, *Back;
};
PCB *RHead, *RTail, *FHead, *FTail, *BHead, *BTail;
PCB Array[20];

void InsertReady(int n)
{
	Array[n].ID = n;
	Array[n].Forward = NULL;
	Array[n].Back = NULL;
	if (RHead == NULL)
	{
		RHead = &Array[n];
	}
	else
	{
		RTail->Forward = &Array[n];
		Array[n].Back = RTail;
	}
	RTail = &Array[n];
}

void InsertFree(int n)
{

	Array[n].ID = n;
	Array[n].Forward = NULL;
	Array[n].Back = NULL;
	if (FHead == NULL)
	{
		FHead = &Array[n];
	}
	else
	{
		FTail->Forward = &Array[n];
		Array[n].Back = FTail;
	}
	FTail = &Array[n];
}

void InsertBlock(int n)
{
	Array[n].ID = n;
	Array[n].Forward = NULL;
	Array[n].Back = NULL;
	if (BHead == NULL)
	{
		BHead = &Array[n];
	}
	else
	{
		BTail->Forward = &Array[n];
		Array[n].Back = BTail;
	}
	BTail = &Array[n];
}
void CreateProcess(int n)
{

	PCB *TempHead = FHead;
	PCB *TempTail = FTail;

	PCB *P;
	PCB *N; 

	if (TempHead->ID == Array[n].ID)  
	{
		FHead = FHead->Forward;  
		FHead->Back = NULL;
		InsertReady(n); 
	}
	else if (TempTail->ID == Array[n].ID) 
	{
		FTail = FTail->Back; 
		FTail->Forward = NULL;
		InsertReady(n); 
	}
	else
	{
		P = Array[n].Back; 
		N = Array[n].Forward;
		P->Forward = N;
		N->Back = P;
		InsertReady(n); 
	}

}

void DeleteProcess(int n)
{

	PCB *TempHead = RHead;
	PCB *TempTail = RTail;
	PCB *P;
	PCB *N; 
	Array[n].ID = n;
	if (TempHead->ID == Array[n].ID) 
	{
		RHead = RHead->Forward; 
		RHead->Back = NULL;
		InsertFree(n); 

	}
	if (TempTail->ID == Array[n].ID)  
	{
		RTail = RTail->Back; 
		RTail->Forward = NULL;
		InsertFree(n); 	
	}
	else 
	{
		P = Array[n].Back;
		N = Array[n].Forward;
		P->Forward = N;
		N->Back = P;
		InsertFree(n);
	}
}


void WaitProcess(int n)
{
	if (BHead == NULL)
		InsertBlock(n); 
	else
	{
		PCB *TempHead = BHead;
		PCB *TempTail = BTail;
		PCB *P;
		PCB *N; 
		Array[n].ID = n;
		if (TempHead->ID == Array[n].ID) 
		{
			RHead = RHead->Forward;  
			RHead->Back = NULL;
			InsertBlock(n); 
		}
		if (TempTail->ID == Array[n].ID) 
		{
			RTail = RTail->Back; 
			RTail->Forward = NULL;
			InsertBlock(n); 
		}
		else 
		{
			P = Array[n].Back;
			N = Array[n].Forward;
			P->Forward = N;
			N->Back = P;
			InsertBlock(n); 
		}
	}
}

void Display()
{
	cout << "\nFree List" << endl;
	for (PCB *Free = FHead; Free != NULL;Free=Free->Forward)
	{
		cout << "ID = " <<Free->ID << endl;
	}
	cout << "\nReady List" << endl;
	for (PCB *Ready = RHead; Ready != NULL; Ready = Ready->Forward)
	{
		cout << "ID = " << Ready->ID << endl;
	}
	cout << "\nBlockList" << endl;
	for (PCB *Block = BHead; Block != NULL; Block = Block->Forward)
	{
		cout << "ID = " << Block->ID << endl;
	}
}
void main()
{
	int n, choice;
	InsertReady(0);
	InsertReady(1);
	InsertReady(2);
	InsertReady(3);
	InsertReady(4);
	InsertReady(5);
	InsertBlock(6);
	InsertBlock(7);
	InsertBlock(8);
	InsertBlock(9);
	InsertFree(10);
	InsertFree(11);
	InsertFree(12);
	InsertFree(13);
	InsertFree(14);
	InsertFree(15);
	InsertFree(16);
	InsertFree(17);
	InsertFree(18);
	InsertFree(19);

	Display();
	do
	{
		cout << " 1 to Create " << endl;
		cout << " 2 for Delete" << endl;
		cout << " 3 for Wait " << endl;
		cout << " 4 for Display " << endl;
		cout << " 5 for Quit " << endl;
		cin >> choice;
		if (choice == 1)
		{
			cout << "Enter ID ";
			cin >> n;
			CreateProcess(n);
			_getch();
		}
		else if (choice == 2)
		{
			cout << "Enter ID ";
			cin >> n;
			DeleteProcess(n);
			_getch();
		}
		else if (choice == 3)
		{
			cout << "Enter ID  ";
			cin >> n;
			WaitProcess(n);
			_getch();
		}
		else if (choice == 4)
		{
			Display();
			_getch();
		}
	}while(choice != 5);
	_getch();
}