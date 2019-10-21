using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work
{
    public class Menager
    {
        public WareHouse WareHouse { get; }
        public Menager()
        {

        }
        public Menager(WareHouse wareHouse)
        {
            WareHouse = wareHouse;
        }
        public void DoWork(List<Workers> workers) {
            if (workers == null || workers.Count ==0)
            {
                CloseWareHouse();
            }
            DelegateCommand(workers);
        }

        private void DelegateCommand(List<Workers> workers)
        {
            List<Task> tasks = new List<Task>();
            workers.ForEach(e => tasks.Add(new Task(() => Console.WriteLine(e.DoWork()))));
            tasks.ForEach(t => t.Start());
            Task.WaitAll(tasks.ToArray());
            CloseWareHouse();
        }

        private void CloseWareHouse()
        {
            Console.WriteLine("Kierownik Kończy pracę");
        }
        private void OpenWareHouse()
        {
            Console.WriteLine("Kierownik rozpoczyna pracę");
           
        }
    }
}
