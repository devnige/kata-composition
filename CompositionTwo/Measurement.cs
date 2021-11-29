namespace Algorithm
{
    public struct Measurement // records in C# 10 which is like classes. Similar to Kotlin (layer on top of Java)
    {
        public Measurement(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X;
        public int Y; // Note there is no behaviour here, just a bag of data.
    }
}
