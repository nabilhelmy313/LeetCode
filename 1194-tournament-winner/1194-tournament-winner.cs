 string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    // Write your code here.
    Dictionary<string, int> score = new();
    string bestTeam = "";
    score[bestTeam] = 0;
    for (int i = 0; i < competitions.Count; i++)
    {
        List<string> comp = competitions[i];

        int res = results[i];
       var winnerr=res ==0 ? comp[1] : comp[0];
        UpdateScore(winnerr, 3, score);
        if (score[winnerr] > score[bestTeam])
        {
            bestTeam = winnerr;
        }
    }
    return bestTeam;

}
List<List<string>> x = new List<List<string>>();
x.Add(new List<string>
{
    "HTML",
    "C#"
});
x.Add(new List<string>
{
    "C#",
    "Python"
});
x.Add(new List<string>
{
    "Python",
    "HTML"
});

void UpdateScore(string team,int Point,Dictionary<string,int> score)
{
    if (!score.ContainsKey(team))
    {
        score[team] = 0;
    }
    score[team] += Point;
}

string xx=TournamentWinner(x, new List<int>
{
    0,0,1
});
Console.WriteLine(xx);
Console.ReadKey();