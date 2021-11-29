using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Composition
{
    public class HighPassSummingAggregator : IAggregationStrategy, IMeasurementFilter
    {
        public HighPassSummingAggregator(IEnumerable<Measurement> measurements)
        {
        }

        public Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            return new Measurement { X = measurements.Sum(m => m.X), Y = measurements.Sum(m => m.Y) };
        }

        public IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements)
        {
            return measurements.Where(m => m.X >= 3 && m.Y >= 3);
        }
    }
}