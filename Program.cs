Console.WriteLine("Pig Dice");

PigDiceGame.PigDice pigdice = new();

//int ScoreOrGames = int.Parse(args[1]);

var start = DateTime.Now;
/*
if(args[0] == "--games") {
    var highScore = pigdice.PlayGames(ScoreOrGames);
    System.Console.WriteLine($"After {ScoreOrGames:N0}, high score is {highScore}.");
} else {
    var games = pigdice.PlayTillScore(ScoreOrGames);
    System.Console.WriteLine($"\n{ScoreOrGames} took {games:N0} games.");
}
*/
PlayTillScore(450);
//var diff = DateTime.Now = start;
//Console.WriteLine($"Runtime is {diff.Minutes}m {diff.Seconds}s {diff.Milliseconds}ms");

//int score = pigdice.Play();

//System.Console.WriteLine($"Score is {score}");
/*
PlayGames(1000000);

void PlayGames (int NbrOfGames) {

    var highScore = pigdice.PlayGames(NbrOfGames);

    System.Console.WriteLine($"After {NbrOfGames:N0}, HighScore is {highScore}");
}
*/

void PlayTillScore(int TargetScore) {
    
    ulong games = pigdice.PlayTillScore(TargetScore);
    
    System.Console.WriteLine($"{TargetScore} took {games:N0} games.");
}

