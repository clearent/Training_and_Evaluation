ProjectEuler2
=============
This is a fully functioning program that generates the solution to http://projecteuler.net/problem=2.  The project is written in C# using Visual Studio 2012.  The unit tests are written with the Visual Studio Testing Tools.  Rhinomocks is used for mocking objects in unit tests, and the Rhinomocks DLL is included in the unit test project.

This project exists not only to deliver programming challenges, but also to provide some examples of coding with TDD.  The Calculator and EvenNumberFilter classes were created using TDD.  Rhinomocks and dependency injection were utilized to properly separate concerns and create focused unit tests.

Challenge 1
-----------
A bug exists in the program.  As it exists, the program does not generate the correct answer to the problem.  The first challenge is to fix the bug that exists so that the program generates the correct answer to Project Euler's problem #2.

This challenge should be met by creating/modifying unit tests as needed and making the appropriate code fixes.

Challenge 2
-----------
A fair portion of this code was not written with TDD (which was REALLY hard to do).  The code needs to be refactored to be more readable and maintainable.  Good refactoring practices should be used to clean up the code.
