/*
tik tac toe game 2 players
choose a number 1-9 thats not already taken
input validation is needed to ensure the chosen number is valid and not already taken
choices are remembered and displayed
loop unitl all slots are full and a player has won
rules for winning should be implemented to check if a player has won after each move
*/
using System;

class Program
{
    static void Main()
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        void DisplayBoardState()
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }
        DisplayBoardState();
        Console.WriteLine("Player 1, choose a number (1-9) that hasnt been chosen yet:");
        string? player1Choice = Console.ReadLine();
        
    }
}