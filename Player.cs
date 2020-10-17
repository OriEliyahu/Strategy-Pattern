class Player
{
    private string PlayerName;
    public Player(string PlayerName)
    {
        this.PlayerName = PlayerName;
    }

    public void Play(Shoots shoot)
    {
        System.Console.WriteLine(this.PlayerName);
        shoot.Shoot();
    }
}