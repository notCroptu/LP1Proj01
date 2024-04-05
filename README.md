# Galo da Velha
#### By Bruno Alegria a22302942, Ivan Emídio a22301234, Mariana Martins a22302203
##### Linguagens de Programação I - Projeto 1
[Project's Git link](https://github.com/notCroptu/LP1Proj01.git)

### Task List
| When | Who | What |
| --- | --- | --- |
| 29/3 | Mariana Martins | Created git |
| 29/3 | Mariana Martins | Added solution and project |
| 29/3 | Mariana Martins | Formated README.md in markdown |
| 30/3 | Bruno Alegria | Updated header of README.md |
| 1/4 | Mariana Martins | Added Architecture description and references |
| 1/4 | Mariana Martins | Created Class Game in Game.cs |
| 1/4 | Ivan Emidio | Created Class Board in Board.cs |
| 1/4 | Ivan Emidio | Added Code to the Board in Board.cs |                                        /// especifica pls
| 1/4 | Ivan Emidio | Looped the Board in Game.cs |
| 1/4 | Ivan Emidio | Created Class Piece in Piece.cs |
| 1/4 | Ivan Emidio | Added Coordinates to Pieces in Piece.cs |     /// bruh? porque dizer isto em especifico e deixar o resto todo?
| 1/4 | Ivan Emidio | Updated README.md |
| 1/4 | Mariana Martins | Created CreatePieces Method in Board Class |
| 1/4 | Mariana Martins | Created PiecesChar Enumeration in PiecesChar.cs |
| 2/4 | Mariana Martins | Scripted Render method in Board Class |
| 2/4 | Mariana Martins | Created unicodeModify method and other getters in Piece class |
| 2/4 | Mariana Martins | Updated references in README |
| 2/4 | Mariana Martins | Created Player Class in Player.cs |
| 2/4 | Mariana Martins | Added script to Game class loop |
| 3/4 | Mariana Martins | Added player instances to Game.cs and created switchPlayer method to Game.cs |
| 3/4 | Mariana Martins | Created CheckInput methods in Game.cs |
| 3/4 | Mariana Martins | Created ConvertInput methods and getters in Player class |
| 3/4 | Mariana Martins | Created getters in Piece class |
| 3/4 | Mariana Martins | Added name input in Start method, name variable in Player class and GetName method |
| 3/4 | Mariana Martins | Edited game loop in Start method to include new methods |
| 3/4 | Bruno Alegria | Created PiecePlacer method in Board.cs |
| 3/4 | Bruno Alegria | Added the PiecePlacer attributes (piece and coordinates) |
| 3/4 | Bruno Alegria | Update README.md's change log |
| 4/4 | Mariana Martins | Edited the PiecePlacer method in board.cs |
| 4/4 | Mariana Martins | Added getter methods to board class |
| 4/4 | Mariana Martins | Reordered and added methods to the game loop logic |
| 4/4 | Mariana Martins | Update README.md's change log |
| 4/4 | Mariana Martins | Edited ConvertPieceInput and ConvertPlaceInput method in Player class |
| 4/4 | Mariana Martins | Fixed errors in Game.cs, missing ;, break, {} etc. |
| 4/4 | Mariana Martins | Fixed errors in Board.cs, missing null check and loop errors |
| 4/4 | Mariana Martins | Fixed errors in Piece.cs, method name wrong, missing null check |
| 4/4 | Mariana Martins | Fixed errors in Player.cs, wrong variable called |
| 4/4 | Bruno Alegria | Modified methods GetName, GetLastPieceInput and GetLastPlaceInput to lambdas in Player.cs |
| 4/4 | Bruno Alegria | Modified methods GetUnicoded and GetChars to lambdas in Piece.cs |
| 4/4 | Mariana Martins | Edited Render method in Board class |
| 5/4 | Ivan Emidio | Fixed errors, PieceChar -> PiecesChar |
| 5/4 | Mariana Martins | Edited CreatePieces method in Board class |
| 5/4 | Mariana Martins | Added Invalid enum in PiecesChar and applied in ConvertInput and CheckInput methods |
| 5/4 | Mariana Martins | Edited ConvertInput methods to add flexibitlity to input, and added XML documentation |
| 5/4 | Mariana Martins | Created ShowAvailable method in Board class |
| 5/4 | Mariana Martins | Edited issues with ConvertInput Methods and Game loop method in Player Game class |
| 5/4 | Mariana Martins | Added error messages in ConvertInput methods and edited game loop |
| 5/4 | Bruno Alegria | Modified class Board description and transformed methods GetpiecesLeft and Getboard to lambdas in Board.cs |
| 5/4 | Mariana Martins | Edited CheckInput methods, to include checking for availability of piece and placement |
| 5/4 | Mariana Martins | Fixed CreatePieces method in board, the ifs were giving true at wrong times |
| 5/4 | Mariana Martins | Fixed CheckInput for loop in Game class |
| 5/4 | Mariana Martins | Added a null check in CheckInput in Game class, and changed spacing between renderings in game loop 
| 5/4 | Mariana Martins | Edited ConvertPieceInput in Player class |
| 5/4 | Bruno Alegria | Added a way to print the available pieces to ShowAvailable in Board.cs |
| 5/4 | Bruno Alegria | Added XML documentation and comments to ShowAvailable in Board.cs |

---
## Architecture

> here goes the description (organizations and non trivial algorithms)

    Our project is organized between 4 classes, Game, Board, Player and Piece. Where Game initiates the instances necessary for the program and has the game loop, Board is an object with the state of the game board and all the Piece Objects in it in a Pieces array, Player has the methods necessary for the moves the player can take, and Piece is an object that is instantiated with an enumeration and has its own string identifier.

> here goes the fluxogram (steps walked through in the program)

```mermaid
flowchart LR;
    M(Main) --> G(Game);
```
---
## References
#### Ideas
* Mariana - To have 4 classes for the project, and deal with the window in the Game class.
* Mariana - use and enumeration with bit by bit to identify pieces
* Mariana - have an array for the board where we place the pieces, and is read in a for when we want to check is the piece is in use
#### Ai Code
#### Open Code
* [Stack Overflow, How to draw tables](https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c)
#### Libraries
* [Markdown cheat sheet](https://www.markdownguide.org/cheat-sheet/) 
* [Markdown docs](https://paperhive.org/help/markdown)
* [Mermaid docs](https://mermaid.js.org/syntax/flowchart.html)
* https://www.w3schools.com/cs/cs_arrays_multi.php
* https://www.w3schools.com/cs/cs_classes.php
* https://www.w3schools.com/cs/cs_constructors.php                            // ivan referencia isto sem ser so links bruv
