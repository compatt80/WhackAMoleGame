namespace WhackAMoleGame;

public class Mole
{
    public int Index;
    public PictureBox Hole;
    public bool IsShow;
    public bool IsGolden;
    public int Score;
    public DateTime ShowTime;
    public int StayTime;

    public Mole(int index, PictureBox hole)
    {
        Index = index;
        Hole = hole;
        IsShow = false;
        IsGolden = false;
        Score = 10;
        StayTime = 1300;
    }
}
