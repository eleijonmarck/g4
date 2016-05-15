import junit.framework.TestCase;
import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class BowlingGameTests extends TestCase {

    @Test
    public void testGutterGame() throws Exception {

        Game g = new Game();
        for (int i=0; i < 20; i++)
            g.roll(0);

        assertEquals(0, g.score());
    }

    @Test
    public void testAllOnesGame() throws Exception {

        Game g = new Game();
        for (int i= 0; i < 20; i++){
           g.roll(1);
        }
        assertEquals(20, g.score());
    }

    @Test
    public void testOneSpare() throws Exception {

        Game g = new Game();

        for (int i=0;i<3;i++){
            g.roll(5);
        }
        assertEquals(20, g.score());

    }

    @Test
    public void testOneStrike() throws Exception {
        Game g = new Game();

        g.roll(10);
        g.roll(2);
        g.roll(8);

        assertEquals(30, g.score());
    }
}
