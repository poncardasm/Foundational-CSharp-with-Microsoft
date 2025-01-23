﻿/*
  ## Role playing game battle challenge

  In some role playing games, the player's character battles non-player characters, which are usually monsters or the "bad guys". Sometimes, a battle consists of each character generating a random value using dice and that value is subtracted from the opponent's health score. Once either character's health reaches zero, they lose the game.

  In this challenge, we boil down that interaction to its essence. A hero and a monster start with the same health score. During the hero's turn, they generate a random value that is subtracted from the monster's health. If the monster's health is greater than zero, they take their turn and attack the hero. As long as both the hero and the monster have health greater than zero, the battle resumes.

  ## Code challenge - write code to implement the game rules

  Here are the rules for the battle game that you need to implement in your code project:

  - You must use either the do-while statement or the while statement as an outer game loop.
  - The hero and the monster start with 10 health points.
  - All attacks are a value between 1 and 10.
  - The hero attacks first.
  - Print the amount of health the monster lost and their remaining health.
  - If the monster's health is greater than 0, it can attack the hero.
  - Print the amount of health the hero lost and their remaining health.
  - Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
  - Print the winner.
*/

Random attackNum = new Random();
int heroHP = 10;
int monsterHP = 10;

do
{
  int heroDMG = attackNum.Next(1, 11);
  monsterHP -= heroDMG;
  Console.WriteLine($"Monster was damaged and lost {heroDMG} and now has {monsterHP} health");

  if (monsterHP <= 0) continue;

  int monsterDMG = attackNum.Next(1, 11);
  heroHP -= monsterDMG;
  Console.WriteLine($"Hero was damaged and lost {monsterDMG} and now has {heroHP} health");

} while (heroHP > 0 && monsterHP > 0);

Console.WriteLine(heroHP > monsterHP ? "Hero wins!" : "Monster wins!");