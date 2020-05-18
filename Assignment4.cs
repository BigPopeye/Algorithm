1. MaxSumOfSubarray
//maxSum[i] = max( A[i], A[i] + maxSum[i - 1] )
// ****************
// Time : O(n)
// Space : O(1)
// ****************
public class Solution{
    public int MaxSumOfSubarray(int[] arr){
        int len = arr.Length ;
        int maxSum = 0;
        int[] maxSum = new int[len]; 
        maxSum[0] = arr[0];
        for(int i = 1; i < len; i++){
            maxSum[i] = arr[i] + maxSum[i-1];
            if(maxSum[i]>maxSum){
                maxSum = maxSum[i];
            }
        }
        return maxSum;
    }



2. FindMissingNum
// add numbers - total sum
// ****************
// Time : O(n)
// Space : O(1)
// ****************
    public int FindMissingNum(int[] arr){
        int sum = n;
        for(int i = 1; i <n; i++){
            sum += i-arr[i-1];
        }
        return sum;
    }


3. PositiveSubarrayAddedToGivenSum
// if sum < Given, add right
// if sum > Given, minus left
// ****************
// Time : O(n)
// Space : O(1)
// ****************
    public int[] PositiveSubarrayAddedToGivenSum(int[] arr, int k){
        if(arr == null || arr.Length == 0){
            PrintErr("No subarray found");
            return null;
        }
        int left = 0;
        int right = 0;
        int sum = 0;
        int len = arr.Length;
        while(left <= right && right < len){
            if(sum > k){
                if(left <right){
                    sum -= arr[left];
                    left++;
                }else if(left == right{
                    sum -= arr[left];
                    left++;
                    right++;
                }
            }else if(sum < k){
                sum += arr[right];
                right++;
            }else if(sum == k){
                int[] idxs = new int[]{left,right};
                Print(idxs,"Sum found between indexes:");
                return idxs; 
            }
        }
        PrintErr("No subarray found");
        return null; 
    }



4. SubarrayAddedToGivenSum
// prefixSum[i] = arr[0] + ... + arr[i -1] == prefixSum[i-1] + arr[i -1]
// prefixSum[0] = 0,prefixSum[] => length = n+1;
// SubarraySum(i,j) = prefixSum[j] - prefixSum[i] == k
// prefixSum[j] = prefixSum[i] + k
// add prefixSum[i],i into dictionary
// ****************
// Time : O(n)
// Space : O(1)
// ****************

    public int[] SubarrayAddedToGivenSum(int[] arr, int k){
        if(arr == null || arr.Length == 0){
            PrintErr("No subarray found");
            return null;
        }
        Dictionary<int,int> prefixSum = new Dictionary<int,int>();
        prefixSum.Add(0,-1);
        int currSum = 0;
        for(int i = 0; i < n; i++){
            currSum += arr[i];
            if(prefixSum.ContainsKey(currSum - k)) 
            {
                int idx = prefixSum[currSum-k];
                int idxs = new int[]{idx,i};
                Print(idxs,"Sum found between indexes:");
                return idxs;
            }else{
                prefixSum.Add(currSum,i);
            }
        }
        PrintErr("No subarray with given sum exists");
        return null;
    }


5. Order012
// use new array to store the frequncy of 0,1,2
// ****************
// Time : 2*O(n)
// Space : O(1)
// ****************

    public int[] Order012(int[] arr)
    {
        if(arr == null || arr.Length <= 1){
            return arr;
        }
        int[] freq = new int[3];
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] == 0){
                freq[0]++;
            }else if(arr[i] == 1){
                freq[1]++;
            }else if(arr[i] == 2){
                freq[2]++;
            }
        }
        int i = 0;
        while(freq[0]-- > 0){
            arr[i++] = 0;
        }
        while(freq[1]-- > 0){
            arr[i++] = 1;
        }
        while(freq[2]-- > 0){
            arr[i++] = 2;
        }
        return arr;
    }


6. EquilibriumIndex
// totalSum - leftSum - curr = rightSum
// check if leftSum == rightSum
// ****************
// Time : 2*O(n)
// Space : O(1)
// ****************

    public int EquilibriumIndex(int[] arr)
    {
        if(arr == null)
        {
            return -1;
        }
        int len = arr.Length;
        if(len <= 1) 
        {
            return 0;
        }
        int totalSum = 0;
        int leftSum = 0;
        for(int i = 0; i < len; i++)
        {
            totalSum += arr[i];
        }
        for(int i = 0; i< len; i++)
        {
            int curr = arr[i];
            if(leftSum == totalSum - leftSum - curr){
                return i;
            }else{
                leftSum += curr;
            }
        }
        return -1;
    }


7. LeadersInArray
// reverse, from right to left, print leader
// ****************
// Time : O(n)
// Space : No extra space needed
// ****************

    public void LeadersInArray(int[] arr)
    {
        if(arr == null || arr.Length == 0){
            Console.Write("Array is Empty, no leader to be printed");
        }
        int len = arr.Length;
        int leader = Int32.MinValue; 
        for(int i = len-1; i >= 0; i--)
        {
            if(arr[i] > leader){
                Console.Write("{0},", i);
                leader = arr[i];
            }
        }
    }


8. KthSmallest
// SortedSet, size = n-k+1
// SortedSet's size == Min(n-k+1,k)
// if size == n-k+1, find the Min in the SortedSet
//   traverse the array, if arr[i] > SortedSet.Min, remove SortedSet.Min and add arr[i]
// if size == k, find the Max in the SortedSet
//   traverse the array, if arr[i] < SortedSet.Max, remove SortedSet.Max and add arr[i]
// ****************
// Time : O(n*log(Size))
// Space : O(Size)
// ****************

    public int KthSmallest(int[] arr, int k)
    {
        if(arr == null || arr.length < k){
            Console.Write("Array is Empty, or the length of array is less then k");
            return -1;
        }
        int len = arr.Length;
        int size = Min(k, n-k+1);
        for(int i = 0; i < size; i++){
            SortedSet.Add(arr[i]);
        }
        if(size == k){
            int max = SortedSet.Max;
            for(int i = size; i < len-1; i++){
                if(arr[i] < max){
                    SortedSet.Remove(max);
                    SortedSet.Add(arr[i]);
                    max = SortedSet.Max;
                }
            }
            return max;
        }else{
            int min = SortedSet.Min;
            for(int i = size; i < len-1; i++){
                if(arr[i] > min){
                    SortedSet.Remove(min);
                    SortedSet.Add(arr[i]);
                    min = SortedSet.Min;
                }
            }
            return min;
        }
    }


9.SpiralArray
// ****************
// Time : O(m*n)
// Space : O(m*n) if output int[], no extra space if just print it out;
// ****************

    public int[,] SpiralArray(int[,] arr)
    {
        if(arr == null || arr[0].Length == 0 || arr.Length == 0){
            return null;
        }
        int n = arr[0].Length;
        int m = arr.Length;
        int left = 0;
        int right = n-1;
        int up = 0;
        int down = m-1;
        int[] output = new int[m*n];
        int idx = 0;
        while(left <= right || up <= down){
            for(j = left ;left <= right && j <= right; j++){
                output[idx++] = arr[up,j];
            }
            up++;
            for(i = up;up <= down && i <= down; i++){
                output[idx++] = arr[i,right];
            }
            right--;
            for(j = right; left <= right && j >= left; j--){
                output[idx++] = arr[down,j];
            }
            down--;
            for(i = down; up <= down && i >= up; i--){
                output[idx++] = arr[i,left];
            }
            left++;
        }
        return output;
    }



10. SortByFrequency
// Use dictionary to store the <num, frequency>
// use another dictionary store thier index <num, first index>
// Use Array of List to store num in the index represent it's frequency, if more than 2 num has same frequency, rank by their index
// eg : num = 2 index = 0, num = 5, index = 3 both frequency 3, so array[3] = new List<int>{2,5}
// ****************
// Time : O(n + freq)
// Space : O(m*n) 
// ****************
// 2, 5, 2, 8, 5, 6, 8, 8
    public int[] SortByFrequency(int[] arr)
    {
        Dictionary<int,int> NumFreq = new Dictionary<int,int>();
        Dictionary<int,int> NumIndex= new Dictionary<int,int>();

        int maxFreq = 0;
        for (int i = 0; i < arr.Length;i++)
        {
            if(NumFreq.ContainsKey(arr[i])){
                NumFreq[arr[i]]++;
                maxFreq = NumFreq[arr[i]] > maxFreq ? NumFreq[arr[i]] ：maxFreq;
                    
            }else{
                NumFreq[arr[i]] = 1;
            }

            if(NumIndex.ContainsKey(arr[i])){
                continue;
            }else{
                NumIndex[arr[i]] = i;
            }
        }
        // NumFreq | NumIndex 
        // <2,2>   | <2,0>
        // <5,2>   | <5,1>
        // <8,3>   | <8,3>
        // <6,1>   | <6,5>
        
        List<int>[] freqArr = new List<int>[maxFreq];
        // output dictionary into FreqArray
        foreach (KeyValuePair<int,int> kvp in NumFreq)
        {
            if(freqArr[kvp.Value] == null){
                freqArr[kvp.Value] = new List<int>();
            }
            freqArr[kvp.Value].Add(kvp.Key);
        }
        // freqArr[0] = null;
        // freqArr[1] = 6
        // freqArr[2] = 2,5
        // freqArr[3] = 8

        // output FreqArray into arr
        int idx = 0;
        for(int i = maxFreq-1; i >= 0; i--){
            int currFreq = i;
            while(freqArr[i] != null && currFreq > 0){
                if(freqArr[i].Count >1){
                    freqArr[i].Sort() // TBD sort by Dictionary NumIndex
                }
                arr[idx] = freqArr[i];
                currFreq--;
                idx++;
            }
        }
        return arr;
    }




    public void Print(int[] arr, string notice) // int, int[]
    {
        Console.Write(notice);
        foreach (int a in arr)
        {
            Console.Write("{0},", i);
        }
        Console.WriteLine();
    }
    public void PrintErr(string error) 
        Console.Write(error);
    }
}
