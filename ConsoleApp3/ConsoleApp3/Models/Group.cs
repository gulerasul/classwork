using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class Group 
    {
        public string GroupNo { get; set; }
        public int StudentLimit {
            get
            {
                return StudentLimit;
            }
           

            set
            {
                if (value<=5 && value>=18)
                {
                    value = StudentLimit;
                }
            }
            
            
        }
        
          

        //public Group(string GroupNo,int StudentLimit)
        //{
        //    this.GroupNo = GroupNo;
        //    this.StudentLimit = StudentLimit;
        //}


    }
}
