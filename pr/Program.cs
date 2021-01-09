/*
 * Created by SharpDevelop.
 * User: mahdii
 * Date: 10/27/2020
 * Time: 2:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace pr
{
	class Program
	{
		public static void Main(string[] args)
		{
            //Student Database
            person[] database = new person[150];


            //Student's position in the database
            int studentStatus = 0; 

            //Condition for the program to stay running
            bool maineMenu_isalive = true;


            //Main menu         
            while (maineMenu_isalive)   
			{
				try 
				{
				int select = Convert.ToInt32( menu());			
					switch (select)
						{
						case 1: //Add student
							{
								Console.Clear();
								person adds = addStudent();
								database[studentStatus] = adds;
                                studentStatus++;
								Console.ReadKey();
								break;
						   	}
						case 2: //Show student
							int numberStudent = 0; //The number opposite the name in the list
                            {
								if (database[0] == null )
								{
									Console.WriteLine("\nNo information was entered from the students");
									Console.ReadKey();
								}
								else
								{
									Console.Clear();
									foreach(person student in database)
									{
                                        numberStudent = numberStudent + 1;
										Console.WriteLine(numberStudent + ") full name : " + student.name + " " + student.family );
									}
					
									Console.ReadKey();
								}
								break;
							}
						case 3: //exit
							{
								Console.Clear();
                                maineMenu_isalive = false;
								break;
						    }	
						default: //Wrong option
                            {
                                Console.Clear();
								Console.WriteLine("The entered option is incorrect");
								Console.ReadKey();
								break;
							}
				    	}	  
			    }
				catch (NullReferenceException)
				{
					Console.WriteLine("\npleas enter number of student : ");
					int studentSelection = showStdOption();
					bool showStdOption_isaliv = true;
					while(showStdOption_isaliv)
						{
							try
							{
								person selectedSudent = database[studentSelection];
								Console.Clear();
								Console.WriteLine("name: " + selectedSudent.name + "\nfamily: " + selectedSudent.family + "\nage: " + selectedSudent.age +"\naverage: " + selectedSudent.average);
                                showStdOption_isaliv = false;
								Console.ReadKey();
								
							}
							catch
							{
								Console.WriteLine("\nEnter only the number in front of the student's name");
								Console.ReadKey();
                                showStdOption_isaliv = false;	
							}
						}
				}
				catch
				{
					Console.WriteLine("The entered option is incorrect");
					Console.ReadKey();
				}
			}
		}



        //Method of menu (1-add student   2-show student   3-exit)
        static string menu()
		{
			Console.Clear();
			Console.WriteLine("Enter the desired option number \n1) add student \n2) show students \n3) exite \n: ");
			string menu_input = Console.ReadLine();
			return menu_input;
		}




        //Method of add student in database
        static person addStudent()
		{
	
			Console.Write("enter student name : ");
			string name = Console.ReadLine();
			Console.Write("enter student family : ");
			string family = Console.ReadLine();
			Console.Write("enter student age : ");
			string age = Console.ReadLine();
			Console.Write("enter student average : ");
			string average = Console.ReadLine();
			person student = new person(name,family,age,average);
			return student;
		}



        //Method of show student 
        static int showStdOption()
		{
			bool showStdOption_Isalive = true;
			int showStdOption_Input = 0;
			while(showStdOption_Isalive)
			{
				try
				{
                    showStdOption_Input = Convert.ToInt32(Console.ReadLine());
                    showStdOption_Input = showStdOption_Input - 1;
                    showStdOption_Isalive = false;
				}
				catch
				{
					Console.WriteLine("\nEnter only the number in front of the student's name");
					Console.WriteLine("pleas enter number of student : ");		
				}
				
				
			}
			return showStdOption_Input;
		}
	}
}