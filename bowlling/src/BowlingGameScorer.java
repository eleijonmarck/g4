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
        frameNumber = 0;
        _frames = new ArrayList<Frame>();
        for (int i=0;i<11;i++){
            _frames.add(new Frame());
        }
    }

    public void roll(int pins) {
        rolls = rolls +1;
        if ( rolls % 2 == 0){
            frameNumber = frameNumber +1;
        }
        totalScore += pins;
        frameScore += pins;
        _frames.get(frameNumber).addFrameScore(pins);

        if (addNextPin){
            totalScore += pins;
            _frames.get(frameNumber - 1).addFrameScore(pins);
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
        return _frames.stream().mapToInt(frame -> frame.score()).sum();
    }

    private boolean isASpare(){
        return (rolls % 2 == 0 && frameScore == 10);
    }

    private boolean isAStrike(){
        return (_frames.get(frameNumber).score() == 10 && rolls % 2 != 0);
    }

    private boolean isTwoRollsWithoutHittingAStrikeOrASpare(){
        return ( rolls % 2 == 0 && frameScore < 10);
    }

    private boolean threeStrikesInARowForAllButLastRolls(){
        return (strikeCount == 3 && rolls < 20);
    }
}
