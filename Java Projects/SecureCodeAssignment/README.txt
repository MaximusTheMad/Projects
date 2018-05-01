Team Seventh Dimension

Sean Gormley	sgormley12@eagles.ewu.edu
Brian Buermann	brianbuermann@eagles.ewu.edu
Max Winston	maxwell.winston@eagles.ewu.edu

Defend Your Code Fix - C programming language

1.	Fixes made:
The overall code is more modularized. At the very least, code handling the different stages of
the program (reading a first and last name, reading two 32-bit integers, reading an input and
output file, storing and salting and hashing a password, and writing to the output file)
are placed into their own functions.

Also the role of the abort() function is much clearer: it is only used for errors unrelated to
bad inputs, as the user is expect to enter something different until there's a successful match.
Also related to this fix is how filenames are validated: input filenames must be in the present
working directory and cannot be directories (including present, or '.', and parent, or '..'). The
output file must be created to avoid potential issues such as overwriting source code and executables.

Finally, the code involving passwords is tweaked. When entering and re-entering a password, the input
is not echoed to the terminal to simulate not being able to see the password as one types. Lastly,
the code generating a salt is modified to ensure the correct character set is produced [./0-9A-Za-z].

Defend Your Code Fix - Java programming language

The overall code is a lot more modularized in the way that most input validation is done through separate methods.  It's not great but it's better than it was.
Also the restriction on non txt files has been lifted for input and output, but the checks to make sure the names are valid and that no illegal files are used.
A restriction was placed to ensure there is no paths in the file names to ensure that the user doesn't get free reign in the file system.

2.	Contact:
Team Seventh Dimension

Sean Gormley	sgormley12@eagles.ewu.edu
Brian Buermann	brianbuermann@eagles.ewu.edu
Max Winston	maxwell.winston@eagles.ewu.edu

3.	Compilation instructions:

On a Linux machine (preferably Ubuntu 16.04), compile using either the Makefile provided (enter "make"
at command line) or using the following command: "gcc -pedantic -Wall -Wextra -Werror defend.c fileio.c regexUtil.c -lcrypt". The executable will be named "a.out".

For the Java Code on a Windows Machine(preferably Windows 8.1 to get as close as possible to the test environment, but any installation works as long as Java is updated).
In command line, in the Java_Version folder, enter the following commands:
javac CSCDAssignment6Java.java
java CSCDAssignment6Java
