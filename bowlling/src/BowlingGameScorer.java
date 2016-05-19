import java.util.ArrayList;

/**
 * Created by ericleijonmarck on 2016-05-13.
 */
public class BowlingGameScorer implements BowlingGame {

    private int totalScore;
    private int rolls;
    private int frameScore;
    private int strikeCount;
    private boolean addNextRoll;
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
        _frames.get(frameNumber).addFrameScore(pins);
        totalScore += pins;
        frameScore += pins;
        if ( rolls % 3 == 0){
            frameNumber = frameNumber +1;
        }

        if (addNextRoll && !strike()){
            totalScore += pins;
            _frames.get(frameNumber - 1).addFrameScore(pins);
            addNextRoll = false;
        }

        if (addNextTwoRolls && !strike()){
            totalScore += pins;
            _frames.get(frameNumber -1).addFrameScore(pins);

            if (rolls % 2 == 0){
                addNextTwoRolls = false;
            }
        }

        if (spare()){
            addNextRoll = true;
            frameScore = 0;
        }

        if (strike()){
            addNextTwoRolls = true;
            rolls = rolls + 1;
            strikeCount = strikeCount + 1;
            frameScore = 0;
        }

        if (strikeCount == 2){
            _frames.get(frameNumber -1).addFrameScore(pins);
        }
        if (threeStrikes()){
            _frames.get(frameNumber - 2).addFrameScore(pins);
            _frames.get(frameNumber - 1).addFrameScore(pins);
            strikeCount = strikeCount - 1;
        }

        if(threeStrikesInARowForAllButLastRolls()){
            totalScore += pins;
            _frames.get(frameNumber -1).addFrameScore(pins);
            strikeCount = strikeCount - 1;
        }
    }

    public int score() {
//        return totalScore;
        return _frames.stream().mapToInt(frame -> frame.score()).sum();
    }

    private boolean oddRoll(int rolls){
       if ( rolls % 2 == 0){
           return false;
       }
        else {
           return true;
       }
    }

    private boolean spare(){
        return (rolls % 2 == 0 && _frames.get(frameNumber).score() == 10);
    }

    private boolean strike(){
        return (_frames.get(frameNumber).score() == 10 && oddRoll(rolls));
    }

    private boolean isTwoRollsWithoutHittingAStrikeOrASpare(){
        return ( rolls % 2 == 0 && frameScore < 10);
    }

    private boolean threeStrikes() {
        return (strikeCount == 3);
    }

    private boolean threeStrikesInARowForAllButLastRolls(){
        return (strikeCount == 3 && rolls < 20);
    }
}
