/**
 * Created by ericleijonmarck on 2016-05-13.
 */
public class BowlingScoreBoard implements BowlingGame {

    private int totalScore;
    private int rolls;
    private int frameScore;
    private int strikeCount;
    private boolean addNextPin;
    private boolean addNextTwoRolls;

    public BowlingScoreBoard(){
        rolls = 0;
        strikeCount = 0;
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

        if(strikeCount == 3 && rolls < 20){
            totalScore += pins;
            strikeCount = strikeCount - 1;
        }

        if (frameScore == 10){
            addNextTwoRolls = true;
            rolls = rolls + 1;
            strikeCount = strikeCount + 1;
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
