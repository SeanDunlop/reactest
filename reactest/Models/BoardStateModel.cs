using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reactest.Models
{
    public class BoardStateModel
    {
        public int[,] board;

        public BoardStateModel() 
        {
            board = new int[8, 8] { { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0},
                                    { 0,0,0,0,0,0,0,0} };
        }

        public string toString() 
        {
            string result = "";
            for (int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++) 
                {
                    result += board[i, j];
                }
                result += "\n";
            }
            return result;
        }
    }
}
