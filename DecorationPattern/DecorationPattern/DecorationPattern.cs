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

namespace DecorationPattern
{
    //装饰者基类
    public abstract class Beverage
    {
        public string description = "Unknown beverage";
        public double price;
        public virtual string getDescription()
        {
            return description;
        }
        public abstract double cost();

    }
    //装饰者基类继承自被装饰者基类
    public abstract class Condiment : Beverage
    {
        //隐藏父类方法
        public abstract override string getDescription();

    }
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "espresso";
            price = 1.99;
        }
        public override double cost()
        {
            return price;
        }
     
    }
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
            price = 0.89;
        }
        public override double cost()
        {
            return price;
        }
    
    }
    public class Mocha : Condiment
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            price = 0.20;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ",Mocha";
        }
        public override double cost()
        {
            return price + beverage.cost();
        }
    }
    public class Soy : Condiment
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            price = 0.11;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ",Soy";
        }
        public override double cost()
        {
            return price + beverage.cost();
        }

    }
    public class Whip : Condiment
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            price = 0.22;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ",Whip";
        }
        public override double cost()
        {
            return price + beverage.cost();
        }

    }
}
