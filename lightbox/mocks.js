let mockViewModel = {
  title: '2018 fantasy baseball projections',
  batters: ko.observableArray([
    { name: 'Mike Trout', team: 'LAA', position: 'OF', 
      games: 156, atBats: 548, battingAverage: 0.308, homeRuns: 39, runsBattedIn: 97, runs: 119, netStolenBases: 21 },
    { name: 'Trea Turner', team: 'WAS', position: 'SS', 
      games: 146, atBats: 586, battingAverage: 0.304, homeRuns: 16, runsBattedIn: 66, runs: 102, netStolenBases: 48 },
    { name: 'Jose Altuve', team: 'HOU', position: '2B', 
      games: 156, atBats: 615, battingAverage: 0.337, homeRuns: 23, runsBattedIn: 84, runs: 106, netStolenBases: 24 },
    { name: 'Mookie Betts', team: 'BOS', position: 'OF', 
      games: 154, atBats: 638, battingAverage: 0.288, homeRuns: 26, runsBattedIn: 102, runs: 107, netStolenBases: 21 },
    { name: 'Nolan Arenado', team: 'COL', position: '3B', 
      games: 159, atBats: 612, battingAverage: 0.302, homeRuns: 40, runsBattedIn: 135, runs: 105, netStolenBases: 0 },
    { name: 'Paul Goldschmidt', team: 'ARI', position: '1B', 
      games: 157, atBats: 567, battingAverage: 0.302, homeRuns: 26, runsBattedIn: 103, runs: 105, netStolenBases: 16 },
    { name: 'Bryce Harper', team: 'WAS', position: 'OF', 
      games: 156, atBats: 559, battingAverage: 0.293, homeRuns: 35, runsBattedIn: 106, runs: 114, netStolenBases: 9 },
    { name: 'Charlie Blackmon', team: 'COL', position: 'OF', 
      games: 154, atBats: 617, battingAverage: 0.323, homeRuns: 31, runsBattedIn: 89, runs: 121, netStolenBases: 6 },
    { name: 'Giancarlo Stanton', team: 'NYY', position: 'OF', 
      games: 150, atBats: 552, battingAverage: 0.268, homeRuns: 49, runsBattedIn: 113, runs: 101, netStolenBases: 0 },
    { name: 'Aaron Judge', team: 'NYY', position: 'OF', injuryType: 'DTD', injuryLocation: 'shoulder', 
      games: 147, atBats: 525, battingAverage: 0.270, homeRuns: 42, runsBattedIn: 106, runs: 111, netStolenBases: 3 }  
  ])
}
