import java.util.ArrayList;

/**
 * Created by ericleijonmarck on 2016-05-13.
 */
public class BowlingGameScorer implements BowlingGame {

    private int totalScore;
    private int rolls;
    private int frameScore;
    private int strikeCount;
    private boolean addNextPin;
    private boolean addNextTwoRolls;

    private int frameNumber;
    private ArrayList<Frame> _frames;

    public BowlingGameScorer(){
        rolls = 0;
        strikeCount = 0;
        _frames = new ArrayList<Frame>(10);
    }

    public void roll(int pins) {
        rolls = rolls +1;
        if ( rolls % 2 == 0){
            frameNumber = frameNumber +1;
        }
        totalScore += pins;
        frameScore += pins;

        if (addNextPin){
            totalScore += pins;
            addNextPin = false;
        }

        if (addNextTwoRolls){
            totalScore += pins;
            if (rolls % 2 == 0){
                addNextTwoRolls = false;
            }
        }

        if(threeStrikesInARowForAllButLastRolls()){
            totalScore += pins;
            strikeCount = strikeCount - 1;
        }

        if (isAStrike()){
            addNextTwoRolls = true;
            rolls = rolls + 1;
            strikeCount = strikeCount + 1;
            frameScore = 0;
        }

        if (isASpare()){
            addNextPin = true;
            frameScore = 0;
        }

        if (isTwoRollsWithoutHittingAStrikeOrASpare()){
            frameScore = 0;
        }
    }

    public int score() {
        return totalScore;
    }

    private boolean isASpare(){
        return (rolls % 2 == 0 && frameScore == 10);
    }

    private boolean isAStrike(){
        return (frameScore == 10 && rolls % 2 != 0);
    }

    private boolean isTwoRollsWithoutHittingAStrikeOrASpare(){
        return ( rolls % 2 == 0 && frameScore < 10);
    }

    private boolean threeStrikesInARowForAllButLastRolls(){
        return (strikeCount == 3 && rolls < 20);
    }
}
