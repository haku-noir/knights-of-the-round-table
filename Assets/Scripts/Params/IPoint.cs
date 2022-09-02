namespace Params
{
    interface IPoint
    {
        int Point { get; set; }

        void AddPoint(int point);
        void SubtractPoint(int point);
    }
}