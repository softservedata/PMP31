using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManager.DAL;

namespace OrderManager
{
   public class Program
    {
        static void Main(string[] args)
        {
            //orderManagerEntities order = new orderManagerEntities();
            Console.Write("Input id of User ");
            int id_u1 = Convert.ToInt32(Console.ReadLine());
            List<int> i = (new OrdersDAL().ItemsList(id_u1));
            foreach (int x in i)
            {
                Console.Write(x + "  ");
            }
            Console.WriteLine();
            Console.Write("Input id of Item ");
            int id_i1 = Convert.ToInt32(Console.ReadLine());
            List<int> u = (new OrdersDAL().UsersList(id_i1));
            foreach (int x in u)
            {
                Console.Write(x + "  ");
            }
            //OrdersDAL ord = new OrdersDAL();
            //UsersDAL use = new UsersDAL();
            //ItemsDAL ite = new ItemsDAL();
            //DeliversDAL del = new DeliversDAL();
            //Console.Write("Input id of User ");
            //int id_u = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input id of Item ");
            //int id_i = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Das the order paid? yes-1/no-0 ");
            //int id_s = Convert.ToInt32(Console.ReadLine());
            //ord.addOrder(id_u,id_i,id_s);
            //Console.WriteLine("Order is add");
            //Console.Write("Input id of deleting Order ");
            //int id_d = Convert.ToInt32(Console.ReadLine());
            //ord.deleteOrder(id_d);
        }
    }
}
