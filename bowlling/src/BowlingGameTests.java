import org.junit.Test;

import static org.junit.Assert.assertEquals;


public class BowlingGameTests {

    @Test
    public void shouldReturnZeroByPlayingAGutterGame() throws Exception {

        BowlingGameScorer g = new BowlingGameScorer();
        for (int i=0; i < 20; i++)
            g.roll(0);

        assertEquals(0, g.score());
    }

    @Test
    public void shouldHaveScoreAfterMakingAllOnes() throws Exception {

        BowlingGameScorer g = new BowlingGameScorer();
        for (int i= 0; i < 20; i++){
           g.roll(1);
        }
        assertEquals(20, g.score());
    }

    @Test
    public void shouldBeAbleToMakeASpare() throws Exception {

        BowlingGameScorer g = new BowlingGameScorer();

        for (int i=0;i<3;i++){
            g.roll(5);
        }
        assertEquals(20, g.score());

    }

    @Test
    public void shouldBeAbleToMakeAStrike() throws Exception {
        BowlingGameScorer g = new BowlingGameScorer();

        g.roll(10);
        g.roll(2);
        g.roll(8);

        assertEquals(30, g.score());
    }

    @Test
    public void shouldBeAbleToPlayAPerfectGame() throws Exception {
        BowlingGameScorer g = new BowlingGameScorer();

        for (int i=0;i<12;i++)
        {
            g.roll(10);
        }

        assertEquals(300, g.score());
    }
}
