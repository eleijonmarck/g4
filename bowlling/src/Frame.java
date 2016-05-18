/**
 * Created by ericleijonmarck on 2016-05-18.
 */
public class Frame {

    private int frameScore;

    public void addFrameScore(int pins){
        frameScore += pins;
    }
    public int score(){
        return frameScore;
    }
}
