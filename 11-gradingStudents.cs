/* HackerLand University has the following grading policy:

Every student receives a grade in the inclusive range from 0 to 100.
Any grade less than 40 is a failing grade.
Sam is a professor at the university and likes to round each student's  according to these rules:

If the difference between the grade and the next multiple of 5 is less than 3, round grade up to the next multiple of 5.
If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.
For example, grade = 38, will be rounded to 85 but grade = 29 will not be rounded because the rounding would result in a number that is less than 40.

Given the initial value of grade for each of Sam's n students, write code to automate the rounding process.

Function Description

Complete the function gradingStudents in the editor below. It should return an integer array consisting of rounded grades.

gradingStudents has the following parameter(s):

grades: an array of integers representing grades before rounding
Input Format

The first line contains a single integer, n, the number of students. 
Each line i of the n subsequent lines contains a single integer, grades[i], denoting student i's grade.

Constraints

- 1 <= n <= 60
- 0 <= grades[i] <= 100


Output Format

For each grades[i], print the rounded grade on a new line.

Sample Input 0

4
73
67
38
33
Sample Output 0

75
67
40
33
Explanation 0
=====================================
| ID | Original Grade | Final Grade |
=====================================
| 1  |        73      |      75     |
-------------------------------------
| 2  |        67      |      67     |
-------------------------------------
| 3  |        38      |      38     |
-------------------------------------
| 4  |        33      |      33     |
-------------------------------------

1. Student 1 received a 73, and the next multiple of 5 from 73 is 75. Since 75-73 < 3, the student's grade is rounded to 75.
2. Student 2 received a 67, and the next multiple of 5 from 67 is 70. Since 70-67 = 3, the grade will not be modified and the student's final grade is 67.
3. Student 3 received a 38, and the next multiple of  from  38 is 40. Since 40-38 < 3, the student's grade will be rounded to 40.
4. Student 4 received a grade below 38, so the grade will not be modified and the student's final grade is 33.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static int[] gradingStudents(int[] grades) {
        for (int i = 0; i < grades.Length; i++)
        {
            var item = grades[i];
            if (item >= 38)
            {
                var diff = 5 - (item % 5);
                if (diff < 3)
                    grades[i] = item + diff;
            }
        }

        return grades;

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
