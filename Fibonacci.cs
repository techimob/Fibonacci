void Main()
{
	GetFibo(skip:100000000).Take(10).Dump();
}

// Define other methods and classes here

const int F0 = 0;
const int F1 = 1;

public IEnumerable<int> GetFibo(int skip=0) 
{
	int i1 = F0;
	int i2 = F1;
	for (int i = 0; i < skip; i++)
	{
		int fibo = i1 + i2;
 		i1 = i2;
		i2 = fibo;
	}
	
	yield return i1;
	yield return i2;
	while (true) 
	{
		int fibo = i1 + i2;
		yield return fibo;	
 		i1 = i2;
		i2 = fibo;
	}
}
