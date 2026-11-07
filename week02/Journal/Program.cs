//Creativiuy : I added more entries than were required. 
// I used try and catch functionality between lines 46 and 75 
// so the program keeps working in case of certain errors. 
//  I created a Menu class to keep the Program class clean.

using System;
using Microsoft.VisualBasic;

class Program
{   
    static void Main(string[] args)
    {   
        Menu menuObj = new Menu();
        menuObj.RunSystem();
    }
}