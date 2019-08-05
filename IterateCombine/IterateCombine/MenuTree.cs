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
using System.Collections;

namespace IterateCombine
{
    class MenuTree : MenuComponent,IEnumerable
    {
        //非泛型，所以默认是object类型，在获取元素时需要强制转换
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;
        public override string getDescription()
        {
            return description;
        }

        public override string getName()
        {
            return name;
        }
        public MenuTree(string name,string description)
        {
            this.name = name;
            this.description = description;
        }
        public override void add(MenuComponent menu)
        {
            menuComponents.Add(menu);
        }
        public override bool isVegetarian()
        {
            return false;
        }
        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }
        public override void remove(MenuComponent menu)
        {
            menuComponents.Remove(menu);
        }
        //这种print的方式是内部迭代，不断地通过子类枚举遍历
        public override void print()
        {
            Console.Write("\n"+getName());
            Console.WriteLine("," + getDescription());
            Console.WriteLine("------------");
            IEnumerator enumerator = menuComponents.GetEnumerator();
            while( enumerator.MoveNext())
            {
                MenuComponent component =(MenuComponent) enumerator.Current;
                component.print();
            }
            /*
            foreach(var item in menuComponents)
            {
                ((MenuComponent)item).print();
            }
            */
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public MenuEnum GetEnumerator()
        {
            return new MenuEnum(menuComponents);
        }

        //外部迭代方式，通过外部管理所有迭代器
        public override IEnumerator createIEnumerator()
        {
            return new CompositeIterator(menuComponents.GetEnumerator());
        }
    }
    public class MenuEnum : IEnumerator
    {
        public ArrayList _menu;
        int position = -1;
        public MenuEnum(ArrayList menu)
        {
            _menu = menu;
        }
        public MenuComponent Current
        {
            get
            {
                try
                {
                    return (MenuComponent)_menu[position];
                }
                catch(IndexOutOfRangeException ex)
                {
                    throw new InvalidOperationException();
                }
            }
        }
         object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _menu.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}

