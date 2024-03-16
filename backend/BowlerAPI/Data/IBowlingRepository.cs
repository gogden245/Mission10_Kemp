namespace BowlerAPI.Data
{
	public interface IBowlingRepository
	{
		IEnumerable<Bowler> Bowlers { get; }
		IEnumerable<Team> Teams { get; }
	}
}
