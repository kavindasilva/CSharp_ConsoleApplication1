using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using static ConsoleApplication1.std;

namespace ConsoleApplication1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //new ProgramXX().ain(null);
            new std();
            new std(2);

            Console.WriteLine("end of program");
            Console.ReadLine();
        }
    }

    class ProgramXX
    {
        //public int x = 0;
        public void ain(string[] args)
        {
            //new Program();
            //Program.Program(
            //initialize variables, user inputs, word list and scanner
            String[] wlist = {"cat", "dog", "donkey", "monkey", "bird", "lion", "desk", "chair", "table", "plane", "train"};
            String rword;
            char guess;
            char[] guesses = {'x', 'x', 'x', 'x', 'x', 'x'};
            int usr_in, wno;
            //Scanner no = new Scanner(System.in);

		    Console.WriteLine("You are given 10 chances to guess the correct word. Use only lower case letters");
		    //select random word from list
            Random rnd= new Random();
            wno = rnd.Next(0,11);

            //wno = (int) (Math.random()*10);
            rword = wlist[wno];

            for (int i = 0; i < rword.Length; i++){
                Console.Write("_ ");
            }
		    Console.WriteLine();
		
		    //user is givem 10 chances
            for (int i=0; i<10; i++){
    			Console.Write("Guess: ");
                //guess = no.nextLine().charAt(0);
                guess = char.Parse(Console.ReadLine().Substring(0,1));

                checkguess(guess, rword, guesses);
            
                if(isWin(guesses, rword)){
                    Console.Write("You won");
                    //System.exit(0);
                    Console.Read();
                    return;
                }
                
            }

            Console.WriteLine("you lost..\n Correct word: " + rword);


            //Console.ReadLine();
            Console.Read();
        }

        //check whether user guess is correct
        static void checkguess(char uin, String word, char[] gword){
            for (int i=0; i<word.Length; i++) {
                if (uin == word[i]) {
                    gword[i] = uin;
                }
        

			    //display user progress
                if (gword[i]!='x') {
                    Console.Write(gword[i]);
                } else {
                    Console.Write(" _");
                }
            }
            Console.WriteLine();
        }

        //check whether user won or not
        static bool isWin(char[] word, String rand_word)
        {

            for (int i = 0; i < rand_word.Length; i++)
            {
                //if (word[i] != rand_word.charAt(i))
                if (word[i] != rand_word[i])
                    return false;
            }
            return true;
        }
    }
}
