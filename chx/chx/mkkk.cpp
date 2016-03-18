#include<iostream>
#include<cstring>
using namespace std;

///////////////////////////////////// this is our stack class of type template ///////////////////////////////////////////////////

template <class type>
class Stack{
    int top;
    int max;
    type * array;
public:
    Stack(int n = 10);
    bool push (type data);
    bool pop(type & data);
    bool isFull();
    bool isEmpty();
    ~Stack();
};

template <class type>
Stack<type>::Stack(int n){
    top = -1;
    max = n;
    array = new type[max];
}

template <class type>
bool Stack<type>::push (type data){
    if(!isFull()){
        array[++top] = data;
        return true;
    }
    else
        return false;
}

template <class type>
bool Stack<type>::pop(type & data){
    if(!isEmpty()){
        data = array[top--];
        return true;
    }
    return false;
}
template <class type>
bool Stack<type>::isFull(){
    if(top == max-1)
        return true;
    else
        return false;
}
template <class type>
bool Stack<type>::isEmpty(){
    if(top==-1)
        return true;
    else
        return false;
}
template <class type>
Stack<type>::    ~Stack(){
    delete [] array;
}

////////////////////////////////////////////stack functions ends here ////////////////////////////////////////////////////


////////////////////////////////////////////////////local functions//////////////////////////////////////////////////////

int convert(char b); ///////////////////convert char to integer/////////////////////////////////////////////////////////
int presi(char b); ///////////////////// check presidence /////////////////////////////////////////////////////////////
bool rpn(char*,float&); //////////// evaluate post fix expression////////////////////////////////////////////////
void postfix(char*,char*,Stack<char>&a);////////// convert infix to postfix////////////////////////////////////////////
bool check(char); //////////////////////////// check whether our required operator comes or not //////////////////////
void print(char*);///////////////////////////////print post fix///////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void main()
{
Stack<char> a;
char * expression;
expression=new char[30];
cout<<"Enter Expression";
cin>>expression;

char * temp;
temp=new char[30];
float result=0;
bool flag=true;
int i=0;



//////////////////////////////////////////////function calling////////////////////////////////////////////////////////
postfix(expression,temp,a); // converting post fix to infix

cout<<"PostFix Expression : "; 
print(temp); /////////////// printing post fix expression

flag=rpn(temp,result); /////////////////// evaluating post fix expression//////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
if(flag)
{

cout<<endl;
cout<<"Answer: "<<result<<endl;
}
else
{
cout<<endl;
cout<<"Invalid Expression : "<<endl;
cout<<endl;
}

system("Pause");




}

int convert(char b)
{
switch(b)
{
case '0':
return 0;
break;
case '1':
return 1;
break;

case '2':
return 2;
break;
case '3':
return 3;
break;

case '4':
return 4;
break;

case '5':
return 5;
break;

case '6':
return 6;
break;

case '7':
return 7;
break;

case '8':
return 8;
break;
case '9':
return 9;
break;
}


}
int presi(char b)
{
switch(b)
{
case '|':
return 0;
break;
case '^':
return 1;
break;
case'=':
    return 2;
break;
case '>':
return 3;
break;
case '<':
return 4;
break;
case '-':
return 5;
break;
case '+':
return 6;
break;

case '*':
return 7;
break;
case '/':
return 8;
break;
case '%':
return 9;
break;
case '!':
return 10;
break;
case '#':
return 11;
break;

}
return 0;
}
///////////////////////////////////// convert infix to postfix//////////////////////////////////////////////////////////////////////////
void postfix(char*expression,char*temp,Stack<char>&a)
{
char ch;

int len;
len=strlen(expression);

int it=0;

for(int i=0;i<len;i++)
{
if(expression[i]>=48&&expression[i]<=57)
{
temp[it]=expression[i];
it++;

}
else if(a.isEmpty() && check(expression[i]) )
{
a.push(expression[i]);
//cout<<"done";
}
else if(!a.isEmpty() && check(expression[i]))
{
a.pop(ch);
a.push(ch);

if(expression[i]=='(')
{
a.push(expression[i]);
}
else if(presi(expression[i])<=presi(ch))
{
a.pop(temp[it]);
a.push(expression[i]);
it++;
}
else if(presi(expression[i])>presi(ch))
{
a.push(expression[i]);

}




}
else if(expression[i]==')')
{
a.pop(ch);
temp[it]=ch;
it++;

while(ch!='(')
{
a.pop(ch);
if(ch!='(')
{
temp[it]=ch;
it++;
}
}
}


}

if(!a.isEmpty())
{
while(!a.isEmpty())
{
a.pop(ch);
temp[it]=ch;
it++;
}
}
temp[it]='\0';



}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////// evaluate postfix///////////////////////////////////////////////////////////////////
bool rpn(char*expression,float &temp)

{
Stack<float> a;
float c1;
float c2;
int len=strlen(expression);
for(int i=0;i<len;i++)
{
if(expression[i]>=48&&expression[i]<=57)
{
temp=convert(expression[i]);
a.push(temp);

}
if(expression[i]=='+')
{
a.pop(c1);
a.pop(c2);
temp=c1+c2;
a.push(temp);
}
if(expression[i]=='-')
{
a.pop(c1);
a.pop(c2);
temp=c2-c1;
a.push(temp);
}
if(expression[i]=='*')
{
a.pop(c1);
a.pop(c2);
temp=c1*c2;
a.push(temp);
}
if(expression[i]=='/')
{
a.pop(c1);
a.pop(c2);
temp=c2/c1;
a.push(temp);
}
if(expression[i]=='>')
{
a.pop(c1);
a.pop(c2);
temp=(c2>c1);
a.push(temp);
}
if(expression[i]=='<')
{
a.pop(c1);
a.pop(c2);
temp=c2<c1;
a.push(temp);
}

if(expression[i]=='=')
{
a.pop(c1);
a.pop(c2);
if(c1==c2)
{
a.push(1);
}
else
{
a.push(0);
}
}

if(expression[i]=='|')
{
a.pop(c1);
a.pop(c2);
if((c1==0||c1==1)&&(c2==0||c2==1))
{
if(c1==0 && c2==0)
{
a.push(0);
}
else
{
a.push(1);
}
}
else
{
return false;
break;
}
}
if(expression[i]=='^')
{
a.pop(c1);
a.pop(c2);
if((c1==0||c1==1)&&(c2==0||c2==1))
{
if(c1==1 && c2==1)
{
a.push(1);
}
else
{
a.push(0);
}
}
else
{
return false;
break;
}
}
if(expression[i]=='%')
{
int t1=0;
int t2=0;
int mod=0;

a.pop(c1);
a.pop(c2);
t1=c1;
t2=c2;

mod=t2%t1;

temp=mod;


a.push(temp);
}

if(expression[i]=='!')
{
a.pop(c1);
if(c1==0||c1==1)
{
if(c1==1)
{
a.push(0);
}
else if(c1==0)
{
a.push(1);
}
}
else 
{
return false;
break;
}
}
   if(expression[i]=='#')
   {
a.pop(c1);
int aiwi;
aiwi=c1;
int t=0;
t=~aiwi+1;
a.push(t);
}





}
a.pop(temp);
return true;


/*
*/



}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


bool check(char a)
{
if (a=='('||a=='*'||a=='/'||a=='+'||a=='-'||a=='^'||a=='|'||a=='>'||a=='<'||a=='='||a=='%'||a=='#'||a=='!')
{
return true;
}
else
{
return false;
}
}

void print(char*temp)

{
for(int j=0;temp[j]!='\0';j++)
{
if(temp[j]!='(')
{
cout<<temp[j];
}
}

}