void Main()
{
	GetFibs(10).Dump();
}

public static IEnumerable<int> GetFibs(int n)
{
	List<int> fibs = new List<int>();
	for (int i = 0; i < n; i++)
	{
		fibs.Add(CalcFib(i));	
	}
	return fibs;
}

private static int CalcFib(int n)
{
	switch (n)
	{
		case 0:
			return 0;
		case 1:
			return 1;
		default:
			return CalcFib(n - 2) + CalcFib(n - 1);
	}
}
