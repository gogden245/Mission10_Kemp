using BowlerAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlerAPI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class BowlingLeagueController : ControllerBase
	{
		private IBowlingRepository _bowlingRepository;
		public BowlingLeagueController(IBowlingRepository temp)
		{
			_bowlingRepository = temp;
		}
		[HttpGet("GetTeam")]
		public IEnumerable<Bowler> GetTeam()
		{
			var bowlerData = _bowlingRepository.Bowlers.ToArray().
				Where(b => b.TeamName == "Marlins" || b.TeamName == "Sharks");
			return bowlerData;
		}
	}
}
