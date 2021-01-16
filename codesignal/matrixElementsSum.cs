int matrixElementsSum(int[][] matrix) {
 int sum = 0;
            for (int i = 0; i < matrix.Length-1; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i + 1][j] = 0;
                    }
                    
                }
                
            }
            for (int i = 0; i < matrix.Length  ; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                   sum += matrix[i][j];
                }

            }
            return sum;
}
