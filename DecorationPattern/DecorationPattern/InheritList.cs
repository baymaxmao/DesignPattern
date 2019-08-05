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

namespace InheritList
{
    public class Beverage
    {
        private double price;
        private Dictionary<Burden,int> dic = new Dictionary<Burden, int>();
        public Beverage(int price)
        {
            this.price = price;
        }
        public void Add(Burden bd,int num)
        {
            dic[bd] = num;
        }
        public double Cost()
        {
            double charge = price;
            foreach (var item in dic)
                charge += item.Key.Cost()*item.Value;
            return charge;
        }
            
    }
    public class Burden
    {
        private double price;
        public Burden(int price)
        {
            this.price = price;
        }
        public double Cost()
        {
            return price;
        }
    }
    class Mocha : Burden
    {
        public Mocha(int price) : base(price)
        {

        }
    }
    class Whip : Burden
    {
        public Whip(int price) : base(price)
        {

        }
    }
    class DarkRoast: Beverage
    {
        public DarkRoast(int price) : base(price)
        {

        }
    }
}
