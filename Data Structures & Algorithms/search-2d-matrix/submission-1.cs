public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int Rows = matrix.Length;
        int Columns = matrix[0].Length;

        if(Rows == 0 || Columns == 0) return false;

        int i = 0, j = 0;
        while(i < Rows) {
            if(matrix[i][j] <= target && target <= matrix[i][Columns-1]) {
                while (j <= Columns -1) {
                    if(matrix[i][j] == target) return true;
                    j++;
                }
                return false;
            }
            i++;
        }

        return false;        
    }
}
