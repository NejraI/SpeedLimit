using SpeedLimit;

VariableSpeedLimit variableSpeedLimit = new VariableSpeedLimit();

double totalTime = 0;

int journeyLength1 = 100;
int[] speedLimit1 = { 50 };
totalTime = variableSpeedLimit.journeyTime(journeyLength1, speedLimit1);
FormatResult(totalTime);

int journeyLength2 = 100;
int[] speedLimit2 = { 50, 25 };
totalTime = variableSpeedLimit.journeyTime(journeyLength2, speedLimit2);
FormatResult(totalTime);

int journeyLength3 = 1000;
int[] speedLimit3 = { 50, 40, 30, 40, 50 };
totalTime = variableSpeedLimit.journeyTime(journeyLength3, speedLimit3);
FormatResult(totalTime);

int journeyLength4 = 2058;
int[] speedLimit4 = { 80, 43, 57, 23, 28, 45, 60, 75, 73, 80 };
totalTime = variableSpeedLimit.journeyTime(journeyLength4, speedLimit4);
FormatResult(totalTime);

int journeyLength5 = 17216;
int[] speedLimit5 = { 26, 30, 62, 55, 51, 56, 58, 4, 60, 23, 31 };
totalTime = variableSpeedLimit.journeyTime(journeyLength5, speedLimit5);
FormatResult(totalTime);

int journeyLength6 = 9839;
int[] speedLimit6 = { 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 69 };
totalTime = variableSpeedLimit.journeyTime(journeyLength6, speedLimit6);
FormatResult(totalTime);


int journeyLength7 = 200000;
int[] speedLimit7 = { 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 69 };
totalTime = variableSpeedLimit.journeyTime(journeyLength7, speedLimit7);
FormatResult(totalTime);


int journeyLength8 = -5;
int[] speedLimit8 = { 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 69 };
totalTime = variableSpeedLimit.journeyTime(journeyLength8, speedLimit8);
FormatResult(totalTime);


int journeyLength9 = 9839;
int[] speedLimit9 = Array.Empty<int>();
totalTime = variableSpeedLimit.journeyTime(journeyLength9, speedLimit9);
FormatResult(totalTime);


int journeyLength10 = 9839;
int[] speedLimit10 = { 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 45, 90, 13, 4, 81, 50, 81, 10, 64, 86, 45, 90, 13, 4, 81, 50, 81, 10, 64, 86 };
totalTime = variableSpeedLimit.journeyTime(journeyLength10, speedLimit10);
FormatResult(totalTime);

int journeyLength11 = 7289;
int[] speedLimit11 = { 45, 150, 13, 4, 81, 50, 81, 10, 64, 86, 69 };
totalTime = variableSpeedLimit.journeyTime(journeyLength11, speedLimit11);
FormatResult(totalTime);

static void FormatResult(double totalTime)
{
    if (totalTime == -1)
        Console.WriteLine("journeyLength must be between 1 and 100000 (10^5), inclusive. \r\n");
    else if (totalTime == -2)
        Console.WriteLine("speedLimit must contain between 1 and 50 elements, inclusive. \r\n");
    else if (totalTime == -3)
        Console.WriteLine("Each element of speedLimit must be between 1 and 100, inclusive. \r\n");
    else
        Console.WriteLine($"Amount of time it takes to complete your journey: {totalTime} \r\n");
}

