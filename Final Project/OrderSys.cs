using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.Linq.Mapping;

namespace Final_Project
{
     static  class OrderSys
    {
        // saves the order to both the ticket (file) and database
        public static int SaveOrder(Hamburger order)
        {
            int orderNum = OrderNumber() + 1;

            SaveToFile(order, orderNum);
            if (SaveToDB(order, orderNum))
            {
                MessageBox.Show("Your order number is: " + orderNum);
            }
            else
            {
                MessageBox.Show("There was an error. Try again");
            }

            return orderNum;
        }



        public static int SaveOrder(Sub order)
        {
            int orderNum = OrderNumber() + 1;
            SaveToFile(order, orderNum);
            if (SaveToDB(order, orderNum))
            {
                MessageBox.Show("Your order number is: " + orderNum);
            }
            else
            {
                MessageBox.Show("There was an error. Try again");
            }
            return orderNum;
        }

        

        //loads order from database. 
        public static Hamburger LoadBurgerOrder(int orderNum)
        {
            Hamburger result = new Hamburger();
            OrderDataDataContext db = new OrderDataDataContext();

            var orderPage = from o in db.Orders
                            join h in db.BurgerDatas
                               on o.OrderId equals h.OrderId
                            where o.OrderId == orderNum
                            select new

                            {
                                o.Name,
                                h.Meat,
                                h.Cheese,
                                h.Bacon,
                                h.Lettuce,
                                h.Tomato,
                                h.Onion,
                                h.Ketchup,
                                h.Mustard,
                                h.Mayo
                            };

            result.name = orderPage.FirstOrDefault().Name;
            result.meat = orderPage.FirstOrDefault().Meat;
            result.cheese = orderPage.FirstOrDefault().Cheese;
            result.bacon = orderPage.FirstOrDefault().Bacon.ToCharArray()[0];
            result.lettuce = orderPage.FirstOrDefault().Lettuce.ToCharArray()[0];
            result.tomato = orderPage.FirstOrDefault().Tomato.ToCharArray()[0];
            result.onion = orderPage.FirstOrDefault().Onion.ToCharArray()[0];
            result.ketchup = orderPage.FirstOrDefault().Ketchup.ToCharArray()[0];
            result.mustard = orderPage.FirstOrDefault().Mustard.ToCharArray()[0];
            result.mayo = orderPage.FirstOrDefault().Mayo.ToCharArray()[0];

            return result;
        }
        public static Sub LoadSubOrder(int orderNum)
        {
            Sub result = new Sub();
            OrderDataDataContext db = new OrderDataDataContext();

            var orderPage = from o in db.Orders
                            join s in db.SubDatas
                               on o.OrderId equals s.OrderId
                            where o.OrderId == orderNum
                            select new

                            {
                                o.Name,
                                s.Meat,
                                s.Cheese,
                                s.Pickle,
                                s.Lettuce,
                                s.Tomato,
                                s.Onion,
                                s.Mustard,
                                s.Mayo,
                                s.Vinaigrette
                            };

            result.name = orderPage.FirstOrDefault().Name;
            result.meat = orderPage.FirstOrDefault().Meat;
            result.cheese = orderPage.FirstOrDefault().Cheese;
            result.lettuce = orderPage.FirstOrDefault().Lettuce.ToCharArray()[0];
            result.onion = orderPage.FirstOrDefault().Onion.ToCharArray()[0];
            result.pickle = orderPage.FirstOrDefault().Pickle.ToCharArray()[0];
            result.mustard = orderPage.FirstOrDefault().Mustard.ToCharArray()[0];
            result.mayo = orderPage.FirstOrDefault().Mayo.ToCharArray()[0];
            result.vinaigrette = orderPage.FirstOrDefault().Vinaigrette.ToCharArray()[0];

            return result;
        }


        private static void SaveToFile(Hamburger order, int orderNum)
        {
            try
            {
                StreamWriter write;
                write = File.CreateText("order.txt");
                write.WriteLine("Order Number: " + orderNum);
                write.WriteLine("Name: " + order.name);
                write.WriteLine("Size: " + order.meat);
                write.WriteLine("Cheese: " + order.cheese);
                write.WriteLine("Bacon: " + order.bacon);
                write.WriteLine("Lettuce: " + order.lettuce);
                write.WriteLine("Tomato: " + order.tomato);
                write.WriteLine("Onion: " + order.tomato);
                write.WriteLine("Onion: " + order.onion);
                write.WriteLine("Ketchup: " + order.ketchup);
                write.WriteLine("Mustard: " + order.mustard);
                write.WriteLine("Mayo: " + order.mayo);

                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void SaveToFile(Sub order, int orderNum)
        {
            try
            {
                StreamWriter write;
                write = File.CreateText("order.txt");
                write.WriteLine("Order Number: " + orderNum);
                write.WriteLine("Name: " + order.name);
                write.WriteLine("Size: " + order.meat);
                write.WriteLine("Cheese: " + order.cheese);
                write.WriteLine("Pickle: " + order.pickle);
                write.WriteLine("Lettuce: " + order.lettuce);
                write.WriteLine("Tomato: " + order.tomato);
                write.WriteLine("Onion: " + order.onion);
                write.WriteLine("Mayo: " + order.mayo);
                write.WriteLine("Mustard: " + order.mustard);
                write.WriteLine("Vinaigrette: " + order.vinaigrette);

                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool SaveToDB(Hamburger order, int orderNum)
        {
            try
            {
                OrderDataDataContext db = new OrderDataDataContext();

                Order ord = new Order();
                ord.OrderId = orderNum;
                ord.Name = order.name;
                ord.HAMBURGER = "Y";
                ord.SUB = "N";

                db.Orders.InsertOnSubmit(ord);

                BurgerData burger = new BurgerData();

                burger.OrderId = orderNum;
                burger.Meat = order.meat;
                burger.Cheese = order.cheese;
                burger.Bacon = order.bacon.ToString();
                burger.Lettuce = order.lettuce.ToString();
                burger.Tomato = order.tomato.ToString();
                burger.Onion = order.onion.ToString();
                burger.Ketchup = order.ketchup.ToString();
                burger.Mustard = order.mustard.ToString();
                burger.Mayo = order.mayo.ToString();

                db.BurgerDatas.InsertOnSubmit(burger);

                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static bool SaveToDB(Sub order, int orderNum) // saves sub order to DB
        {
            try
            {
                OrderDataDataContext db = new OrderDataDataContext();

                Order ord = new Order();
                ord.OrderId = orderNum;
                ord.Name = order.name;
                ord.HAMBURGER = "N";
                ord.SUB = "Y";

                db.Orders.InsertOnSubmit(ord);

                SubData sub = new SubData();

                sub.OrderId = orderNum;
                sub.Meat = order.meat;
                sub.Cheese = order.cheese;

                sub.Lettuce = order.lettuce.ToString();
                sub.Tomato = order.tomato.ToString();
                sub.Onion = order.onion.ToString();
                sub.Pickle = order.pickle.ToString();
                sub.Mustard = order.mustard.ToString();
                sub.Mayo = order.mayo.ToString();
                sub.Vinaigrette = order.vinaigrette.ToString();
                db.SubDatas.InsertOnSubmit(sub);

                db.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool isBurger(int orderNum)
        {
            // returns true if is a hamburger order, or false if a sub
            OrderDataDataContext db = new OrderDataDataContext();

            var result = from o in db.Orders
                         where o.OrderId == orderNum
                         select new
                         {
                             o.HAMBURGER,
                             o.SUB
                         };
            if (result.FirstOrDefault().HAMBURGER == "Y")
            {
                return true;
            }
            else if (result.FirstOrDefault().SUB == "Y")
            {
                return false;
            }
            return true;
        }

        public static int OrderNumber()
        {
            int orderNum = 0;
            OrderDataDataContext db = new OrderDataDataContext();

            var orders = from order in db.Orders
                         select order.OrderId;

            if (orders.Any())
            {
                orderNum = orders.Max();
            }
            else
            {
                return 1;
            }
            

            return orderNum;
        }
    }
}
