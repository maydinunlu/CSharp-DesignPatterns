using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new DataSource();
            var uiControl1 = new UIObject();
            var uiControl2 = new UIObject();
            dataSource.AddObserver(uiControl1);
            dataSource.AddObserver(uiControl2);

            dataSource.Value = 7;
        }
    }
}