using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Encryption_Decryption
{
    class Program
    {
   class CaesarCipher
        {
           string input;
           int key;

           char[] inputIntoArray;
            int check;
           char ch;
           string output;

    public void getData()
            {
               Console.WriteLine(" Enter a string : ");
               input = Console.ReadLine();

            inputIntoArray = input.ToCharArray();

              Console.WriteLine(" Enter a key: ");
               key = int.Parse(Console.ReadLine());

            }

           public void Encrypt()
            {  
             for (int i = 0; i<inputIntoArray.Length; i++)
          {

               ch = inputIntoArray[i];
               check = (int)ch;

              if (check > 64 && check < 91) 
                    {
                       ch = (char)(ch + key);


                   if (ch>'Z')
                        {
                     ch = (char)(ch - 26);
                        }//end of if

            else if (ch<'A')
                        {
                             ch = (char)(ch + 26);

                        }//end of nested else if
                  else
                        {
                              ch = ch;
                        }//end of nested else
                        inputIntoArray[i] = ch;

                    }
                            else if (check > 96 && check < 123)
                    { 
                             ch=(char)(ch + key);
                              if (ch>'z')
                        {
                           ch = (char)(ch - 26);
                        }//end of nested if
                      else if (ch<'a')
                        {
                            ch = (char)(ch + 26);

                        }//end of nested else if
                        else
                        {
                             ch = ch;
                        }//end of nested else if
                           inputIntoArray[i] = ch;

                    }
                        else
                    {
                         inputIntoArray[i] = ch;
                    }//end of else

                }//end of for

        foreach (char item in inputIntoArray)
                {
                      Console.Write(item.ToString());
                }//end of foreach

            }//end of encrypt()

                  public void Decrypt()
            {
              for (int i = 0; i<inputIntoArray.Length; i++)
                {
                      ch = inputIntoArray[i];
                      check = (int)ch;

                       if (check > 64 && check < 91) 
                    {
                          ch = (char)(ch - key);


                        if (ch>'Z')
                        {
                            ch = (char)(ch - 26);
                        }//end of nested if

                        else if (ch<'A')
                        {
                        ch = (char)(ch + 26);

                        }//end of nested else if
                      else
                        {
                               ch = ch;
                        }//end of nested else
                    inputIntoArray[i] = ch;

                    }
                          else if (check > 96 && check < 123)
                    { 
                      ch=(char)(ch - key);
                       if (ch>'z')
                        {
                         ch = (char)(ch - 26);
                        }//end of nested if
                         else if (ch<'a')
                        {
                           ch = (char)(ch + 26);

                        }//end of nested else if
            else
                        {
                              ch = ch;
                        }//end of nested else
                        inputIntoArray[i] = ch;

                    }//end of if
               else
                    {
inputIntoArray[i] = ch;
                    }//end of else

                }//end of for

                 Console.WriteLine("\n Decrypted result is : \n");

           foreach (char item in inputIntoArray)
                {
                    Console.Write(item.ToString());
                }// end of for each

            }//end of decrypt()


                  public IEnumerable<char> intinputIntoArray { get; set; }

                  public IEnumerable<char> ininputIntoArray { get; set; }
        }//end of ceaserCipher


             static void Main()
               {
                   CaesarCipher obj = new CaesarCipher();
                   obj.getData();
                   obj.Encrypt();
                   obj.Decrypt();
                   Console.ReadLine();


        }
    }
}
