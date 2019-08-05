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
using System.Text;

namespace ConsoleApp1
{
    class CeilingFan
    {
        //const定义的可以直接用类名访问
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        int speed;
        public CeilingFan()
        {
            speed = OFF;
        }
        public void high()
        {
            speed = HIGH;
        }
        public void low()
        {
            speed = LOW;
        }
        public void medium()
        {
            speed = MEDIUM;
        }
        public void Off()
        {
            speed = OFF;
        }
        public int getSpeed()
        {
            return speed;
        }
            
    }
}
