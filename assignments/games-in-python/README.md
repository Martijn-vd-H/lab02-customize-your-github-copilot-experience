# 📘 Assignment: Hangman Game Challenge

## 🎯 Objective

Build a classic Hangman game in Python using strings, loops, conditionals, and user input. By the end of this assignment, you will create a complete command-line game with clear win and lose conditions.

## 📝 Tasks

### 🛠️ Setup the Game Data

#### Description
Create the core game setup by defining a word list, selecting one random word, and preparing variables to track guesses and attempts.

#### Requirements
Completed program should:

- Define a list with at least 5 possible secret words.
- Randomly choose one word from that list at the start of the game.
- Create a display format for hidden letters (for example: `_ _ _ _`).
- Set a fixed number of incorrect guesses allowed.


### 🛠️ Implement the Guessing Loop

#### Description
Build the main game loop where the player enters letter guesses and receives feedback after each guess.

#### Requirements
Completed program should:

- Prompt the player to enter one letter per turn.
- Reveal correctly guessed letters in all matching positions.
- Decrease remaining attempts only for incorrect guesses.
- Show updated word progress and attempts remaining after each turn.


### 🛠️ Finish the Game with Results

#### Description
Add final game outcomes so the program clearly ends when the player wins or runs out of attempts.

#### Requirements
Completed program should:

- End the game with a win message when the full word is guessed.
- End the game with a lose message when attempts reach zero.
- Display the secret word at the end of the game.
