using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkgmail2
{
    class Student
    {
        
        //----------------First Name--------------------
        internal bool setName(string name, out string errorMsg)
        {

            //NOW check if name is empty or null

            if (name == "" || name == " " || name == null)
            {

                errorMsg = "First Name can not be empty or null, please enter the first name ";
                return false;

            }

            //check that name is 2 chars long 
            if (name.Length < 2)
            {
                errorMsg = "First Name has to be at least 2 characters long, please enter First name again ";
                return false;
            }


            //check that name has vowel or y 
            if ((!name.Contains('a')) && (!name.Contains('e')) && (!name.Contains('i')) && (!name.Contains('o')) && (!name.Contains('u')) && (!name.Contains('y')))
            {

                errorMsg = "First Name must contain Vowel or Y, please enter First name again ";
                return false;
            }

            //convert string to array of chars (characters)
            char[] nameCharArray = name.ToCharArray();

            

            //check if first character is uppercase
            char firstChar = name.ToCharArray()[0];

            if (!char.IsUpper(firstChar))
            {
                errorMsg = "First Name has to start with capital(uppercase) letter, please enter First name again ";
                return false;
            }


            for (int i = 1; i < name.Length; ++i)
            {
                char otherChars = name.ToCharArray()[i];

                //Cant contain numbers
                if (char.IsNumber(otherChars))
                {
                    errorMsg = "First Name cant have numbers, please enter First name again ";
                    return false;
                }

                //All characters except first one must be in lowercase
                else if (!char.IsLower(otherChars))
                {
                    errorMsg = "First Name has to have lowercase letters, exept first one, please enter First name again ";
                    return false;
                }

                //Name cant have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg = "First Name cant have special characters, please enter First name again ";
                    return false;
                }

            }

            errorMsg = "";
            return true;
        }





        //------------------------Second Name---------------------------------------
        internal bool setLastName(string name1, out string errorMsg1)
        {

            //NOW check if name is empty or null

            if (name1 == "" || name1 == " " || name1 == null)
            {

                errorMsg1 = "Last Name can not be empty or null, please enter Last name ";
                return false;

            }

            //check that name is 2 chars long 
            if (name1.Length < 2)
            {
                errorMsg1 = "Last Name has to be at least 2 characters long, please enter Last name again ";
                return false;
            }


            //check that name has vowel or y 
            if ((!name1.Contains('a')) && (!name1.Contains('e')) && (!name1.Contains('i')) && (!name1.Contains('o')) && (!name1.Contains('u')) && (!name1.Contains('y')))
            {

                errorMsg1 = "Last Name must contain Vowel or Y, please enter Last name again ";
                return false;
            }

            //convert string to array of chars (characters)
            char[] nameCharArray = name1.ToCharArray();

            //NOW check that Name contains Only letters. Numbers, spaces, special characters etc. are not allowed
            //"Name must contain only letters. Numbers, spaces, special characters etc. are not allowed"

            //check if first character is uppercase
            char firstChar = name1.ToCharArray()[0];

            if (!char.IsUpper(firstChar))
            {
                errorMsg1 = "Last Name has to start with capital(uppercase) letter, please enter Last name again ";
                return false;
            }


            for (int i = 1; i < name1.Length; ++i)
            {
                char otherChars = name1.ToCharArray()[i];

                //Cant contain numbers
                if (char.IsNumber(otherChars))
                {
                    errorMsg1 = "Last Name cant have numbers, please enter Last name again ";
                    return false;
                }

                //All characters except first one must be in lowercase
                else if (!char.IsLower(otherChars))
                {
                    errorMsg1 = "Last Name has to have lowercase letters, exept first one";
                    return false;
                }

                //Name cant have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg1 = "Last Name cant have special character, please enter Last name again ";
                    return false;
                }

            }

            errorMsg1 = "";
            return true;
        }





        public string mail;

        //---------------------------Email-------------------------------------
        internal bool setMail(string name2, out string errorMsg2)
        {

            //NOW check if mail is empty or null

            if (name2 == "" || name2 == " " || name2 == null)
            {

                errorMsg2 = "Mail can not be empty or null, please enter Mail";
                return false;

            }

            //check that mail is 5 chars long 
            if (name2.Length < 5)
            {
                errorMsg2 = "Mail has to be at least 5 characters long, please enter Mail again ";
                return false;
            }


            //check that mail has @ or dot 
            if ((!name2.Contains('@')))
            {

                errorMsg2 = "Mail must contain @ sign, please enter Mail again";
                return false;
            }



            //Check if mail has .com, ba or edu domain
            if ((!name2.EndsWith(".com")) && (!name2.EndsWith(".ba")) && (!name2.EndsWith(".edu")) && (!name2.EndsWith(".edu.ba")))
            {

                errorMsg2 = "Mail must contain .com, .ba, .edu or .edu.ba domain, please enter Mail again ";
                return false;
            }
            //convert string to array of chars (characters)
            //char[] nameCharArray = name2.ToCharArray();

            //NOW check that Name contains Only letters. Numbers, spaces, special characters etc. are not allowed
            //"Name must contain only letters. Numbers, spaces, special characters etc. are not allowed"


            //char firstChar = name2.ToCharArray()[0];

            mail = name2;

            errorMsg2 = "";
            return true;
        }


        



        //----------------------Location-----------------------------------
        internal bool setLocation(string name3, out string errorMsg3)
        {

            //NOW check if name is empty or null

            if (name3 == "" || name3 == " " || name3 == null)
            {

                errorMsg3 = "Location can not be empty or null, please enter Location";
                return false;

            }

            //check that name is 2 chars long 
            if (name3.Length < 2)
            {
                errorMsg3 = "Location has to be at least 2 characters long, please enter Location again ";
                return false;
            }


            //check that name has vowel or y 
            if ((!name3.Contains('a')) && (!name3.Contains('e')) && (!name3.Contains('i')) && (!name3.Contains('o')) && (!name3.Contains('u')) && (!name3.Contains('y')))
            {

                errorMsg3 = "Location Name must contain Vowel or Y, please enter Location again ";
                return false;
            }

            //convert string to array of chars (characters)
            char[] nameCharArray = name3.ToCharArray();


            //check if first character is uppercase
            char firstChar = name3.ToCharArray()[0];

            if (!char.IsUpper(firstChar))
            {
                errorMsg3 = "Location Name has to start with capital(uppercase) letter, please enter Location again ";
                return false;
            }


            for (int i = 1; i < name3.Length; ++i)
            {
                char otherChars = name3.ToCharArray()[i];



                //All characters except first one must be in lowercase
                if (!char.IsLower(otherChars))
                {
                    errorMsg3 = "Location Name has to have lowercase letters, exept first one, please enter Location again";
                    return false;
                }

                //Location Name cant have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg3 = "Location Name cant have special characters";
                    return false;
                }

            }

            errorMsg3 = "";
            return true;
        }


        public double finalni;


        //----------------------Result---------------------------------
        internal bool setResult(string name4, out string errorMsg4)
        {

            //NOW check if result is empty or null

            if (name4.ToString() == "" || name4.ToString() == " " || name4.ToString() == null)
            {

                errorMsg4 = "Test Result can not be empty or null, if student didnt work test please enter -1";
                return false;

            }


            //convert string to array of chars (characters)
            char[] nameCharArray = name4.ToCharArray();

            //NOW check that Name contains Only letters. Numbers, spaces, special characters etc. are not allowed
            //"Name must contain only letters. Numbers, spaces, special characters etc. are not allowed"

            char firstChar = name4.ToCharArray()[0];




            for (int i = 1; i < name4.Length; ++i)
            {
                char otherChars = name4.ToCharArray()[i];

                //Cant contain letters
                if (char.IsLetter(otherChars))
                {
                    errorMsg4 = "result cant have letters";
                    return false;
                }


                //Name cant have special characters
                else if (!char.IsLetterOrDigit(otherChars))
                {
                    errorMsg4 = "Result cant have special characters";
                    return false;
                }

            }

            //Console.WriteLine("Enter number of tests: ");
            //string input4 = Console.ReadLine();

            //setResult(input4);

            double[] arr = new double[10];
            int[] ukupno = new int[10];

            for (int k = 1; k <= Convert.ToInt32(name4); ++k)
            {

                //OVO TREBA DORADITI - NIJE MI SE DALO
                Console.WriteLine("Enter Grade for test " + k + ": ");

                try
                {
                    arr[k] = Convert.ToDouble(Console.ReadLine());
                    //ukupno[k] += arr[k];

                }
                catch
                {
                    Console.WriteLine("You enterd letters insted of numbers; YOU FAIL, buhahaha");
                    break;
                }


            }

            Console.WriteLine("\n\n\n Student test results: ");

            for (int i = 1; i <= Convert.ToInt32(name4); i++)
            {
                Console.WriteLine("\n Results for test" + i + " are: {0} ", arr[i]);
            }

            finalni = arr.Sum() / Convert.ToDouble(name4);

            Console.WriteLine("\n\n   Total avarage score is " + finalni);
            errorMsg4 = "";
            return true;
        }
        


        //Checking are students equal by email


       public bool CompareResult(string email, string email2)
        {
            if (email == email2)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
