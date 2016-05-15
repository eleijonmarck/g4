/**
 * Created by ericleijonmarck on 2016-05-13.
 */
public class Game {

    private int totalScore;
    private int rolls;
    private int frameScore;
    private boolean addNextPin;
    private boolean addNextTwoRolls;

    public Game(){
        rolls = 0;
    }

    public void roll(int pins) {
        rolls = rolls +1;
        totalScore += pins;
        frameScore += pins;

        if (addNextPin){
            totalScore += pins;
            addNextPin = false;
        }

        if (addNextTwoRolls){
            totalScore += pins;
            if (rolls % 2 == 0){
                addNextPin = false;
            }
        }

        if (rolls % 1 == 0 && frameScore == 10){
            addNextTwoRolls = true;
            rolls = rolls + 1;
            frameScore = 0;
        }

        if (rolls % 2 == 0 && frameScore == 10){
            addNextPin = true;
            frameScore = 0;
        }

        if ( rolls % 2 == 0 && frameScore < 10){
            frameScore = 0;
        }
    }

    public int score() {
        return totalScore;
    }
}
