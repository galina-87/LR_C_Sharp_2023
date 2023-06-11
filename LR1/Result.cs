using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LR1
{
    internal class Result
    {
        public int text_number;
        public TimeSpan span;
        public int errors;
        public double speed;
        public void CalcSpeed(String s)
        {
            speed = s.Length / span.TotalMinutes;
        }

        public static int Diff(string original, string actual)
        {
            var board = new int[original.Length + 1, actual.Length + 1];
            for (var i = 0; i < board.GetLength(0); i++) board[i, 0] = i;
            for (var i = 0; i < board.GetLength(1); i++) board[0, i] = i;

            for (var i = 1; i < board.GetLength(0); i++)
            {
                for (var j = 1; j < board.GetLength(1); j++)
                {
                    var stringsEquals = original[i - 1] == actual[j - 1];
                    var add = (stringsEquals ? 0 : 1);
                    board[i, j] = Math.Min(board[i - 1, j - 1] + add * 1, Math.Min(board[i - 1, j] + 1, board[i, j - 1] + 1));
                }
            }
            return board[original.Length, actual.Length];
        }
    }
}
