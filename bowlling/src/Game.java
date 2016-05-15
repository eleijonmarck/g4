/**
 * Created by ericleijonmarck on 2016-05-13.
 */
public class Game {

    private int totalScore;
    private int rolls;
    private int frameScore;
    private boolean addNextPin;

    public Game(){
        rolls = 0;
    }

    public void roll(int pins) {
        rolls = rolls +1;
        totalScore += pins;
        frameScore += pins;

        if (addNextPin){
            totalScore += pins;
        }

        if (rolls % 1 == 0 && frameScore == 10){
            addNextPin = true;
        }

        if (rolls % 2 == 0 && frameScore == 10){
            addNextPin = true;
            frameScore = 0;
        }
    }

    public int score() {
        return totalScore;
    }
}
