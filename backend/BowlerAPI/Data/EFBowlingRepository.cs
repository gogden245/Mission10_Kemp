using API.Controllers;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace BowlerAPI.Data
{
	public class EFBowlingRepository : IBowlingRepository
	{
		private BowlerContext _bowlerContext;
		public EFBowlingRepository(BowlerContext temp)
		{
			_bowlerContext = temp;
		}
		public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers;
		public IEnumerable<Team> Teams => _bowlerContext.Teams;

		public IEnumerable<Bowler> GetTeam()
		{
			var teamBowlers = from team in _bowlerContext.Teams
							  join bowler in _bowlerContext.Bowlers on team.TeamID equals bowler.TeamID
							  select new Bowler
							  {
								  TeamName = team.TeamName,
								  BowlerFirstName = bowler.BowlerFirstName,
								  BowlerLastName = bowler.BowlerLastName,
								  BowlerAddress = bowler.BowlerAddress,
								  BowlerCity = bowler.BowlerCity,
								  BowlerState = bowler.BowlerState,
								  BowlerZip = bowler.BowlerZip,
								  BowlerPhoneNumber = bowler.BowlerPhoneNumber,
							  };
		return teamBowlers.ToList();
		}
}
