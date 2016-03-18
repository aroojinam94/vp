#include<stdio.h>
#include<conio.h>
#include<string.h>
#include<stdlib.h>



void add_patient(FILE *fp);
void display_patient(FILE *fp);
void modify_patient(FILE *fp);
void del_patient(FILE *fp);
void search_pat(FILE *fp);


void doc_add(FILE *fp1);
void doc_display(FILE *fp1);
void doc_modify(FILE *fp1);
void del_doc(FILE *fp1);  
void search_doc(FILE *fp1);

//patient structure
struct patient{
char name[150];
char fname[150];
int age;
char gender[150];
char disease[150];
int ad, am, ay;
int dd, dm, dy;
char ward[150];
char tests[150];
};
struct patient p ;

//doctor structure
struct doctor{
int  id;
char dname[150];
int age;
char gender[10];
char ward[150];
char timings[150];
};
struct doctor d;


int password ();         // get password



main()
{     
       FILE *fp1,*ft1;
       FILE *fp,*ft;
       int size_pat;
       int size_doctor;
       size_pat=sizeof(p);
       size_doctor=sizeof(d);
       char patname[40];
       char docname[40];
       int choice;
       char another;
       int choice1;
       char another1;
       char record;
       
       
       
        
       fp=fopen("pat.dat","rb+");
       if (fp==NULL)
       {
                    fp=fopen("pat.dat","wb+");
                    if (fp==NULL)                      /*patient files*/
                    {
                                 puts("Cannot Open file");
                    }
       } 
      
      
       fp1=fopen("doctor.dat","rb+");
       if (fp1==NULL)
       {
                    fp1=fopen("doctor.dat","wb+");         /*doctor files*/
                    if (fp1==NULL)
                    {
                                 puts("Cannot Open file");
                    }
       }
      
      system("color 3f");   //for background color
    
    fflush (stdin);
      
      // main menu
      printf("WELCOME TO HOSPITAL MANAGEMENT SYSTEM");
      printf("\npress D for Doctor record\npress P for student record\npress 0 to exit\n");
      printf("Your Choice:");
      scanf("%c",&record);
      
      switch(record)

      
{
              case 'P':
              case 'p': 
                       char ano;
                  ano='y';
                  while(ano=='y'){ 

                    while ( 1 )
                          {    //sub menu for patient
                          printf("\n\nMenu for your selection\n");     
                          printf ( "\n1. Add Records" ) ;
                          printf ( "\n2. Display Records" ) ;
                          printf ( "\n3. Modify/Edit Records" ) ;
                          printf ( "\n4. Delete Records" ) ;
                          printf ( "\n5. Search" ) ;
                          printf ( "\n6. Previous screen" ) ;
                          printf("\n\n Enter your choice=");
                          fflush ( stdin ) ;
                          scanf("%d",&choice);
                          if (choice <0 || choice > 6)
        { 
           printf ("You enter wrong choice.\n");
        } 
                          switch(choice)
                          
                          { // calling functions of patient menu
                                        case 1:
                                             add_patient(fp);
                                             break;
                                
                                        case 2:
                                             
                                             display_patient(fp);
                                             break;
        
                                        case 3:
                                             modify_patient(fp);                     
                                              break;
             
                   
                                        case 4:
                                             if (password () == 1)
                                             del_patient(fp);
                                             break;
                                        case 5:
                                             search_pat(fp);
                                             break;     
                                        
                                        case 6:
                                               { // to go previous
                                               main();
                                               fclose ( fp ) ;
                                               getch();
                                                return 0;
                                                }
                                                
                                                                                  
                     }
                     ano=getch();}
}// patient menu ends


                       case 'D':
                       case 'd':
            {
                       char ano1;
                       ano1='y';
                  while(ano1=='y'){ 
                                 
                                 while ( 1 )
                                 {   //doctor sub menu
                                 printf("\n\nMenu for your selection\n");     
                                 printf ( "\n1. Add Records" ) ;
                                 printf ( "\n2. List Records" ) ;
                                 printf ( "\n3. Modify Records" ) ;
                                 printf ( "\n4. Delete Records" ) ;
                                 printf ( "\n5. Search Records" ) ;
                                 printf ( "\n6. Previous Screen" ) ;
                                 printf("\n\n Enter your choice=");
                                 fflush ( stdin ) ;
 
                                 scanf("%d",&choice1);
                          if (choice1 <0 || choice1 > 6)       
        { 
           printf ("You enter wrong choice.\n");
        } 
                                 switch(choice1)
                                 {              //calling functions for doctor menu
                                                case 1:
                                                     doc_add(fp1);
                                                     break;
                                             
                                                case 2:
                                                     doc_display(fp1);
                                                     break;
                                     
                                                case 3:
                                                     doc_modify(fp1);     
                                                     break;

                                                case 4:
                                                     del_doc(fp1);         
                                                     break;
                                                case 5:
                                                     search_doc(fp1); 
                                                     break;    
   
                                               case 6:
                                                    {// to go previous
                                                    main();
                                                     fclose ( fp1 ) ;
                                                     getch();
                                                     exit(1) ;
                                                     }
                                  }} ano1=getch();
                                  break;// doctor menu breaks
                    }
                    
                    
                                                  case 0:
                                                  {// to exit from main menu
                                                     fclose ( fp1 ) ;
                                                     getch();
                                                     exit(1) ;
                                                     }
}
}
return 0;

}         



                                                
                                                

void add_patient(FILE *fp)
{
     int size_pat;
     size_pat=sizeof(p);
     char another;
     fseek(fp,0,SEEK_END);
     another='y';
             while(another=='y')
         {
                                printf("\nName =");
                                scanf("%s",p.name);
                                fflush(stdin);
                                printf("\nFather name=");
                                scanf("%s",p.fname);
                                fflush(stdin);
                                printf("\nage=");
                                scanf("%d",&p.age);
                                fflush(stdin);
                                printf("\nGender=");
                                scanf("%s",p.gender);
                                fflush(stdin);
                                printf("\nDisease=");   
                                scanf("%s",p.disease);
                                fflush(stdin);
                                printf("\nEnter Date of Admit\n");
                                printf("dd:");
                                scanf("%d",&p.ad);
                                fflush(stdin);
                                printf("mm:");
                                scanf("%d",&p.am);
                                fflush(stdin);
                                printf("yyyy:");
                                scanf("%d",&p.ay);
                                fflush(stdin);
                                printf("\nEnter Date of Discharg\n");
                                printf("dd:");
                                scanf("%d",&p.dd);
                                fflush(stdin);
                                printf("mm:");
                                scanf("%d",&p.dm);
                                fflush(stdin);
                                printf("yyyy:");
                                scanf("%d",&p.dy);
                                fflush(stdin);
                                printf("\nWard No.=");
                                scanf("%s",p.ward);
                                fflush(stdin);
                                printf("\nTests=");
                                scanf("%s",p.tests);
                                fflush(stdin);
                                
                                fwrite(&p,size_pat,1,fp);
                                printf("\nadd another record(y/n):");   
                                fflush(stdin);
                                another=getche();
                               }              
    
    
    }




void display_patient(FILE *fp)
{
     int size_pat;
     size_pat=sizeof(p);
     char another;
     
          {
                   rewind(fp);
                   another='y';
                   while(fread(&p,size_pat,1,fp)==1)
                   {
                    
                         printf("\n----------------------------------------------------------\n");
                         printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                         printf("\n----------------------------------------------------------\n");
                    
                   } printf("\nPress Any key to Continue....");

                   getch();
                                                 
           }        
}




void modify_patient(FILE *fp)
{
                
       int size_pat;
       size_pat=sizeof(p);
       char another;
       char patname[40];                  
                
                
                  {
             another='y';
             while(another=='y')
             {//while start
             printf("\nenter name to modify its record:");
             fflush ( stdin ) ;
             gets(patname);
             rewind(fp);
             while(fread(&p,size_pat,1,fp)==1)
             {
             if ( strcmp ( p.name, patname ) == 0 )
             {
                                
                                printf("\nNew name=");
                                gets(p.name);
                                fflush(stdin); 
                                printf("\nFather name=");
                                scanf("%s",p.fname);
                                fflush(stdin); 
                                
                                printf("\nnew age=");
                                scanf("%d",&p.age);
                                fflush(stdin);
                                printf("\ngender=");
                                scanf("%s",p.gender);
                                fflush(stdin);
                                printf("\nnew disease=");   
                                scanf("%s",&p.disease);
                                fflush(stdin);
                                 printf("\nEnter New Date of Admit");
                                printf("dd:");
                                scanf("%d",&p.ad);
                                fflush(stdin);
                                printf("mm:");
                                scanf("%d",&p.am);
                                fflush(stdin);
                                printf("yyyy:");
                                scanf("%d",&p.ay);
                                
                                fflush(stdin);
                                printf("\nEnter New Date of Discharg");
                                printf("dd:");
                                scanf("%d",&p.dd);
                                fflush(stdin);
                                printf("mm:");
                                scanf("%d",&p.dm);
                                fflush(stdin);
                                printf("yyyy:");
                                scanf("%d",&p.dy);
                                fflush(stdin);
                                printf("\nnew ward=");
                                scanf("%s",p.ward);
                                fflush(stdin);
                                printf("\nnew tests");
                                scanf("%s",p.tests);
                                fflush(stdin);
                                fseek(fp,-size_pat,SEEK_CUR);
                                fwrite(&p,size_pat,1,fp);
                                
             }
             }
             printf("\nmodify another(y/n):");
             fflush ( stdin ) ;
             another=getche();
             
             }}}
             
             
             
void del_patient(FILE *fp)
{
     FILE *ft;
     int size_pat;
     size_pat=sizeof(p);
     char another;
     char patname[40];
     
     
     another = 'Y' ;
     while ((another=='Y') || (another=='y'))
     {
     printf ( "\nEnter name:" ) ;
     fflush ( stdin ) ;
     gets(patname) ;
     ft = fopen ( "temp.dat", "wb" ) ;
     rewind ( fp ) ;
     while ( fread ( &p, size_pat, 1, fp ) == 1 )
     {
           if ( strcmp ( p.name, patname ) != 0 )
            fwrite ( &p, size_pat, 1, ft ) ;
      }
      fclose ( fp ) ;
      fclose ( ft ) ;
      remove ( "pat.dat" ) ;
      rename ( "temp.dat", "pat.dat" ) ;
      fp = fopen ( "pat.txt", "rb+" ) ;
      printf ( "\nDelete Another Record (Y/N):" ) ;
      fflush ( stdin ) ;
      another = getche( ) ;
      }//main while ends

}        
             


void doc_add(FILE *fp1)
{
     int size_doctor;
     size_doctor=sizeof(d);
     char another1;
             {
             fseek(fp1,0,SEEK_END);
             another1='y';
             while(another1=='y')
         {
                                printf("\nid=");
                                fflush(stdin);
                                scanf("%d",&d.id);
                                fflush(stdin);
                                printf("\nname=");
                                gets(d.dname);
                                fflush(stdin); 
                                printf("\nage=");
                                scanf("%d",&d.age);
                                fflush(stdin); 
                                printf("\ngender=");
                                gets(d.gender);
                                fflush(stdin);
                                printf("\nward=");   
                                gets(d.ward);
                                fflush(stdin);
                                printf("\ntimings=");   
                                gets(d.timings);
                                fflush(stdin);
                                fwrite(&d,size_doctor,1,fp1);
                                printf("\nadd another record(y/n):");   
                                fflush(stdin);
                                another1=getche();
                               }
                               
                                }
     
     
     }
     
     
void doc_display(FILE *fp1)
     {    
          int size_doctor;
          size_doctor=sizeof(d);
          char another1;
           {
              rewind(fp1);
              another1='y';
              
              while(fread(&d,size_doctor,1,fp1)==1)
              {
                   printf("\n----------------------------------------------------------\n");                                
              printf("ID: %d\t Name: %s\t Age: %d\n Gender: %s\t Ward: %s\t Timings: %s",d.id,d.dname,d.age,d.gender,d.ward,d.timings);
                   printf("\n----------------------------------------------------------\n");                                                                           
              } printf("\nPress Any key to Continue....");

              getch();
                                     
           }
          
     }
          
          
          
          
void doc_modify(FILE *fp1)
{    
       int size_doctor;
       size_doctor=sizeof(d);
       char docname[40];             
       char another1;
                {
             another1='y';
             while(another1=='y')
             {//while start
             printf("\nenter name to modify its record:");
             fflush ( stdin ) ;
             gets(docname);
             rewind(fp1);
             while(fread(&d,size_doctor,1,fp1)==1)
             {
             if ( strcmp ( d.dname, docname ) == 0 )
             {
                               printf("\nnew id=");
                                fflush(stdin);
                                scanf("%d",&d.id);
                                fflush(stdin);
                                printf("\nnew name=");
                                gets(d.dname);
                                fflush(stdin); 
                                printf("\nnew age=");
                                scanf("%d",&d.age);
                                fflush(stdin); 
                                printf("\n gender=");
                                scanf("%s",&d.gender);
                                fflush(stdin);
                                printf("\nnew ward=");   
                                gets(d.ward);
                                fflush(stdin); 
                                printf("\n timings=");
                                scanf("%s",&d.timings);
                                fflush(stdin);
                                fseek(fp1,-size_doctor,SEEK_CUR);
                                fwrite(&d,size_doctor,1,fp1);
             }
             }
             printf("\nmodify another(y/n):");
             fflush ( stdin ) ;
             another1=getche();
             }//main while ends
             }
               
}
               
               
               
               
void del_doc(FILE *fp1)
{
     FILE *ft1;
     int size_doctor;
     size_doctor=sizeof(d);
     char docname[40];             
     char another1;
                    
     another1 = 'Y' ;
     while ((another1=='Y') || (another1=='y'))
     {
     printf ( "\nEnter name:" ) ;
     fflush ( stdin ) ;
     gets(docname) ;
     ft1 = fopen ( "temp1.dat", "wb+" ) ;
     rewind ( fp1 ) ;
     while ( fread ( &d, size_doctor, 1, fp1 ) == 1 )
           {
           if ( strcmp ( d.dname, docname ) != 0 )
           fwrite ( &d, size_doctor, 1, ft1 ) ;
           }
           fclose ( fp1 ) ;
           fclose ( ft1 ) ;
           remove ( "doctor.dat" ) ;
           rename ( "temp1.dat", "doctor.dat" ) ;
           fp1 = fopen ( "doctor.txt", "rb+" ) ;
           printf ( "\nDelete Another Record (Y/N):" ) ;
           fflush ( stdin ) ;
           another1 = getche( ) ;
           }// main while ends
}



// get password
int password ()
{
    char pass[] = "basit";
    char str[10];
    // get input
    fflush (stdin);
    printf ("\nEnter Password: ");
    gets (str);
    
            
            
    // comparing
    if (strcmp (str, pass) == 0)
       return 1;
    printf ("You enter wrong password.\n"); 
    return 0;
}



void search_pat(FILE *fp)
{                
       int size_pat;
       size_pat=sizeof(p);
       char another;
       int age;
       char gender[30];
       char disease[30];
       char admit[30];
       char discharg[30];
       char ward[30];          
       int selection;
           
 {
             another='y';
             while(another=='y')
             {//while start
             
                  rewind(fp);
                  printf("Select your Option");
                  printf("\n[1] For search by  age");
                  printf("\n[2] For search by gender");
	              printf("\n[3] For search by disease");
	              printf("\n[4] For search by date of admit");
	              printf("\n[5] For search by date of discharg");
                  printf("\n[6] For search by Ward No.");

                     while(fread(&p,size_pat,1,fp)==1)
                    {
                        printf("\nEnter your selection :");
                        scanf("%d",&selection);
                        
                        if(selection==1)
                        {
                         (p.age==age) == 0;
                           {
                             printf("\nenter age to find record:");
                             fflush ( stdin ) ;
                             scanf("%d",&age);
                             fseek(fp,-size_pat,SEEK_CUR);
		 	                 printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                             getch();
                             break;            
                             }
		                  }//1st selection ends



	                   if(selection==2)
                        {
                         printf("\nenter gender to find record:");
                         fflush ( stdin ) ;
                         scanf("%s",gender);
                         strcmp ( p.gender, gender) == 0 ;
                           {
                            fseek(fp,-size_pat,SEEK_CUR);
		 	                printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                            getch();
	                        break;            
                           }
		                }//2nd selection ends

	                   if(selection==3)
                        {
                          printf("\nenter disease to find record:");
                          fflush ( stdin ) ;
                          scanf("%s",disease);
                          strcmp ( p.disease, disease) == 0;
                           {
                             fseek(fp,-size_pat,SEEK_CUR);
                             printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                             getch();
	                         break;            
                           }
		                }//3rd selection ends


	if(selection==4)
                       /* {
                                
                                printf("\nenter date of admit to find record(dd mm yyyy):");
             fflush ( stdin ) ;
             scanf("d",admit);
                        

	strcmp ( p.datea, admit) == 0 ;

             {

                                fseek(fp,-size_pat,SEEK_CUR);
		 	 printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                   getch();
	
                   break;            
                                
             }
		}*/


	if(selection==5)
           /*             {
                                printf("\nenter date of discharg to find record:");
             fflush ( stdin ) ;
             scanf("%s",discharg);
                        
	strcmp ( p.dated, discharg) == 0;
             {

                                fseek(fp,-size_pat,SEEK_CUR);
		 	 printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                   getch();
	
                   break;            
                                
             }
		}
*/

	                  if(selection==6)
                        {
                         printf("\nenter ward No. to find record:");
                         fflush ( stdin ) ;
                         scanf("%s",ward);
                         strcmp ( p.ward, ward) == 0;
                          {
                            fseek(fp,-size_pat,SEEK_CUR);
                            printf("Name: %s\t\tFather Name: %s\nAge: %d\t\t\tGender: %s\nDisease: %s\nDate Of Admit: %d-%d-%d\tDate OF Discharg: %d-%d-%d\nWard: %s\t Test: %s",p.name,p.fname,p.age,p.gender,p.disease,p.ad,p.am,p.ay,p.dd,p.dm,p.dy,p.ward,p.tests);
                            getch();
	                        break;            
                            }
                         }//6th selection ends

             }//nested while ends
             printf("\nsearch another(y/n):");
             fflush ( stdin ) ;
             another=getche();
             
             }//main while ends

}


}


// search doctor record
void search_doc(FILE *fp1)
{                
       int size_doctor;
       size_doctor=sizeof(d);
       char another1;
       char docname[40];   
       int selection;      
       char ward1[1];      
       char timings[100];   
        {
            another1='y';
             while(another1=='y')
             {
             
             rewind(fp1);
             
            printf("Select your Option");
            printf("\n[1] For assigned wards");
            printf("\n[2] For search by timings");                                      
                    
             while(fread(&d,size_doctor,1,fp1)==1)
             {
                printf("\nEnter your selection :");
                scanf("%d",&selection);
            
                        if(selection==1)
                        {                                   
                             strcmp ( d.ward, ward1 ) == 0 ;
                           {
                                printf("\nenter ward number to find record:");
                                fflush ( stdin ) ;
                                scanf("%s",ward1);         
                                fseek(fp1,-size_doctor,SEEK_CUR);
	                            printf("\n%d\t%s\t%d\t%s\t%s\t%s",d.id,d.dname,d.age,d.gender,d.ward,d.timings);
                                getch();
	
                              break;
                            }
                         }
                                
                        if(selection==2)
                        {                                   
                           strcmp ( d.timings, timings) == 0 ;
                            {                 
                                 printf("\nenter timings to find record:");
                                 fflush ( stdin ) ;
                                 scanf("%s",timings);
                                 fseek(fp1,-size_doctor,SEEK_CUR);
                                 printf("\n%d\t%s\t%d\t%s\t%s\t%s",d.id,d.dname,d.age,d.gender,d.ward,d.timings);
                                 getch();
	                             break;  
                            }
                        }
                                
                                        
             printf("\nsearch another(y/n):");
             fflush ( stdin ) ;
             another1=getche();
             }
            }//main while loop ends
               }          
 }
             

