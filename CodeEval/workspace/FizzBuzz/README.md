Fizz Buzz (**Solved**)
--------------------------
https://www.codeeval.com/open_challenges/1/

**Challenge Description:**

>Players generally sit in a circle. The first player says the number “1”, and each player says next number in turn. However, any number divisible by X (for example, three) is replaced by the word fizz, and any divisible by Y (for example, five) by the word buzz. Numbers divisible by both become fizz buzz. A player who hesitates, or makes a mistake is eliminated from the game.

>Write a program that prints out the final series of numbers where those divisible by X, Y and both are replaced by “F” for fizz, “B” for buzz and “FB” for fizz buzz.

**Input sample:**

Your program should accept a file as its first argument. The file contains multiple separated lines; each line contains 3 numbers that are space delimited. The first number is the first divider (X), the second number is the second divider (Y), and the third number is how far you should count (N). You may assume that the input file is formatted correctly and the numbers are valid positive integers.

For example:

>3 5 10

>2 7 15

**Output sample:**

Print out the series 1 through N replacing numbers divisible by X with “F”, numbers divisible by Y with “B” and numbers divisible by both with “FB”. Since the input file contains multiple sets of values, your output should print out one line per set. Ensure that there are no trailing empty spaces in each line you print.

>1 2 F 4 B F 7 8 F B

>1 F 3 F 5 F B F 9 F 11 F 13 FB 15

**Constraints:**

    The number of test cases ≤ 20
    "X" is in range [1, 20]
    "Y" is in range [1, 20]
    "N" is in range [21, 100]

Main.java
```java
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/*
 * Prints a sequence of numbers until 'N' which prints "F" if its divisible by int 'A' and prints "B" if divisible by int 'B' and "FB" if divisible by both.
 */
public class Main {

	/*
	 * Prints the Fizz Buzz sequence until N
	 * 
	 * @param args[0] first number to check if it divides into a number.
	 * 
	 * @param args[1] second number to check if it divides into a number.
	 * 
	 * @param args[2] the max from 1-max to keep printing the sequence for.
	 */
	public static void main(String[] args) throws FileNotFoundException {
		Scanner scan = new Scanner(new File(args[0]));
		Scanner scan2;
		String string;
		int div1;
		int div2;
		int max;
		while (scan.hasNextLine()) {
			string = scan.nextLine();
			scan2 = new Scanner(string);
			while (scan2.hasNextInt()) {
				div1 = scan2.nextInt();
				div2 = scan2.nextInt();
				max = scan2.nextInt();
				String answer = "";
				for (int i = 1; i <= max; i++) {
					if (i % div1 == 0) {
						if (i % div2 == 0) {
							answer = answer + " FB";
						} else
							answer = answer + " F";
					} else if (i % div2 == 0) {
						answer = answer + " B";
					} else
						answer = answer + " " + Integer.toString(i);
				}
				System.out.println(answer.substring(1, answer.length()));
				answer = "";
			}
			scan2.close();
		}
		scan.close();

	}
}
```
