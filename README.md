# ReverGo
CME 1101 - PROJECT BASED LEARNING I COURSE / Project 2 (2015)





Code / Project     :  CME1101 / 2


Year / Semester	:  2015-2016 Fall Semester 
Duration	      :  5 weeks

Project:  ReverGo

The aim of the project is to develop a strategic board game for two players, played on a 1×16 or 8×8 board, in which the user plays against the computer and tries to reverse the stones' color into his/her color, so s/he will have more stone on the board for winning.

General Information

The game is played on a board which has 1×16 or 8×8 squares, with black and white stones. Both kinds of boards have safe areas whose sizes are 1×8 and 4×4 that are colored gray and located in the center of the boards. The object of the game is to have the majority of the stones when the board is full.

Game Rules

1.	Initially, human player chooses the board: 1×16 or 8×8. 

2.	The game begins with an empty board. White is human player, black is computer player. White starts the game.

3.	Players place their stones on the board in their turns. Every stone must be in safe area or must be maximum 2 cells away (horizontally/vertically/diagonally) from any stone placed earlier. 

4.	When a player places a stone, if there are opponent's stones between this and previously placed player's stones (in 8 directions) then the opponent's stones are converted into the player's stones.

5.	Players must play in their turns, they cannot say pass. 

6.	The game continues until the board is full. When the game is finished, the player who has the most of the stones wins.

Sample Games


   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  0
 | . . . . . . . . . . . . . . . . |   Human   :  0
 + - - - - - - - - - - - - - - - - +   Computer:  0

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  1
 | . . . . . ○ . . . . . . . . . . |   Human   :  1
 + - - - - - - - - - - - - - - - - +   Computer:  0

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  2
 | . . . . . ○ ● . . . . . . . . . |   Human   :  1
 + - - - - - - - - - - - - - - - - +   Computer:  1

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  3
 | . . . . . ○ ○ ○ . . . . . . . . |   Human   :  3
 + - - - - - - - - - - - - - - - - +   Computer:  0

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  4
 | . . . ● . ○ ○ ○ . . . . . . . . |   Human   :  3
 + - - - - - - - - - - - - - - - - +   Computer:  1



   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  5
 | . ○ . ● . ○ ○ ○ . . . . . . . . |   Human   :  4
 + - - - - - - - - - - - - - - - - +   Computer:  1

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  6
 | ● ○ . ● . ○ ○ ○ . . . . . . . . |   Human   :  4
 + - - - - - - - - - - - - - - - - +   Computer:  2

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  7
 | ● ○ . ● . ○ ○ ○ . . ○ . . . . . |   Human   :  5
 + - - - - - - - - - - - - - - - - +   Computer:  2

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  8
 | ● ● ● ● . ○ ○ ○ . . ○ . . . . . |   Human   :  4
 + - - - - - - - - - - - - - - - - +   Computer:  4

   0 0 0 0 0 0 0 0 0 1 1 1 1 1 1 1 
   1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6       
 + - - - - - - - - - - - - - - - - +   Round   :  9
 | ● ● ● ● . ○ ○ ○ . . ○ . ○ . . . |   Human   :  5
 + - - - - - - - - - - - - - - - - +   Computer:  4

 ...



   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  0
1| . . . . . . . . | Human   :  0
2| . . . . . . . . | Computer:  0
3| . . . . . . . . | 
4| . . . . . . . . |
5| . . . . . . . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  1
1| . . . . . . . . | Human   :  1
2| . . . . . . . . | Computer:  0
3| . . . ○ . . . . | 
4| . . . . . . . . |
5| . . . . . . . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  2
1| . . . . . . . . | Human   :  1
2| . . . . . . . . | Computer:  1
3| . . . ○ . . . . | 
4| . . . . ● . . . |
5| . . . . . . . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  3
1| . . . . . . . . | Human   :  2
2| . . . . . . . . | Computer:  1
3| . . . ○ . ○ . . | 
4| . . . . ● . . . |
5| . . . . . . . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  4
1| . . . . . . . . | Human   :  2
2| . . . . . . . . | Computer:  2
3| . . . ○ ● ○ . . | 
4| . . . . ● . . . |
5| . . . . . . . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +



   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  5
1| . . . . . . . . | Human   :  4
2| . . . . . . . . | Computer:  1
3| . . . ○ ● ○ . . | 
4| . . . . ○ . . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  6
1| . . . . . . . . | Human   :  3
2| . . . . . . . . | Computer:  3
3| . . ● ● ● ○ . . | 
4| . . . . ○ . . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  7
1| . . . . . . . . | Human   :  7
2| . . . . . . . . | Computer:  0
3| . ○ ○ ○ ○ ○ . . | 
4| . . . . ○ . . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  8
1| ● . . . . . . . | Human   :  7
2| . . . . . . . . | Computer:  1
3| . ○ ○ ○ ○ ○ . . | 
4| . . . . ○ . . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   :  9
1| ● . . . . . . . | Human   :  8
2| . . . ○ . . . . | Computer:  1
3| . ○ ○ ○ ○ ○ . . | 
4| . . . . ○ . . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +


   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   : 10
1| ● . . . . . . . | Human   :  8
2| . . . ○ . . . . | Computer:  2
3| . ○ ○ ○ ○ ○ . . | 
4| . . . . ○ ● . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   : 11
1| ● ○ . . . . . . | Human   :  9
2| . . . ○ . . . . | Computer:  2
3| . ○ ○ ○ ○ ○ . . | 
4| . . . . ○ ● . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   : 12
1| ● ● ● . . . . . | Human   :  6
2| . . . ● . . . . | Computer:  6
3| . ○ ○ ○ ● ○ . . | 
4| . . . . ○ ● . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   : 13
1| ● ● ● . . . . . | Human   :  8
2| . . . ● ○ . . . | Computer:  5
3| . ○ ○ ○ ○ ○ . . | 
4| . . . . ○ ● . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

   1 2 3 4 5 6 7 8 
 + - - - - - - - - + Round   : 14
1| ● ● ● . . . . . | Human   :  6
2| . . . ● ○ . . . | Computer:  8
3| . ○ ○ ● ○ ○ . . | 
4| . . . ● ● ● . . |
5| . . . . . ○ . . |
6| . . . . . . . . |
7| . . . . . . . . |
8| . . . . . . . . |
 + - - - - - - - - +

 ...



Suggested Weekly Program

1. Discussing the problem, designing solution alternatives, creating necessary variables/structures, screen.
2. Checking a move for 1×16 board. Human move for 1×16 board.
3. Computer move for 1×16 board.
4. Checking a move for 8×8 board. Human move for 8×8 game.
5. Computer move for 8×8 game. Remaining parts of the game.


First Evaluation: 20.11.2015
Report: 20.11.2015
Final Evaluation: 27.11.2015 (Powerpoint + Poster)
                Report: 30.11.2015
