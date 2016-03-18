#include<iostream>
using namespace std;

class OS
{
public:
	struct PCB
	{
		PCB *FWD;
		PCB *BKWD;
		int ID;
	};
	PCB pcb[20];
	PCB *Rhead = NULL, *Rtail;
	PCB *Fhead = NULL, *Ftail;
	PCB *Bhead = NULL, *Btail;

	void initilize_ready(int i)
	{

		if (Rhead == NULL)
		{
			pcb[i].ID = i;
			Rhead = &pcb[i];
			Rtail = &pcb[i];
		}
		else
		{
			pcb[i].ID = i;
			Rtail->FWD = &pcb[i];
			pcb[i].BKWD = Rtail;
			Rtail = &pcb[i];
			Rtail->FWD = NULL;
		}
	}

	void initilize_free(int i)
	{

		if (Fhead == NULL)
		{
			pcb[i].ID = i;
			Fhead = &pcb[i];
			Ftail = &pcb[i];
		}
		else
		{
			pcb[i].ID = i;
			Ftail->FWD = &pcb[i];
			pcb[i].BKWD = Ftail;
			Ftail = &pcb[i];
			Ftail->FWD = NULL;
		}
	}

	void initilize_block(int i)
	{

		if (Bhead == NULL)
		{
			pcb[i].ID = i;
			Bhead = &pcb[i];
			Btail = &pcb[i];
		}
		else
		{
			pcb[i].ID = i;
			Btail->FWD = &pcb[i];
			pcb[i].BKWD = Btail;
			Btail = &pcb[i];
			Btail->FWD = NULL;
		}
	}


	void display()
	{
		PCB *p, *q, *r;
		cout << "Ready List\n" << endl;
		cout << "!~~~~~ ";
		for (p = Rhead; p != NULL; p = p->FWD)
			cout << p->ID << "  ";
		cout << "~~~~~!";
		cout << "\n\n\nFree List\n" << endl;
		cout << "!~~~~~ ";
		for (q = Fhead; q != NULL; q = q->FWD)
			cout << q->ID << "  ";
		cout << "~~~~~!";
		cout << "\n\n\nBlock List\n" << endl;
		cout << "!~~~~~ ";
		for (r = Bhead; r != NULL; r = r->FWD)
			cout << r->ID<<"  ";
		cout << "~~~~~!";
	}
	void Create(int i)
	{
		PCB *p = Fhead, *q = NULL, *r = NULL, *s = NULL;
		while (1)
		{

			if (p->ID == i&&Ftail->ID == i)
			{
				Ftail = Ftail->BKWD;
				Ftail->FWD = NULL;
				Rtail->FWD = p;
				p->BKWD = Rtail;
				Rtail = p;
				break;
			}
			else if (p->ID == i&&Fhead->ID == i)
			{
				q = p;
				r = q->FWD;
				r->BKWD = q;
				q->FWD = NULL;
				r->BKWD = NULL;
				Fhead = r;
				Rtail->FWD = q;
				q->BKWD = Rtail;
				Rtail = q;
				break;
			}
			else if (p->ID == i&&Ftail->ID != i)
			{
				q = p->BKWD;
				s = p->FWD;
				q->FWD = s;
				s->BKWD = q;
				Rtail->FWD = p;
				p->BKWD = Rtail;
				p->FWD = NULL;
				Rtail = p;
				break;
			}
			p = p->FWD;
		}

	}

	void Delete(int i)
	{
		PCB *p = Rhead, *q = NULL, *r = NULL, *s = NULL;
		while (1)
		{

			if (p->ID == i&&Rtail->ID == i)
			{
				Rtail = Rtail->BKWD;
				Rtail->FWD = NULL;
				Ftail->FWD = p;
				p->BKWD = Ftail;
				Ftail = p;
				break;
			}
			else if (p->ID == i&&Rhead->ID == i)
			{
				q = p;
				r = q->FWD;
				r->BKWD = q;
				q->FWD = NULL;
				r->BKWD = NULL;
				Rhead = r;
				Ftail->FWD = q;
				q->BKWD = Ftail;
				Ftail = q;
				break;
			}
			else if (p->ID == i&&Rtail->ID != i)
			{
				q = p->BKWD;
				s = p->FWD;
				q->FWD = s;
				s->BKWD = q;
				Ftail->FWD = p;
				p->BKWD = Ftail;
				p->FWD = NULL;
				Ftail = p;
				break;
			}
			p = p->FWD;
		}
	}

	void Wait(int i)
	{
		PCB *p = Rhead, *q = NULL, *r = NULL, *s = NULL;
		while (1)
		{

			if (p->ID == i&&Rtail->ID == i)
			{
				Rtail = Rtail->BKWD;
				Rtail->FWD = NULL;
				Btail->FWD = p;
				p->BKWD = Btail;
				Btail = p;
				break;
			}
			else if (p->ID == i&&Rhead->ID == i)
			{
				q = p;
				r = q->FWD;
				r->BKWD = q;
				q->FWD = NULL;
				r->BKWD = NULL;
				Rhead = r;
				Btail->FWD = q;
				q->BKWD = Btail;
				Btail = q;
				break;
			}
			else if (p->ID == i&&Rtail->ID != i)
			{
				q = p->BKWD;
				s = p->FWD;
				q->FWD = s;
				s->BKWD = q;
				Btail->FWD = p;
				p->BKWD = Btail;
				p->FWD = NULL;
				Btail = p;
				break;
			}
			p = p->FWD;
		}
	}
};


void main()
{
	OS obj;
	for (int i = 0; i <= 20; i++)
	{
		if (i == 0 || i == 3 || i == 5 || i == 8 || i == 13)
		{
			obj.initilize_ready(i);
		}
	}
	for (int i = 0; i <= 20; i++)
	{
		if (i == 1 || i == 4 || i == 6 || i == 9 || i == 15)
		{
			obj.initilize_free(i);
		}
	}

	for (int i = 0; i <= 20; i++)
	{
		if (i == 2 || i == 7 || i == 10 || i == 11 || i == 12 || i == 14 || i == 16 || i == 17 || i == 18 || i == 19)
		{
			obj.initilize_block(i);
		}
	}
	obj.display();

	int a;
	cin >> a;
	obj.Wait(a);

	cout << "lists are updated" << endl;
	obj.display();
	system("pause");
}
