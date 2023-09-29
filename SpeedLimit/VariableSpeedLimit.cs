namespace SpeedLimit
{
    public class VariableSpeedLimit
    {
        public double journeyTime(int journeyLength, int[] speedLimit)
        {
            Console.WriteLine($"Journey length: {journeyLength}, Speed limit: [{string.Join(", ", speedLimit)}]");

            if (journeyLength < 1 || journeyLength > 100000)
                return -1;

            if (!speedLimit.Any() || speedLimit.Count() > 50)
                return -2;

            if (!IsValidSpeedLimit(speedLimit))
                return -3;

            double totalTime = 0;
            int currentTime = 0;

            while (journeyLength > 0)
            {
                int currentSpeedLimit = speedLimit[currentTime % speedLimit.Length];

                // Calculate the distance that can be covered at the current speed limit.
                int distanceCovered = Math.Min(journeyLength, currentSpeedLimit);

                double time = 0;

                // Calculate the time it takes to cover the distance at the current speed limit.
                if (Math.Abs(currentSpeedLimit) > 1E-9)
                {
                    time = (double)distanceCovered / currentSpeedLimit;
                }

                // Update the total time and decrement the remaining journey length.
                totalTime += time;
                journeyLength -= distanceCovered;

                currentTime++;
            }

            return totalTime;
        }

        private bool IsValidSpeedLimit(int[] speedLimit)
        {
            return speedLimit.All(x => x >= 1 && x <= 100);
        }
    }
}
