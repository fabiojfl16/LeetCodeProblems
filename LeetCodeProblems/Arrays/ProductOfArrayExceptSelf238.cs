namespace LeetCode.Arrays;

public class ProductOfArrayExceptSelf238
{
    /// <summary>
    /// Big O (n2)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] ProductExceptSelf2(int[] nums)
    {
        var products = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int product = 1;

            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                {
                    product *= nums[j];
                }
            }

            products.Add(product);
        }

        return products.ToArray();
    }

    /// <summary>
    /// Big O (n)
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] ProductExceptSelf(int[] nums)
    {
        int prefix = 1;
        int postfix = 1;
        int[] result = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= postfix;
            postfix *= nums[i];
        }

        return result;
    }
}