using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class data
    {
        public int consumer_id { get; set; }
        public string consumer_name { get; set; }
        public double consumer_units { get; set; }
        public double costperunit { get; set; }
        public double total_amount { get; set; }
    }

    #region bill

    
    class bill_data
    {
        public int bill_number { get; set; }
        public int consumer_id { get; set; }
        public double total_amount { get; set; }
        public DateTime due_date { get; set; }

        public static int count=1;

    }
    #endregion
    class Program
    {
        public static bill_data bill_generation(data consumer_data)
        {
            bill_data temp_data = new bill_data();
            temp_data.bill_number = bill_data.count;
            bill_data.count++;
            temp_data.consumer_id = consumer_data.consumer_id;
            temp_data.total_amount = consumer_data.total_amount;
            DateTime now = DateTime.Now;
            temp_data.due_date = now.AddDays(20).Date;
            return temp_data;

        }
        static void Main(string[] args)
        {
            var consumer_data = new List <data>();
            var bill = new List<bill_data>();
            double costperunit = 10;
            Console.WriteLine("Enter the number of consumers:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Consumer no:");
                int consumer_no = Convert.ToInt32(Console.ReadLine());

                Console.Write("Consumer name:");
                string consumer_name=Console.ReadLine();

                Console.Write("No of units:");
                double consumer_units =Convert.ToDouble( Console.ReadLine());

                double total_amount = consumer_units * costperunit;

                data c_data = new data() { consumer_id=consumer_no,consumer_name= consumer_name, consumer_units=consumer_units, costperunit = costperunit, total_amount = total_amount };
                consumer_data.Add(c_data);
                bill_data b_data = bill_generation(c_data);
                bill.Add(b_data);
            }

            Console.WriteLine("Bills generated:\n ***************************************");

            foreach (var b_data in bill)
            {
                Console.WriteLine("Bill number:" + b_data.bill_number);
                Console.WriteLine("Consumer ID:" + b_data.consumer_id);
                Console.WriteLine("Total Amount:" + b_data.total_amount);
                Console.WriteLine("Due Date:" + b_data.due_date);
                Console.WriteLine("\n\n");
            }
            

            Console.ReadLine();
        }
    }
}
