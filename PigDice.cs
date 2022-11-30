namespace PigDiceGame;

public class PigDice {

    Random random = new();

    private int RollDie() {
       return random.Next(1, 7);
    }

    public int Play() {
        int score = 0;
        int roll = RollDie();
        while (roll != 1) {
            score += roll;
            roll = RollDie();

        } 
        return score;
    }
    public int PlayGames(int NbrGames) {
        int highScore = 0;
        for (int i = 0; i < NbrGames; i++) {
            var score = Play();
            if(score > highScore) highScore = score;
        }
        return highScore;
    }

    public ulong PlayTillScore(int TargetScore) {
        ulong games = 0;
        int highscore = 0; 
        int score;
        while((score = Play()) < TargetScore) {
            if (score > highscore) {
                highscore = score; 
                System.Console.WriteLine($"{highscore,15:N0},");      
            }
            games ++;
        }
        return games;
    }
}