using System;

namespace Lab_2___Shackbräde
{
    internal class Program
    {// LAB 2 - Shackbradet - Hjalmar Stranninge (NET23)
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Hur stort shackbräde? "); //Har tillfrågas anvandaren hur stort bradet ska vara
            int boardSize = int.Parse(Console.ReadLine()); //vardet sparas i en int-variabel. En 2d string-array skapas i storleken anvandaren valt
            string[,] board = new string[boardSize, boardSize];
            string[] column = new string[boardSize];    //två arrayer för att ge varje ruta ett namn, t.ex 'G3'
            string[]  row = new string[boardSize];
            
            for (int i = 0; i < boardSize; i++)
            {
                column[i] = ((char)('a'+i)).ToString();        
                row[i]=(i+1).ToString();                    
                for (int j = 0; j < boardSize; j++)
                {
                    if ((i+j) % 2 == 0)                     //två nastlade for-loopar går igenom hela arrayen och tilldelar varje index en  
                    {                                       //svart eller vit ruta baserat på om indexnumret ar jamnt eller udda.
                        board[i, j] = "◻︎ ";
                    }
                    else
                    {
                        board[i, j] = "◼︎ ";
                    }
                }              
            }

            Console.WriteLine("Vart ska drottningen stå? ex. B4");      
            string userInput = Console.ReadLine();                  //anvandarens input delas up i bokstaven och siffran som representarar kolumn och rad på
            char userColumn = userInput[0];                         //bradet. båda behöver subtraheras med 1 eftersom att index startar på 0.
            userColumn=char.ToLower(userColumn);
            string userRow = userInput.Substring(1);
            int columnIndex = userColumn - 'a';
            int rowIndex = int.Parse(userRow) - 1;
            if (rowIndex >= 0 && rowIndex < boardSize && columnIndex >= 0 && columnIndex < boardSize) //testar så att anvandarens input ar en giltig koordinat
            {
                (board[rowIndex, columnIndex]) = "♛  "; //lyckas inte få pjasen att centrera vilket gör mig GALEN men tror inte det har med koden att göra
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        Console.Write(board[i, j]);        //två nya for-loopar printar hela bradet 

                    }
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("Ogiltiga koordinater");
            }   
            

            
            
        }
    }
}