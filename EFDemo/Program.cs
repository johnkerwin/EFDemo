 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EFDemoEntities())
            {
                var query = from b in db.MyGroups
                           
                            orderby b.group_name
                            select b;
           
             



                Console.WriteLine("All Groups in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.group_name);
                    var members = item.GroupMembers;
                    foreach (var member in members)
                    {
                        Console.Write("-->");
                        Console.WriteLine((member.Member.member_name));
                    }


                        
                }

            }
        }
    }
}
