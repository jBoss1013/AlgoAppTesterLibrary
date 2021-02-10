﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgorithmAppUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlgorithmAppUI.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class FindThreeLargestNumbers
        ///    {
        ///        public static int[] FIndTheThreeLargestNum(int[] array)
        ///        {
        ///            FindThreeLargestNumbers threeLgstNum = new FindThreeLargestNumbers();
        ///            int[] threeLargest = { Int32.MinValue, Int32.MinValue, Int32.MinValue };
        ///
        ///            foreach (int num in array)
        ///            {
        ///                threeLgstNum.UpdateLargestNum(threeLargest, num);
        ///            }
        ///            return threeLargest;
        ///        }
        ///
        ///        private void UpdateLargestNu [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FindThreeLargestNumsCode {
            get {
                return ResourceManager.GetString("FindThreeLargestNumsCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Find the three largest numbers in an array
        ///
        ///This algorithm takes in an integer array and returns an array that contains the three largest numbers within the given array. 
        ///
        ///Below, please enter an integer array of 3 or more elements. .
        /// </summary>
        internal static string FindThreeLargestNumsInfoTxt {
            get {
                return ResourceManager.GetString("FindThreeLargestNumsInfoTxt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class ElementsToEnd
        ///    {   
        ///
        ///        public static List&lt;int&gt; MoveElementToEnd(List&lt;int&gt; array, int toMove)
        ///        {
        ///            ElementsToEnd move = new ElementsToEnd();
        ///            int i = 0;
        ///            int j = array.Count - 1;
        ///
        ///            while (i &lt; j)
        ///            {
        ///                while (i &lt; j &amp;&amp; array[j] == toMove) j--;
        ///                if (array[i] == toMove) move.Swap(i, j, array);
        ///                i++;
        ///            }
        ///            return array;
        ///        }
        ///
        ///        private void  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MoveToEndCode {
            get {
                return ResourceManager.GetString("MoveToEndCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move an element in an array to the end
        ///
        ///This algorithm takes in an integer array and an integer, moving all instances of that integer to the end of the array.
        ///
        ///Below, please enter an integer array, sepeperated by commas, in the field and an integer contained within the array in the second field. .
        /// </summary>
        internal static string MoveToEndInfoTxt {
            get {
                return ResourceManager.GetString("MoveToEndInfoTxt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  public class NthFibonacci
        ///    {
        ///        public static int GetNthFib(int n)
        ///        {
        ///            int[] lastTwo = { 0, 1 };
        ///            int counter = 2;
        ///
        ///            while (counter &lt;= n)
        ///            {
        ///                int nextFib = lastTwo[0] + lastTwo[1];
        ///                lastTwo[0] = lastTwo[1];
        ///                lastTwo[1] = nextFib;
        ///                counter++;
        ///            }
        ///            return n &gt; 0 ? lastTwo[1] : lastTwo[0];
        ///        }
        ///    }.
        /// </summary>
        internal static string NthFibonacciCode {
            get {
                return ResourceManager.GetString("NthFibonacciCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nth Fibonacci
        ///
        ///The Fibonacci sequence is a series of numbers where a number is the addition of the last two numbers in the current sequence, starting with 0 and 1. This is derived by the formula Fn = F(n-1)+ F(n-2). The first few lines within the sequence are as follows: 0,1,1,2,3,5,8,13,21,34,55...
        ///
        ///This algorithm takes an integer number and plugs that number into n and gives the resulting index of n. It is important to note that there are some variants to how this formula is coded. This particular alg [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NthFibonacciInfoTxt {
            get {
                return ResourceManager.GetString("NthFibonacciInfoTxt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class PalindromeChecker
        ///    {
        ///        public static bool IsPalindrome(string str)
        ///        {
        ///            int leftSide = 0;
        ///            int rightSide = str.Length - 1;
        ///
        ///            while (leftSide &lt; rightSide)
        ///            {
        ///                if (str[leftSide] != str[rightSide])
        ///                {
        ///                    return false;
        ///                }
        ///                leftSide += 1;
        ///                rightSide -= 1;
        ///            }
        ///            return true;
        ///        }
        ///    }.
        /// </summary>
        internal static string PalindromeCheckerCode {
            get {
                return ResourceManager.GetString("PalindromeCheckerCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Palindrome Checker
        ///
        ///A palindrome is a string that is spelled the same way forwards and backwards (ex: racecar). This algorithm takes a single string (with no spaces) and checks to see if the string is a palindrome before returning a boolean response. 
        ///
        ///Below, please enter in a string of characters to determine if the string is a palindrome..
        /// </summary>
        internal static string PalindromeCheckerInfoTxt {
            get {
                return ResourceManager.GetString("PalindromeCheckerInfoTxt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subsequence of an array
        ///
        ///A subsequence of an array is a set a numbers that are not adjacent in the array but are in the same order as they appear in given array (ex: {2,4,6} is a subsequence to the array {1,2,3,4,5,6}). 
        ///
        ///This algorithm takes two non-empty integer arrays and returns a boolean response to whether or not the potential second array is a subsequence to the first array.
        ///
        ///Below, please enter a full array into the first input field using only integers separated by commas. In the secondary fi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SubsequenceInfoTxt {
            get {
                return ResourceManager.GetString("SubsequenceInfoTxt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to public class SubsetChecker
        ///    {
        ///        public static bool IsValidSubsequence(List&lt;int&gt; array, List&lt;int&gt; sequence)
        ///        {
        ///            int arrayPointer = 0;
        ///            int seqPointer = 0;
        ///
        ///            while (seqPointer &lt; sequence.Count &amp;&amp; arrayPointer &lt; array.Count)
        ///            {
        ///                if (sequence[seqPointer] == array[arrayPointer])
        ///                {
        ///                    seqPointer++;
        ///                }
        ///                arrayPointer++;
        ///            }
        ///            return seqPointer = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SubsetCheckerCode {
            get {
                return ResourceManager.GetString("SubsetCheckerCode", resourceCulture);
            }
        }
    }
}