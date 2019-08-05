// ************************************************************************
//  
// Copyright © 2010-2018 wuhan wangyou tec.Corporation,All Rights Reserved.
// 版权所有：     武汉网友科技有限公司
//
// 作者(Author):                    毛善丽
//
// 数据表(Table):
//
// 创建日期(Create Time):
//
// 说明（Description):
//
// 修改记录（Revision History)：
//    R1: 
//           
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    class Waitress
    {
        List<Menu> lst = new List<Menu>();
       
        public Waitress(List<Menu> lst)
        {
            this.lst = lst;
        }
        public void printMenu()
        {
            foreach(var item in lst)
            printMenu(item.createIterator());
         
            Console.ReadKey();
        }
        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem item = (MenuItem)iterator.Next();
                Console.WriteLine(item.getName() + ","+item.getDescription()+","+item.getPrice()+"\n");
               
            }
        }
    }
}
