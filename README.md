# Assignment6.2.2

- Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
- The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
- You must write an algorithm that runs in O(n) time and without using the division operation.

- Example 1:
- Input: nums = [1,2,3,4]
- Output: [24,12,8,6]
- Example 2:
- Input: nums = [-1,1,0,-3,3]
- Output: [0,0,9,0,0]

Hints:
- To return an array answer where answer[i] is the product of all elements in nums except nums[i], without using division and in O(n) time, you can use a two-pass approach. 
- First, create two auxiliary arrays to store the prefix and suffix products.
- First pass: Calculate prefix products answer[i] will store the product of all elements to the left of i.
- Second pass: Calculate suffix products and combine with prefix products suffixProduct will store the product of all elements to the right of current i.
- Finally, combine the prefix and suffix products to get the desired result for each element in nums.
- Update suffix product for the next iteration.
- This approach ensures that you do not use division and achieve the required time complexity of O(n).