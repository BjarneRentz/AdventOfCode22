namespace AdventOfCode22.Challenges;

public class Challenge1
{
	public void Solve(string rawInput)
	{
		List<int> caloriesPerElf = new();

		var numbers = rawInput.Split("\n");

		var currentPos = 0;
		foreach (var number in numbers)
		{
			if (number == "")
			{
				currentPos++;
				continue;
			}
			
			if(caloriesPerElf.Count == currentPos)
				caloriesPerElf.Insert(currentPos,Convert.ToInt32(number));
			else
				caloriesPerElf[currentPos] += Convert.ToInt32(number);
		}
		
		Console.WriteLine(caloriesPerElf.Max());
	} 
}