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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterateCombine
{
    class LeafComponent : MenuComponent
    {
        string name;
        string description;
        bool isvegetarian;
        double price;

        public LeafComponent(string name,string description,bool isvegetarian,double price)
        {
            this.name = name;
            this.description = description;
            this.isvegetarian = isvegetarian;
            this.price = price;
        }

        public override IEnumerator createIEnumerator()
        {
            //return null;
            return new NullIEnumerator();
        }

        public override string getDescription()
        {
            return description;
        }

        public override string getName()
        {
            return name;
        }

        public override double getPrice()
        {
            return price;
        }

        public override bool isVegetarian()
        {
            return isvegetarian;
        }

        public override void print()
        {
            Console.Write(" " + getName());
            if (isVegetarian())
                Console.Write("v");
            Console.WriteLine("," + getPrice());
            Console.WriteLine("    --" + getDescription());
        }
    }
}
