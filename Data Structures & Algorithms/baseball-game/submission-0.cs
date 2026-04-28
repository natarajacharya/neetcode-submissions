public class Solution {
    public int CalPoints(string[] operations) {
        
        Stack<int> result = new Stack<int>();

        foreach(string operation in operations) {

            if(operation == "+") {
                int latest = result.Pop();
                int latestButOne = result.Pop();

                int sumofLastTwo = latest + latestButOne;

                result.Push(latestButOne);
                result.Push(latest);
                result.Push(sumofLastTwo); 
            }
            else if(operation == "C"){
                result.Pop();
            }
            else if(operation == "D") {
                int latest = result.Pop();

                result.Push(latest);
                result.Push(latest * 2);
            }
            else {
                result.Push(int.Parse(operation));
            }
        }

        return result.Sum();

    }
}