using System;

namespace ProjectEuler.Core.Util
{
    public static class Common
    {
        public static char Space = ' ';
        public static char Comma = ',';

        public static int[] TurnTextIntoRows(string text)
        {
            string[] rowTexts = text.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            int[] rows = new int[rowTexts.Length];

            for (int i = 0; i < rowTexts.Length; i++)
            {
                string rowText = rowTexts[i].Trim();
                rows[i] = int.Parse(rowText);
            }

            return rows;
        }
        
        public static int[][] TurnTextIntoGrid(string text, char separator)
        {
            string[] rowTexts = text.Split(new[] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
            int[][] rows = new int[rowTexts.Length][];

            for (int i = 0; i < rowTexts.Length; i++)
            {
                string rowText = rowTexts[i].Trim();

                string[] rowValues = rowText.Split(new[] {separator}, StringSplitOptions.RemoveEmptyEntries);
                rows[i] = new int[rowValues.Length];

                for (int j = 0; j < rowValues.Length; j++)
                {
                    string rowValue = rowValues[j];
                    rows[i][j] = int.Parse(rowValue);
                }
            }

            return rows;
        }
    }
}
