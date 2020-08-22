//Simple C++ program to encrypt and decrypt a string
#include <conio.h>
#include <windows.h>
#include <iostream>

using namespace std;



 int con()
{
   int i, x;
   char str[100];


do 
{
	
system("cls");
  cout << "\t Sub menu with constant key:\n";
  cout<<"-----------------------------------------\n";
   cout<<"\n";
   cout << "Please enter a string:\t";
   cin >> str;

   cout << "\nPlease choose following options:\n";
   cout << "1 = Encrypt the string.\n";
   cout << "2 = Decrypt the string.\n";
   cin >> x;

   //using switch case statements
   switch(x)
   {
   	
      //first case for encrypting a string
      case 1:
         for(i = 0; (i < 100 && str[i] != '\0'); i++)
            str[i] = str[i] + 3; //the key for encryption is 3 that is added to ASCII value

         cout << "\nEncrypted string: " << str << endl;
         break;

      //second case for decrypting a string
      case 2:
         for(i = 0; (i < 100 && str[i] != '\0'); i++)
         str[i] = str[i] - 3; //the key for encryption is 3 that is subtracted to ASCII value

      cout << "\nDecrypted string: " << str << endl;
      break;

      default:
         cout << "\nInvalid Input !!!\n";
   }
   
   cout << "\n to repeat again please type '  s ' !!!\n";  
}
   while(getche()=='s');
}




int v_keys ()
{
   int i, x;
   char str[100];
int key;

do 
{
system("cls");
 cout << "Sub menu with variable key:\n";
  cout<<"-----------------------------------------\n";
  
   cout << "Please enter a string:\t";
   cin >> str;
   cout << "Please enter a variable key \t";
   cin >>key ;

   cout << "\nPlease choose following options:\n";
   cout << "1 = Encrypt the string.\n";
   cout << "2 = Decrypt the string.\n";
   cin >> x;

   //using switch case statements
   switch(x)
   {
   	
      //first case for encrypting a string
      case 1:
         for(i = 0; (i < 100 && str[i] != '\0'); i++)
            str[i] = str[i] + key; //the key for encryption is 3 that is added to ASCII value

         cout << "\nEncrypted string: " << str << endl;
         break;

      //second case for decrypting a string
      case 2:
         for(i = 0; (i < 100 && str[i] != '\0'); i++)
         str[i] = str[i] - key; //the key for encryption is 3 that is subtracted to ASCII value

      cout << "\nDecrypted string: " << str << endl;
      break;

      default:
         cout << "\nInvalid Input !!!\n";
   }
   
   cout << "\n to repeat again please type '  s ' !!!\n";  
}
   while(getche()=='s');
   return 0;
}

main()
{
	int y;
	do
	{
	
	system("cls");

   cout << "Main menu :\n";
   cout<<"-----------------------------------------\n";
   cout << "\nPlease choose following options:\n";
   cout << "1 = Constant key.\n";
   cout << "2 =  Variable key.\n";
   cin >> y;
   switch(y)
   {
   	
   	case 1: 
   	con();
   	break;
   	case 2: 
   	v_keys();
   	break;
   	default : 
   	cout<<"invalid input \n";
   	
   }
	  	cout<<"to repeat main menu please type:   'm'   \n";
}
while(getche()=='m');
}
